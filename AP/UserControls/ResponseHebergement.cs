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
        private Response _response;
        private modifHebergement _modifHebergement;
        private Utilisateur _utilisateur;
        public ResponseHebergement(Response response = null, modifHebergement ModifHebergement = null, Utilisateur utilisateur = null)
        {
            InitializeComponent();
            this._response = response;
            this._modifHebergement = ModifHebergement;
            this._utilisateur = utilisateur;
            this.nom.Text = utilisateur.Nom + " " + utilisateur.Prenom;
            this.reponse.Text = response.Reponse;
            labelDate.Text = _response.Date.ToString("dd-MM-yyyy");
        }
    }
}
