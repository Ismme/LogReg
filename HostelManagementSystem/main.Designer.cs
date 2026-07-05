namespace LogReg
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAllRooms = new System.Windows.Forms.Button();
            this.buttonLog_out = new System.Windows.Forms.Button();
            this.buttonEmployees = new System.Windows.Forms.Button();
            this.buttonAll_students = new System.Windows.Forms.Button();
            this.buttonStudentFees = new System.Windows.Forms.Button();
            this.buttonUpdate_delete = new System.Windows.Forms.Button();
            this.buttonNew_student = new System.Windows.Forms.Button();
            this.buttonManage_rooms = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAllemployees = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(413, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME ADMIN";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(945, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(0, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "NAVIGATION BAR";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(916, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(29, 23);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonAllRooms
            // 
            this.buttonAllRooms.BackColor = System.Drawing.Color.Magenta;
            this.buttonAllRooms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonAllRooms.Location = new System.Drawing.Point(0, 98);
            this.buttonAllRooms.Name = "buttonAllRooms";
            this.buttonAllRooms.Size = new System.Drawing.Size(125, 26);
            this.buttonAllRooms.TabIndex = 13;
            this.buttonAllRooms.Text = "All Available Rooms";
            this.buttonAllRooms.UseVisualStyleBackColor = false;
            this.buttonAllRooms.Click += new System.EventHandler(this.buttonAllRooms_Click);
            // 
            // buttonLog_out
            // 
            this.buttonLog_out.BackColor = System.Drawing.Color.Magenta;
            this.buttonLog_out.ForeColor = System.Drawing.Color.Blue;
            this.buttonLog_out.Image = ((System.Drawing.Image)(resources.GetObject("buttonLog_out.Image")));
            this.buttonLog_out.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLog_out.Location = new System.Drawing.Point(12, 457);
            this.buttonLog_out.Name = "buttonLog_out";
            this.buttonLog_out.Size = new System.Drawing.Size(125, 36);
            this.buttonLog_out.TabIndex = 11;
            this.buttonLog_out.Text = "LOG OUT";
            this.buttonLog_out.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLog_out.UseVisualStyleBackColor = false;
            this.buttonLog_out.Click += new System.EventHandler(this.buttonLog_out_Click);
            // 
            // buttonEmployees
            // 
            this.buttonEmployees.BackColor = System.Drawing.Color.Magenta;
            this.buttonEmployees.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEmployees.BackgroundImage")));
            this.buttonEmployees.ForeColor = System.Drawing.Color.Blue;
            this.buttonEmployees.Location = new System.Drawing.Point(0, 234);
            this.buttonEmployees.Name = "buttonEmployees";
            this.buttonEmployees.Size = new System.Drawing.Size(99, 30);
            this.buttonEmployees.TabIndex = 9;
            this.buttonEmployees.Text = "Employees";
            this.buttonEmployees.UseVisualStyleBackColor = false;
            this.buttonEmployees.Click += new System.EventHandler(this.buttonEmployees_Click);
            // 
            // buttonAll_students
            // 
            this.buttonAll_students.BackColor = System.Drawing.Color.Magenta;
            this.buttonAll_students.ForeColor = System.Drawing.Color.Blue;
            this.buttonAll_students.Image = ((System.Drawing.Image)(resources.GetObject("buttonAll_students.Image")));
            this.buttonAll_students.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAll_students.Location = new System.Drawing.Point(0, 166);
            this.buttonAll_students.Name = "buttonAll_students";
            this.buttonAll_students.Size = new System.Drawing.Size(128, 28);
            this.buttonAll_students.TabIndex = 8;
            this.buttonAll_students.Text = "All students here";
            this.buttonAll_students.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAll_students.UseVisualStyleBackColor = false;
            this.buttonAll_students.Click += new System.EventHandler(this.buttonAll_students_Click);
            // 
            // buttonStudentFees
            // 
            this.buttonStudentFees.BackColor = System.Drawing.Color.Magenta;
            this.buttonStudentFees.ForeColor = System.Drawing.Color.Blue;
            this.buttonStudentFees.Image = ((System.Drawing.Image)(resources.GetObject("buttonStudentFees.Image")));
            this.buttonStudentFees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStudentFees.Location = new System.Drawing.Point(3, 200);
            this.buttonStudentFees.Name = "buttonStudentFees";
            this.buttonStudentFees.Size = new System.Drawing.Size(105, 28);
            this.buttonStudentFees.TabIndex = 7;
            this.buttonStudentFees.Text = "Student fees";
            this.buttonStudentFees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStudentFees.UseVisualStyleBackColor = false;
            this.buttonStudentFees.Click += new System.EventHandler(this.buttonStudentFees_Click);
            // 
            // buttonUpdate_delete
            // 
            this.buttonUpdate_delete.BackColor = System.Drawing.Color.Magenta;
            this.buttonUpdate_delete.ForeColor = System.Drawing.Color.Blue;
            this.buttonUpdate_delete.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdate_delete.Image")));
            this.buttonUpdate_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdate_delete.Location = new System.Drawing.Point(0, 345);
            this.buttonUpdate_delete.Name = "buttonUpdate_delete";
            this.buttonUpdate_delete.Size = new System.Drawing.Size(128, 28);
            this.buttonUpdate_delete.TabIndex = 6;
            this.buttonUpdate_delete.Text = "Update and Delete";
            this.buttonUpdate_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUpdate_delete.UseVisualStyleBackColor = false;
            this.buttonUpdate_delete.Click += new System.EventHandler(this.buttonUpdate_delete_Click);
            // 
            // buttonNew_student
            // 
            this.buttonNew_student.BackColor = System.Drawing.Color.Magenta;
            this.buttonNew_student.ForeColor = System.Drawing.Color.Blue;
            this.buttonNew_student.Image = ((System.Drawing.Image)(resources.GetObject("buttonNew_student.Image")));
            this.buttonNew_student.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNew_student.Location = new System.Drawing.Point(0, 132);
            this.buttonNew_student.Name = "buttonNew_student";
            this.buttonNew_student.Size = new System.Drawing.Size(99, 28);
            this.buttonNew_student.TabIndex = 5;
            this.buttonNew_student.Text = "New student";
            this.buttonNew_student.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNew_student.UseVisualStyleBackColor = false;
            this.buttonNew_student.Click += new System.EventHandler(this.buttonNew_student_Click);
            // 
            // buttonManage_rooms
            // 
            this.buttonManage_rooms.BackColor = System.Drawing.Color.Magenta;
            this.buttonManage_rooms.ForeColor = System.Drawing.Color.Blue;
            this.buttonManage_rooms.Image = ((System.Drawing.Image)(resources.GetObject("buttonManage_rooms.Image")));
            this.buttonManage_rooms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonManage_rooms.Location = new System.Drawing.Point(0, 61);
            this.buttonManage_rooms.Name = "buttonManage_rooms";
            this.buttonManage_rooms.Size = new System.Drawing.Size(114, 31);
            this.buttonManage_rooms.TabIndex = 3;
            this.buttonManage_rooms.Text = "Manage rooms";
            this.buttonManage_rooms.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonManage_rooms.UseVisualStyleBackColor = false;
            this.buttonManage_rooms.Click += new System.EventHandler(this.buttonManage_rooms_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(226, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(805, 498);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAllemployees
            // 
            this.buttonAllemployees.BackColor = System.Drawing.Color.Magenta;
            this.buttonAllemployees.ForeColor = System.Drawing.Color.Blue;
            this.buttonAllemployees.Location = new System.Drawing.Point(3, 270);
            this.buttonAllemployees.Name = "buttonAllemployees";
            this.buttonAllemployees.Size = new System.Drawing.Size(105, 23);
            this.buttonAllemployees.TabIndex = 14;
            this.buttonAllemployees.Text = "All Employees";
            this.buttonAllemployees.UseVisualStyleBackColor = false;
            this.buttonAllemployees.Click += new System.EventHandler(this.buttonAllemployees_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(945, 505);
            this.Controls.Add(this.buttonAllemployees);
            this.Controls.Add(this.buttonAllRooms);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonLog_out);
            this.Controls.Add(this.buttonEmployees);
            this.Controls.Add(this.buttonAll_students);
            this.Controls.Add(this.buttonStudentFees);
            this.Controls.Add(this.buttonUpdate_delete);
            this.Controls.Add(this.buttonNew_student);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonManage_rooms);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.Text = " ";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonManage_rooms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonNew_student;
        private System.Windows.Forms.Button buttonUpdate_delete;
        private System.Windows.Forms.Button buttonStudentFees;
        private System.Windows.Forms.Button buttonAll_students;
        private System.Windows.Forms.Button buttonEmployees;
        private System.Windows.Forms.Button buttonLog_out;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonAllRooms;
        private System.Windows.Forms.Button buttonAllemployees;
    }
}