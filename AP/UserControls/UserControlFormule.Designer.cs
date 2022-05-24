
namespace AP.UserControls
{
    partial class UserControlFormule
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
            this.checkBoxFormule = new System.Windows.Forms.CheckBox();
            this.textBoxFormule = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxFormule
            // 
            this.checkBoxFormule.AutoSize = true;
            this.checkBoxFormule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFormule.Location = new System.Drawing.Point(12, 17);
            this.checkBoxFormule.Name = "checkBoxFormule";
            this.checkBoxFormule.Size = new System.Drawing.Size(252, 33);
            this.checkBoxFormule.TabIndex = 1;
            this.checkBoxFormule.Text = "TITRE de la formule";
            this.checkBoxFormule.UseVisualStyleBackColor = true;
            this.checkBoxFormule.CheckedChanged += new System.EventHandler(this.checkBoxFormule_CheckedChanged);
            // 
            // textBoxFormule
            // 
            this.textBoxFormule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFormule.Location = new System.Drawing.Point(365, 15);
            this.textBoxFormule.Name = "textBoxFormule";
            this.textBoxFormule.Size = new System.Drawing.Size(158, 34);
            this.textBoxFormule.TabIndex = 2;
            this.textBoxFormule.TextChanged += new System.EventHandler(this.textBoxFormule_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(529, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "€";
            // 
            // UserControlFormule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFormule);
            this.Controls.Add(this.checkBoxFormule);
            this.Name = "UserControlFormule";
            this.Size = new System.Drawing.Size(575, 66);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxFormule;
        private System.Windows.Forms.TextBox textBoxFormule;
        private System.Windows.Forms.Label label1;
    }
}
