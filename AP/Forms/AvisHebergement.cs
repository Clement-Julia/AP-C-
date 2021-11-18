using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AP.Model;

namespace AP.Forms
{
    public partial class AvisHebergement : UserControl
    {
        Avis avis;
        public AvisHebergement(Avis avis)
        {
            InitializeComponent();
            this.nom.Text = avis.Nom;
            this.prénom.Text = avis.Prénom;
            this.rating.Text = avis.Note.ToString();
            this.commentaire.Text = avis.Commentaire;
        }

        private void link_avis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("test");
        }
    }
}
