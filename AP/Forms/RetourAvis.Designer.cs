
namespace AP.Forms
{
    partial class RetourAvis
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
            this.retour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // retour
            // 
            this.retour.Location = new System.Drawing.Point(0, 0);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(91, 28);
            this.retour.TabIndex = 0;
            this.retour.Text = "Retour";
            this.retour.UseVisualStyleBackColor = true;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // RetourAvis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.retour);
            this.Name = "RetourAvis";
            this.Size = new System.Drawing.Size(94, 34);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button retour;
    }
}
