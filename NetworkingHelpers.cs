using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesAndMusicRenting
{
    public class NetworkingHelpers
    {

        public static string HostConfig()
        {
            return @"Data Source=LAPTOP-GPSG7DIK\SQLEXPRESS; Initial Catalog=rental_store; Integrated Security=True";
        }

        public string Configs()
        {
            return HostConfig();
        }

        // Add to DataGridView
        public static void AddToDataGridView(string table, DataGridView view, MetroFramework.Controls.MetroTile tile)
        {
            using (SqlConnection conn = new SqlConnection(NetworkingHelpers.HostConfig()))
            {
                // Establish Connection
                conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM " + table, conn);
                DataTable dataTable = new DataTable();
                dataTable.Clear();
                adapter.Fill(dataTable);

                view.AutoGenerateColumns = false;
                view.DataSource = dataTable;
            }
        }

        // CONDITIONS FOR DELETING MOVIES OR CUSTOMERS
        public static int GetUserRentedMovies(int CustomerID)
        {
            List<string> MoviesList = new List<string>();
            using (SqlConnection conn = new SqlConnection(HostConfig()))
            {
                // Open Connection
                conn.Open();

                SqlCommand _cmd = new SqlCommand("SELECT * FROM Rented WHERE CustomerID=@id", conn);
                _cmd.Parameters.AddWithValue("@id", CustomerID);
                SqlDataReader reader;
                reader = _cmd.ExecuteReader();
                while (reader.Read())
                {
                    MoviesList.Add(reader["RentalID"].ToString());
                }
                reader.Close();
                return MoviesList.Count();
            }
        }

        public static int GetMovieOnRent(int MovieID)
        {
            List<string> MoviesList = new List<string>();
            using (SqlConnection conn = new SqlConnection(HostConfig()))
            {
                // Open Connection
                conn.Open();

                SqlCommand _cmd = new SqlCommand("SELECT * FROM Rented WHERE MovieID=@id", conn);
                _cmd.Parameters.AddWithValue("@id", MovieID.ToString());
                SqlDataReader reader;
                reader = _cmd.ExecuteReader();
                while (reader.Read())
                {
                    MoviesList.Add(reader["RentalID"].ToString());
                }
                reader.Close();
                return MoviesList.Count();
            }
        }

        public int GetRentalCount()
        {
            return GetMovieOnRent(0);
        }
    }
}
