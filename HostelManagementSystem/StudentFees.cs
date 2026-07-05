using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LogReg
{
    public partial class StudentFees : Form
    {

        Function fn = new Function();
        string query;
        public StudentFees()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void StudentFees_Load(object sender, EventArgs e)
        {
            this.Location = new Point(200, 170);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "mmmm yyyy ";

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
