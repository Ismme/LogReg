using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogReg
{

    public partial class Newstude : Form
    {
        Function fn = new Function();
        string query;
        public Newstude()
        {
            InitializeComponent();
        }

        private void Newstude_Load(object sender, EventArgs e)
        {
            this.Location = new Point(200, 170);
            //query = "SELECT roomNo from rooms WHERE roomStatus='Yes' and Booked='No'";
            //DataSet ds= fn.getData(query);
            // for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //   {
            //   Int64 room = Int64.Parse(ds.Tables[0].Rows[i][0].ToString());
            //  comboBox1.Items.Add(room);

            // }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {

            textBoxMobile_Number.Clear(); // Clear the mobile number text box
            textBoxName.Clear(); // Clear the name text box
            textBoxFather_Name.Clear(); // Clear the father's name text box
            textBoxMother_Name.Clear(); // Clear the mother's name text box
            textBoxEmail.Clear(); // Clear the email text box
            textBoxAdmission_No.Clear(); // Clear the admission number text box
            comboBox1.SelectedIndex = -1; // Clear the selected item in the comboBox1

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Validate input fields (optional)
            if (textBoxMobile_Number.Text != "" && textBoxName.Text != "" && textBoxFather_Name.Text != "" && textBoxMother_Name.Text != "" && textBoxEmail.Text != "" && textBoxAdmission_No.Text != "" && comboBox1.SelectedIndex != -1)
            {
                // Prepare SQL query with string concatenation (not recommended)
                string mobile = textBoxMobile_Number.Text;
                string name = textBoxName.Text;
                string fatherName = textBoxFather_Name.Text;
                string motherName = textBoxMother_Name.Text;
                string email = textBoxEmail.Text;
                string admissionNo = textBoxAdmission_No.Text;
                string roomNo = comboBox1.SelectedItem.ToString(); // Assuming string value in comboBoxRoomNo

                string query = string.Format("INSERT INTO student (mobilel, namel, fnamel, mnamel, emaill, adminol, roomNo) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", mobile, name, fatherName, motherName, email, admissionNo, roomNo);

                // Execute the query (caution: potential for SQL injection)
                fn.setData(query, "Student registration successful.");
            }
            else
            {
                MessageBox.Show("Please fill in all required fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.roomsTableAdapter1.FillBy(this.logindataDataSet.rooms);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.roomsTableAdapter1.FillBy(this.logindataDataSet.rooms);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
