namespace iaFinal1
{
    partial class PaySlip
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
            this.label8 = new System.Windows.Forms.Label();
            this.month = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Absences = new System.Windows.Forms.Label();
            this.Deductions = new System.Windows.Forms.Label();
            this.GrossSalary = new System.Windows.Forms.Label();
            this.Shortage = new System.Windows.Forms.Label();
            this.NetSalary = new System.Windows.Forms.Label();
            this.PrintPay = new Guna.UI2.WinForms.Guna2TileButton();
            this.EmployeeName = new System.Windows.Forms.Label();
            this.EmployeeID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 26);
            this.label8.TabIndex = 19;
            this.label8.Text = "Salary for the month:";
            // 
            // month
            // 
            this.month.AutoSize = true;
            this.month.Font = new System.Drawing.Font("Georgia", 10.2F);
            this.month.Location = new System.Drawing.Point(242, 47);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(98, 20);
            this.month.TabIndex = 24;
            this.month.Text = "Month Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.2F);
            this.label2.Location = new System.Drawing.Point(117, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Absence loss of pay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.2F);
            this.label3.Location = new System.Drawing.Point(143, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Total Deduction";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.2F);
            this.label4.Location = new System.Drawing.Point(111, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Deductions:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 10.2F);
            this.label5.Location = new System.Drawing.Point(193, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Shortages";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 10.2F);
            this.label6.Location = new System.Drawing.Point(143, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Gross Salary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 10.2F);
            this.label7.Location = new System.Drawing.Point(167, 528);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Net Salary";
            // 
            // Absences
            // 
            this.Absences.AutoSize = true;
            this.Absences.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Absences.Font = new System.Drawing.Font("Georgia", 10.2F);
            this.Absences.Location = new System.Drawing.Point(314, 340);
            this.Absences.Name = "Absences";
            this.Absences.Size = new System.Drawing.Size(104, 22);
            this.Absences.TabIndex = 33;
            this.Absences.Text = "                      .";
            // 
            // Deductions
            // 
            this.Deductions.AutoSize = true;
            this.Deductions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Deductions.Font = new System.Drawing.Font("Georgia", 10.2F);
            this.Deductions.Location = new System.Drawing.Point(314, 384);
            this.Deductions.Name = "Deductions";
            this.Deductions.Size = new System.Drawing.Size(104, 22);
            this.Deductions.TabIndex = 34;
            this.Deductions.Text = "                      .";
            this.Deductions.Click += new System.EventHandler(this.WorkingDays_Click);
            // 
            // GrossSalary
            // 
            this.GrossSalary.AutoSize = true;
            this.GrossSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GrossSalary.Font = new System.Drawing.Font("Georgia", 10.2F);
            this.GrossSalary.Location = new System.Drawing.Point(288, 203);
            this.GrossSalary.Name = "GrossSalary";
            this.GrossSalary.Size = new System.Drawing.Size(104, 22);
            this.GrossSalary.TabIndex = 35;
            this.GrossSalary.Text = "                      .";
            // 
            // Shortage
            // 
            this.Shortage.AutoSize = true;
            this.Shortage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Shortage.Font = new System.Drawing.Font("Georgia", 10.2F);
            this.Shortage.Location = new System.Drawing.Point(314, 295);
            this.Shortage.Name = "Shortage";
            this.Shortage.Size = new System.Drawing.Size(104, 22);
            this.Shortage.TabIndex = 36;
            this.Shortage.Text = "                      .";
            // 
            // NetSalary
            // 
            this.NetSalary.AutoSize = true;
            this.NetSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NetSalary.Font = new System.Drawing.Font("Georgia", 10.2F);
            this.NetSalary.Location = new System.Drawing.Point(314, 526);
            this.NetSalary.Name = "NetSalary";
            this.NetSalary.Size = new System.Drawing.Size(104, 22);
            this.NetSalary.TabIndex = 37;
            this.NetSalary.Text = "                      .";
            // 
            // PrintPay
            // 
            this.PrintPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PrintPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PrintPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PrintPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PrintPay.FillColor = System.Drawing.Color.LightGray;
            this.PrintPay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintPay.ForeColor = System.Drawing.Color.Black;
            this.PrintPay.Location = new System.Drawing.Point(171, 618);
            this.PrintPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PrintPay.Name = "PrintPay";
            this.PrintPay.Size = new System.Drawing.Size(223, 46);
            this.PrintPay.TabIndex = 43;
            this.PrintPay.Text = "Print Pay Slip";
            // 
            // EmployeeName
            // 
            this.EmployeeName.AutoSize = true;
            this.EmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmployeeName.Font = new System.Drawing.Font("Georgia", 10.2F);
            this.EmployeeName.Location = new System.Drawing.Point(288, 133);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(116, 22);
            this.EmployeeName.TabIndex = 47;
            this.EmployeeName.Text = "                         .";
            // 
            // EmployeeID
            // 
            this.EmployeeID.AutoSize = true;
            this.EmployeeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmployeeID.Font = new System.Drawing.Font("Georgia", 10.2F);
            this.EmployeeID.Location = new System.Drawing.Point(288, 96);
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Size = new System.Drawing.Size(116, 22);
            this.EmployeeID.TabIndex = 46;
            this.EmployeeID.Text = "                         .";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 10.2F);
            this.label9.Location = new System.Drawing.Point(118, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 20);
            this.label9.TabIndex = 45;
            this.label9.Text = "Employee Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 10.2F);
            this.label10.Location = new System.Drawing.Point(143, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 20);
            this.label10.TabIndex = 44;
            this.label10.Text = "Employee ID";
            // 
            // PaySlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 741);
            this.Controls.Add(this.EmployeeName);
            this.Controls.Add(this.EmployeeID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PrintPay);
            this.Controls.Add(this.NetSalary);
            this.Controls.Add(this.Shortage);
            this.Controls.Add(this.GrossSalary);
            this.Controls.Add(this.Deductions);
            this.Controls.Add(this.Absences);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.month);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PaySlip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaySlip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label month;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Absences;
        private System.Windows.Forms.Label Deductions;
        private System.Windows.Forms.Label GrossSalary;
        private System.Windows.Forms.Label Shortage;
        private System.Windows.Forms.Label NetSalary;
        private Guna.UI2.WinForms.Guna2TileButton PrintPay;
        private System.Windows.Forms.Label EmployeeName;
        private System.Windows.Forms.Label EmployeeID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}