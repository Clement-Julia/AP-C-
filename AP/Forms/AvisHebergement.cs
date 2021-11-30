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
        private Avis avis;
        private modifHebergement ModifHebergement;
        private int idHebergement;
        public AvisHebergement(Avis avis, modifHebergement ModifHebergement, int idHebergement)
        {
            InitializeComponent();
            this.nom.Text = avis.Nom;
            this.prénom.Text = avis.Prénom;
            this.rating.Text = avis.Note.ToString();
            this.commentaire.Text = avis.Commentaire;
            this.avis = avis;
            this.ModifHebergement = ModifHebergement;
            this.idHebergement = idHebergement;
        }

        private void link_avis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ModifHebergement.flow_avis.Controls.Clear();
            ModifHebergement.flow_avis.Controls.Add(new AvisHebergement(avis, ModifHebergement, idHebergement));
            Response Response = new Response();
            List<Response> réponse = Response.GetResponses(avis.IdAvis);
            int idResponse = 0;

            foreach (Response result in réponse)
            {
                ResponseHebergement customControl = new ResponseHebergement(result, ModifHebergement);
                ModifHebergement.flow_avis.Controls.Add(customControl);
                idResponse = result.IdResponse;
            }

            TextResponse test = new TextResponse();
            ModifHebergement.flow_avis.Controls.Add(test);
            ModifHebergement.flow_avis.Controls.Add(new AjouterResponse(réponse, avis.IdAvis, idHebergement, test, idResponse, ModifHebergement));
            if (réponse.Count != 0)
            {
                ModifHebergement.flow_avis.Controls.Add(new SupprimerResponse());
            }
            ModifHebergement.flow_avis.Controls.Add(new RetourAvis(ModifHebergement, idHebergement));
        }
    }
}
