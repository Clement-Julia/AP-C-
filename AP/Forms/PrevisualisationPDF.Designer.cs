
namespace AP.Forms
{
    partial class PrevisualisationPDF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelUserId = new System.Windows.Forms.Label();
            this.labelPeriode = new System.Windows.Forms.Label();
            this.flowLayoutPanelDonnees = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelGains = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelHebergement = new System.Windows.Forms.Label();
            this.labelVille = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelIdReservation = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(23, 22);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(48, 21);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenom.Location = new System.Drawing.Point(23, 43);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(70, 21);
            this.labelPrenom.TabIndex = 1;
            this.labelPrenom.Text = "Prenom";
            // 
            // labelUserId
            // 
            this.labelUserId.AutoSize = true;
            this.labelUserId.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserId.Location = new System.Drawing.Point(23, 64);
            this.labelUserId.Name = "labelUserId";
            this.labelUserId.Size = new System.Drawing.Size(63, 21);
            this.labelUserId.TabIndex = 2;
            this.labelUserId.Text = "User Id";
            // 
            // labelPeriode
            // 
            this.labelPeriode.AutoSize = true;
            this.labelPeriode.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeriode.Location = new System.Drawing.Point(430, 107);
            this.labelPeriode.Name = "labelPeriode";
            this.labelPeriode.Size = new System.Drawing.Size(295, 21);
            this.labelPeriode.TabIndex = 3;
            this.labelPeriode.Text = "Période du 01/01/2020 au 01/02/2020";
            // 
            // flowLayoutPanelDonnees
            // 
            this.flowLayoutPanelDonnees.AutoScroll = true;
            this.flowLayoutPanelDonnees.BackColor = System.Drawing.Color.Gainsboro;
            this.flowLayoutPanelDonnees.Location = new System.Drawing.Point(0, 204);
            this.flowLayoutPanelDonnees.Name = "flowLayoutPanelDonnees";
            this.flowLayoutPanelDonnees.Size = new System.Drawing.Size(723, 392);
            this.flowLayoutPanelDonnees.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.labelGains);
            this.panel1.Controls.Add(this.labelNom);
            this.panel1.Controls.Add(this.flowLayoutPanelDonnees);
            this.panel1.Controls.Add(this.labelPrenom);
            this.panel1.Controls.Add(this.labelPeriode);
            this.panel1.Controls.Add(this.labelUserId);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 700);
            this.panel1.TabIndex = 5;
            // 
            // labelGains
            // 
            this.labelGains.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGains.Location = new System.Drawing.Point(553, 617);
            this.labelGains.Name = "labelGains";
            this.labelGains.Size = new System.Drawing.Size(172, 51);
            this.labelGains.TabIndex = 5;
            this.labelGains.Text = "Gains : ";
            this.labelGains.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(27, 626);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 35);
            this.button1.TabIndex = 26;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(207, 626);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 35);
            this.button2.TabIndex = 27;
            this.button2.Text = "Générer le PDF";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.labelHebergement);
            this.panel2.Controls.Add(this.labelIdReservation);
            this.panel2.Controls.Add(this.labelVille);
            this.panel2.Location = new System.Drawing.Point(0, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(723, 50);
            this.panel2.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(646, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 50);
            this.label1.TabIndex = 33;
            this.label1.Text = "Gains";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHebergement
            // 
            this.labelHebergement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHebergement.ForeColor = System.Drawing.Color.White;
            this.labelHebergement.Location = new System.Drawing.Point(452, -1);
            this.labelHebergement.Name = "labelHebergement";
            this.labelHebergement.Size = new System.Drawing.Size(188, 50);
            this.labelHebergement.TabIndex = 32;
            this.labelHebergement.Text = "Hébergement";
            this.labelHebergement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVille
            // 
            this.labelVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVille.ForeColor = System.Drawing.Color.White;
            this.labelVille.Location = new System.Drawing.Point(305, -1);
            this.labelVille.Name = "labelVille";
            this.labelVille.Size = new System.Drawing.Size(141, 50);
            this.labelVille.TabIndex = 31;
            this.labelVille.Text = "Ville";
            this.labelVille.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(76, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 50);
            this.label2.TabIndex = 30;
            this.label2.Text = "Période";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIdReservation
            // 
            this.labelIdReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdReservation.ForeColor = System.Drawing.Color.White;
            this.labelIdReservation.Location = new System.Drawing.Point(0, 0);
            this.labelIdReservation.Name = "labelIdReservation";
            this.labelIdReservation.Size = new System.Drawing.Size(70, 50);
            this.labelIdReservation.TabIndex = 29;
            this.labelIdReservation.Text = "Id";
            this.labelIdReservation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PrevisualisationPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 700);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrevisualisationPDF";
            this.Text = "PrevisualisationPDF";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelUserId;
        private System.Windows.Forms.Label labelPeriode;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDonnees;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelGains;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelHebergement;
        private System.Windows.Forms.Label labelIdReservation;
        private System.Windows.Forms.Label labelVille;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}