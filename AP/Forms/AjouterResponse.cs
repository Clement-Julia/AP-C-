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
    public partial class AjouterResponse : UserControl
    {
        List<Response> réponse;
        int idAvis;
        int idHebergement;
        TextResponse textResponse;
        int idResponse;
        modifHebergement ModifHebergement;
        public AjouterResponse(List<Response> réponse, int idAvis, int idHebergement, TextResponse textResponse, int idResponse, modifHebergement modifHebergement)
        {
            InitializeComponent();
            this.réponse = réponse;
            this.idAvis = idAvis;
            this.idHebergement = idHebergement;
            this.textResponse = textResponse;
            this.idResponse = idResponse;
            this.ModifHebergement = modifHebergement;
        }

        private void ajout_Click(object sender, EventArgs e)
        {
            Avis Avis = new Avis();
            if (réponse.Count == 0)
            {
                MessageBox.Show(Avis.AjoutResponse(idAvis, idHebergement, textResponse.text.Text));

                ModifHebergement.flow_avis.Controls.Clear();
                List<Avis> allAvis = Avis.GetAllAvisHebergement(ModifHebergement.idHebergement);
                foreach (Avis avis in allAvis)
                {
                    AvisHebergement customControl = new AvisHebergement(avis, ModifHebergement, idHebergement);
                    ModifHebergement.flow_avis.Controls.Add(customControl);
                }
            }
            else
            {
                MessageBox.Show(Avis.UpdateResponse(idResponse, textResponse.text.Text));

                ModifHebergement.flow_avis.Controls.Clear();
                List<Avis> allAvis = Avis.GetAllAvisHebergement(ModifHebergement.idHebergement);
                foreach (Avis avis in allAvis)
                {
                    AvisHebergement customControl = new AvisHebergement(avis, ModifHebergement, idHebergement);
                    ModifHebergement.flow_avis.Controls.Add(customControl);
                }
            }
        }
    }
}