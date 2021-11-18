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
        int idHebergement = 0;
        int idVille = 0;
        int open = 0;
        List<Option> allOptions;
        List<Option> checkedOptions;
        List<Avis> allAvis;

        public modifHebergement()
        {
            InitializeComponent();
            
            MySqlConnection conn = new MySqlConnection("database=ppe; server=localhost; user id = root; pwd=");
            conn.Open();


            //Initialisation des valeurs du menu de base
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@id", 23);
            command.CommandText = "SELECT libelle, description, prix, latitude, longitude, idVille, idHebergement FROM hebergement WHERE idHebergement = @id";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                name.Text = reader.GetString(0);
                description.Text = reader.GetString(1);
                prix.Text = reader.GetString(2);
                latitude.Text = reader.GetString(3);
                longitude.Text = reader.GetString(4);
                idVille = reader.GetInt32(5);
                idHebergement = reader.GetInt32(6);
            }
            conn.Close();

            conn.Open();
            MySqlCommand test = conn.CreateCommand();
            test.Parameters.AddWithValue("@ville", idVille);
            test.CommandText = "SELECT libelle, idVille FROM villes";
            MySqlDataReader reader2 = test.ExecuteReader();
            while (reader2.Read())
            {
                if (reader2.GetInt32(1) == idVille)
                {
                    ville.Text = reader2.GetString(0);
                }
                else
                {
                    ville.Items.Add(reader2.GetString(0));
                }

            }
            conn.Close();

            //Initialisation du menu option
            Option Option = new Option();
            Hebergement Hebergement = new Hebergement();
            this.allOptions = Option.getAllOptions();
            this.checkedOptions = Hebergement.GetAllOptionsByHebergement(idHebergement);

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
                AvisHebergement customControl = new AvisHebergement(avis, this);
                flow_avis.Controls.Add(customControl);
            }

            //Vérification et avertissement si impossibilité de modifiation
            conn.Open();
            string result = null;
            MySqlCommand verif = conn.CreateCommand();
            verif.Parameters.AddWithValue("@idHebergement", idHebergement);
            verif.CommandText = "SELECT * FROM reservations_hebergement where idHebergement = @idHebergement and dateFin > now()";

            MySqlDataReader reader3 = verif.ExecuteReader();
            while (reader3.Read())
            {
                result = reader3.GetString(0);
            }
            conn.Close();
            
            if(result != null)
            {
                open = 1;
            }

            if(open == 1)
            {
                MessageBox.Show("L'herbegement est réservé par des utilisateurs\nToute modification apportée ne sera pas prise en compte", "Attention");
            }
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
        
        private void modif2_Click(object sender, EventArgs e)
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

        private void sup_Click(object sender, EventArgs e)
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
            //Faire une redirection
        }
    }
}
