
namespace AP
{
    partial class modifHebergement
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modifHebergement));
            this.nom = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.appartenance = new System.Windows.Forms.Label();
            this.labeldesc = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.labellat = new System.Windows.Forms.Label();
            this.labellong = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.prix = new System.Windows.Forms.TextBox();
            this.latitude = new System.Windows.Forms.TextBox();
            this.longitude = new System.Windows.Forms.TextBox();
            this.modif = new System.Windows.Forms.Button();
            this.retour = new System.Windows.Forms.Button();
            this.ville = new System.Windows.Forms.ComboBox();
            this.sup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nom
            // 
            this.nom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nom.AutoSize = true;
            this.nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.Location = new System.Drawing.Point(272, 28);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(61, 24);
            this.nom.TabIndex = 0;
            this.nom.Text = "Nom :";
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name.Location = new System.Drawing.Point(275, 55);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(360, 22);
            this.name.TabIndex = 1;
            // 
            // appartenance
            // 
            this.appartenance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.appartenance.AutoSize = true;
            this.appartenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appartenance.Location = new System.Drawing.Point(271, 93);
            this.appartenance.Name = "appartenance";
            this.appartenance.Size = new System.Drawing.Size(139, 24);
            this.appartenance.TabIndex = 2;
            this.appartenance.Text = "Appartenance :";
            // 
            // labeldesc
            // 
            this.labeldesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labeldesc.AutoSize = true;
            this.labeldesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldesc.Location = new System.Drawing.Point(272, 159);
            this.labeldesc.Name = "labeldesc";
            this.labeldesc.Size = new System.Drawing.Size(114, 24);
            this.labeldesc.TabIndex = 3;
            this.labeldesc.Text = "Description :";
            // 
            // price
            // 
            this.price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(272, 292);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(52, 24);
            this.price.TabIndex = 4;
            this.price.Text = "Prix :";
            // 
            // labellat
            // 
            this.labellat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labellat.AutoSize = true;
            this.labellat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellat.Location = new System.Drawing.Point(273, 355);
            this.labellat.Name = "labellat";
            this.labellat.Size = new System.Drawing.Size(85, 24);
            this.labellat.TabIndex = 5;
            this.labellat.Text = "Latitude :";
            // 
            // labellong
            // 
            this.labellong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labellong.AutoSize = true;
            this.labellong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellong.Location = new System.Drawing.Point(272, 420);
            this.labellong.Name = "labellong";
            this.labellong.Size = new System.Drawing.Size(104, 24);
            this.labellong.TabIndex = 6;
            this.labellong.Text = "Longitude :";
            // 
            // description
            // 
            this.description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.description.Location = new System.Drawing.Point(275, 186);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(360, 92);
            this.description.TabIndex = 8;
            // 
            // prix
            // 
            this.prix.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prix.Location = new System.Drawing.Point(275, 319);
            this.prix.Name = "prix";
            this.prix.Size = new System.Drawing.Size(360, 22);
            this.prix.TabIndex = 9;
            // 
            // latitude
            // 
            this.latitude.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.latitude.Location = new System.Drawing.Point(276, 382);
            this.latitude.Name = "latitude";
            this.latitude.Size = new System.Drawing.Size(360, 22);
            this.latitude.TabIndex = 10;
            // 
            // longitude
            // 
            this.longitude.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.longitude.Location = new System.Drawing.Point(275, 447);
            this.longitude.Name = "longitude";
            this.longitude.Size = new System.Drawing.Size(360, 22);
            this.longitude.TabIndex = 11;
            // 
            // modif
            // 
            this.modif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modif.BackColor = System.Drawing.Color.White;
            this.modif.Location = new System.Drawing.Point(275, 499);
            this.modif.Name = "modif";
            this.modif.Size = new System.Drawing.Size(150, 42);
            this.modif.TabIndex = 12;
            this.modif.Text = "Modifier";
            this.modif.UseVisualStyleBackColor = false;
            this.modif.Click += new System.EventHandler(this.modif_Click);
            // 
            // retour
            // 
            this.retour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.retour.BackColor = System.Drawing.Color.White;
            this.retour.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.retour.Location = new System.Drawing.Point(383, 547);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(146, 42);
            this.retour.TabIndex = 13;
            this.retour.Text = "Retour";
            this.retour.UseVisualStyleBackColor = false;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // ville
            // 
            this.ville.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ville.FormattingEnabled = true;
            this.ville.Location = new System.Drawing.Point(275, 120);
            this.ville.Name = "ville";
            this.ville.Size = new System.Drawing.Size(360, 24);
            this.ville.TabIndex = 14;
            // 
            // sup
            // 
            this.sup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sup.BackColor = System.Drawing.Color.White;
            this.sup.Location = new System.Drawing.Point(485, 499);
            this.sup.Name = "sup";
            this.sup.Size = new System.Drawing.Size(150, 42);
            this.sup.TabIndex = 15;
            this.sup.Text = "Supprimer";
            this.sup.UseVisualStyleBackColor = false;
            this.sup.Click += new System.EventHandler(this.sup_Click);
            // 
            // modifHebergement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(899, 608);
            this.Controls.Add(this.sup);
            this.Controls.Add(this.ville);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.modif);
            this.Controls.Add(this.longitude);
            this.Controls.Add(this.latitude);
            this.Controls.Add(this.prix);
            this.Controls.Add(this.description);
            this.Controls.Add(this.labellong);
            this.Controls.Add(this.labellat);
            this.Controls.Add(this.price);
            this.Controls.Add(this.labeldesc);
            this.Controls.Add(this.appartenance);
            this.Controls.Add(this.name);
            this.Controls.Add(this.nom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "modifHebergement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modification d\'un hebergement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label appartenance;
        private System.Windows.Forms.Label labeldesc;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label labellat;
        private System.Windows.Forms.Label labellong;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox prix;
        private System.Windows.Forms.TextBox latitude;
        private System.Windows.Forms.TextBox longitude;
        private System.Windows.Forms.Button modif;
        private System.Windows.Forms.Button retour;
        private System.Windows.Forms.ComboBox ville;
        private System.Windows.Forms.Button sup;
    }
}

