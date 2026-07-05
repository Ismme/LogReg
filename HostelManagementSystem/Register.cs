using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace LogReg
{
    public partial class Register : Form
    {
        // Create a SqlConnection object with the connection string
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\linzs\Documents\logindata.mdf;Integrated Security=True;Connect Timeout=30");
        public Register()
        {
            InitializeComponent(); // Initialize the form components
        }

        private void Register_Load(object sender, EventArgs e)
        {
            this.Location = new Point(200, 100); // Set the initial location of the form
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login login = new Login(); // Create a new instance of the Login form
            login.ShowDialog(); // Show the Login form as a modal dialog
            this.Hide(); // Hide the current Register form
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open(); // Open the database connection

                    // SQL query to check if the entered name already exists in the "admin" table
                    string checkName = "SELECT * FROM admin WHERE Name = '" + signup_name.Text.Trim() + "'";

                    using (SqlCommand checkUser = new SqlCommand(checkName, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(checkUser); // Create a SqlDataAdapter with the command
                        DataTable table = new DataTable(); // Create a DataTable to hold the query result
                        adapter.Fill(table); // Fill the DataTable with the query result

                        if (table.Rows.Count > 1)
                        {
                            // If the query returned more than one row (name already exists)
                            MessageBox.Show(signup_name.Text + " is already exist", "error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            // If the name is unique, construct an SQL query to insert a new record into the "admin" table
                            string insertData = "INSERT INTO admin (Name, Admission_no, Password, date_created)" +
                                                "VALUES(@Name, @Admission_no, @Password, @date_created)";
                            DateTime date = DateTime.Today; // Get the current date


                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@Name" , signup_name.Text.Trim());
                                cmd.Parameters.AddWithValue("@Admission_no",signup_adminno.Text.Trim());
                                cmd.Parameters.AddWithValue("@Password",signup_pass.Text.Trim());
                                cmd.Parameters.AddWithValue("@date_created",date);

                                cmd.ExecuteNonQuery();

                                 MessageBox.Show("Registered sucessfully", "Information message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                //to switch to login form
                                Login login = new Login();
                                login.Show();
                                this.Hide();

                            }

                        }
               
                    }

                }catch(Exception ex)
                {
                    MessageBox.Show("Error connecting Database:" +ex, "ErrorMessage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }

        }

        private void signup_showpass_CheckedChanged(object sender, EventArgs e)
        {
            // Check if the signup_showpass CheckBox is checked
            if (signup_showpass.Checked)
            {
                // If checked, make the signup_pass TextBox visible
                signup_pass.PasswordChar = '\0';
            }
            else
            {
                // If unchecked, set the PasswordChar property of the signup_pass TextBox control to '*' (hiding characters)
                signup_pass.PasswordChar = '*';
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        { // Check if the showpass2 CheckBox is checked
            if (showpass2.Checked)
            {
                // If checked, set the PasswordChar property of the password TextBox control to '\0' (showing characters)
                signup_confirmpass.PasswordChar = '\0';
            }
            else
            {
                // If unchecked, set the PasswordChar property of the password TextBox control to '*' (hiding characters)
                signup_confirmpass.PasswordChar = '*';
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
