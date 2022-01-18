﻿using AP.Model;
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
        private string Email;
        private string MotDePasse;
        public Connexion(Utilisateur utilisateur = null)
        {
            InitializeComponent();
            TextBoxUsername.Text = "mrtreflestremy@outlook.com";
            TextBoxPassword.Text = "Kdo%test89T";
            if (utilisateur != null)
                TextBoxUsername.Text = utilisateur.Email;
        }

        private void BtnConnexion_Click(object sender, EventArgs e)
        {
            if(TextBoxUsername.Text == "" || TextBoxPassword.Text == "")
            {
                MessageBox.Show("Les champs identifiant et mot de passe doivent être rempli pour se connecter", "Connexion échouée", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Email = TextBoxUsername.Text;
                MotDePasse = TextBoxPassword.Text;

                Utilisateur utilisateur = new Utilisateur(Email);

                if(utilisateur.IdRole != 3 || utilisateur.IdRole == 1)
                {
                    if(utilisateur.Mdp != null && BCrypt.Net.BCrypt.Verify(MotDePasse, utilisateur.Mdp))
                    {
                        new Home(utilisateur).Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Veuillez vérifier vos informations de connexion", "Connexion échouée", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else
                {
                    MessageBox.Show("Il faut avoir le status de propriétaire afin de pouvoir se connecter à l'application", "Connexion échouée", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void TextBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                BtnConnexion.PerformClick();
            }
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
