﻿using MySql.Data.MySqlClient;
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
        private string Identifiant;
        private string MotDePasse;
        private string ConfirmationMotDePasse;
        private string Nom;
        private string Prenom;
        private string DoB;
        private int Age;
        private int IdRole = 3;
        private bool AcceptRGPD;
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
            Identifiant = TextBoxUsername.Text;
            MotDePasse = TextBoxPassword.Text;
            ConfirmationMotDePasse = TextBoxConfirmation.Text;
            Nom = TextBoxNom.Text;
            Prenom = TextBoxPrenom.Text;
            AcceptRGPD = CheckBoxRgpd.Checked;


            if (Identifiant == "" || MotDePasse == "" || ConfirmationMotDePasse == "" || Nom == "" || Prenom == "" || Age < 18 || Age > 120 || AcceptRGPD == false)
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
                        MySqlConnection conn = new MySqlConnection("database=ppe; server=localhost; user id = root; pwd=");
                        conn.Open();
                        MySqlCommand command = conn.CreateCommand();
                        command.Parameters.AddWithValue("@email", Identifiant);
                        command.Parameters.AddWithValue("@mdp", BCrypt.Net.BCrypt.HashPassword(MotDePasse));
                        command.Parameters.AddWithValue("@nom", Nom);
                        command.Parameters.AddWithValue("@prenom", Prenom);
                        command.Parameters.AddWithValue("@age", Age);
                        command.Parameters.AddWithValue("@idRole", IdRole);
                        command.Parameters.AddWithValue("@acceptRGPD", 1);
                        command.Parameters.AddWithValue("@DoB", DoB);
                        command.CommandText = "INSERT INTO utilisateurs (email, mdp, nom, prenom, age, idRole, acceptRGPD, dateAcceptRGPD, DoB) VALUES (@email , @mdp , @nom , @prenom, @age , @idRole , @acceptRGPD , now(), @DoB)";

                        if (command.ExecuteNonQuery() > 0)
                        {
                            TextBoxUsername.Text = "";
                            TextBoxPassword.Text = "";
                            TextBoxConfirmation.Text = "";
                            TextBoxNom.Text = "";
                            TextBoxPrenom.Text = "";
                            CheckBoxRgpd.Checked = true;
                            MessageBox.Show("Inscription réussie", "Inscription réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Inscription échouée", "Inscription échouée", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        conn.Close();
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

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            this.DoB = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            DateTime thisDay = DateTime.Now;
            DateTime dob = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
            this.Age = (thisDay - dob).Days / 365;

        }
    }
}