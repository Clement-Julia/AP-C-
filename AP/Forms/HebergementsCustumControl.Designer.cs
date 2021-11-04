
namespace AP.Forms
{
    partial class HebergementsCustumControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HebergementsCustumControl));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnInfos = new System.Windows.Forms.Button();
            this.BtnModification = new System.Windows.Forms.Button();
            this.LabelNomHebergement = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabelNbReservationEnCours = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelNbReservationAVenir = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hebergements";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BtnInfos
            // 
            this.BtnInfos.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnInfos.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.BtnInfos.FlatAppearance.BorderSize = 4;
            this.BtnInfos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInfos.Font = new System.Drawing.Font("Bodoni MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInfos.ForeColor = System.Drawing.Color.White;
            this.BtnInfos.Location = new System.Drawing.Point(5, 308);
            this.BtnInfos.Name = "BtnInfos";
            this.BtnInfos.Size = new System.Drawing.Size(132, 35);
            this.BtnInfos.TabIndex = 2;
            this.BtnInfos.Text = "Infos";
            this.BtnInfos.UseVisualStyleBackColor = false;
            // 
            // BtnModification
            // 
            this.BtnModification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnModification.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnModification.FlatAppearance.BorderSize = 4;
            this.BtnModification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModification.Font = new System.Drawing.Font("Bodoni MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModification.ForeColor = System.Drawing.Color.White;
            this.BtnModification.Location = new System.Drawing.Point(138, 308);
            this.BtnModification.Name = "BtnModification";
            this.BtnModification.Size = new System.Drawing.Size(132, 35);
            this.BtnModification.TabIndex = 3;
            this.BtnModification.Text = "Modifier";
            this.BtnModification.UseVisualStyleBackColor = false;
            // 
            // LabelNomHebergement
            // 
            this.LabelNomHebergement.AutoSize = true;
            this.LabelNomHebergement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNomHebergement.Location = new System.Drawing.Point(11, 133);
            this.LabelNomHebergement.Name = "LabelNomHebergement";
            this.LabelNomHebergement.Size = new System.Drawing.Size(205, 24);
            this.LabelNomHebergement.TabIndex = 4;
            this.LabelNomHebergement.Text = "Nom de l\'hébergement";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.LabelNbReservationAVenir);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 108);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(5, 166);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(265, 140);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(257, 114);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "En cours";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(257, 114);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "A venir";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.LabelNbReservationEnCours);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 108);
            this.panel2.TabIndex = 6;
            // 
            // LabelNbReservationEnCours
            // 
            this.LabelNbReservationEnCours.AutoSize = true;
            this.LabelNbReservationEnCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNbReservationEnCours.ForeColor = System.Drawing.Color.Black;
            this.LabelNbReservationEnCours.Location = new System.Drawing.Point(122, 35);
            this.LabelNbReservationEnCours.Name = "LabelNbReservationEnCours";
            this.LabelNbReservationEnCours.Size = new System.Drawing.Size(117, 24);
            this.LabelNbReservationEnCours.TabIndex = 1;
            this.LabelNbReservationEnCours.Text = "1 réservation";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(113, 102);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(141, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "en cours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(149, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "à venir";
            // 
            // LabelNbReservationAVenir
            // 
            this.LabelNbReservationAVenir.AutoSize = true;
            this.LabelNbReservationAVenir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNbReservationAVenir.ForeColor = System.Drawing.Color.Black;
            this.LabelNbReservationAVenir.Location = new System.Drawing.Point(115, 35);
            this.LabelNbReservationAVenir.Name = "LabelNbReservationAVenir";
            this.LabelNbReservationAVenir.Size = new System.Drawing.Size(136, 24);
            this.LabelNbReservationAVenir.TabIndex = 5;
            this.LabelNbReservationAVenir.Text = "10 réservations";
            // 
            // HebergementsCustumControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.LabelNomHebergement);
            this.Controls.Add(this.BtnModification);
            this.Controls.Add(this.BtnInfos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(25, 10, 25, 10);
            this.Name = "HebergementsCustumControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(275, 350);
            this.Load += new System.EventHandler(this.HebergementsCustumControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnInfos;
        private System.Windows.Forms.Button BtnModification;
        private System.Windows.Forms.Label LabelNomHebergement;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LabelNbReservationEnCours;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelNbReservationAVenir;
        private System.Windows.Forms.Label label5;
    }
}
