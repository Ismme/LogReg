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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LogReg
{
    public partial class Newroom : Form
    {
       Function fn = new Function();

        string query;
        SqlParameter[] parameters;
        public Newroom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Newroom_Load(object sender, EventArgs e)
        {
            this.Location = new Point(200, 170); 
            labelroom.Visible = false;
            labelroomExist.Visible = false;

            query = "Select * from rooms";
            DataSet ds = fn.getData(query);
            dataGridView1R.DataSource = ds.Tables[0];




        }

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            // Construct a SQL query to check if the room number already exists
            query = "select * from rooms where roomNo = " + textBox1RoomNO1.Text + "";
            DataSet ds1 = fn.getData(query);

            if (ds1.Tables[0].Rows.Count == 0)
            {
                string status;
                // Check if the DataSet contains any rows (i.e., if the room number exists)
                if (checkBoxAciveDe.Checked)
                {
                    status = "Yes";
                }
                else
                {
                    status = "No";
                }
                labelroomExist.Visible = false;
                // Construct a SQL query to insert the new room into the database
                query = "insert into rooms(roomNo,roomStatus)values(" + textBox1RoomNO1.Text + " , '" + status + "')";
                fn.setData(query, "Room added.");
                Newroom_Load(this, null);

            }
            else
            {
                labelroomExist.Text = "Room already exist";
                labelroomExist.Visible = true;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            query = "select * from rooms where roomNo =" + textBoxRoomNO2.Text + "";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                labelroom.Text = "No room exist.";
                labelroom.Visible = true;
                checkBox2DEACT.Checked = false;
            }
            else
            {
                labelroom.Text = "Room Found";
                labelroom.Visible = true;
                if (ds.Tables[0].Rows[0][1].ToString() == "Yes")
                {
                    checkBox2DEACT.Checked=true;


                }
                else
                {
                checkBox2DEACT.Checked=true ;
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string Status;
            if(checkBox2DEACT.Checked)
            {
                Status = "Yes";
            }
            else
            {
                Status = "No";
            }
            query = "update rooms set roomStatus ='" + Status + "' where roomNo=" + textBoxRoomNO2.Text + "";
            fn.setData(query, "Details updated.");
            Newroom_Load(this, null);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (labelroom.Text=="Room Found")
            {
                query = "delete from rooms where roomNo = " + textBoxRoomNO2.Text + "";
                fn.setData(query, "room details deleted");
                Newroom_Load(this, null);
            }
            else
            {
                MessageBox.Show("Trying to delete which doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }

}
