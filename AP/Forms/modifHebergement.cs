using AP.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AP.Forms;
using AP.Services;
using AP.UserControls;

namespace AP
{
    public partial class modifHebergement : Form
    {
        private List<Ville> allVilles;
        private List<Option> allOptions;
        private int open = 0;
        private Utilisateur _utilisateur;
        private Hebergement _hebergement;
        private FormHebergements _formHebergements;
        private HebergementsCustumControl _hebergementsCustumControl;
        private AssoHebergementFormule _assoHebergementFormule;
        private List<AssoHebergementFormule> _listeAssoHebergementFormule;

        public modifHebergement(Hebergement hebergement, Utilisateur utilisateur, FormHebergements formHebergements, HebergementsCustumControl hebergementsCustumControl)
        {
            InitializeComponent();
            this._utilisateur = utilisateur;
            this._formHebergements = formHebergements;
            this._hebergementsCustumControl = hebergementsCustumControl;
            this._hebergement = new Hebergement(hebergement.IdHebergement);
            this._assoHebergementFormule = new AssoHebergementFormule();

            // On cache le loader
            panelLoader.Visible = false;

            //Initialisation des valeurs de tab généraux
            name.Text = _hebergement.Libelle;
            description.Text = _hebergement.Description;
            prix.Text = _hebergement.Prix.ToString();
            latitude.Text = _hebergement.Latitude.ToString();
            longitude.Text = _hebergement.Longitude.ToString();

            Ville Ville = new Ville();
            allVilles = Ville.GetAllVille();

            List<Object> items = new List<Object>();
            ville.DisplayMember = "Text";
            ville.ValueMember = "Value";

            string nomVille = "";
            int index = 0;
            for(int i = 0; i < allVilles.Count; i++)
            {
                items.Add(new ComboboxItemDto { Text = allVilles[i].Libelle, Value = allVilles[i].IdVille });
                if (allVilles[i].IdVille == _hebergement.Ville.IdVille)
                {
                    index = i;
                    nomVille = allVilles[i].Libelle;
                }
            }
            ville.DataSource = items;
            ville.SelectedIndex = index;

            //Initialisation du menu option
            Option Option = new Option();
            this.allOptions = Option.getAllOptions();

            foreach (Option option in allOptions)
            {
                var check = _hebergement.ListOption.Where(w => w.IdOption == option.IdOption).FirstOrDefault();
                if (check != null)
                {
                    OptionHebergement customControl = new OptionHebergement(option, true);
                    float_options.Controls.Add(customControl);
                }
                else
                {
                    OptionHebergement customControl = new OptionHebergement(option, false);
                    float_options.Controls.Add(customControl);
                }
            }

            //Initialisation menu avis
            foreach (Avis avis in _hebergement.ListAvis)
            {
                AvisHebergement customControl = new AvisHebergement(avis, this, _hebergement.IdHebergement, _utilisateur);
                flow_avis.Controls.Add(customControl);
                ControlExtension.Draggable(customControl, true);
                //flow_avis.Draggable(customControl, true);
            }

            Formule Formule = new Formule();
            _listeAssoHebergementFormule = _hebergement.GetFormules();
            //Initialisation menu formules
            foreach (Formule formule in Formule.GetFormules())
            {
                var check = _listeAssoHebergementFormule.Where(w => w.IdFormule == formule.IdFormule).FirstOrDefault();
                if(check != null)
                {
                    UserControlFormule userControlFormule = new UserControlFormule(check.IdFormule, true, formule.Libelle, check.Prix);
                    flowLayoutPanelFormules.Controls.Add(userControlFormule);
                }
                else
                {
                    UserControlFormule userControlFormule = new UserControlFormule(formule.IdFormule, false, formule.Libelle);
                    flowLayoutPanelFormules.Controls.Add(userControlFormule);
                }
            }

            //Initialisation menu images
            AddPicture customPicture = new AddPicture(flow_picture, _hebergement, panelLoader);
            customPicture.AutoScroll = true;
            tab_images.Controls.Add(customPicture);
            tab_images.Tag = customPicture;
            customPicture.Dock = DockStyle.Bottom;
            customPicture.BringToFront();
            customPicture.Show();

            //Vérification et avertissement si impossibilité de modifiation
            open = hebergement.GetStatusHebergement(_hebergement.IdHebergement);
        }

        private void modif_Click(object sender, EventArgs e)
        {
            string idVilleComboBox = (ville.SelectedItem as ComboboxItemDto).Value.ToString();
            if (String.IsNullOrEmpty(name.Text) && String.IsNullOrEmpty(idVilleComboBox) && String.IsNullOrEmpty(description.Text) && String.IsNullOrEmpty(prix.Text) && String.IsNullOrEmpty(latitude.Text) && String.IsNullOrEmpty(longitude.Text))
            {
                MessageBox.Show("Les informations ne peuvent pas être vides");
            }else if(open == 1)
            {
                MessageBox.Show("L'hebegement est réservé\nIl ne peut pas être modifié", "Attention");
            }
            else
            {
                _hebergement.Libelle = name.Text;
                _hebergement.Description = description.Text;
                _hebergement.Ville.IdVille = Convert.ToInt32(idVilleComboBox);
                try
                {
                    _hebergement.Latitude = Convert.ToDouble(latitude.Text);
                    _hebergement.Longitude = Convert.ToDouble(longitude.Text);
                    _hebergement.Prix = Convert.ToDecimal(prix.Text);
                } catch (Exception)
                {
                    MessageBox.Show("Une erreur est survenu durant la mise à jour de l'hébergement, veuillez vérifier le format des données que vous avez souhaité envoyer.");
                    return;
                }
                bool result = _hebergement.UpdateHebergement();
                if (result)
                {
                    MessageBox.Show("Modification effectuée !");
                }
                else
                {
                    MessageBox.Show("Un problème est apparu veuillez recommencer");
                }
            }

        }

        private void modif2_Click_1(object sender, EventArgs e)
        {
            List<string> checkid = new List<string>();

            foreach (OptionHebergement checkbox in float_options.Controls)
            {
                if (checkbox.checkBox1.Checked == true)
                {
                    checkid.Add(checkbox.checkBox1.Name);
                }
            }

            if (open != 1)
            {
                Option Option = new Option();
                Option.UpdateOption(_hebergement.IdHebergement, allOptions.Count(), checkid);
            }
            else
            {
                MessageBox.Show("L'hebegement est réservé\nIl ne peut pas être modifié", "Attention");
            }
        }

        private void sup_Click_1(object sender, EventArgs e)
        {

            if (open != 1)
            {
                var confirmResult = MessageBox.Show("Vous allez supprimer l'herbergement : " + name.Text + "\n\nÊtes-vous sûr ? \n\nSi des utilisateurs avaient réservé votre hébergement pour des dates ultérieures, toutes ses réservations se verrons annulées et les utilisateurs remboursés.", "Attention", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    bool result = _hebergement.DeleteHebergement();
                    if (result)
                    {
                        MessageBox.Show("Suppression effectuée !\n\nVous avez bien supprimé : " + name.Text);
                        _utilisateur.ListHebergements.Remove(_utilisateur.ListHebergements.Where(w => w.IdHebergement.Equals(_hebergement.IdHebergement)).FirstOrDefault());
                        _formHebergements.PanelHebergements.Controls.Remove(_hebergementsCustumControl);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Un problème est apparu veuillez recommencer");
                    }
                }
                else
                {
                    MessageBox.Show("La suppression à été annulé");
                }
            }
            else
            {
                MessageBox.Show("L'hebegement est actuellement réservé\nIl ne peut pas être supprimé", "Attention");
            }

        }

        private void retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSauvegarderFormules_Click(object sender, EventArgs e)
        {
            List<AssoHebergementFormule> assoHebergementFormules = new List<AssoHebergementFormule>();
            foreach(UserControlFormule userControlFormule in flowLayoutPanelFormules.Controls)
            {
                AssoHebergementFormule assoHebergementFormule = new AssoHebergementFormule(_hebergement.IdHebergement, userControlFormule.formuleId, userControlFormule.prixFormule);
                assoHebergementFormules.Add(assoHebergementFormule);
            }
            _assoHebergementFormule.UpdateFormules(assoHebergementFormules, _hebergement.IdHebergement);
        }
    }
}
