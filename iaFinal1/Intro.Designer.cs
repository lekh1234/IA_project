namespace iaFinal1
{
    partial class Intro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intro));
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.TMSLabel = new System.Windows.Forms.Label();
            this.RKLogo = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RKLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.Color.LightGray;
            this.WelcomeLabel.Font = new System.Drawing.Font("Gill Sans MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.WelcomeLabel.Location = new System.Drawing.Point(276, 313);
            this.WelcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(175, 39);
            this.WelcomeLabel.TabIndex = 7;
            this.WelcomeLabel.Text = "WELCOME";
            // 
            // TMSLabel
            // 
            this.TMSLabel.AutoSize = true;
            this.TMSLabel.Font = new System.Drawing.Font("Gill Sans MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMSLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TMSLabel.Location = new System.Drawing.Point(160, 260);
            this.TMSLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TMSLabel.Name = "TMSLabel";
            this.TMSLabel.Size = new System.Drawing.Size(443, 39);
            this.TMSLabel.TabIndex = 6;
            this.TMSLabel.Text = "Terminal Management Software";
            // 
            // RKLogo
            // 
            this.RKLogo.Image = ((System.Drawing.Image)(resources.GetObject("RKLogo.Image")));
            this.RKLogo.Location = new System.Drawing.Point(245, 46);
            this.RKLogo.Margin = new System.Windows.Forms.Padding(2);
            this.RKLogo.Name = "RKLogo";
            this.RKLogo.Size = new System.Drawing.Size(221, 198);
            this.RKLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RKLogo.TabIndex = 5;
            this.RKLogo.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.IndianRed;
            this.progressBar1.Location = new System.Drawing.Point(0, 403);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(713, 28);
            this.progressBar1.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 431);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.TMSLabel);
            this.Controls.Add(this.RKLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Intro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intro";
            this.Load += new System.EventHandler(this.Intro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RKLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label TMSLabel;
        private System.Windows.Forms.PictureBox RKLogo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}