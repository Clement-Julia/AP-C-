using AP.Model;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AP.Forms
{
    public partial class Inscription : Form
    {
        private string MotDePasse;
        private string ConfirmationMotDePasse;
        private Utilisateur _utilisateur;
        private bool _showRGPD = false;
        public Inscription()
        {
            InitializeComponent();
            panelRGPDBorder.Hide();
            labelRGPD.Text = "Article 1 : Les mentions légales \n\n L'édition de l'application Propalacool est assurée par la Société J&D Development au capital de 10 000 euros, immatriculée au RCS de Paris sous le numéro 5454151, dont le siège social est situé à Paris. \nNuméro de téléphone \n 06.01.18.07.60.\nAdresse e-mail : \nloocalacool @gmail.fr. \nLe Directeur de la publication est: \nJULIA Clément. \nL'hébergeur de l'application Propalacool est la société OVH, dont le siège social est situé au 19 Pl.Françoise Dorin, 75017 Paris, avec le numéro de téléphone: 09 55 00 66 33. \n\n\n ARTICLE 3 : Collecte des données \n\n L'application assure à l'Utilisateur une collecte et un traitement d'informations personnelles dans le respect de la vie privée conformément à la loi n°78-17 du 6 janvier 1978 relative à l'informatique, aux fichiers et aux libertés.l'application est déclaré à la CNIL sous le numéro 05151215. En vertu de la loi Informatique et Libertés, en date du 6 janvier 1978, l'Utilisateur dispose d'un droit d'accès, de rectification, de suppression et d'opposition de ses données personnelles.L'Utilisateur exerce ce droit via son espace personnel";
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

        private void pictureBoxRGPD_Click(object sender, EventArgs e)
        {
            _showRGPD = !_showRGPD;
            if (_showRGPD)
                panelRGPDBorder.Show();
            else
                panelRGPDBorder.Hide();
        }
    }
}
