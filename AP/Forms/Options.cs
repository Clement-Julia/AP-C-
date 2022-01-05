﻿using AP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP.Forms
{
    public partial class Options : Form
    {
        private Utilisateur _utilisateur;
        private Home _home;
        public Options(Utilisateur utilisateur, Home home)
        {
            InitializeComponent();
            this._utilisateur = utilisateur;
            this._home = home;
            textBoxNom.Text = _utilisateur.Nom;
            textBoxPrenom.Text = _utilisateur.Prenom;
            textBoxAge.Text = _utilisateur.GetAge();
            textBoxEmail.Text = _utilisateur.Email;
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            // il faudra tout fermer (ce form plus le home)
            _utilisateur = null;
            _home.Close();
            this.Close();
            new Connexion().Show();
        }

        private void btnDesinscription_Click(object sender, EventArgs e)
        {
            // Simulation de désinscription
        }

        private void pictureBoxValidNewMdp_Click(object sender, EventArgs e)
        {
            // Modification du mot de passe
            string OldMDP = textBoxOldMDP.Text;
            string NewMDP = textBoxNewMDP.Text;
            string ConfirmNewMDP = textBoxConfirmNewMDP.Text;
            bool result = false;
            if (NewMDP == ConfirmNewMDP)
            {
                result = _utilisateur.UpdateMDP(OldMDP, NewMDP);
            }
            if (result)
                MessageBox.Show("Modification du mot de passe réussie", "Modification du mot de passe réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Modification du mot de passe échouée", "Modification du mot de passe échouée", MessageBoxButtons.OK, MessageBoxIcon.Error);
 
        }
        private void pictureBoxValidInfos_Click(object sender, EventArgs e)
        {
            // faire une message box êtes vous sur de vouloir modifier ces informations, cela pourrait engendrer des erreurs de versement, de déclaration au fisc ?
            string nom = textBoxNom.Text;
            string prenom = textBoxPrenom.Text;
            string email = textBoxEmail.Text;
            bool result = false;

            if(nom != "" && prenom != "" && email != "")
            {
                DialogResult dresult = MessageBox.Show("Vous allez modifier des informations sensibles. Elles pourrait engendrer des erreurs voire un arrêt temporaire des versemments. Êtes-vous sur de vouloir faire cela ?", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dresult == DialogResult.OK)
                {
                    result = _utilisateur.UpdateUser(nom, prenom, email);
                    if (result)
                    {
                        MessageBox.Show("Modification des informations réussie", "Modification réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _utilisateur.Nom = nom;
                        _utilisateur.Prenom = prenom;
                        _utilisateur.Email = email;
                        _home.LabelUserName.Text = nom + " " + prenom;
                    }
                    else
                        MessageBox.Show("Modification des informations échouée", "Modification échouée", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    MessageBox.Show("Modification des informations échouée. Erreur Interne", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Modification des informations échouée. Il manque des informations", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
