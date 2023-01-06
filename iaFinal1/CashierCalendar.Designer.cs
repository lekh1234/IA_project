namespace iaFinal1
{
    partial class CashierCalendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierCalendar));
            this.header = new System.Windows.Forms.Panel();
            this.Minimise = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Exit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.ProfileImage = new System.Windows.Forms.PictureBox();
            this.RKandCo = new System.Windows.Forms.Label();
            this.Heading = new System.Windows.Forms.Label();
            this.Logo2 = new System.Windows.Forms.PictureBox();
            this.RKLogo1 = new System.Windows.Forms.PictureBox();
            this.dashboard = new System.Windows.Forms.Panel();
            this.SearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Settings = new Guna.UI2.WinForms.Guna2Button();
            this.Salary = new Guna.UI2.WinForms.Guna2Button();
            this.ShiftHistory = new Guna.UI2.WinForms.Guna2Button();
            this.Shift = new Guna.UI2.WinForms.Guna2Button();
            this.Calendar = new Guna.UI2.WinForms.Guna2Button();
            this.HomePage = new Guna.UI2.WinForms.Guna2Button();
            this.footer = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CalenderPanel = new System.Windows.Forms.Panel();
            this.Previous = new Guna.UI2.WinForms.Guna2TileButton();
            this.Next = new Guna.UI2.WinForms.Guna2TileButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datelb = new System.Windows.Forms.Label();
            this.daycontainer = new System.Windows.Forms.FlowLayoutPanel();
            this.ScheduleEvent = new Guna.UI2.WinForms.Guna2TileButton();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RKLogo1)).BeginInit();
            this.dashboard.SuspendLayout();
            this.footer.SuspendLayout();
            this.CalenderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.Controls.Add(this.Minimise);
            this.header.Controls.Add(this.Exit);
            this.header.Controls.Add(this.ProfileImage);
            this.header.Controls.Add(this.RKandCo);
            this.header.Controls.Add(this.Heading);
            this.header.Controls.Add(this.Logo2);
            this.header.Controls.Add(this.RKLogo1);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1227, 85);
            this.header.TabIndex = 3;
            // 
            // Minimise
            // 
            this.Minimise.BorderColor = System.Drawing.Color.Gray;
            this.Minimise.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Minimise.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Minimise.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Minimise.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Minimise.FillColor = System.Drawing.SystemColors.Control;
            this.Minimise.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Minimise.ForeColor = System.Drawing.Color.White;
            this.Minimise.HoverState.BorderColor = System.Drawing.Color.Cornsilk;
            this.Minimise.HoverState.FillColor = System.Drawing.Color.Cornsilk;
            this.Minimise.Image = ((System.Drawing.Image)(resources.GetObject("Minimise.Image")));
            this.Minimise.ImageSize = new System.Drawing.Size(40, 40);
            this.Minimise.Location = new System.Drawing.Point(1100, 9);
            this.Minimise.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Minimise.Name = "Minimise";
            this.Minimise.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Minimise.Size = new System.Drawing.Size(51, 63);
            this.Minimise.TabIndex = 10;
            this.Minimise.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.Minimise.Click += new System.EventHandler(this.Minimise_Click);
            // 
            // Exit
            // 
            this.Exit.BorderColor = System.Drawing.Color.Gray;
            this.Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Exit.FillColor = System.Drawing.SystemColors.Control;
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.HoverState.BorderColor = System.Drawing.Color.Cornsilk;
            this.Exit.HoverState.FillColor = System.Drawing.Color.Cornsilk;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.ImageSize = new System.Drawing.Size(40, 40);
            this.Exit.Location = new System.Drawing.Point(1156, 9);
            this.Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit.Name = "Exit";
            this.Exit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Exit.Size = new System.Drawing.Size(45, 63);
            this.Exit.TabIndex = 9;
            this.Exit.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ProfileImage
            // 
            this.ProfileImage.Image = ((System.Drawing.Image)(resources.GetObject("ProfileImage.Image")));
            this.ProfileImage.Location = new System.Drawing.Point(1035, 15);
            this.ProfileImage.Margin = new System.Windows.Forms.Padding(0);
            this.ProfileImage.Name = "ProfileImage";
            this.ProfileImage.Size = new System.Drawing.Size(51, 50);
            this.ProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfileImage.TabIndex = 5;
            this.ProfileImage.TabStop = false;
            this.ProfileImage.Click += new System.EventHandler(this.ProfileImage_Click);
            // 
            // RKandCo
            // 
            this.RKandCo.AutoSize = true;
            this.RKandCo.Font = new System.Drawing.Font("Gill Sans MT Condensed", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RKandCo.Location = new System.Drawing.Point(88, 42);
            this.RKandCo.Name = "RKandCo";
            this.RKandCo.Size = new System.Drawing.Size(171, 23);
            this.RKandCo.TabIndex = 2;
            this.RKandCo.Text = "Ramakrishanaiah and Company";
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.Location = new System.Drawing.Point(85, 15);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(342, 27);
            this.Heading.TabIndex = 4;
            this.Heading.Text = "Terminal Management Software";
            // 
            // Logo2
            // 
            this.Logo2.Image = ((System.Drawing.Image)(resources.GetObject("Logo2.Image")));
            this.Logo2.Location = new System.Drawing.Point(12, 10);
            this.Logo2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Logo2.Name = "Logo2";
            this.Logo2.Size = new System.Drawing.Size(67, 64);
            this.Logo2.TabIndex = 3;
            this.Logo2.TabStop = false;
            // 
            // RKLogo1
            // 
            this.RKLogo1.Image = ((System.Drawing.Image)(resources.GetObject("RKLogo1.Image")));
            this.RKLogo1.Location = new System.Drawing.Point(609, 10);
            this.RKLogo1.Margin = new System.Windows.Forms.Padding(0);
            this.RKLogo1.Name = "RKLogo1";
            this.RKLogo1.Size = new System.Drawing.Size(65, 62);
            this.RKLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RKLogo1.TabIndex = 2;
            this.RKLogo1.TabStop = false;
            // 
            // dashboard
            // 
            this.dashboard.Controls.Add(this.SearchBox);
            this.dashboard.Controls.Add(this.Settings);
            this.dashboard.Controls.Add(this.Salary);
            this.dashboard.Controls.Add(this.ShiftHistory);
            this.dashboard.Controls.Add(this.Shift);
            this.dashboard.Controls.Add(this.Calendar);
            this.dashboard.Controls.Add(this.HomePage);
            this.dashboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.dashboard.Location = new System.Drawing.Point(0, 85);
            this.dashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(236, 626);
            this.dashboard.TabIndex = 4;
            // 
            // SearchBox
            // 
            this.SearchBox.BorderRadius = 18;
            this.SearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchBox.DefaultText = "";
            this.SearchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("SearchBox.IconLeft")));
            this.SearchBox.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.SearchBox.IconLeftSize = new System.Drawing.Size(30, 30);
            this.SearchBox.Location = new System.Drawing.Point(12, 28);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PasswordChar = '\0';
            this.SearchBox.PlaceholderText = "Search Here";
            this.SearchBox.SelectedText = "";
            this.SearchBox.Size = new System.Drawing.Size(207, 48);
            this.SearchBox.TabIndex = 7;
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Settings.BorderRadius = 10;
            this.Settings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Settings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Settings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Settings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Settings.FillColor = System.Drawing.SystemColors.Control;
            this.Settings.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.ForeColor = System.Drawing.Color.Gray;
            this.Settings.HoverState.BorderColor = System.Drawing.Color.Cornsilk;
            this.Settings.HoverState.FillColor = System.Drawing.Color.Cornsilk;
            this.Settings.Image = ((System.Drawing.Image)(resources.GetObject("Settings.Image")));
            this.Settings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Settings.ImageOffset = new System.Drawing.Point(5, 0);
            this.Settings.ImageSize = new System.Drawing.Size(30, 30);
            this.Settings.Location = new System.Drawing.Point(3, 436);
            this.Settings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(229, 65);
            this.Settings.TabIndex = 3;
            this.Settings.Text = "Settings";
            this.Settings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Settings.TextOffset = new System.Drawing.Point(10, 0);
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Salary
            // 
            this.Salary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Salary.BorderRadius = 10;
            this.Salary.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Salary.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Salary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Salary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Salary.FillColor = System.Drawing.SystemColors.Control;
            this.Salary.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salary.ForeColor = System.Drawing.Color.Gray;
            this.Salary.HoverState.BorderColor = System.Drawing.Color.Cornsilk;
            this.Salary.HoverState.FillColor = System.Drawing.Color.Cornsilk;
            this.Salary.Image = ((System.Drawing.Image)(resources.GetObject("Salary.Image")));
            this.Salary.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Salary.ImageOffset = new System.Drawing.Point(5, 0);
            this.Salary.ImageSize = new System.Drawing.Size(30, 30);
            this.Salary.Location = new System.Drawing.Point(3, 366);
            this.Salary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(229, 65);
            this.Salary.TabIndex = 6;
            this.Salary.Text = "Salary";
            this.Salary.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Salary.TextOffset = new System.Drawing.Point(10, 0);
            this.Salary.Click += new System.EventHandler(this.Salary_Click);
            // 
            // ShiftHistory
            // 
            this.ShiftHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ShiftHistory.BorderRadius = 10;
            this.ShiftHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ShiftHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ShiftHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ShiftHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ShiftHistory.FillColor = System.Drawing.SystemColors.Control;
            this.ShiftHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShiftHistory.ForeColor = System.Drawing.Color.Gray;
            this.ShiftHistory.HoverState.BorderColor = System.Drawing.Color.Cornsilk;
            this.ShiftHistory.HoverState.FillColor = System.Drawing.Color.Cornsilk;
            this.ShiftHistory.Image = ((System.Drawing.Image)(resources.GetObject("ShiftHistory.Image")));
            this.ShiftHistory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ShiftHistory.ImageOffset = new System.Drawing.Point(5, 0);
            this.ShiftHistory.ImageSize = new System.Drawing.Size(30, 30);
            this.ShiftHistory.Location = new System.Drawing.Point(3, 294);
            this.ShiftHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShiftHistory.Name = "ShiftHistory";
            this.ShiftHistory.Size = new System.Drawing.Size(229, 65);
            this.ShiftHistory.TabIndex = 5;
            this.ShiftHistory.Text = "Shift History";
            this.ShiftHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ShiftHistory.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // Shift
            // 
            this.Shift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Shift.BorderRadius = 10;
            this.Shift.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Shift.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Shift.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Shift.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Shift.FillColor = System.Drawing.SystemColors.Control;
            this.Shift.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shift.ForeColor = System.Drawing.Color.Gray;
            this.Shift.HoverState.BorderColor = System.Drawing.Color.Cornsilk;
            this.Shift.HoverState.FillColor = System.Drawing.Color.Cornsilk;
            this.Shift.Image = ((System.Drawing.Image)(resources.GetObject("Shift.Image")));
            this.Shift.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Shift.ImageOffset = new System.Drawing.Point(5, 0);
            this.Shift.ImageSize = new System.Drawing.Size(30, 30);
            this.Shift.Location = new System.Drawing.Point(3, 224);
            this.Shift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Shift.Name = "Shift";
            this.Shift.Size = new System.Drawing.Size(229, 65);
            this.Shift.TabIndex = 4;
            this.Shift.Text = "Shift";
            this.Shift.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Shift.TextOffset = new System.Drawing.Point(10, 0);
            this.Shift.Click += new System.EventHandler(this.Shift_Click);
            // 
            // Calendar
            // 
            this.Calendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Calendar.BorderRadius = 10;
            this.Calendar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Calendar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Calendar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Calendar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Calendar.FillColor = System.Drawing.SystemColors.Control;
            this.Calendar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendar.ForeColor = System.Drawing.Color.Gray;
            this.Calendar.HoverState.BorderColor = System.Drawing.Color.Cornsilk;
            this.Calendar.HoverState.FillColor = System.Drawing.Color.Cornsilk;
            this.Calendar.Image = ((System.Drawing.Image)(resources.GetObject("Calendar.Image")));
            this.Calendar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Calendar.ImageOffset = new System.Drawing.Point(5, 0);
            this.Calendar.ImageSize = new System.Drawing.Size(30, 30);
            this.Calendar.Location = new System.Drawing.Point(3, 153);
            this.Calendar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Calendar.Name = "Calendar";
            this.Calendar.Size = new System.Drawing.Size(229, 65);
            this.Calendar.TabIndex = 3;
            this.Calendar.Text = "Calender";
            this.Calendar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Calendar.TextOffset = new System.Drawing.Point(10, 0);
            this.Calendar.Click += new System.EventHandler(this.Calendar_Click);
            // 
            // HomePage
            // 
            this.HomePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.HomePage.BorderRadius = 10;
            this.HomePage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HomePage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HomePage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HomePage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.HomePage.FillColor = System.Drawing.SystemColors.Control;
            this.HomePage.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomePage.ForeColor = System.Drawing.Color.Gray;
            this.HomePage.HoverState.BorderColor = System.Drawing.Color.Cornsilk;
            this.HomePage.HoverState.FillColor = System.Drawing.Color.Cornsilk;
            this.HomePage.Image = ((System.Drawing.Image)(resources.GetObject("HomePage.Image")));
            this.HomePage.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HomePage.ImageOffset = new System.Drawing.Point(5, 0);
            this.HomePage.ImageSize = new System.Drawing.Size(30, 30);
            this.HomePage.Location = new System.Drawing.Point(3, 82);
            this.HomePage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HomePage.Name = "HomePage";
            this.HomePage.Size = new System.Drawing.Size(229, 65);
            this.HomePage.TabIndex = 2;
            this.HomePage.Text = "Home Page";
            this.HomePage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HomePage.TextOffset = new System.Drawing.Point(10, 0);
            this.HomePage.Click += new System.EventHandler(this.HomePage_Click);
            // 
            // footer
            // 
            this.footer.Controls.Add(this.label2);
            this.footer.Controls.Add(this.label1);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(236, 664);
            this.footer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(991, 47);
            this.footer.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "CC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(668, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ramakrishanaiah and Company 2022";
            // 
            // CalenderPanel
            // 
            this.CalenderPanel.Controls.Add(this.Previous);
            this.CalenderPanel.Controls.Add(this.Next);
            this.CalenderPanel.Controls.Add(this.label10);
            this.CalenderPanel.Controls.Add(this.label9);
            this.CalenderPanel.Controls.Add(this.label8);
            this.CalenderPanel.Controls.Add(this.label7);
            this.CalenderPanel.Controls.Add(this.label6);
            this.CalenderPanel.Controls.Add(this.label5);
            this.CalenderPanel.Controls.Add(this.label4);
            this.CalenderPanel.Controls.Add(this.datelb);
            this.CalenderPanel.Controls.Add(this.daycontainer);
            this.CalenderPanel.Controls.Add(this.ScheduleEvent);
            this.CalenderPanel.Location = new System.Drawing.Point(243, 100);
            this.CalenderPanel.Name = "CalenderPanel";
            this.CalenderPanel.Size = new System.Drawing.Size(984, 550);
            this.CalenderPanel.TabIndex = 7;
            // 
            // Previous
            // 
            this.Previous.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Previous.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Previous.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Previous.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Previous.FillColor = System.Drawing.Color.LightGray;
            this.Previous.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Previous.ForeColor = System.Drawing.Color.Black;
            this.Previous.Location = new System.Drawing.Point(546, 501);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(109, 24);
            this.Previous.TabIndex = 21;
            this.Previous.Text = "Previous";
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // Next
            // 
            this.Next.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Next.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Next.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Next.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Next.FillColor = System.Drawing.Color.LightGray;
            this.Next.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.ForeColor = System.Drawing.Color.Black;
            this.Next.Location = new System.Drawing.Point(661, 501);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(109, 24);
            this.Next.TabIndex = 20;
            this.Next.Text = "Next";
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(673, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 18);
            this.label10.TabIndex = 19;
            this.label10.Text = "Saturday";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(577, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Friday";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(473, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Thursday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(367, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Wednesday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(278, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tuesday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(176, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Monday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sunday";
            // 
            // datelb
            // 
            this.datelb.AutoSize = true;
            this.datelb.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelb.Location = new System.Drawing.Point(340, 22);
            this.datelb.Name = "datelb";
            this.datelb.Size = new System.Drawing.Size(128, 24);
            this.datelb.TabIndex = 12;
            this.datelb.Text = "Month YEAR";
            this.datelb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // daycontainer
            // 
            this.daycontainer.Location = new System.Drawing.Point(58, 86);
            this.daycontainer.Name = "daycontainer";
            this.daycontainer.Size = new System.Drawing.Size(712, 409);
            this.daycontainer.TabIndex = 11;
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
            this.ScheduleEvent.Location = new System.Drawing.Point(796, 183);
            this.ScheduleEvent.Name = "ScheduleEvent";
            this.ScheduleEvent.Size = new System.Drawing.Size(160, 46);
            this.ScheduleEvent.TabIndex = 10;
            this.ScheduleEvent.Text = "Schedule Event";
            this.ScheduleEvent.Click += new System.EventHandler(this.ScheduleEvent_Click);
            // 
            // CashierCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 711);
            this.Controls.Add(this.CalenderPanel);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.dashboard);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CashierCalendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashierCalendar";
            this.Load += new System.EventHandler(this.CashierCalendar_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RKLogo1)).EndInit();
            this.dashboard.ResumeLayout(false);
            this.footer.ResumeLayout(false);
            this.footer.PerformLayout();
            this.CalenderPanel.ResumeLayout(false);
            this.CalenderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private Guna.UI2.WinForms.Guna2CircleButton Minimise;
        private Guna.UI2.WinForms.Guna2CircleButton Exit;
        private System.Windows.Forms.PictureBox ProfileImage;
        private System.Windows.Forms.Label RKandCo;
        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.PictureBox Logo2;
        private System.Windows.Forms.PictureBox RKLogo1;
        private System.Windows.Forms.Panel dashboard;
        private Guna.UI2.WinForms.Guna2TextBox SearchBox;
        private Guna.UI2.WinForms.Guna2Button Settings;
        private Guna.UI2.WinForms.Guna2Button Salary;
        private Guna.UI2.WinForms.Guna2Button ShiftHistory;
        private Guna.UI2.WinForms.Guna2Button Shift;
        private Guna.UI2.WinForms.Guna2Button Calendar;
        private Guna.UI2.WinForms.Guna2Button HomePage;
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel CalenderPanel;
        private Guna.UI2.WinForms.Guna2TileButton Previous;
        private Guna.UI2.WinForms.Guna2TileButton Next;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label datelb;
        private System.Windows.Forms.FlowLayoutPanel daycontainer;
        private Guna.UI2.WinForms.Guna2TileButton ScheduleEvent;
    }
}