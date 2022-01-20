using AP.Model;
using System;
using System.Windows.Forms;

namespace AP.Forms
{
    public partial class FormHebergements : Form
    {
        public Utilisateur Utilisateur;

        public FormHebergements(Utilisateur utilisateur)
        {
            InitializeComponent();
            this.Utilisateur = utilisateur;
        }

        private void FormHebergements_Load(object sender, EventArgs e)
        {

            foreach (Hebergement hebergement in Utilisateur.ListHebergements)
            {
                HebergementsCustumControl Cs = new HebergementsCustumControl(hebergement, Utilisateur, this);
                PanelHebergements.Controls.Add(Cs);
            }
        }
    }
}
