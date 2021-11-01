using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP.Forms
{
    public partial class Connexion : Form
    {
        private string Identifiant;
        private string MotDePasse;
        public Connexion()
        {
            InitializeComponent();
        }

        private void BtnConnexion_Click(object sender, EventArgs e)
        {
            if(TextBoxUsername.Text == "" || TextBoxPassword.Text == "")
            {
                MessageBox.Show("Les champs identifiant et mot de passe doivent être rempli pour se connecter", "Connexion échouée", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Identifiant = TextBoxUsername.Text;
                MotDePasse = TextBoxPassword.Text;
                string bddMDP = null;

                MySqlConnection conn = new MySqlConnection("database=ppe; server=localhost; user id = root; pwd=");
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.Parameters.AddWithValue("@email", Identifiant);
                command.CommandText = "SELECT mdp FROM utilisateurs WHERE email = @email";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    bddMDP = reader.GetString(0);
                }
                conn.Close();

                if(BCrypt.Net.BCrypt.Verify(MotDePasse, bddMDP))
                {
                    new Home().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Veuillez vérifier vos informations de connexion", "Connexion échouée", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void CheckBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxShowPassword.Checked)
            {
                TextBoxPassword.PasswordChar = '\0';
            }
            else
            {
                TextBoxPassword.PasswordChar = '●';
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new Inscription().Show();
            this.Hide();
        }
    }
}
