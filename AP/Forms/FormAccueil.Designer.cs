
namespace AP.Forms
{
    partial class FormAccueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccueil));
            this.panel10 = new System.Windows.Forms.Panel();
            this.LabelTotalReservations = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.LabelReservationsAVenir = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.LabelReservationsEnCours = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.LabelGainsPrevisonel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LabelGainTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CPBhebergements = new CircularProgressBar.CircularProgressBar();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Controls.Add(this.LabelTotalReservations);
            this.panel10.Controls.Add(this.pictureBox6);
            this.panel10.Location = new System.Drawing.Point(39, 243);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(672, 75);
            this.panel10.TabIndex = 10;
            this.panel10.Paint += new System.Windows.Forms.PaintEventHandler(this.panel10_Paint);
            // 
            // LabelTotalReservations
            // 
            this.LabelTotalReservations.AutoSize = true;
            this.LabelTotalReservations.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalReservations.ForeColor = System.Drawing.Color.Black;
            this.LabelTotalReservations.Location = new System.Drawing.Point(139, 23);
            this.LabelTotalReservations.Name = "LabelTotalReservations";
            this.LabelTotalReservations.Size = new System.Drawing.Size(336, 30);
            this.LabelTotalReservations.TabIndex = 1;
            this.LabelTotalReservations.Text = "Vous totalisez 253 réservations";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(232)))), ((int)(((byte)(113)))));
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(15, 15);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox6.Size = new System.Drawing.Size(45, 45);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.LabelReservationsAVenir);
            this.panel9.Controls.Add(this.pictureBox5);
            this.panel9.Location = new System.Drawing.Point(39, 405);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(672, 75);
            this.panel9.TabIndex = 11;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // LabelReservationsAVenir
            // 
            this.LabelReservationsAVenir.AutoSize = true;
            this.LabelReservationsAVenir.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelReservationsAVenir.Location = new System.Drawing.Point(139, 27);
            this.LabelReservationsAVenir.Name = "LabelReservationsAVenir";
            this.LabelReservationsAVenir.Size = new System.Drawing.Size(345, 30);
            this.LabelReservationsAVenir.TabIndex = 2;
            this.LabelReservationsAVenir.Text = "Vous avez 5 réservations à venir";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(117)))), ((int)(((byte)(244)))));
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(15, 15);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(45, 45);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.LabelReservationsEnCours);
            this.panel8.Controls.Add(this.pictureBox4);
            this.panel8.Location = new System.Drawing.Point(39, 324);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(672, 75);
            this.panel8.TabIndex = 9;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // LabelReservationsEnCours
            // 
            this.LabelReservationsEnCours.AutoSize = true;
            this.LabelReservationsEnCours.BackColor = System.Drawing.Color.Transparent;
            this.LabelReservationsEnCours.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelReservationsEnCours.ForeColor = System.Drawing.Color.Black;
            this.LabelReservationsEnCours.Location = new System.Drawing.Point(139, 22);
            this.LabelReservationsEnCours.Name = "LabelReservationsEnCours";
            this.LabelReservationsEnCours.Size = new System.Drawing.Size(362, 30);
            this.LabelReservationsEnCours.TabIndex = 1;
            this.LabelReservationsEnCours.Text = "Vous avez 5 réservations en cours";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(243)))), ((int)(((byte)(154)))));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(15, 15);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox4.Size = new System.Drawing.Size(45, 45);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.LabelGainsPrevisonel);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.pictureBox3);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(245, 121);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(466, 99);
            this.panel6.TabIndex = 8;
            // 
            // LabelGainsPrevisonel
            // 
            this.LabelGainsPrevisonel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelGainsPrevisonel.AutoSize = true;
            this.LabelGainsPrevisonel.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGainsPrevisonel.Location = new System.Drawing.Point(332, 27);
            this.LabelGainsPrevisonel.Name = "LabelGainsPrevisonel";
            this.LabelGainsPrevisonel.Size = new System.Drawing.Size(84, 37);
            this.LabelGainsPrevisonel.TabIndex = 6;
            this.LabelGainsPrevisonel.Text = "453 €";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(105, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gains prévisionels :";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(20, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 59);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(0, 101);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(466, 99);
            this.panel7.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.LabelGainTotal);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(245, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(466, 99);
            this.panel4.TabIndex = 7;
            // 
            // LabelGainTotal
            // 
            this.LabelGainTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelGainTotal.AutoSize = true;
            this.LabelGainTotal.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGainTotal.Location = new System.Drawing.Point(332, 32);
            this.LabelGainTotal.Name = "LabelGainTotal";
            this.LabelGainTotal.Size = new System.Drawing.Size(99, 37);
            this.LabelGainTotal.TabIndex = 5;
            this.LabelGainTotal.Text = "3568 €";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3.Location = new System.Drawing.Point(102, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gains  :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BackColor = System.Drawing.Color.PaleGreen;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(0, 101);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(466, 99);
            this.panel5.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.CPBhebergements);
            this.panel3.Location = new System.Drawing.Point(39, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 200);
            this.panel3.TabIndex = 6;
            // 
            // CPBhebergements
            // 
            this.CPBhebergements.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.CPBhebergements.AnimationSpeed = 500;
            this.CPBhebergements.BackColor = System.Drawing.Color.White;
            this.CPBhebergements.Dock = System.Windows.Forms.DockStyle.Top;
            this.CPBhebergements.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.CPBhebergements.ForeColor = System.Drawing.Color.Black;
            this.CPBhebergements.InnerColor = System.Drawing.Color.White;
            this.CPBhebergements.InnerMargin = 2;
            this.CPBhebergements.InnerWidth = -1;
            this.CPBhebergements.Location = new System.Drawing.Point(0, 0);
            this.CPBhebergements.MarqueeAnimationSpeed = 2000;
            this.CPBhebergements.Name = "CPBhebergements";
            this.CPBhebergements.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.CPBhebergements.OuterMargin = -25;
            this.CPBhebergements.OuterWidth = 26;
            this.CPBhebergements.ProgressColor = System.Drawing.Color.LightSeaGreen;
            this.CPBhebergements.ProgressWidth = 25;
            this.CPBhebergements.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.CPBhebergements.Size = new System.Drawing.Size(200, 200);
            this.CPBhebergements.StartAngle = 270;
            this.CPBhebergements.SubscriptColor = System.Drawing.Color.White;
            this.CPBhebergements.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.CPBhebergements.SubscriptText = "";
            this.CPBhebergements.SuperscriptColor = System.Drawing.Color.White;
            this.CPBhebergements.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.CPBhebergements.SuperscriptText = "";
            this.CPBhebergements.TabIndex = 0;
            this.CPBhebergements.Text = "1 hébergement";
            this.CPBhebergements.TextMargin = new System.Windows.Forms.Padding(0);
            this.CPBhebergements.Value = 63;
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAccueil";
            this.Text = "FormAccueil";
            this.Shown += new System.EventHandler(this.FormAccueil_Shown);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label LabelTotalReservations;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label LabelReservationsAVenir;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label LabelReservationsEnCours;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label LabelGainsPrevisonel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LabelGainTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private CircularProgressBar.CircularProgressBar CPBhebergements;
    }
}