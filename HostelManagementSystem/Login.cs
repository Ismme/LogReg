using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace LogReg
{
    public partial class Login : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\linzs\Documents\logindata.mdf;Integrated Security=True;Connect Timeout=30");

        public Login()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
           this.Location = new Point(200,100);
        }

        private void registerhere_direct_Click(object sender, EventArgs e)
        {
            Register sForm =new Register ();
            sForm.Show();
               this.Hide();
        }

        private void login_showpass_CheckedChanged(object sender, EventArgs e)
        {
            // Check if the login_showpass CheckBox is checked
            if (login_showpass.Checked)
            {
                // If checked, set the PasswordChar property of the password TextBox control to '\0' (showing characters)
                login_pass.PasswordChar = '\0';
            }
            else
            {
                // If unchecked, set the PasswordChar property of the password TextBox control to '*' (hiding characters)
                login_pass.PasswordChar = '*';
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (login_adminno.Text == "" || login_pass.Text == "")
            {
                // If either the username (admin number) or password field is empty
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open(); // Open the database connection

                        // SQL query to select from the "admin" table where the admission number and password match the input
                        String selectData = "SELECT * FROM admin WHERE Admission_no = @Admin_no AND password = @pass";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            // Add the input values as parameters to the SQL command
                            cmd.Parameters.AddWithValue("@Admin_no", login_adminno.Text);
                            cmd.Parameters.AddWithValue("@pass", login_pass.Text);

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd); // Create a SqlDataAdapter with the command
                            DataTable table = new DataTable(); // Create a DataTable to hold the query result
                            adapter.Fill(table); // Fill the DataTable with the query result

                            if (table.Rows.Count >= 1)
                            {
                                // If the query returned at least one row (admin record found)
                                MessageBox.Show("Logged In successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                main mForm = new main(); // Create an instance of the "main" form
                                mForm.Show(); // Show the "main" form
                                this.Hide(); // Hide the current form
                            }
                            else
                            {
                                // If the query returned no rows (admin record not found)
                                MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // If an exception occurs during the database operation
                        MessageBox.Show("Error Connecting: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close(); // Close the database connection
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
