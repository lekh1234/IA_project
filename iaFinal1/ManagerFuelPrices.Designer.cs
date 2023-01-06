namespace iaFinal1
{
    partial class ManagerFuelPrices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerFuelPrices));
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
            this.StaffDetails = new Guna.UI2.WinForms.Guna2Button();
            this.FuelPrices = new Guna.UI2.WinForms.Guna2Button();
            this.CashieronDuty = new Guna.UI2.WinForms.Guna2Button();
            this.Calendar = new Guna.UI2.WinForms.Guna2Button();
            this.HomePage = new Guna.UI2.WinForms.Guna2Button();
            this.footer = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SavePrices = new Guna.UI2.WinForms.Guna2TileButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PricesDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RKLogo1)).BeginInit();
            this.dashboard.SuspendLayout();
            this.footer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.dashboard.Controls.Add(this.StaffDetails);
            this.dashboard.Controls.Add(this.FuelPrices);
            this.dashboard.Controls.Add(this.CashieronDuty);
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
            // StaffDetails
            // 
            this.StaffDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.StaffDetails.BorderRadius = 10;
            this.StaffDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StaffDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StaffDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StaffDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StaffDetails.FillColor = System.Drawing.SystemColors.Control;
            this.StaffDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffDetails.ForeColor = System.Drawing.Color.Gray;
            this.StaffDetails.HoverState.BorderColor = System.Drawing.Color.Cornsilk;
            this.StaffDetails.HoverState.FillColor = System.Drawing.Color.Cornsilk;
            this.StaffDetails.Image = ((System.Drawing.Image)(resources.GetObject("StaffDetails.Image")));
            this.StaffDetails.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.StaffDetails.ImageOffset = new System.Drawing.Point(5, 0);
            this.StaffDetails.ImageSize = new System.Drawing.Size(30, 30);
            this.StaffDetails.Location = new System.Drawing.Point(3, 366);
            this.StaffDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StaffDetails.Name = "StaffDetails";
            this.StaffDetails.Size = new System.Drawing.Size(229, 65);
            this.StaffDetails.TabIndex = 6;
            this.StaffDetails.Text = "Staff Details";
            this.StaffDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.StaffDetails.TextOffset = new System.Drawing.Point(10, 0);
            this.StaffDetails.Click += new System.EventHandler(this.StaffDetails_Click);
            // 
            // FuelPrices
            // 
            this.FuelPrices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.FuelPrices.BorderRadius = 10;
            this.FuelPrices.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FuelPrices.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FuelPrices.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FuelPrices.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FuelPrices.FillColor = System.Drawing.SystemColors.Control;
            this.FuelPrices.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuelPrices.ForeColor = System.Drawing.Color.Gray;
            this.FuelPrices.HoverState.BorderColor = System.Drawing.Color.Cornsilk;
            this.FuelPrices.HoverState.FillColor = System.Drawing.Color.Cornsilk;
            this.FuelPrices.Image = ((System.Drawing.Image)(resources.GetObject("FuelPrices.Image")));
            this.FuelPrices.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FuelPrices.ImageOffset = new System.Drawing.Point(5, 0);
            this.FuelPrices.ImageSize = new System.Drawing.Size(30, 30);
            this.FuelPrices.Location = new System.Drawing.Point(3, 294);
            this.FuelPrices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FuelPrices.Name = "FuelPrices";
            this.FuelPrices.Size = new System.Drawing.Size(229, 65);
            this.FuelPrices.TabIndex = 5;
            this.FuelPrices.Text = "Fuel Prices";
            this.FuelPrices.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FuelPrices.TextOffset = new System.Drawing.Point(10, 0);
            this.FuelPrices.Click += new System.EventHandler(this.FuelPrices_Click);
            // 
            // CashieronDuty
            // 
            this.CashieronDuty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.CashieronDuty.BorderRadius = 10;
            this.CashieronDuty.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CashieronDuty.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CashieronDuty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CashieronDuty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CashieronDuty.FillColor = System.Drawing.SystemColors.Control;
            this.CashieronDuty.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashieronDuty.ForeColor = System.Drawing.Color.Gray;
            this.CashieronDuty.HoverState.BorderColor = System.Drawing.Color.Cornsilk;
            this.CashieronDuty.HoverState.FillColor = System.Drawing.Color.Cornsilk;
            this.CashieronDuty.Image = ((System.Drawing.Image)(resources.GetObject("CashieronDuty.Image")));
            this.CashieronDuty.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CashieronDuty.ImageOffset = new System.Drawing.Point(5, 0);
            this.CashieronDuty.ImageSize = new System.Drawing.Size(30, 30);
            this.CashieronDuty.Location = new System.Drawing.Point(3, 224);
            this.CashieronDuty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CashieronDuty.Name = "CashieronDuty";
            this.CashieronDuty.Size = new System.Drawing.Size(229, 65);
            this.CashieronDuty.TabIndex = 4;
            this.CashieronDuty.Text = "Cashier on Duty";
            this.CashieronDuty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CashieronDuty.TextOffset = new System.Drawing.Point(10, 0);
            this.CashieronDuty.Click += new System.EventHandler(this.CashieronDuty_Click);
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
            this.label2.Location = new System.Drawing.Point(32, 9);
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
            this.label1.Location = new System.Drawing.Point(636, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ramakrishanaiah and Company 2022";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.SavePrices);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.PricesDate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(276, 158);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 428);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(163, 270);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(113, 22);
            this.textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 210);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 22);
            this.textBox1.TabIndex = 12;
            // 
            // SavePrices
            // 
            this.SavePrices.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SavePrices.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SavePrices.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SavePrices.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SavePrices.FillColor = System.Drawing.Color.LightGray;
            this.SavePrices.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavePrices.ForeColor = System.Drawing.Color.Black;
            this.SavePrices.Location = new System.Drawing.Point(115, 322);
            this.SavePrices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SavePrices.Name = "SavePrices";
            this.SavePrices.Size = new System.Drawing.Size(160, 46);
            this.SavePrices.TabIndex = 11;
            this.SavePrices.Text = "Save ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Petrol Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Diesel Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Select date";
            // 
            // PricesDate
            // 
            this.PricesDate.Location = new System.Drawing.Point(161, 135);
            this.PricesDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PricesDate.Name = "PricesDate";
            this.PricesDate.Size = new System.Drawing.Size(213, 22);
            this.PricesDate.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enter Fuel Price";
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(725, 222);
            this.cartesianChart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(464, 293);
            this.cartesianChart1.TabIndex = 8;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(747, 535);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(435, 75);
            this.dataGridView1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(720, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 31);
            this.label3.TabIndex = 14;
            this.label3.Text = "Fuel Price Trend";
            // 
            // ManagerFuelPrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 711);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.dashboard);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManagerFuelPrices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerFuelPrices";
            this.Load += new System.EventHandler(this.ManagerFuelPrices_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RKLogo1)).EndInit();
            this.dashboard.ResumeLayout(false);
            this.footer.ResumeLayout(false);
            this.footer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Guna.UI2.WinForms.Guna2Button StaffDetails;
        private Guna.UI2.WinForms.Guna2Button FuelPrices;
        private Guna.UI2.WinForms.Guna2Button CashieronDuty;
        private Guna.UI2.WinForms.Guna2Button Calendar;
        private Guna.UI2.WinForms.Guna2Button HomePage;
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private Guna.UI2.WinForms.Guna2TileButton SavePrices;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker PricesDate;
        private System.Windows.Forms.Label label4;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
    }
}