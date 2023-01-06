namespace iaFinal1
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dayslbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dayslbl
            // 
            this.dayslbl.AutoSize = true;
            this.dayslbl.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayslbl.Location = new System.Drawing.Point(12, 10);
            this.dayslbl.Name = "dayslbl";
            this.dayslbl.Size = new System.Drawing.Size(30, 21);
            this.dayslbl.TabIndex = 0;
            this.dayslbl.Text = "00";
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dayslbl);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(94, 51);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dayslbl;
    }
}
