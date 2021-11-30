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
    public partial class RetourAvis : UserControl
    {
        private modifHebergement ModifHebergement;
        private int idHebergement;
        public RetourAvis(modifHebergement ModifHebergement, int idHebergement)
        {
            InitializeComponent();
            this.ModifHebergement = ModifHebergement;
            this.idHebergement = idHebergement;
        }

        private void retour_Click(object sender, EventArgs e)
        {
            ModifHebergement.flow_avis.Controls.Clear();
            Avis Avis = new Avis();
            List<Avis> allAvis = Avis.GetAllAvisHebergement(ModifHebergement.idHebergement);

            foreach (Avis avis in allAvis)
            {
                AvisHebergement customControl = new AvisHebergement(avis, ModifHebergement, idHebergement);
                ModifHebergement.flow_avis.Controls.Add(customControl);
            }
        }
    }
}
