
namespace AP.Forms
{
    partial class OptionHebergement
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.iconButton = new FontAwesome.Sharp.IconButton();
            this.panelBorderBottom = new System.Windows.Forms.Panel();
            this.panelBorderBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(10, 0);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(150, 36);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // iconButton
            // 
            this.iconButton.BackColor = System.Drawing.Color.White;
            this.iconButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconButton.FlatAppearance.BorderSize = 0;
            this.iconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton.IconColor = System.Drawing.Color.Black;
            this.iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton.IconSize = 30;
            this.iconButton.Location = new System.Drawing.Point(180, 2);
            this.iconButton.Name = "iconButton";
            this.iconButton.Size = new System.Drawing.Size(36, 36);
            this.iconButton.TabIndex = 1;
            this.iconButton.UseVisualStyleBackColor = false;
            this.iconButton.Click += new System.EventHandler(this.iconButton_Click);
            // 
            // panelBorderBottom
            // 
            this.panelBorderBottom.BackColor = System.Drawing.Color.White;
            this.panelBorderBottom.Controls.Add(this.checkBox1);
            this.panelBorderBottom.Controls.Add(this.iconButton);
            this.panelBorderBottom.Location = new System.Drawing.Point(0, 0);
            this.panelBorderBottom.Name = "panelBorderBottom";
            this.panelBorderBottom.Size = new System.Drawing.Size(434, 40);
            this.panelBorderBottom.TabIndex = 2;
            // 
            // OptionHebergement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Controls.Add(this.panelBorderBottom);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OptionHebergement";
            this.Size = new System.Drawing.Size(434, 42);
            this.panelBorderBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.CheckBox checkBox1;
        private FontAwesome.Sharp.IconButton iconButton;
        private System.Windows.Forms.Panel panelBorderBottom;
    }
}
