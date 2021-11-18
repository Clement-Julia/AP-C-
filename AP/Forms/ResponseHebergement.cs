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
        Response response;
        public ResponseHebergement(Response response)
        {
            InitializeComponent();
            this.nom.Text = response.Nom;
            this.prenom.Text = response.Prénom;
            this.reponse.Text = response.Reponse;
        }
    }
}
