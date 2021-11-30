using AP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP.UserControls
{
    public partial class LigneAvis : UserControl
    {
        private Avis _avis;
        private Utilisateur _utilisateur;

        public LigneAvis(Avis avis, Utilisateur utilisateur, Boolean colorTrueOrFalse)
        {
            InitializeComponent();
            this._avis = avis;
            this._utilisateur = utilisateur;
            labelNom.Text = _utilisateur.Nom;
            labelPrenom.Text = _utilisateur.Prenom;
            labelDate.Text = _avis.Date.ToString("dd-MM-yyyy");
            labelCommentaire.Text = _avis.Commentaire;

            for ( int i = 0; i < _avis.Note; i++)
            {
                flowLayoutPanelEtoiles.Controls.Add(new Stars());
            }

            if (colorTrueOrFalse)
            {
                this.BackColor = Color.FromArgb(228, 228, 228);
            }
        }
    }
}
