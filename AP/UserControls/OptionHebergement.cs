using AP.Model;
using System;
using System.Drawing;
using System.Linq;
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
            // Permet de récupérer le FontAwesome.Sharp.IconChar correspondant à l'image souhaité
            this.iconButton.IconChar = FontAwesome.Sharp.IconHelper.Icons.FirstOrDefault(w => w.ToString() == this.getFontawesomeNameForSharp());

            if (check)
            {
                this.checkBox1.Checked = true;
                this.iconButton.BackColor = Color.FromArgb(177, 221, 91);
            }
            else
            {
                this.checkBox1.Checked = false;
                this.iconButton.BackColor = Color.FromArgb(221, 91, 91);
            }
        }
        
        // Permet la mis en forme du naming de fontawesome version Csharp (même naming que web mais sans '-' et avec des majuscules)
        private string getFontawesomeNameForSharp()
        {
            // Comme le naming des icon dans fontawesome peut avoir deux ou trois '-' dans la partie importante, il a fallu les prévoir manuellement car on ne peut pas instancier de variable au seins d'un foreach
            string nameOne = "";
            string nameTwo = "";
            string nameThree = "";
            string[] tabIcon = option.Icon.Split('-');
            for (int i = 0; i < tabIcon.Length; i++)
            {
                string icon = tabIcon[i];
                if (i == 1)
                    nameOne = icon[0].ToString().ToUpper() + icon.Substring(1).ToLower();
                if (i == 2)
                    nameTwo = icon[0].ToString().ToUpper() + icon.Substring(1).ToLower();
                if (i == 3)
                    nameThree = icon[0].ToString().ToUpper() + icon.Substring(1).ToLower();
            }
            string nameIcon = nameOne + nameTwo + nameThree;
            return nameIcon;
        }

        private void iconButton_Click(object sender, EventArgs e)
        {
            this.checkBox1.Checked = !this.checkBox1.Checked;
            if (this.checkBox1.Checked == true)
                this.iconButton.BackColor = Color.FromArgb(177, 221, 91);
            else
                this.iconButton.BackColor = Color.FromArgb(221, 91, 91);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true)
                this.iconButton.BackColor = Color.FromArgb(177, 221, 91);
            else
                this.iconButton.BackColor = Color.FromArgb(221, 91, 91);
        }
    }
}
