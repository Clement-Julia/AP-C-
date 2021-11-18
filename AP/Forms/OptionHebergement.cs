using AP.Model;
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
    public partial class OptionHebergement : UserControl
    {
        Option option;
        public OptionHebergement(Option option, Boolean check)
        {
            InitializeComponent();
            this.option = option;
            this.checkBox1.Name = option.IdOption.ToString();
            this.checkBox1.Text = option.Libelle;

            if (check)
            {
                this.checkBox1.Checked = true;
            }
            else
            {
                this.checkBox1.Checked = false;
            }
        }
    }
}
