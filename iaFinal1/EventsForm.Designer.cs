namespace iaFinal1
{
    partial class EventsForm
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
            this.EventName = new Guna.UI2.WinForms.Guna2TextBox();
            this.Datelbl = new System.Windows.Forms.Label();
            this.Namelbl = new System.Windows.Forms.Label();
            this.ScheduleEvent = new Guna.UI2.WinForms.Guna2TileButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // EventName
            // 
            this.EventName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EventName.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.EventName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EventName.DefaultText = "";
            this.EventName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EventName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EventName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EventName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EventName.FillColor = System.Drawing.Color.WhiteSmoke;
            this.EventName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EventName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventName.ForeColor = System.Drawing.Color.Black;
            this.EventName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EventName.Location = new System.Drawing.Point(320, 225);
            this.EventName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EventName.Name = "EventName";
            this.EventName.PasswordChar = '\0';
            this.EventName.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.EventName.PlaceholderText = "enter name of event here";
            this.EventName.SelectedText = "";
            this.EventName.Size = new System.Drawing.Size(201, 25);
            this.EventName.TabIndex = 15;
            this.EventName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelbl.ForeColor = System.Drawing.Color.Goldenrod;
            this.Datelbl.Location = new System.Drawing.Point(256, 164);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(62, 23);
            this.Datelbl.TabIndex = 16;
            this.Datelbl.Text = "Date:";
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelbl.ForeColor = System.Drawing.Color.Goldenrod;
            this.Namelbl.Location = new System.Drawing.Point(190, 229);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(128, 23);
            this.Namelbl.TabIndex = 17;
            this.Namelbl.Text = "EventName:";
            // 
            // ScheduleEvent
            // 
            this.ScheduleEvent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ScheduleEvent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ScheduleEvent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ScheduleEvent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ScheduleEvent.FillColor = System.Drawing.Color.LightGray;
            this.ScheduleEvent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleEvent.ForeColor = System.Drawing.Color.Black;
            this.ScheduleEvent.Location = new System.Drawing.Point(269, 297);
            this.ScheduleEvent.Name = "ScheduleEvent";
            this.ScheduleEvent.Size = new System.Drawing.Size(160, 46);
            this.ScheduleEvent.TabIndex = 18;
            this.ScheduleEvent.Text = "Schedule Event";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Schedule Event:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(324, 165);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(264, 22);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScheduleEvent);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.Datelbl);
            this.Controls.Add(this.EventName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EventsForm";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox EventName;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Label Namelbl;
        private Guna.UI2.WinForms.Guna2TileButton ScheduleEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}