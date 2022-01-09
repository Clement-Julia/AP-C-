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

namespace AP
{
    public partial class modifHebergement : Form
    {
        private int idHebergement = 23;
        private int idVille = 0;
        private int open = 0;

        private List<Ville> allVilles;
        private List<Option> allOptions;
        private List<Option> checkedOptions;
        private List<Avis> allAvis;

        private Utilisateur _utilisateur;
        private Hebergement _hebergement;

        public modifHebergement(Utilisateur Utilisateur, Hebergement Hebergement)
        {
            InitializeComponent();
            this._utilisateur = Utilisateur;

            this._hebergement = Hebergement;

            //Initialisation des valeurs de tab généraux
            name.Text = _hebergement.Libelle;
            description.Text = _hebergement.Description;
            prix.Text = _hebergement.Prix.ToString();
            latitude.Text = _hebergement.Latitude.ToString();
            longitude.Text = _hebergement.Longitude.ToString();
            idVille = _hebergement.IdVille;

            Ville Ville = new Ville();
            allVilles = Ville.GetAllVille();

            foreach(Ville allVille in allVilles)
            {
                if (allVille.IdVille == idVille)
                {
                    ville.Text = allVille.Libelle;
                }
                else
                {
                    ville.Items.Add(allVille.Libelle);
                }
            }

            //Initialisation du menu option
            Option Option = new Option();
            Hebergement hebergement = new Hebergement();
            this.allOptions = Option.getAllOptions();
            this.checkedOptions = hebergement.GetAllOptionsByHebergement(idHebergement);

            foreach (Option option in allOptions)
            {
                var check = checkedOptions.Where(w => w.IdOption == option.IdOption).FirstOrDefault();
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
            Avis Avis = new Avis();
            allAvis = Avis.GetAllAvisHebergement(idHebergement);

            foreach (Avis avis in allAvis)
            {
                AvisHebergement customControl = new AvisHebergement(avis, this, idHebergement, _utilisateur);
                flow_avis.Controls.Add(customControl);
            }

            //Vérification et avertissement si impossibilité de modifiation
            open = hebergement.GetStatusHebergement(_hebergement.IdHebergement);
        }

        private void modif_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("database=ppe; server=localhost; user id = root; pwd=");
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@idHebergement", idHebergement);
            command.Parameters.AddWithValue("@libelle", name.Text);
            command.Parameters.AddWithValue("@desciption", description.Text);
            command.Parameters.AddWithValue("@prix", prix.Text);
            command.Parameters.AddWithValue("@latitude", latitude.Text);
            command.Parameters.AddWithValue("@longitude", longitude.Text);
            conn.Close();

            if (String.IsNullOrEmpty(name.Text) && String.IsNullOrEmpty(prix.Text) && String.IsNullOrEmpty(latitude.Text) && String.IsNullOrEmpty(longitude.Text))
            {
                MessageBox.Show("Les informations ne peuvent pas être vides");
            }else if(open == 1)
            {
                MessageBox.Show("L'hebegement est réservé\nIl ne peut pas être modifié", "Attention");
            }
            else
            {
                conn.Open();
                MySqlCommand recup = conn.CreateCommand();
                recup.Parameters.AddWithValue("@libelle_ville", ville.Text);
                recup.CommandText = "SELECT idVille from villes where libelle = @libelle_ville";
                MySqlDataReader recup_ville = recup.ExecuteReader();
                while (recup_ville.Read())
                {
                    command.Parameters.AddWithValue("@ville", recup_ville.GetInt32(0));
                }
                conn.Close();
                conn.Open();
                command.CommandText = "update hebergement set libelle = @libelle, description = @desciption, prix = @prix, idVille = @ville where idHebergement = @idHebergement";
                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Modification effectuée !");
                }
                else
                {
                    MessageBox.Show("Un problème est apparu veuillez recommencer");
                }
            }


            conn.Close();
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
                Hebergement Hebergement = new Hebergement();
                Hebergement.UpdateOption(idHebergement, allOptions.Count(), checkid);
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

            command.Parameters.AddWithValue("@idHebergement", idHebergement);

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
