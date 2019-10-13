namespace MoviesAndMusicRenting
{
    partial class Form1
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
            this.tab_rentingItems = new MetroFramework.Controls.MetroTabPage();
            this.DeleteMovie = new MetroFramework.Controls.MetroButton();
            this.MovieModify = new System.Windows.Forms.RadioButton();
            this.MovieAdd = new System.Windows.Forms.RadioButton();
            this.Add_ModifyMovie = new MetroFramework.Controls.MetroButton();
            this.MovieGenreField = new MetroFramework.Controls.MetroComboBox();
            this.MovieRentingCostField = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.MovieCopiesField = new System.Windows.Forms.NumericUpDown();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.MovieRatingsField = new System.Windows.Forms.NumericUpDown();
            this.MovieRelease = new MetroFramework.Controls.MetroDateTime();
            this.MovieTitleField = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.MovieID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieRatings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieCopies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieRatingCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_customers = new MetroFramework.Controls.MetroTabPage();
            this.CustomerPhone = new MetroFramework.Controls.MetroTextBox();
            this.DeleteCustomer = new MetroFramework.Controls.MetroButton();
            this.modifyCustomer = new System.Windows.Forms.RadioButton();
            this.addNewCustomer = new System.Windows.Forms.RadioButton();
            this.AddCustomer = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerAddress = new MetroFramework.Controls.MetroTextBox();
            this.CustomerLastName = new MetroFramework.Controls.MetroTextBox();
            this.CustomerFirstName = new MetroFramework.Controls.MetroTextBox();
            this.CustomerUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tab_rentedItems = new MetroFramework.Controls.MetroTabPage();
            this.rentingPeriodEnd = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.rentingPeriodStart = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.ReturnMovie = new MetroFramework.Controls.MetroButton();
            this.IssueMovie = new MetroFramework.Controls.MetroButton();
            this.label3 = new System.Windows.Forms.Label();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.RentalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentTill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DragPanel = new MetroFramework.Controls.MetroPanel();
            this.ExitApplication = new System.Windows.Forms.Button();
            this.tab_rentingItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MovieCopiesField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovieRatingsField)).BeginInit();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tab_customers.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.tab_rentedItems.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.DragPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_rentingItems
            // 
            this.tab_rentingItems.Controls.Add(this.DeleteMovie);
            this.tab_rentingItems.Controls.Add(this.MovieModify);
            this.tab_rentingItems.Controls.Add(this.MovieAdd);
            this.tab_rentingItems.Controls.Add(this.Add_ModifyMovie);
            this.tab_rentingItems.Controls.Add(this.MovieGenreField);
            this.tab_rentingItems.Controls.Add(this.MovieRentingCostField);
            this.tab_rentingItems.Controls.Add(this.metroLabel3);
            this.tab_rentingItems.Controls.Add(this.MovieCopiesField);
            this.tab_rentingItems.Controls.Add(this.metroLabel2);
            this.tab_rentingItems.Controls.Add(this.metroLabel1);
            this.tab_rentingItems.Controls.Add(this.MovieRatingsField);
            this.tab_rentingItems.Controls.Add(this.MovieRelease);
            this.tab_rentingItems.Controls.Add(this.MovieTitleField);
            this.tab_rentingItems.Controls.Add(this.label2);
            this.tab_rentingItems.Controls.Add(this.metroPanel3);
            this.tab_rentingItems.HorizontalScrollbarBarColor = true;
            this.tab_rentingItems.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_rentingItems.HorizontalScrollbarSize = 10;
            this.tab_rentingItems.Location = new System.Drawing.Point(4, 38);
            this.tab_rentingItems.Name = "tab_rentingItems";
            this.tab_rentingItems.Size = new System.Drawing.Size(1272, 653);
            this.tab_rentingItems.TabIndex = 3;
            this.tab_rentingItems.Text = "Movies / Music";
            this.tab_rentingItems.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tab_rentingItems.VerticalScrollbarBarColor = true;
            this.tab_rentingItems.VerticalScrollbarHighlightOnWheel = false;
            this.tab_rentingItems.VerticalScrollbarSize = 10;
            // 
            // DeleteMovie
            // 
            this.DeleteMovie.Enabled = false;
            this.DeleteMovie.Location = new System.Drawing.Point(1129, 620);
            this.DeleteMovie.Name = "DeleteMovie";
            this.DeleteMovie.Size = new System.Drawing.Size(147, 33);
            this.DeleteMovie.Style = MetroFramework.MetroColorStyle.Magenta;
            this.DeleteMovie.TabIndex = 22;
            this.DeleteMovie.Text = "Delete Movie";
            this.DeleteMovie.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DeleteMovie.UseSelectable = true;
            this.DeleteMovie.UseStyleColors = true;
            this.DeleteMovie.Click += new System.EventHandler(this.DeleteMovie_Click);
            // 
            // MovieModify
            // 
            this.MovieModify.AutoSize = true;
            this.MovieModify.BackColor = System.Drawing.Color.Black;
            this.MovieModify.ForeColor = System.Drawing.Color.White;
            this.MovieModify.Location = new System.Drawing.Point(1184, 339);
            this.MovieModify.Name = "MovieModify";
            this.MovieModify.Size = new System.Drawing.Size(88, 17);
            this.MovieModify.TabIndex = 21;
            this.MovieModify.TabStop = true;
            this.MovieModify.Text = "Modify Movie";
            this.MovieModify.UseVisualStyleBackColor = false;
            this.MovieModify.CheckedChanged += new System.EventHandler(this.MovieModify_CheckedChanged);
            // 
            // MovieAdd
            // 
            this.MovieAdd.AutoSize = true;
            this.MovieAdd.BackColor = System.Drawing.Color.Black;
            this.MovieAdd.ForeColor = System.Drawing.Color.White;
            this.MovieAdd.Location = new System.Drawing.Point(941, 340);
            this.MovieAdd.Name = "MovieAdd";
            this.MovieAdd.Size = new System.Drawing.Size(101, 17);
            this.MovieAdd.TabIndex = 20;
            this.MovieAdd.TabStop = true;
            this.MovieAdd.Text = "Add New Movie";
            this.MovieAdd.UseVisualStyleBackColor = false;
            this.MovieAdd.CheckedChanged += new System.EventHandler(this.MovieAdd_CheckedChanged);
            // 
            // Add_ModifyMovie
            // 
            this.Add_ModifyMovie.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Add_ModifyMovie.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Add_ModifyMovie.Location = new System.Drawing.Point(941, 363);
            this.Add_ModifyMovie.Name = "Add_ModifyMovie";
            this.Add_ModifyMovie.Size = new System.Drawing.Size(330, 48);
            this.Add_ModifyMovie.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Add_ModifyMovie.TabIndex = 19;
            this.Add_ModifyMovie.Text = "Add Movie";
            this.Add_ModifyMovie.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Add_ModifyMovie.UseSelectable = true;
            this.Add_ModifyMovie.UseStyleColors = true;
            this.Add_ModifyMovie.Click += new System.EventHandler(this.Add_ModifyMovie_Click);
            // 
            // MovieGenreField
            // 
            this.MovieGenreField.FormattingEnabled = true;
            this.MovieGenreField.ItemHeight = 23;
            this.MovieGenreField.Location = new System.Drawing.Point(942, 304);
            this.MovieGenreField.Name = "MovieGenreField";
            this.MovieGenreField.Size = new System.Drawing.Size(330, 29);
            this.MovieGenreField.TabIndex = 18;
            this.MovieGenreField.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MovieGenreField.UseSelectable = true;
            // 
            // MovieRentingCostField
            // 
            // 
            // 
            // 
            this.MovieRentingCostField.CustomButton.Image = null;
            this.MovieRentingCostField.CustomButton.Location = new System.Drawing.Point(309, 1);
            this.MovieRentingCostField.CustomButton.Name = "";
            this.MovieRentingCostField.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.MovieRentingCostField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MovieRentingCostField.CustomButton.TabIndex = 1;
            this.MovieRentingCostField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MovieRentingCostField.CustomButton.UseSelectable = true;
            this.MovieRentingCostField.CustomButton.Visible = false;
            this.MovieRentingCostField.Lines = new string[0];
            this.MovieRentingCostField.Location = new System.Drawing.Point(941, 274);
            this.MovieRentingCostField.MaxLength = 32767;
            this.MovieRentingCostField.Name = "MovieRentingCostField";
            this.MovieRentingCostField.PasswordChar = '\0';
            this.MovieRentingCostField.PromptText = "Renting Cost";
            this.MovieRentingCostField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MovieRentingCostField.SelectedText = "";
            this.MovieRentingCostField.SelectionLength = 0;
            this.MovieRentingCostField.SelectionStart = 0;
            this.MovieRentingCostField.ShortcutsEnabled = true;
            this.MovieRentingCostField.Size = new System.Drawing.Size(331, 23);
            this.MovieRentingCostField.TabIndex = 17;
            this.MovieRentingCostField.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MovieRentingCostField.UseSelectable = true;
            this.MovieRentingCostField.WaterMark = "Renting Cost";
            this.MovieRentingCostField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MovieRentingCostField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Black;
            this.metroLabel3.ForeColor = System.Drawing.Color.White;
            this.metroLabel3.Location = new System.Drawing.Point(1112, 225);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(49, 19);
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "Copies";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // MovieCopiesField
            // 
            this.MovieCopiesField.BackColor = System.Drawing.Color.Black;
            this.MovieCopiesField.ForeColor = System.Drawing.Color.White;
            this.MovieCopiesField.Location = new System.Drawing.Point(1112, 247);
            this.MovieCopiesField.Name = "MovieCopiesField";
            this.MovieCopiesField.Size = new System.Drawing.Size(160, 20);
            this.MovieCopiesField.TabIndex = 15;
            this.MovieCopiesField.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Black;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(942, 225);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Ratings";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Black;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(941, 167);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 19);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Release Date";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // MovieRatingsField
            // 
            this.MovieRatingsField.BackColor = System.Drawing.Color.Black;
            this.MovieRatingsField.DecimalPlaces = 1;
            this.MovieRatingsField.ForeColor = System.Drawing.Color.White;
            this.MovieRatingsField.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.MovieRatingsField.Location = new System.Drawing.Point(941, 247);
            this.MovieRatingsField.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.MovieRatingsField.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.MovieRatingsField.Name = "MovieRatingsField";
            this.MovieRatingsField.Size = new System.Drawing.Size(164, 20);
            this.MovieRatingsField.TabIndex = 12;
            this.MovieRatingsField.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // MovieRelease
            // 
            this.MovieRelease.Location = new System.Drawing.Point(941, 189);
            this.MovieRelease.MinimumSize = new System.Drawing.Size(0, 29);
            this.MovieRelease.Name = "MovieRelease";
            this.MovieRelease.Size = new System.Drawing.Size(331, 29);
            this.MovieRelease.TabIndex = 11;
            this.MovieRelease.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // MovieTitleField
            // 
            // 
            // 
            // 
            this.MovieTitleField.CustomButton.Image = null;
            this.MovieTitleField.CustomButton.Location = new System.Drawing.Point(309, 1);
            this.MovieTitleField.CustomButton.Name = "";
            this.MovieTitleField.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.MovieTitleField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MovieTitleField.CustomButton.TabIndex = 1;
            this.MovieTitleField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MovieTitleField.CustomButton.UseSelectable = true;
            this.MovieTitleField.CustomButton.Visible = false;
            this.MovieTitleField.Lines = new string[0];
            this.MovieTitleField.Location = new System.Drawing.Point(941, 137);
            this.MovieTitleField.MaxLength = 32767;
            this.MovieTitleField.Name = "MovieTitleField";
            this.MovieTitleField.PasswordChar = '\0';
            this.MovieTitleField.PromptText = "Movie Title";
            this.MovieTitleField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MovieTitleField.SelectedText = "";
            this.MovieTitleField.SelectionLength = 0;
            this.MovieTitleField.SelectionStart = 0;
            this.MovieTitleField.ShortcutsEnabled = true;
            this.MovieTitleField.Size = new System.Drawing.Size(331, 23);
            this.MovieTitleField.TabIndex = 10;
            this.MovieTitleField.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MovieTitleField.UseSelectable = true;
            this.MovieTitleField.WaterMark = "Movie Title";
            this.MovieTitleField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MovieTitleField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(941, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "Movie";
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.dataGridView3);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(0, 3);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(935, 650);
            this.metroPanel3.TabIndex = 3;
            this.metroPanel3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MovieID,
            this.MovieTitle,
            this.MovieReleaseDate,
            this.MovieRatings,
            this.MovieCopies,
            this.MovieRatingCost,
            this.MovieGenre});
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(935, 650);
            this.dataGridView3.TabIndex = 2;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView3_CellClick);
            // 
            // MovieID
            // 
            this.MovieID.DataPropertyName = "MovieID";
            this.MovieID.HeaderText = "Movie ID";
            this.MovieID.Name = "MovieID";
            this.MovieID.ReadOnly = true;
            this.MovieID.Width = 75;
            // 
            // MovieTitle
            // 
            this.MovieTitle.DataPropertyName = "MovieTitle";
            this.MovieTitle.HeaderText = "Movie Title";
            this.MovieTitle.Name = "MovieTitle";
            this.MovieTitle.ReadOnly = true;
            this.MovieTitle.Width = 265;
            // 
            // MovieReleaseDate
            // 
            this.MovieReleaseDate.DataPropertyName = "MovieReleaseDate";
            this.MovieReleaseDate.HeaderText = "Release Date";
            this.MovieReleaseDate.Name = "MovieReleaseDate";
            this.MovieReleaseDate.ReadOnly = true;
            this.MovieReleaseDate.Width = 150;
            // 
            // MovieRatings
            // 
            this.MovieRatings.DataPropertyName = "MovieRatings";
            this.MovieRatings.HeaderText = "Ratings";
            this.MovieRatings.Name = "MovieRatings";
            this.MovieRatings.ReadOnly = true;
            // 
            // MovieCopies
            // 
            this.MovieCopies.DataPropertyName = "MovieCopies";
            this.MovieCopies.HeaderText = "Copies";
            this.MovieCopies.Name = "MovieCopies";
            this.MovieCopies.ReadOnly = true;
            this.MovieCopies.Width = 75;
            // 
            // MovieRatingCost
            // 
            this.MovieRatingCost.DataPropertyName = "MovieRatingCost";
            this.MovieRatingCost.HeaderText = "Renting Cost";
            this.MovieRatingCost.Name = "MovieRatingCost";
            this.MovieRatingCost.ReadOnly = true;
            // 
            // MovieGenre
            // 
            this.MovieGenre.DataPropertyName = "MovieGenre";
            this.MovieGenre.HeaderText = "Genre";
            this.MovieGenre.Name = "MovieGenre";
            this.MovieGenre.ReadOnly = true;
            this.MovieGenre.Width = 125;
            // 
            // tab_customers
            // 
            this.tab_customers.Controls.Add(this.CustomerPhone);
            this.tab_customers.Controls.Add(this.DeleteCustomer);
            this.tab_customers.Controls.Add(this.modifyCustomer);
            this.tab_customers.Controls.Add(this.addNewCustomer);
            this.tab_customers.Controls.Add(this.AddCustomer);
            this.tab_customers.Controls.Add(this.label1);
            this.tab_customers.Controls.Add(this.CustomerAddress);
            this.tab_customers.Controls.Add(this.CustomerLastName);
            this.tab_customers.Controls.Add(this.CustomerFirstName);
            this.tab_customers.Controls.Add(this.CustomerUsername);
            this.tab_customers.Controls.Add(this.metroPanel1);
            this.tab_customers.HorizontalScrollbarBarColor = true;
            this.tab_customers.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_customers.HorizontalScrollbarSize = 10;
            this.tab_customers.Location = new System.Drawing.Point(4, 38);
            this.tab_customers.Name = "tab_customers";
            this.tab_customers.Size = new System.Drawing.Size(1272, 653);
            this.tab_customers.TabIndex = 2;
            this.tab_customers.Text = "Customers";
            this.tab_customers.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tab_customers.VerticalScrollbarBarColor = true;
            this.tab_customers.VerticalScrollbarHighlightOnWheel = false;
            this.tab_customers.VerticalScrollbarSize = 10;
            // 
            // CustomerPhone
            // 
            // 
            // 
            // 
            this.CustomerPhone.CustomButton.Image = null;
            this.CustomerPhone.CustomButton.Location = new System.Drawing.Point(305, 2);
            this.CustomerPhone.CustomButton.Name = "";
            this.CustomerPhone.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.CustomerPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CustomerPhone.CustomButton.TabIndex = 1;
            this.CustomerPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CustomerPhone.CustomButton.UseSelectable = true;
            this.CustomerPhone.CustomButton.Visible = false;
            this.CustomerPhone.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.CustomerPhone.Lines = new string[0];
            this.CustomerPhone.Location = new System.Drawing.Point(941, 273);
            this.CustomerPhone.MaxLength = 10;
            this.CustomerPhone.Name = "CustomerPhone";
            this.CustomerPhone.PasswordChar = '\0';
            this.CustomerPhone.PromptText = "Phone Number";
            this.CustomerPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CustomerPhone.SelectedText = "";
            this.CustomerPhone.SelectionLength = 0;
            this.CustomerPhone.SelectionStart = 0;
            this.CustomerPhone.ShortcutsEnabled = true;
            this.CustomerPhone.Size = new System.Drawing.Size(331, 28);
            this.CustomerPhone.TabIndex = 8;
            this.CustomerPhone.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CustomerPhone.UseSelectable = true;
            this.CustomerPhone.WaterMark = "Phone Number";
            this.CustomerPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CustomerPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // DeleteCustomer
            // 
            this.DeleteCustomer.Enabled = false;
            this.DeleteCustomer.Location = new System.Drawing.Point(1125, 620);
            this.DeleteCustomer.Name = "DeleteCustomer";
            this.DeleteCustomer.Size = new System.Drawing.Size(147, 33);
            this.DeleteCustomer.Style = MetroFramework.MetroColorStyle.Magenta;
            this.DeleteCustomer.TabIndex = 12;
            this.DeleteCustomer.Text = "Delete Customer";
            this.DeleteCustomer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DeleteCustomer.UseSelectable = true;
            this.DeleteCustomer.UseStyleColors = true;
            this.DeleteCustomer.Click += new System.EventHandler(this.DeleteCustomer_Click);
            // 
            // modifyCustomer
            // 
            this.modifyCustomer.AutoSize = true;
            this.modifyCustomer.BackColor = System.Drawing.Color.Black;
            this.modifyCustomer.ForeColor = System.Drawing.Color.White;
            this.modifyCustomer.Location = new System.Drawing.Point(1169, 306);
            this.modifyCustomer.Name = "modifyCustomer";
            this.modifyCustomer.Size = new System.Drawing.Size(103, 17);
            this.modifyCustomer.TabIndex = 10;
            this.modifyCustomer.TabStop = true;
            this.modifyCustomer.Text = "Modify Customer";
            this.modifyCustomer.UseVisualStyleBackColor = false;
            this.modifyCustomer.CheckedChanged += new System.EventHandler(this.ModifyCustomer_CheckedChanged);
            // 
            // addNewCustomer
            // 
            this.addNewCustomer.AutoSize = true;
            this.addNewCustomer.BackColor = System.Drawing.Color.Black;
            this.addNewCustomer.ForeColor = System.Drawing.Color.White;
            this.addNewCustomer.Location = new System.Drawing.Point(941, 307);
            this.addNewCustomer.Name = "addNewCustomer";
            this.addNewCustomer.Size = new System.Drawing.Size(116, 17);
            this.addNewCustomer.TabIndex = 9;
            this.addNewCustomer.TabStop = true;
            this.addNewCustomer.Text = "Add New Customer";
            this.addNewCustomer.UseVisualStyleBackColor = false;
            this.addNewCustomer.CheckedChanged += new System.EventHandler(this.AddNewCustomer_CheckedChanged);
            // 
            // AddCustomer
            // 
            this.AddCustomer.DisplayFocus = true;
            this.AddCustomer.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.AddCustomer.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.AddCustomer.ForeColor = System.Drawing.Color.White;
            this.AddCustomer.Location = new System.Drawing.Point(941, 329);
            this.AddCustomer.Name = "AddCustomer";
            this.AddCustomer.Size = new System.Drawing.Size(331, 47);
            this.AddCustomer.Style = MetroFramework.MetroColorStyle.Magenta;
            this.AddCustomer.TabIndex = 11;
            this.AddCustomer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AddCustomer.UseSelectable = true;
            this.AddCustomer.UseStyleColors = true;
            this.AddCustomer.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(941, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Customer";
            // 
            // CustomerAddress
            // 
            // 
            // 
            // 
            this.CustomerAddress.CustomButton.Image = null;
            this.CustomerAddress.CustomButton.Location = new System.Drawing.Point(305, 2);
            this.CustomerAddress.CustomButton.Name = "";
            this.CustomerAddress.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.CustomerAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CustomerAddress.CustomButton.TabIndex = 1;
            this.CustomerAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CustomerAddress.CustomButton.UseSelectable = true;
            this.CustomerAddress.CustomButton.Visible = false;
            this.CustomerAddress.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.CustomerAddress.Lines = new string[0];
            this.CustomerAddress.Location = new System.Drawing.Point(941, 239);
            this.CustomerAddress.MaxLength = 255;
            this.CustomerAddress.Name = "CustomerAddress";
            this.CustomerAddress.PasswordChar = '\0';
            this.CustomerAddress.PromptText = "Address";
            this.CustomerAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CustomerAddress.SelectedText = "";
            this.CustomerAddress.SelectionLength = 0;
            this.CustomerAddress.SelectionStart = 0;
            this.CustomerAddress.ShortcutsEnabled = true;
            this.CustomerAddress.Size = new System.Drawing.Size(331, 28);
            this.CustomerAddress.TabIndex = 7;
            this.CustomerAddress.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CustomerAddress.UseSelectable = true;
            this.CustomerAddress.WaterMark = "Address";
            this.CustomerAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CustomerAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // CustomerLastName
            // 
            // 
            // 
            // 
            this.CustomerLastName.CustomButton.Image = null;
            this.CustomerLastName.CustomButton.Location = new System.Drawing.Point(305, 2);
            this.CustomerLastName.CustomButton.Name = "";
            this.CustomerLastName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.CustomerLastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CustomerLastName.CustomButton.TabIndex = 1;
            this.CustomerLastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CustomerLastName.CustomButton.UseSelectable = true;
            this.CustomerLastName.CustomButton.Visible = false;
            this.CustomerLastName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.CustomerLastName.Lines = new string[0];
            this.CustomerLastName.Location = new System.Drawing.Point(941, 205);
            this.CustomerLastName.MaxLength = 32;
            this.CustomerLastName.Name = "CustomerLastName";
            this.CustomerLastName.PasswordChar = '\0';
            this.CustomerLastName.PromptText = "Last Name";
            this.CustomerLastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CustomerLastName.SelectedText = "";
            this.CustomerLastName.SelectionLength = 0;
            this.CustomerLastName.SelectionStart = 0;
            this.CustomerLastName.ShortcutsEnabled = true;
            this.CustomerLastName.Size = new System.Drawing.Size(331, 28);
            this.CustomerLastName.TabIndex = 6;
            this.CustomerLastName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CustomerLastName.UseSelectable = true;
            this.CustomerLastName.WaterMark = "Last Name";
            this.CustomerLastName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CustomerLastName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // CustomerFirstName
            // 
            // 
            // 
            // 
            this.CustomerFirstName.CustomButton.Image = null;
            this.CustomerFirstName.CustomButton.Location = new System.Drawing.Point(305, 2);
            this.CustomerFirstName.CustomButton.Name = "";
            this.CustomerFirstName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.CustomerFirstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CustomerFirstName.CustomButton.TabIndex = 1;
            this.CustomerFirstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CustomerFirstName.CustomButton.UseSelectable = true;
            this.CustomerFirstName.CustomButton.Visible = false;
            this.CustomerFirstName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.CustomerFirstName.Lines = new string[0];
            this.CustomerFirstName.Location = new System.Drawing.Point(941, 171);
            this.CustomerFirstName.MaxLength = 32;
            this.CustomerFirstName.Name = "CustomerFirstName";
            this.CustomerFirstName.PasswordChar = '\0';
            this.CustomerFirstName.PromptText = "First Name";
            this.CustomerFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CustomerFirstName.SelectedText = "";
            this.CustomerFirstName.SelectionLength = 0;
            this.CustomerFirstName.SelectionStart = 0;
            this.CustomerFirstName.ShortcutsEnabled = true;
            this.CustomerFirstName.Size = new System.Drawing.Size(331, 28);
            this.CustomerFirstName.TabIndex = 5;
            this.CustomerFirstName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CustomerFirstName.UseSelectable = true;
            this.CustomerFirstName.WaterMark = "First Name";
            this.CustomerFirstName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CustomerFirstName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // CustomerUsername
            // 
            // 
            // 
            // 
            this.CustomerUsername.CustomButton.Image = null;
            this.CustomerUsername.CustomButton.Location = new System.Drawing.Point(302, 2);
            this.CustomerUsername.CustomButton.Name = "";
            this.CustomerUsername.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.CustomerUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CustomerUsername.CustomButton.TabIndex = 1;
            this.CustomerUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CustomerUsername.CustomButton.UseSelectable = true;
            this.CustomerUsername.CustomButton.Visible = false;
            this.CustomerUsername.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.CustomerUsername.Lines = new string[0];
            this.CustomerUsername.Location = new System.Drawing.Point(941, 137);
            this.CustomerUsername.MaxLength = 20;
            this.CustomerUsername.Name = "CustomerUsername";
            this.CustomerUsername.PasswordChar = '\0';
            this.CustomerUsername.PromptText = "Username";
            this.CustomerUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CustomerUsername.SelectedText = "";
            this.CustomerUsername.SelectionLength = 0;
            this.CustomerUsername.SelectionStart = 0;
            this.CustomerUsername.ShortcutsEnabled = true;
            this.CustomerUsername.Size = new System.Drawing.Size(328, 28);
            this.CustomerUsername.TabIndex = 4;
            this.CustomerUsername.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CustomerUsername.UseSelectable = true;
            this.CustomerUsername.WaterMark = "Username";
            this.CustomerUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CustomerUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerUsername.TextChanged += new System.EventHandler(this.CustomerUsername_TextChanged);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.dataGridView1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(935, 649);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.Username,
            this.FirstName,
            this.LastName,
            this.Address,
            this.PhoneNumber});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(935, 649);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "Customer ID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 120;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 120;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 10;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 320;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "Phone Number";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Width = 130;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tab_customers);
            this.metroTabControl1.Controls.Add(this.tab_rentingItems);
            this.metroTabControl1.Controls.Add(this.tab_rentedItems);
            this.metroTabControl1.Location = new System.Drawing.Point(0, 25);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(1280, 695);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tab_rentedItems
            // 
            this.tab_rentedItems.Controls.Add(this.rentingPeriodEnd);
            this.tab_rentedItems.Controls.Add(this.metroLabel5);
            this.tab_rentedItems.Controls.Add(this.rentingPeriodStart);
            this.tab_rentedItems.Controls.Add(this.metroLabel4);
            this.tab_rentedItems.Controls.Add(this.ReturnMovie);
            this.tab_rentedItems.Controls.Add(this.IssueMovie);
            this.tab_rentedItems.Controls.Add(this.label3);
            this.tab_rentedItems.Controls.Add(this.metroPanel4);
            this.tab_rentedItems.HorizontalScrollbarBarColor = true;
            this.tab_rentedItems.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_rentedItems.HorizontalScrollbarSize = 10;
            this.tab_rentedItems.Location = new System.Drawing.Point(4, 38);
            this.tab_rentedItems.Name = "tab_rentedItems";
            this.tab_rentedItems.Size = new System.Drawing.Size(1272, 653);
            this.tab_rentedItems.TabIndex = 4;
            this.tab_rentedItems.Text = "Rented Movies / Music";
            this.tab_rentedItems.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tab_rentedItems.VerticalScrollbarBarColor = true;
            this.tab_rentedItems.VerticalScrollbarHighlightOnWheel = false;
            this.tab_rentedItems.VerticalScrollbarSize = 10;
            // 
            // rentingPeriodEnd
            // 
            this.rentingPeriodEnd.Location = new System.Drawing.Point(942, 251);
            this.rentingPeriodEnd.MinimumSize = new System.Drawing.Size(0, 29);
            this.rentingPeriodEnd.Name = "rentingPeriodEnd";
            this.rentingPeriodEnd.Size = new System.Drawing.Size(330, 29);
            this.rentingPeriodEnd.TabIndex = 16;
            this.rentingPeriodEnd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rentingPeriodEnd.Value = new System.DateTime(2019, 8, 12, 23, 26, 0, 0);
            this.rentingPeriodEnd.ValueChanged += new System.EventHandler(this.RentingPeriodEnd_ValueChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Black;
            this.metroLabel5.Location = new System.Drawing.Point(942, 228);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(58, 19);
            this.metroLabel5.TabIndex = 15;
            this.metroLabel5.Text = "Rent Till:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // rentingPeriodStart
            // 
            this.rentingPeriodStart.Location = new System.Drawing.Point(942, 192);
            this.rentingPeriodStart.MinimumSize = new System.Drawing.Size(0, 29);
            this.rentingPeriodStart.Name = "rentingPeriodStart";
            this.rentingPeriodStart.Size = new System.Drawing.Size(330, 29);
            this.rentingPeriodStart.TabIndex = 14;
            this.rentingPeriodStart.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rentingPeriodStart.ValueChanged += new System.EventHandler(this.RentingPeriodStart_ValueChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Black;
            this.metroLabel4.Location = new System.Drawing.Point(942, 169);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(74, 19);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "Rent From:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ReturnMovie
            // 
            this.ReturnMovie.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.ReturnMovie.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.ReturnMovie.Location = new System.Drawing.Point(1111, 320);
            this.ReturnMovie.Name = "ReturnMovie";
            this.ReturnMovie.Size = new System.Drawing.Size(161, 46);
            this.ReturnMovie.Style = MetroFramework.MetroColorStyle.Magenta;
            this.ReturnMovie.TabIndex = 12;
            this.ReturnMovie.Text = "Return Movie";
            this.ReturnMovie.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ReturnMovie.UseSelectable = true;
            this.ReturnMovie.UseStyleColors = true;
            this.ReturnMovie.Click += new System.EventHandler(this.ReturnMovie_Click);
            // 
            // IssueMovie
            // 
            this.IssueMovie.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.IssueMovie.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.IssueMovie.Location = new System.Drawing.Point(942, 320);
            this.IssueMovie.Name = "IssueMovie";
            this.IssueMovie.Size = new System.Drawing.Size(160, 46);
            this.IssueMovie.Style = MetroFramework.MetroColorStyle.Magenta;
            this.IssueMovie.TabIndex = 11;
            this.IssueMovie.Text = "Issue Movie";
            this.IssueMovie.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.IssueMovie.UseSelectable = true;
            this.IssueMovie.UseStyleColors = true;
            this.IssueMovie.Click += new System.EventHandler(this.IssueMovie_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(941, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 37);
            this.label3.TabIndex = 10;
            this.label3.Text = "Rent Movie";
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.dataGridView2);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(0, 3);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(935, 650);
            this.metroPanel4.TabIndex = 4;
            this.metroPanel4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RentalID,
            this.User,
            this.CustID,
            this.MovieIndex,
            this.RentFrom,
            this.RentTill});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(935, 650);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellClick);
            // 
            // RentalID
            // 
            this.RentalID.DataPropertyName = "RentalID";
            this.RentalID.HeaderText = "ID";
            this.RentalID.Name = "RentalID";
            this.RentalID.ReadOnly = true;
            // 
            // User
            // 
            this.User.DataPropertyName = "Username";
            this.User.HeaderText = "Username";
            this.User.Name = "User";
            this.User.ReadOnly = true;
            this.User.Width = 150;
            // 
            // CustID
            // 
            this.CustID.DataPropertyName = "CustomerID";
            this.CustID.HeaderText = "Customer ID";
            this.CustID.Name = "CustID";
            this.CustID.ReadOnly = true;
            // 
            // MovieIndex
            // 
            this.MovieIndex.DataPropertyName = "MovieIndex";
            this.MovieIndex.HeaderText = "Movie ID";
            this.MovieIndex.Name = "MovieIndex";
            this.MovieIndex.ReadOnly = true;
            // 
            // RentFrom
            // 
            this.RentFrom.DataPropertyName = "RentFrom";
            this.RentFrom.HeaderText = "From";
            this.RentFrom.Name = "RentFrom";
            this.RentFrom.ReadOnly = true;
            this.RentFrom.Width = 220;
            // 
            // RentTill
            // 
            this.RentTill.DataPropertyName = "RentTill";
            this.RentTill.HeaderText = "Till";
            this.RentTill.Name = "RentTill";
            this.RentTill.ReadOnly = true;
            this.RentTill.Width = 220;
            // 
            // DragPanel
            // 
            this.DragPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.DragPanel.Controls.Add(this.ExitApplication);
            this.DragPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DragPanel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.DragPanel.HorizontalScrollbarBarColor = true;
            this.DragPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.DragPanel.HorizontalScrollbarSize = 10;
            this.DragPanel.Location = new System.Drawing.Point(0, 0);
            this.DragPanel.Name = "DragPanel";
            this.DragPanel.Size = new System.Drawing.Size(1280, 25);
            this.DragPanel.Style = MetroFramework.MetroColorStyle.Yellow;
            this.DragPanel.TabIndex = 1;
            this.DragPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DragPanel.UseCustomBackColor = true;
            this.DragPanel.VerticalScrollbarBarColor = true;
            this.DragPanel.VerticalScrollbarHighlightOnWheel = false;
            this.DragPanel.VerticalScrollbarSize = 10;
            this.DragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            // 
            // ExitApplication
            // 
            this.ExitApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.ExitApplication.BackgroundImage = global::MoviesAndMusicRenting.Properties.Resources.close_window_25px;
            this.ExitApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ExitApplication.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitApplication.FlatAppearance.BorderSize = 0;
            this.ExitApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitApplication.Location = new System.Drawing.Point(1240, 0);
            this.ExitApplication.Name = "ExitApplication";
            this.ExitApplication.Size = new System.Drawing.Size(40, 25);
            this.ExitApplication.TabIndex = 2;
            this.ExitApplication.UseVisualStyleBackColor = false;
            this.ExitApplication.Click += new System.EventHandler(this.ExitApplication_Click);
            this.ExitApplication.MouseEnter += new System.EventHandler(this.ExitApplication_MouseEnter);
            this.ExitApplication.MouseLeave += new System.EventHandler(this.ExitApplication_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.DragPanel);
            this.Controls.Add(this.metroTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab_rentingItems.ResumeLayout(false);
            this.tab_rentingItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MovieCopiesField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovieRatingsField)).EndInit();
            this.metroPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tab_customers.ResumeLayout(false);
            this.tab_customers.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.tab_rentedItems.ResumeLayout(false);
            this.tab_rentedItems.PerformLayout();
            this.metroPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.DragPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabPage tab_rentingItems;
        private MetroFramework.Controls.MetroTabPage tab_customers;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tab_rentedItems;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox CustomerUsername;
        private MetroFramework.Controls.MetroTextBox CustomerLastName;
        private MetroFramework.Controls.MetroTextBox CustomerFirstName;
        private MetroFramework.Controls.MetroTextBox CustomerAddress;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton AddCustomer;
        private System.Windows.Forms.RadioButton addNewCustomer;
        private System.Windows.Forms.RadioButton modifyCustomer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton DeleteCustomer;
        private MetroFramework.Controls.MetroPanel DragPanel;
        private MetroFramework.Controls.MetroTextBox CustomerPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox MovieTitleField;
        private MetroFramework.Controls.MetroDateTime MovieRelease;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.NumericUpDown MovieCopiesField;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.NumericUpDown MovieRatingsField;
        private MetroFramework.Controls.MetroTextBox MovieRentingCostField;
        private MetroFramework.Controls.MetroComboBox MovieGenreField;
        private System.Windows.Forms.RadioButton MovieModify;
        private System.Windows.Forms.RadioButton MovieAdd;
        private MetroFramework.Controls.MetroButton Add_ModifyMovie;
        private MetroFramework.Controls.MetroButton DeleteMovie;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroButton ReturnMovie;
        private MetroFramework.Controls.MetroButton IssueMovie;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieRatings;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieCopies;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieRatingCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieGenre;
        private MetroFramework.Controls.MetroDateTime rentingPeriodEnd;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroDateTime rentingPeriodStart;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentTill;
        private System.Windows.Forms.Button ExitApplication;
    }
}

