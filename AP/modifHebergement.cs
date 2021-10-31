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

namespace AP
{
    public partial class modifHebergement : Form
    {
        int idHebergement = 0;
        int idVille = 0;

        public modifHebergement()
        {
            InitializeComponent();

            MySqlConnection conn = new MySqlConnection("database=ppe; server=localhost; user id = root; pwd=");
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@id", 1);
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
                if(reader2.GetInt32(1) == idVille)
                {
                    ville.Text = reader2.GetString(0);
                }
                else
                {
                    ville.Items.Add(reader2.GetString(0));
                }
            }

            conn.Close();
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

            command.CommandText = "update hebergement set libelle = @libelle, description = @desciption, prix = @prix where idHebergement = @idHebergement";
            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Modification effectuée !");
            }
            else
            {
                MessageBox.Show("Un problème est apparu veuillez recommencer");
            }

            conn.Close();
        }

        private void sup_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("database=ppe; server=localhost; user id = root; pwd=");
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@idHebergement", idHebergement);

            command.CommandText = "DELETE FROM hebergement where idHebergement = @idHebergement";
            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Suppression effectuée !");
            }
            else
            {
                MessageBox.Show("Un problème est apparu veuillez recommencer");
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
