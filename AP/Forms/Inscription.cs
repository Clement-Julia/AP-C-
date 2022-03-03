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
            labelRGPD.Text = "L’entreprise « Loocalacool », à travers son application « Propalacool », est situé au : 23 mail Haroun Tazieff 44000 Nantes.\n\nAfin d’assurer le bon fonctionnement du service que la société vous propose, nous allons collecter: votre nom, votre prénom, votre date de naissance, votre adresse électronique. Cela nous permettra de vous identifier et de vous contacter lors de l’utilisation de nos services. Lors de l’ajout d’hébergement prévus à la location, l’adresse de celui - ci sera elle aussi collectée et sera visible par les clients de l’entreprise « Loocalacool ». \n\nCes données seront conservées jusqu’à 30 jours après votre désinscription. Il vous sera possible de modifier ces informations à tout moment lors de l’utilisation de l’application, un onglet spécifique « Options » a été créé à cet effet. \n\nSi durant l’utilisation de l’application, vous venez à avoir des questions sur la gestion de vos données personnelles, une adresse email a été mise à disposition : loocalacool - rgpd@admin.fr.En cas de désaccord, il est vous est possible de faire une réclamation auprès de la CNIL.\n\nLes données sont traitées conformément à la Loi n° 78 - 17 du 6 janvier 1978 relative à l'informatique, aux fichiers et aux libertés ainsi que du Décret n° 2019-536 du 29 mai 2019 pris pour l'application de la loi n° 78 - 17 du 6 janvier 1978 relative à l'informatique, aux fichiers et aux libertés.";
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
