
namespace AP.Forms
{
    partial class ControlResponse
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
            this.retourResponse = new System.Windows.Forms.Button();
            this.supprimerResponse = new System.Windows.Forms.Button();
            this.ajoutResponse = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // retourResponse
            // 
            this.retourResponse.BackColor = System.Drawing.Color.LightSeaGreen;
            this.retourResponse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retourResponse.Font = new System.Drawing.Font("Bodoni MT", 14F, System.Drawing.FontStyle.Bold);
            this.retourResponse.ForeColor = System.Drawing.Color.White;
            this.retourResponse.Location = new System.Drawing.Point(330, 141);
            this.retourResponse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.retourResponse.Name = "retourResponse";
            this.retourResponse.Size = new System.Drawing.Size(86, 32);
            this.retourResponse.TabIndex = 33;
            this.retourResponse.Text = "Retour";
            this.retourResponse.UseVisualStyleBackColor = false;
            this.retourResponse.Click += new System.EventHandler(this.retourResponse_Click);
            // 
            // supprimerResponse
            // 
            this.supprimerResponse.BackColor = System.Drawing.Color.Salmon;
            this.supprimerResponse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supprimerResponse.Font = new System.Drawing.Font("Bodoni MT", 14F, System.Drawing.FontStyle.Bold);
            this.supprimerResponse.ForeColor = System.Drawing.Color.White;
            this.supprimerResponse.Location = new System.Drawing.Point(189, 141);
            this.supprimerResponse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.supprimerResponse.Name = "supprimerResponse";
            this.supprimerResponse.Size = new System.Drawing.Size(110, 32);
            this.supprimerResponse.TabIndex = 32;
            this.supprimerResponse.Text = "Supprimer";
            this.supprimerResponse.UseVisualStyleBackColor = false;
            this.supprimerResponse.Click += new System.EventHandler(this.supprimerResponse_Click);
            // 
            // ajoutResponse
            // 
            this.ajoutResponse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ajoutResponse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ajoutResponse.Font = new System.Drawing.Font("Bodoni MT", 14F, System.Drawing.FontStyle.Bold);
            this.ajoutResponse.ForeColor = System.Drawing.Color.White;
            this.ajoutResponse.Location = new System.Drawing.Point(71, 141);
            this.ajoutResponse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ajoutResponse.Name = "ajoutResponse";
            this.ajoutResponse.Size = new System.Drawing.Size(86, 32);
            this.ajoutResponse.TabIndex = 30;
            this.ajoutResponse.Text = "Publier";
            this.ajoutResponse.UseVisualStyleBackColor = false;
            this.ajoutResponse.Click += new System.EventHandler(this.ajoutResponse_Click);
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(53, 24);
            this.text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(383, 113);
            this.text.TabIndex = 31;
            // 
            // ControlResponse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.retourResponse);
            this.Controls.Add(this.supprimerResponse);
            this.Controls.Add(this.ajoutResponse);
            this.Controls.Add(this.text);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ControlResponse";
            this.Size = new System.Drawing.Size(487, 180);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button retourResponse;
        private System.Windows.Forms.Button supprimerResponse;
        private System.Windows.Forms.Button ajoutResponse;
        public System.Windows.Forms.TextBox text;
    }
}
