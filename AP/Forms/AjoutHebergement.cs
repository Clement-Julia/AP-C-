using AP.dtos;
using AP.Model;
using AP.Services;
using AP.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP.Forms
{
    public partial class AjoutHebergement : Form
    {
        private Utilisateur _utilisateur;
        private ApiGouvCommunes _apiGouvCommunes;
        private List<ApiCommuneDto> _listeCommunes = new List<ApiCommuneDto>();
        private List<string> _idsRegion = new List<string>();
        private ApiCoordonneesRootDto _allMatch;
        private int number = 2;
        private string _codeVille = "";
        private int _cp;
        private string _adresse;
        private string _commune;

        public AjoutHebergement(Utilisateur utilisateur)
        {
            InitializeComponent();
            this._utilisateur = utilisateur;
            this._apiGouvCommunes = new ApiGouvCommunes();
            panelChoixAdresse.Hide();
            panelChoixVille.Hide();
            labelErreurSubmit.Hide();
            BtnRetourOk.Hide();
        }



        private async void inputCommune_TextChanged(object sender, EventArgs e)
        {
            comboBoxCommune.Items.Clear();
            _listeCommunes.Clear();

            //var cancellationTokenSource = new CancellationTokenSource();

            //if (this.number != 2)
            //    cancellationTokenSource.Cancel();
            //await Task.Delay(1000).ContinueWith((task) => { this.number--; });

            if (int.TryParse(inputCommune.Text, out int number))
            {
                if (number.ToString().Length == 5)
                {
                    _listeCommunes = await _apiGouvCommunes.ListeCommunes(number);

                    noDuplicatedCodeComboBoxItem();
                    //this.number = 2;
                } else
                {
                    // si le code fait pas 5 chiffres on fait rien
                }
            }
            else
            {
                _listeCommunes = await _apiGouvCommunes.ListeCommunes(inputCommune.Text);

                noDuplicatedCodeComboBoxItem();
                //this.number = 2;
            }

        }

        private async void BtnRechercherCoordonnees_Click(object sender, EventArgs e)
        {
            if(comboBoxCommune.SelectedItem == null)
            {
                this._codeVille = "";
            }

            string adresseInput = richTextBoxAdresse.Text;
            // string t = @"\b\d{5}\b";
            Regex codePostal = new Regex(@"\b\d{5}\b", RegexOptions.IgnoreCase);
            Regex allBeforeCP = new Regex(@".+?(?=\b\d{5}\b)", RegexOptions.IgnoreCase);
            Regex allAfterCP = new Regex(@"[^\b\d{5}\b]+$", RegexOptions.IgnoreCase);

            if (codePostal.IsMatch(adresseInput))
            {
                this._adresse = allBeforeCP.Match(adresseInput).ToString().Trim();
                this._cp = Convert.ToInt32(codePostal.Match(adresseInput).ToString());
                this._commune = allAfterCP.Match(adresseInput).ToString().Trim();
            } else
            {
                this._adresse = adresseInput;
            }

            if (this._adresse != "")
            {


                if(this._codeVille != "")
                {
                    noDuplicatedCodeGetCoordonnees(this._adresse);
                } 
                else
                {
                    // Veuillez remplir le champ de la ville avant d'entrer l'adresse
                    List<ApiCommuneDto> temporaire = new List<ApiCommuneDto>();
                    if (this._commune != "")
                    {
                        temporaire = await _apiGouvCommunes.ListeCommunes(this._commune);
                    } else
                    {
                        temporaire = await _apiGouvCommunes.ListeCommunes(this._cp);
                    }
                    List<string> pk = new List<string>();
                    _apiGouvCommunes._listeNosRegions.ForEach(x => pk.Add(x.code));
                    _listeCommunes.Clear();
                    foreach (var item in temporaire)
                    {
                        if (pk.Contains(item.codeRegion))
                        {
                            _listeCommunes.Add(item);
                        }
                    }
                   // _listeCommunes = communesDansNosRegions;

                    if (_listeCommunes.Count() == 0)
                    {
                        // Affichage erreur
                    } else if (_listeCommunes.Count() == 1)
                    {
                        this._codeVille = _listeCommunes.Select(s => s.code).FirstOrDefault();
                        noDuplicatedCodeGetCoordonnees(this._adresse);
                        comboBoxCommune.Items.Clear();
                        comboBoxCommune.Items.Add(_listeCommunes[0].nom);
                        comboBoxCommune.SelectedItem = _listeCommunes[0].nom;
                    } else
                    {
                        // on met en place nouveau panel pour choix des villes trouvées

                        flowLayoutPanelChoixVille.Controls.Clear();
                        flowLayoutPanelChoixVille.WrapContents = false;

                        foreach (ApiCommuneDto item in _listeCommunes)
                        {
                            RadioButton radio = new RadioButton();
                            radio.Text = item.nom;
                            radio.Size = new Size(295, 40);
                            flowLayoutPanelChoixVille.Controls.Add(radio);
                        }
                        panelChoixVille.Show();
                        BtnRechercherCoordonnees.Hide();
                    }

                }
               // }
            }
        }

        private void BtnRetour2_Click(object sender, EventArgs e)
        {
            panelChoixVille.Hide();
            BtnRechercherCoordonnees.Show();
            this._codeVille = "";
        }

        private void BtnValiderVille_Click(object sender, EventArgs e)
        {
            var checkedButton = flowLayoutPanelChoixVille.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if(checkedButton != null)
            {
                int index = _listeCommunes.IndexOf(_listeCommunes.Where(w => w.nom.Equals(checkedButton.Text)).FirstOrDefault());
                if(index != -1)
                {
                    this._codeVille = _listeCommunes[index].code;
                    this._commune = _listeCommunes[index].nom;
                    comboBoxCommune.Items.Clear();
                    comboBoxCommune.Items.Add(_listeCommunes[index].nom);
                    comboBoxCommune.SelectedItem = _listeCommunes[index].nom;
                    noDuplicatedCodeGetCoordonnees(this._adresse);
                }
            }
        }

        // Quand une selection manuelle est faite sur la comboBox, on associe le code ville de la ville choisi
        private void comboBoxCommune_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._codeVille = _listeCommunes.Where(w => w.nom.Equals(comboBoxCommune.Text)).Select(s => s.code).FirstOrDefault();
        }

        // bouton de retour quand il existe plusieurs adresse et qu'un panel spécial est affiché (cela voudra dire que l'utilisateur n'a pas trouvé l'adresse qu'il souhaitait)
        private void BtnRetour_Click(object sender, EventArgs e)
        {
            panelChoixAdresse.Hide();
            BtnRechercherCoordonnees.Show();
            this._codeVille = "";
        }

        // bouton de validation du choix d'adresse quand plusieurs résultats trouvés
        private void BtnValiderAdresse_Click(object sender, EventArgs e)
        {
            var checkedButton = flowLayoutPanelChoixAdresse.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if(checkedButton != null)
            {
                int index = _allMatch.features.IndexOf(_allMatch.features.Where(w => w.properties.label.Equals(checkedButton.Text)).FirstOrDefault());
                richTextBoxLatitude.Text = _allMatch.features[index].geometry.coordinates[0].ToString();
                richTextBoxLongitude.Text = _allMatch.features[index].geometry.coordinates[1].ToString();
                richTextBoxAdresse.Text = _allMatch.features[index].properties.label;
                panelChoixAdresse.Hide();
                BtnRechercherCoordonnees.Show();
            }
        }

        // fonction pour éviter la duplication de code
        private async void noDuplicatedCodeGetCoordonnees(string adresse)
        {
            _allMatch = await _apiGouvCommunes.GetCoordonnees(adresse, this._codeVille);

            if (_allMatch.features.Count > 1)
            {
                // On clear le panel 
                flowLayoutPanelChoixAdresse.Controls.Clear();
                flowLayoutPanelChoixAdresse.WrapContents = false;

                foreach (var item in _allMatch.features)
                {
                    RadioButton radio = new RadioButton();
                    radio.Text = item.properties.label;
                    radio.Size = new Size(295, 40);
                    flowLayoutPanelChoixAdresse.Controls.Add(radio);
                }
                BtnRechercherCoordonnees.Hide();
                panelChoixVille.Hide();
                panelChoixVille.BringToFront();
                panelChoixAdresse.Show();

            }
            else
            {
                richTextBoxLatitude.Text = _allMatch.features[0].geometry.coordinates[0].ToString();
                richTextBoxLongitude.Text = _allMatch.features[0].geometry.coordinates[1].ToString();
                richTextBoxAdresse.Text = _allMatch.features[0].properties.label;
            }
        }

        // fonction pour éviter la duplication de code (comboxBox avec méthode string ou int)
        private void noDuplicatedCodeComboBoxItem()
        {
            List<ApiCommuneDto> communesDansNosRegions = _listeCommunes.Where(w => this._idsRegion.Contains(w.codeRegion)).ToList();
            _listeCommunes = communesDansNosRegions;

            if (comboBoxCommune.Items.Count > communesDansNosRegions.Count())
            {
                comboBoxCommune.Items.Clear();
            }
            foreach (ApiCommuneDto item in _listeCommunes)
            {
                if (_apiGouvCommunes._listeNosRegions.Where(w => w.code == item.codeRegion).FirstOrDefault() != null)
                {
                    string comboItem = item.nom;
                    comboBoxCommune.Items.Add(comboItem);
                }
            }
        }

        // bouton de base du formulaire pour revenir à l'accueil
        private void BtnRetourClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnValidHebergement_Click(object sender, EventArgs e)
        {

            BtnValidAjoutHebergement.Enabled = false;

            string nomHebergement = richTextBoxNomHebergement.Text;
            string description = richTextBoxDescription.Text;
            string ville = this._commune;
            if (this._commune == "")
                ville = comboBoxCommune.SelectedItem.ToString();
            float latitude;
            Single.TryParse(richTextBoxLatitude.Text, out latitude);
            float longitude;
            Single.TryParse(richTextBoxLongitude.Text, out longitude);
            decimal prix;
            Decimal.TryParse(richTextBoxPrix.Text, out prix);

            if (nomHebergement != "" &&
                description != "" &&
                ville != "" &&
                richTextBoxLatitude.Text != "" &&
                richTextBoxLongitude.Text != "" &&
                prix > 0)
            {
                AdminValidHebergement adminValidHebergement = new AdminValidHebergement();
                Boolean result = adminValidHebergement.InsertAdminValidHebergement(nomHebergement, description, ville, latitude, longitude, prix, this._utilisateur.IdUtilisateur);

                if (result)
                {
                    labelErreurSubmit.Text = "L'ajout de l'hébergement a été effectué avec succès";
                    labelErreurSubmit.TextAlign = ContentAlignment.MiddleCenter;
                    labelErreurSubmit.BackColor = Color.FromArgb(227, 255, 179);
                    labelErreurSubmit.Show();
                    BtnRetourOk.Show();
                }
                else
                {
                    labelErreurSubmit.Text = "Un problème est survenue durant la tentative d'ajout de l'hébergement et celle-ci n'a pas pu aboutir.";
                    labelErreurSubmit.TextAlign = ContentAlignment.MiddleCenter;
                    labelErreurSubmit.BackColor = Color.FromArgb(255, 213, 152);
                    labelErreurSubmit.Show();

                    BtnValidAjoutHebergement.Enabled = true;
                }
            }
            else
            {
                // ERREUR IL MANQUE DES INFORMATIONS
                labelErreurSubmit.Text = "La demande d'ajout de l'hébergement n'a pas pu aboutir. Veuillez vérifier les informations.";
                labelErreurSubmit.TextAlign = ContentAlignment.MiddleCenter;
                labelErreurSubmit.BackColor = Color.FromArgb(255, 192, 192);
                labelErreurSubmit.Show();

                BtnValidAjoutHebergement.Enabled = true;
            }
        }

        // quand l'ajout hébergement s'est fait avec succès, on affiche qu'un seul bouton pour revenir à l'accueil
        private void BtnRetourOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Commme le constructeur ne peut pas être async et que j'ai besoin de cette donnée avant de parcourir avec le foreach, j'ai du faire une méthode async
        private async void AjoutHebergement_Load(object sender, EventArgs e)
        {
            this._apiGouvCommunes._listeNosRegions = await this._apiGouvCommunes.GetRegions();
            foreach(var item in this._apiGouvCommunes._listeNosRegions)
            {
                this._idsRegion.Add(item.code);
            }
        }
    }
}
