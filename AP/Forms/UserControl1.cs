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
    public partial class UserControl1 : UserControl
    {

        private string numero;
        public UserControl1(string numero)
        {
            InitializeComponent();
            this.numero = numero;
            label1.Text = this.numero;
        }
    }
}
