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
using AP.UserControls;

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
