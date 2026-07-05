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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void buttonLog_out_Click(object sender, EventArgs e)
        {
            Login fm = new Login();
            fm.Show();
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void buttonManage_rooms_Click(object sender, EventArgs e)
        {
            Newroom anr = new Newroom();   
            anr.Show();
        }

        private void buttonNew_student_Click(object sender, EventArgs e)
        {
           Newstude ns= new Newstude();
            ns.Show();
        }

        private void buttonUpdate_delete_Click(object sender, EventArgs e)
        {
            UpdateDelete ns = new UpdateDelete();
            ns .Show();
        }

        private void buttonStudentFees_Click(object sender, EventArgs e)
        {
            StudentFees ns = new StudentFees();
            ns .Show();
        }

        private void buttonAll_students_Click(object sender, EventArgs e)
        {
           Allstudents ns = new Allstudents();
            ns .Show();
        }

        private void buttonAllRooms_Click(object sender, EventArgs e)
        {
            Allrooms ns =new Allrooms();
            ns .Show();
        }

        private void main_Load(object sender, EventArgs e)
        {
            Employees ns = new Employees();
            ns .Show();
        }

        private void buttonEmployees_Click(object sender, EventArgs e)
        {
            Employees ns = new Employees();
            ns.Show();
        }

        private void buttonAllemployees_Click(object sender, EventArgs e)
        {
            All_Employees ns = new All_Employees();
            ns.Show();







                
        }
    }
}
