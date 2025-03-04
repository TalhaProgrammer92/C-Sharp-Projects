using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Employee_Management
{
    class Functions
    {
        // Attributes
        private SqlConnection connection;
        private SqlCommand command;
        private DataTable dataTable;
        private SqlDataAdapter dataAdapter;
        private string connectionString;

        // Constructor
        public Functions() 
        {
            // Establishing a connection with database
            connectionString = @"Data Source=DESKTOP-UACK8EI;Initial Catalog=EmployeeDatabase;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;
        }

        // Method to get data table of the database from given query
        public DataTable GetData(string query)
        {
            // Creates a new DataTable to store query results
            dataTable = new DataTable();

            // Initializes a SqlDataAdapter with the provided query and connection string
            dataAdapter = new SqlDataAdapter(query, connectionString);

            // Executes the query and fills the DataTable with the retrieved data
            dataAdapter.Fill(dataTable);

            // Returns the populated DataTable to the caller
            return dataTable;
        }

        // Method to set data from given query
        public int SetData(string query)
        {
            // Declare an integer variable to store the number of affected rows
            int affectedRows = 0;

            try
            {
                // Open the database connection if it is not already open
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                // Set the SQL command text to the provided query
                //command.CommandText = query;
                using (command = new SqlCommand(query, connection))
                {
                    affectedRows = command.ExecuteNonQuery(); // Execute query
                }

                // Execute the query and store the number of affected rows in cnt
                //affectedRows = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
            finally
            {
                // Always close the connection after execution
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            // Return the number of affected rows to the caller
            return affectedRows;
        }
    }
}
