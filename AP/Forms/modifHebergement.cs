using AP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using AP.Forms;
using AP.Services;

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

        public modifHebergement(Hebergement hebergement, Utilisateur utilisateur, FormHebergements formHebergements)
        {
            InitializeComponent();
            this._utilisateur = utilisateur;
            this._formHebergements = formHebergements;
            this._hebergement = new Hebergement(hebergement.IdHebergement);

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
                items.Add(new ComboboxItem { Text = allVilles[i].Libelle, Value = allVilles[i].IdVille });
                if (allVilles[i].IdVille == _hebergement.IdVille)
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
            }

            //Vérification et avertissement si impossibilité de modifiation
            open = hebergement.GetStatusHebergement(_hebergement.IdHebergement);
        }

        private void modif_Click(object sender, EventArgs e)
        {
            string idVilleComboBox = (ville.SelectedItem as ComboboxItem).Value.ToString();
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
                _hebergement.IdVille = Convert.ToInt32(idVilleComboBox);
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
                _hebergement.UpdateOption(_hebergement.IdHebergement, allOptions.Count(), checkid);
            }
            else
            {
                MessageBox.Show("L'hebegement est réservé\nIl ne peut pas être modifié", "Attention");
            }
        }

        private void sup_Click_1(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("database=ppe; server=localhost; user id = root; pwd=");
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@idHebergement", _hebergement.IdHebergement);

            if (open != 1)
            {
                var confirmResult = MessageBox.Show("Vous allez supprimer l'herbergement : " + name.Text + "\nÊtes-vous sûr ?", "Attention", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    command.CommandText = "DELETE FROM hebergement where idHebergement = @idHebergement";
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Suppression effectuée !\nVous avez bien supprimé : " + name.Text);
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
                MessageBox.Show("L'hebegement est réservé\nIl ne peut pas être supprimé", "Attention");
            }

            conn.Close();

            //Faire une redirection
        }

        private void retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }


        //private void ajoutResponse_Click(object sender, EventArgs e)
        //{
        //    List<Response> réponse;
        //    int idAvis;
        //    int idHebergement;
        //    TextResponse textResponse;
        //    int idResponse;
        //    modifHebergement ModifHebergement;
        //    public AjouterResponse(List<Response> réponse, int idAvis, int idHebergement, TextResponse textResponse, int idResponse, modifHebergement modifHebergement)
        //    {
        //        InitializeComponent();
        //        this.réponse = réponse;
        //        this.idAvis = idAvis;
        //        this.idHebergement = idHebergement;
        //        this.textResponse = textResponse;
        //        this.idResponse = idResponse;
        //        this.ModifHebergement = modifHebergement;
        //    }

        //    private void ajout_Click(object sender, EventArgs e)
        //    {
        //        Avis Avis = new Avis();
        //        if (réponse.Count == 0)
        //        {
        //            MessageBox.Show(Avis.AjoutResponse(idAvis, idHebergement, textResponse.text.Text));

        //            ModifHebergement.flow_avis.Controls.Clear();
        //            List<Avis> allAvis = Avis.GetAllAvisHebergement(ModifHebergement.idHebergement);
        //            foreach (Avis avis in allAvis)
        //            {
        //                AvisHebergement customControl = new AvisHebergement(avis, ModifHebergement, idHebergement);
        //                ModifHebergement.flow_avis.Controls.Add(customControl);
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show(Avis.UpdateResponse(idResponse, textResponse.text.Text));

        //            ModifHebergement.flow_avis.Controls.Clear();
        //            List<Avis> allAvis = Avis.GetAllAvisHebergement(ModifHebergement.idHebergement);
        //            foreach (Avis avis in allAvis)
        //            {
        //                AvisHebergement customControl = new AvisHebergement(avis, ModifHebergement, idHebergement);
        //                ModifHebergement.flow_avis.Controls.Add(customControl);
        //            }
        //        }
        //    }
        //}
    }
}
