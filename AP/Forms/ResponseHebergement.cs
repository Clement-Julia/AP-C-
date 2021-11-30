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
<<<<<<< HEAD
        Response response;
        public ResponseHebergement(Response response)
=======
        private Response response;
        private modifHebergement ModifHebergement;
        public ResponseHebergement(Response response = null, modifHebergement ModifHebergement = null)
>>>>>>> new_main
        {
            InitializeComponent();
            this.nom.Text = response.Nom;
            this.prenom.Text = response.Prénom;
            this.reponse.Text = response.Reponse;
<<<<<<< HEAD
=======
            this.response = response;
            this.ModifHebergement = ModifHebergement;
>>>>>>> new_main
        }
    }
}
