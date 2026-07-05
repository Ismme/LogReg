using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LogReg
{
    public partial class Employees : Form
    {
        Function fn = new Function();
        string query;
        public Employees()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {

            clearAll();
        }
        public void clearAll()
        {
            textBoxEmpMobile.Clear();
            textBoxEmpName.Clear();
            textBoxEmpEmail.Clear();
            textBoxEmpAge.Clear();
         
            comboBoxDept.SelectedIndex = -1;

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxEmpMobile.Text != "" && textBoxEmpName.Text != "" && textBoxEmpEmail.Text != "" && textBoxEmpAge.Text != ""  && comboBoxDept.SelectedIndex != -1)
            {
                // Prepare SQL query with string concatenation (not recommended)
                string mobile = textBoxEmpMobile.Text;
                string name = textBoxEmpName.Text;
               
                string email = textBoxEmpEmail.Text;
                string Age = textBoxEmpAge.Text;
                string Dept = comboBoxDept.SelectedItem.ToString(); // Assuming string value in comboBoxRoomNo

                string query = string.Format("INSERT INTO Employees (EmpMobile, EmpName, EmpEmail, EmpAge, Dept) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", mobile, name, email, Age, Dept);

                // Execute the query (caution: potential for SQL injection)
                fn.setData(query, "Employee registration successful.");
            }
            else
            {
                MessageBox.Show("Please fill in all required fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            this.Location = new Point(200, 170);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
