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
    public partial class Conseils : Form
    {
        public Conseils()
        {
            InitializeComponent();
        }

        private void linkLabelLocCourteDuree_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string target = "https://www.economie.gouv.fr/particuliers/investissement-locatif-location-courte-saisonniere-longue-duree#attractif";
            System.Diagnostics.Process.Start(target);
        }

        private void linkLabelLocLongueDuree_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string target = "https://www.economie.gouv.fr/particuliers/investissement-locatif-location-courte-saisonniere-longue-duree#faible";
            System.Diagnostics.Process.Start(target);
        }

        private void linkLabelAides_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string target = "https://www.economie.gouv.fr/particuliers/investir-locatifs-aides";
            System.Diagnostics.Process.Start(target);
        }

        private void linkLabelSimulation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string target = "https://www.anil.org/outil-mise-en-location-simulation-investissement-immobilier-rendement/";
            System.Diagnostics.Process.Start(target);
        }
    }
}
