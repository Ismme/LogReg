using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogReg
{
    public partial class Allrooms : Form
    {
        Function fn =new Function();
        string query;
        public Allrooms()
        {
            InitializeComponent();
        }

        private void Allrooms_Load(object sender, EventArgs e)

        {
            this.Location = new Point(200, 170);
            query = "select * from rooms where roomStatus='Yes'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource= ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
