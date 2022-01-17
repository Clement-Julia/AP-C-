using AP.Model;
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
    public partial class Inscription : Form
    {
        private string MotDePasse;
        private string ConfirmationMotDePasse;
        private Utilisateur _utilisateur;
        public Inscription()
        {
            InitializeComponent();
            DateTime today = DateTime.Now;
            dateTimePicker1.Value = today.AddYears(-18);
        }

        private void CheckBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxShowPassword.Checked)
            {
                TextBoxPassword.PasswordChar = '\0';
                TextBoxConfirmation.PasswordChar = '\0';
            }
            else
            {
                TextBoxPassword.PasswordChar = '●';
                TextBoxConfirmation.PasswordChar = '●';
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new Connexion().Show();
            this.Hide();
        }

        private void BtnInscription_Click(object sender, EventArgs e)
        {
            MotDePasse = TextBoxPassword.Text;
            ConfirmationMotDePasse = TextBoxConfirmation.Text;
            _utilisateur = new Utilisateur();
            _utilisateur.Email = TextBoxUsername.Text;
            _utilisateur.Nom = TextBoxNom.Text;
            _utilisateur.Prenom = TextBoxPrenom.Text;
            _utilisateur.AcceptRGPD = CheckBoxRgpd.Checked;
            _utilisateur.DateOfBirth = dateTimePicker1.Value;

            DateTime Now = DateTime.Now;
            int Age = (Now.Subtract(_utilisateur.DateOfBirth).Days / 365);


            if (_utilisateur.Email == "" || MotDePasse == "" || ConfirmationMotDePasse == "" || _utilisateur.Nom == "" || _utilisateur.Prenom == "" || Age < 18 || Age > 120 || _utilisateur.AcceptRGPD == false)
            {
                MessageBox.Show("Veuillez vérifier les informations d'inscription", "Inscription échouée", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MotDePasse == ConfirmationMotDePasse)
                {

                    Regex hasNumber = new Regex(@"[0-9]+");
                    Regex hasUpperChar = new Regex(@"[A-Z]+");
                    Regex hasMinimum8Chars = new Regex(@".{8,}");
                    bool isValidated = hasNumber.IsMatch(MotDePasse) && hasUpperChar.IsMatch(MotDePasse) && hasMinimum8Chars.IsMatch(MotDePasse);

                    if (isValidated)
                    {
                        Utilisateur Utilisateur = new Utilisateur();
                        bool result = Utilisateur.Inscription(_utilisateur.Email, MotDePasse, _utilisateur.Nom, _utilisateur.Prenom, _utilisateur.AcceptRGPD, _utilisateur.DateOfBirth);

                        if (result)
                        {
                            MessageBox.Show("Inscription réussie", "Inscription réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            new Connexion(_utilisateur).Show();
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Inscription échouée", "Inscription échouée", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Le mot de passe doit faire au moins 8 caractères, contenir un chiffre, une minuscule et une majuscule", "Inscription échouée", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Les mots de passe saisi ne sont pas identique", "Inscription échouée", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
