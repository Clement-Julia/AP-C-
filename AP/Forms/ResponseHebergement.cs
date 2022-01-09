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
    public partial class ResponseHebergement : UserControl
    {
        private Response response;
        private modifHebergement ModifHebergement;
        public ResponseHebergement(Response response = null, modifHebergement ModifHebergement = null)
        {
            InitializeComponent();
            this.nom.Text = response.Nom;
            this.prenom.Text = response.Prénom;
            this.reponse.Text = response.Reponse;
            this.response = response;
            this.ModifHebergement = ModifHebergement;
        }
    }
}
