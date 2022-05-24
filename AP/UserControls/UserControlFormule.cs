using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP.UserControls
{
    public partial class UserControlFormule : UserControl
    {
        public int formuleId;
        public bool formuleChecked;
        public string titreFormule;
        public decimal prixFormule;

        public UserControlFormule(int formuleId, bool formuleChecked, string titre, decimal prix = 0)
        {
            InitializeComponent();
            this.formuleId = formuleId;
            this.formuleChecked = formuleChecked;
            this.titreFormule = titre;
            checkBoxFormule.Checked = formuleChecked;
            checkBoxFormule.Text = titre;
            textBoxFormule.Text = prix.ToString();
            if (prix == 0)
                textBoxFormule.Enabled = false;
            else
                textBoxFormule.Enabled = true;
        }

        private void checkBoxFormule_CheckedChanged(object sender, EventArgs e)
        {
            this.formuleChecked = !this.formuleChecked;
            textBoxFormule.Enabled = !textBoxFormule.Enabled;
        }

        private void textBoxFormule_TextChanged(object sender, EventArgs e)
        {
            this.prixFormule = Int32.Parse(textBoxFormule.Text);
        }
    }
}
