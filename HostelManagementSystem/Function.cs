using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogReg
{
    internal class Function
    {
        protected SqlConnection GetSqlConnection()
        {
            // Set the connection string for the SqlConnection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=C:\\USERS\\LINZS\\DOCUMENTS\\LOGINDATA.MDF;Integrated Security=True";
            return con;
        }
        public DataSet getData(String query )
        { // Get the SqlConnection object by calling the GetSqlConnection method
            SqlConnection con = GetSqlConnection();
            // Crate a new instance of SqlCommand
            SqlCommand cmd = new SqlCommand();
            // Set the SqlConnection for the SqlCommand
            cmd.Connection = con;
            // Set the SQL query for the SqlCommand
            cmd.CommandText = query;
            // Create a new instance of SqlDataAdapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // Create a new instance of DataSet
            DataSet ds = new DataSet();
            // Fill the DataSet with data from the SQL query
            da.Fill(ds);
            // Return the DataSet
            return ds;

        }

        public void setData(String query ,String msg , params SqlParameter[] parameters)
        { // Using block for proper connection disposal
            using (SqlConnection con = GetSqlConnection())
            {
                try
                {
                    con.Open();

                    // Create SqlCommand object
                    SqlCommand cmd = new SqlCommand(query, con);

                    // Add parameters if provided
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    // Execute the query
                    cmd.ExecuteNonQuery();

                    MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Handle potential exceptions
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
