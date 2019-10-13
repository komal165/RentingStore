using System;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace MoviesAndMusicRenting
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        // Startup Animation Variables
        public const int HOR_POSITIVE = 0X1;
        public const int HOR_NEGATIVE = 0X2;
        public const int VER_POSITIVE = 0X4;
        public const int VER_NEGATIVE = 0X8;
        public const int CENTER = 0X10;
        public const int BLEND = 0X80000;

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern int AnimateWindow(IntPtr hwand, int dwTime, int dwFlag);


        // Indexing Variables
        private int CustomersRowIndex;
        private int MovieRowIndex;

        // Check if user exists
        private bool UsernameExists = false;

        // Selected Row ID's
        private int CustomerRowID = 0;
        private int MovieRowID = 0;
        private int RentalRawID = 0;

        public Form1()
        {
            InitializeComponent();

            // Get round border for launcher
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addNewCustomer.Checked = true;
            modifyCustomer.Checked = false;
            AddCustomer.Text = "Add Customer";

            MovieAdd.Checked = true;
            MovieModify.Checked = false;
            Add_ModifyMovie.Text = "Add Movie";

            rentingPeriodStart.Value = DateTime.Now;
            rentingPeriodEnd.Value = rentingPeriodStart.Value.AddDays(1);

            // Gets all the tables from database
            GetCustomersList();
            GetMoviesList();
            GetRentingList();

            MovieGenreField.Items.Clear();
            MovieGenreField.Items.Add("Action");
            MovieGenreField.Items.Add("Adventure");
            MovieGenreField.Items.Add("Comedy");
            MovieGenreField.Items.Add("Drama");
            MovieGenreField.Items.Add("Historic");
            MovieGenreField.Items.Add("Romance");
            MovieGenreField.Items.Add("Sci-Fi");
            MovieGenreField.Items.Add("Music");
            MovieGenreField.SelectedIndex = 0;

            AnimateWindow(this.Handle,2000, BLEND);
        }

        // Custom Drag Panel ----- Start
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void DisplayError(string message)
        {
            MessageBox.Show(message);
        }


        /*********************************************************************************/
        // CUSTOMERS TAB

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            if (CustomerUsername.Text == "" || CustomerFirstName.Text == "" || CustomerLastName.Text == "" || CustomerAddress.Text == "" || CustomerPhone.Text == "")
            {
                MessageBox.Show("One or More fields are Empty!");
            }
            else
            {
                if (addNewCustomer.Checked)
                {
                    if (!UsernameExists)
                    {
                        // Add new User Query
                        string[] fieldNames = { "@Username", "@FirstName", "@LastName", "@Address", "@PhoneNumber" };
                        string[] fieldValues = { CustomerUsername.Text.ToString(), CustomerFirstName.Text.ToString(), CustomerLastName.Text.ToString(), CustomerAddress.Text.ToString(), CustomerPhone.Text.ToString() };

                        // Function to add new entries to table
                        using (SqlConnection conn = new SqlConnection(NetworkingHelpers.HostConfig()))
                        {
                            // Open Connection
                            conn.Open();

                            SqlCommand _cmd = new SqlCommand("INSERT INTO Customers (Username, FirstName, LastName, Address, PhoneNumber) VALUES (@Username, @FirstName, @LastName, @Address, @PhoneNumber)", conn);
                            for (int index = 0; index < fieldNames.Length; index++)
                            {
                                _cmd.Parameters.AddWithValue(fieldNames[index], fieldValues[index]);
                            }
                            _cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show(CustomerUsername.Text + " has been added successfully!");
                        GetCustomersList();
                    }
                    else
                    {
                        DisplayError("Username Already Exists!");
                    }
                }
                else
                {
                    // Update User Query
                    string[] fieldNames = { "@user", "@firstName", "@lastName", "@address", "@phone", "@cid" };
                    string[] fieldValues = { CustomerUsername.Text, CustomerFirstName.Text, CustomerLastName.Text, CustomerAddress.Text, CustomerPhone.Text, CustomerRowID.ToString() };
                    
                    using (SqlConnection conn = new SqlConnection(NetworkingHelpers.HostConfig()))
                    {
                        // Open Connection
                        conn.Open();

                        string query = "UPDATE Customers SET Username=@user, FirstName=@firstName, LastName=@lastName, Address=@address, PhoneNumber=@phone WHERE CustomerID=@cid";
                        SqlCommand _cmd = new SqlCommand(query, conn);
                        for (int index = 0; index < fieldNames.Length; index++)
                        {
                            _cmd.Parameters.AddWithValue(fieldNames[index], fieldValues[index]);
                        }
                        _cmd.ExecuteNonQuery();
                    }
                    GetCustomersList();
                }
                ResetCustomersField();
            }
        }

        private void CustomerUsername_TextChanged(object sender, EventArgs e)
        {
            // Verify Username in Real-time
            using(SqlConnection conn = new SqlConnection(NetworkingHelpers.HostConfig()))
            {
                using(SqlCommand _cmd = new SqlCommand("SELECT * FROM Customers WHERE Username=@user", conn))
                {
                    try
                    {
                        conn.Open();
                        _cmd.Parameters.AddWithValue("@user", CustomerUsername.Text.ToString());
                        object count = _cmd.ExecuteScalar();
                        if (count != null)
                        {
                            UsernameExists = true;
                        }
                        else
                        {
                            UsernameExists = false;
                        }
                        Error(UsernameExists.ToString());
                    }
                    catch (Exception err)
                    {
                        throw err;
                    }
                }
            }
        }

        private void ModifyCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (modifyCustomer.Checked)
            {
                AddCustomer.Text = "Modify Customer";
            }
            else
            {
                // Do Nothing
            }
        }

        private void Error(string message)
        {
            Console.WriteLine("Error: " + message);
        }

        private void GetCustomersList()
        {
            NetworkingHelpers.AddToDataGridView("Customers", dataGridView1, null);
        }

        private void AddNewCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (addNewCustomer.Checked)
            {
                AddCustomer.Text = "Add Customer";
            }
            else
            {
                // Do Nothing
            }
        }

        private void ResetCustomersField()
        {
            CustomerUsername.Text = "";
            CustomerFirstName.Text = "";
            CustomerLastName.Text = "";
            CustomerAddress.Text = "";
            CustomerPhone.Text = "";

            addNewCustomer.Checked = true;
            modifyCustomer.Checked = false;
            AddCustomer.Text = "Add Customer";

            DeleteCustomer.Enabled = false;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.CustomersRowIndex = e.RowIndex;

            if (this.CustomersRowIndex < 0)
            {
                Error("Incorrect Index");
                ResetCustomersField();
            }
            else
            {
                DataGridViewRow row = dataGridView1.Rows[this.CustomersRowIndex];
                if (row.Selected)
                {
                    // To avoid the error if selecting the empty auto generated row by Microsoft SSMS
                    if (this.CustomersRowIndex < dataGridView1.Rows.Count - 1)
                    {
                        DeleteCustomer.Enabled = true;
                        // Assign values of selected row to each field
                        CustomerRowID = Convert.ToInt32(row.Cells[0].Value);
                        CustomerUsername.Text = row.Cells[1].Value.ToString();
                        CustomerFirstName.Text = row.Cells[2].Value.ToString();
                        CustomerLastName.Text = row.Cells[3].Value.ToString();
                        CustomerAddress.Text = row.Cells[4].Value.ToString();
                        CustomerPhone.Text = row.Cells[5].Value.ToString();
                    }
                    else
                    {
                        DeleteCustomer.Enabled = false;
                        Error("Null operator doesn't exist.");
                        ResetCustomersField();
                    }
                }
                else
                {
                    ResetCustomersField();
                }
            }
        }

        private void DeleteCustomer_Click(object sender, EventArgs e)
        {
            if (NetworkingHelpers.GetUserRentedMovies(CustomerRowID) > 0)
            {
                DisplayError("This Customer has rented movies!");
            }
            else
            {
                // Delete the customer from list
                using (SqlConnection conn = new SqlConnection(NetworkingHelpers.HostConfig()))
                {
                    // Open Connection
                    conn.Open();

                    string query = "DELETE FROM Customers WHERE CustomerID=@custID";
                    SqlCommand _cmd = new SqlCommand(query, conn);
                    _cmd.Parameters.AddWithValue("@custID", CustomerRowID);

                    _cmd.ExecuteNonQuery();
                }

                // Update the list
                GetCustomersList();
                ResetCustomersField();
            }
        }


        /*********************************************************************************/
        // MOVIES TAB

        private void GetMoviesList()
        {
            NetworkingHelpers.AddToDataGridView("Movies", dataGridView3, null);
        }

        private void Add_ModifyMovie_Click(object sender, EventArgs e)
        {
            if (MovieTitleField.Text == "" || MovieRentingCostField.Text == "")
            {
                MessageBox.Show("One or More fields are Empty!");
            }
            else
            {
                if (MovieAdd.Checked)
                {
                    string columns = "(MovieTitle, MovieReleaseDate, MovieRatings, MovieCopies, MovieRatingCost, MovieGenre)";
                    string values = "(@title, @date, @ratings, @copies, @rentingCost, @genre)";
                    string[] fieldNames = { "@title", "@date", "@ratings", "@copies", "@rentingCost", "@genre" };
                    using (SqlConnection conn = new SqlConnection(NetworkingHelpers.HostConfig()))
                    {
                        // Open Connection
                        conn.Open();

                        SqlCommand _cmd = new SqlCommand("INSERT INTO Movies " + columns + " VALUES " + values, conn);
                        _cmd.Parameters.AddWithValue("@title", MovieTitleField.Text);
                        _cmd.Parameters.AddWithValue("@date", MovieRelease.Value);
                        _cmd.Parameters.AddWithValue("@ratings", MovieRatingsField.Value);
                        _cmd.Parameters.AddWithValue("@copies", MovieCopiesField.Value);
                        _cmd.Parameters.AddWithValue("@rentingCost", MovieRentingCostField.Text);
                        _cmd.Parameters.AddWithValue("@genre", MovieGenreField.SelectedItem.ToString());
                        _cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    string values = "MovieTitle=@title, MovieReleaseDate=@date, MovieRatings=@ratings, MovieCopies=@copies, MovieRatingCost=@rentingCost, MovieGenre=@genre";
                    using (SqlConnection conn = new SqlConnection(NetworkingHelpers.HostConfig()))
                    {
                        // Open Connection
                        conn.Open();

                        SqlCommand _cmd = new SqlCommand("UPDATE Movies SET " + values + " WHERE MovieID=@id", conn);
                        _cmd.Parameters.AddWithValue("@title", MovieTitleField.Text);
                        _cmd.Parameters.AddWithValue("@date", MovieRelease.Value);
                        _cmd.Parameters.AddWithValue("@ratings", MovieRatingsField.Value);
                        _cmd.Parameters.AddWithValue("@copies", MovieCopiesField.Value);
                        _cmd.Parameters.AddWithValue("@rentingCost", MovieRentingCostField.Text);
                        _cmd.Parameters.AddWithValue("@genre", MovieGenreField.SelectedItem.ToString());
                        _cmd.Parameters.AddWithValue("@id", MovieRowID);
                        _cmd.ExecuteNonQuery();
                    }
                }
                GetMoviesList();
                ResetMovieFields();
            }
        }

        private void DataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.MovieRowIndex = e.RowIndex;

            if (this.MovieRowIndex < 0)
            {
                Error("Incorrect Index");
                ResetMovieFields();
            }
            else
            {
                DataGridViewRow row = dataGridView3.Rows[this.MovieRowIndex];
                if (row.Selected)
                {
                    // To avoid the error if selecting the empty auto generated row by Microsoft SSMS
                    if (this.MovieRowIndex < dataGridView3.Rows.Count - 1)
                    {
                        DeleteMovie.Enabled = true;
                        // Assign values of selected row to each field
                        MovieRowID = Convert.ToInt32(row.Cells[0].Value);
                        MovieTitleField.Text = row.Cells[1].Value.ToString();
                        MovieRelease.Value = Convert.ToDateTime(row.Cells[2].Value);
                        MovieRatingsField.Value = Convert.ToDecimal(row.Cells[3].Value);
                        MovieCopiesField.Value = Convert.ToInt32(row.Cells[4].Value);
                        MovieRentingCostField.Text = row.Cells[5].Value.ToString();
                        if (MovieGenreField.Items.Contains(row.Cells[6].Value.ToString()))
                        {
                            MovieGenreField.SelectedItem = row.Cells[6].Value.ToString();
                        }
                        else
                        {
                            // If the selected genre doesn't exist then we will select first index
                            MovieGenreField.SelectedIndex = 0;
                        }
                    }
                    else
                    {
                        DeleteMovie.Enabled = false;
                        Error("Null operator doesn't exist.");
                        ResetMovieFields();
                    }
                }
                else
                {
                    ResetMovieFields();
                }
            }
        }

        private void MovieAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (MovieAdd.Checked)
            {
                Add_ModifyMovie.Text = "Add Movie";
            }
            else
            {
                // Do Nothing
            }
        }

        private void MovieModify_CheckedChanged(object sender, EventArgs e)
        {
            if (MovieModify.Checked)
            {
                Add_ModifyMovie.Text = "Modify Movie";
            }
            else
            {
                // Do Nothing
            }
        }

        private void DeleteMovie_Click(object sender, EventArgs e)
        {
            if (NetworkingHelpers.GetMovieOnRent(MovieRowID) > 0)
            {
                DisplayError("Copy of this movie is Currently on Rent!");
            }
            else
            {
                // Delete the customer from list
                using (SqlConnection conn = new SqlConnection(NetworkingHelpers.HostConfig()))
                {
                    // Open Connection
                    conn.Open();

                    string query = "DELETE FROM Movies WHERE MovieID=@movID";
                    SqlCommand _cmd = new SqlCommand(query, conn);
                    _cmd.Parameters.AddWithValue("@movID", MovieRowID);

                    _cmd.ExecuteNonQuery();
                }
                GetMoviesList();
            }
        }

        private void ResetMovieFields()
        {
            MovieTitleField.Text = "";
            MovieRatingsField.Value = 0.5M;
            MovieRelease.Value = DateTime.Now;
            MovieRentingCostField.Text = "";
            MovieGenreField.SelectedIndex = 0;
            MovieCopiesField.Value = 1;
        }


        /*********************************************************************************/
        // RENTED MOVIES TAB

        private void IssueMovie_Click(object sender, EventArgs e)
        {
            if(CustomerRowID > 0 && MovieRowID > 0)
            {
                using(SqlConnection conn = new SqlConnection(NetworkingHelpers.HostConfig()))
                {
                    // Open Connection
                    conn.Open();

                    // Only executes if there are copies of movies available
                    // NOTE: For Production Purpose - This is not a very good way to do this
                   if (MovieCopiesField.Value > 0)
                    { // Update Movies table to decrease available copies count
                        using (SqlCommand _cmd = new SqlCommand("UPDATE Movies SET MovieCopies=@copies WHERE MovieID=@id", conn))
                        {
                            _cmd.Parameters.AddWithValue("@copies", Convert.ToInt32(MovieCopiesField.Value - 1));
                            _cmd.Parameters.AddWithValue("@id", MovieRowID);
                            _cmd.ExecuteNonQuery();
                        }

                        // Add Movie to Rented Movies table
                        using (SqlCommand _cmd = new SqlCommand("INSERT INTO Rented (CustomerID, Username, MovieID, RentFrom, RentTill) VALUES(@uid, @user, @id, @from, @till)", conn))
                        {
                            _cmd.Parameters.AddWithValue("@uid", CustomerRowID);
                            _cmd.Parameters.AddWithValue("@user", CustomerUsername.Text);
                            _cmd.Parameters.AddWithValue("@id", MovieRowID);
                            _cmd.Parameters.AddWithValue("@from", rentingPeriodStart.Value);
                            _cmd.Parameters.AddWithValue("@till", rentingPeriodEnd.Value);
                            _cmd.ExecuteNonQuery();
                        }

                        // Display Pop-up message to let user know total days the customer has rented movie for
                        TimeSpan time = rentingPeriodEnd.Value.Subtract(rentingPeriodStart.Value);
                        // This message will let user of the app know, which customer has hired which movie for how many days
                        DisplayError(CustomerUsername.Text + " has rented " + MovieTitleField.Text + " for " + Convert.ToInt32(time.TotalDays));

                        // Update the tables to keep data in sync with the database
                        GetMoviesList();
                        GetRentingList();
                        ResetRentingFields();
                    }
                   else
                    {
                        DisplayError("All copies of " + MovieTitleField.Text + " are rented!");
                    }
                }
            }
            else
            {
                if (CustomerRowID <= 0)
                {
                    DisplayError("Please Select the customer!");
                }
                else
                {
                    DisplayError("Please Select the Movie!");
                }
            }
        }

        private void ReturnMovie_Click(object sender, EventArgs e)
        {
            // Delete the customer from list
            using (SqlConnection conn = new SqlConnection(NetworkingHelpers.HostConfig()))
            {
                // Open Connection
                conn.Open();

                string query = "DELETE FROM Rented WHERE RentalID=@renID";
                SqlCommand _cmd = new SqlCommand(query, conn);
                _cmd.Parameters.AddWithValue("@renID", RentalRawID);

                _cmd.ExecuteNonQuery();
            }

            using (SqlConnection conn = new SqlConnection(NetworkingHelpers.HostConfig()))
            {
                // Open Connection
                conn.Open();

                // Execute Query
                using (SqlCommand _cmd = new SqlCommand("UPDATE Movies SET MovieCopies=@copies WHERE MovieID=@id", conn))
                {
                    int copies = 0;
                    SqlCommand _getCopies = new SqlCommand("SELECT MovieCopies FROM Movies WHERE MovieID=@id", conn);
                    _getCopies.Parameters.AddWithValue("@id", MovieRowID);
                    SqlDataReader reader = _getCopies.ExecuteReader();
                    while(reader.Read())
                    {
                        copies = Convert.ToInt32(reader["MovieCopies"]);
                    }
                    reader.Close();

                    _cmd.Parameters.AddWithValue("@copies", copies + 1);
                    _cmd.Parameters.AddWithValue("@id", MovieRowID);
                    _cmd.ExecuteNonQuery();
                }

                // Update Tables to keep the table data in sync with database
                GetMoviesList();
                GetRentingList();
            }
        }

        private void GetRentingList()
        {
            NetworkingHelpers.AddToDataGridView("Rented", dataGridView2, null);
        }

        private void ResetRentingFields()
        {
            rentingPeriodStart.Value = DateTime.Now;
            rentingPeriodEnd.Value = rentingPeriodStart.Value.AddDays(1);
        }

        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.RentalRawID = e.RowIndex;

            if (this.RentalRawID < 0)
            {
                Error("Incorrect Index");
                ResetRentingFields();
            }
            else
            {
                DataGridViewRow row = dataGridView2.Rows[this.RentalRawID];
                if (row.Selected)
                {
                    // To avoid the error if selecting the empty auto generated row by Microsoft SSMS
                    if (this.RentalRawID < dataGridView2.Rows.Count - 1)
                    {
                        ReturnMovie.Enabled = true;
                        // Assign values of selected row to each field
                        RentalRawID = Convert.ToInt32(row.Cells[0].Value);
                        // Only need to Get Movie id if we don't have it
                        if (MovieRowID <= 0)
                        {
                            MovieRowID = Convert.ToInt32(row.Cells[2].Value);
                        }
                        rentingPeriodStart.Value = Convert.ToDateTime(row.Cells[4].Value);
                        rentingPeriodEnd.Value = Convert.ToDateTime(row.Cells[5].Value);
                    }
                    else
                    {
                        ReturnMovie.Enabled = false;
                        Error("Null operator doesn't exist.");
                        ResetRentingFields();
                    }
                }
                else
                {
                    ResetRentingFields();
                }
            }
        }

        private void RentingPeriodStart_ValueChanged(object sender, EventArgs e)
        {
            if (rentingPeriodStart.Value.Date >= rentingPeriodEnd.Value.Date)
            {
                rentingPeriodEnd.Value = rentingPeriodStart.Value.AddDays(1);
            }
        }

        private void RentingPeriodEnd_ValueChanged(object sender, EventArgs e)
        {
            if (rentingPeriodEnd.Value.Date <= rentingPeriodStart.Value.Date)
            {
                rentingPeriodEnd.Value = rentingPeriodStart.Value.AddDays(1);
            }
        }

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void DragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ExitApplication_MouseEnter(object sender, EventArgs e)
        {
            ExitApplication.BackColor = Color.FromArgb(240, 71, 71);
        }

        private void ExitApplication_MouseLeave(object sender, EventArgs e)
        {
            ExitApplication.BackColor = Color.FromArgb(32, 34, 37);
        }

        private void ExitApplication_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
