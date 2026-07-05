namespace LogReg
{
    partial class Newroom
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Newroom));
            this.labelNewRoom = new System.Windows.Forms.Label();
            this.checkBoxAciveDe = new System.Windows.Forms.CheckBox();
            this.textBox1RoomNO1 = new System.Windows.Forms.TextBox();
            this.labelRoomNumber = new System.Windows.Forms.Label();
            this.labelUpdateRoom = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelActivateDeactivate = new System.Windows.Forms.Label();
            this.textBoxRoomNO2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox2DEACT = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAddRoom = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelroomExist = new System.Windows.Forms.Label();
            this.labelroom = new System.Windows.Forms.Label();
            this.dataGridView1R = new System.Windows.Forms.DataGridView();
            this.functionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNewRoom
            // 
            this.labelNewRoom.AutoSize = true;
            this.labelNewRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelNewRoom.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewRoom.Location = new System.Drawing.Point(-1, 33);
            this.labelNewRoom.MaximumSize = new System.Drawing.Size(200, 200);
            this.labelNewRoom.Name = "labelNewRoom";
            this.labelNewRoom.Size = new System.Drawing.Size(106, 14);
            this.labelNewRoom.TabIndex = 0;
            this.labelNewRoom.Text = "Add New Room";
            // 
            // checkBoxAciveDe
            // 
            this.checkBoxAciveDe.AutoSize = true;
            this.checkBoxAciveDe.Location = new System.Drawing.Point(321, 63);
            this.checkBoxAciveDe.Name = "checkBoxAciveDe";
            this.checkBoxAciveDe.Size = new System.Drawing.Size(47, 17);
            this.checkBoxAciveDe.TabIndex = 1;
            this.checkBoxAciveDe.Text = "YES";
            this.checkBoxAciveDe.UseVisualStyleBackColor = true;
            // 
            // textBox1RoomNO1
            // 
            this.textBox1RoomNO1.Location = new System.Drawing.Point(93, 61);
            this.textBox1RoomNO1.Name = "textBox1RoomNO1";
            this.textBox1RoomNO1.Size = new System.Drawing.Size(64, 20);
            this.textBox1RoomNO1.TabIndex = 2;
            // 
            // labelRoomNumber
            // 
            this.labelRoomNumber.AutoSize = true;
            this.labelRoomNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelRoomNumber.Location = new System.Drawing.Point(12, 64);
            this.labelRoomNumber.Name = "labelRoomNumber";
            this.labelRoomNumber.Size = new System.Drawing.Size(75, 13);
            this.labelRoomNumber.TabIndex = 3;
            this.labelRoomNumber.Text = "Room Number";
            // 
            // labelUpdateRoom
            // 
            this.labelUpdateRoom.AutoSize = true;
            this.labelUpdateRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelUpdateRoom.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdateRoom.Location = new System.Drawing.Point(-1, 127);
            this.labelUpdateRoom.Name = "labelUpdateRoom";
            this.labelUpdateRoom.Size = new System.Drawing.Size(190, 15);
            this.labelUpdateRoom.TabIndex = 4;
            this.labelUpdateRoom.Text = "Update And Delete Room";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(279, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "ALL ROOMS HERE";
            // 
            // labelActivateDeactivate
            // 
            this.labelActivateDeactivate.AutoSize = true;
            this.labelActivateDeactivate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelActivateDeactivate.ForeColor = System.Drawing.Color.Red;
            this.labelActivateDeactivate.Location = new System.Drawing.Point(202, 64);
            this.labelActivateDeactivate.Name = "labelActivateDeactivate";
            this.labelActivateDeactivate.Size = new System.Drawing.Size(113, 13);
            this.labelActivateDeactivate.TabIndex = 6;
            this.labelActivateDeactivate.Text = "Activate or Deactivate";
            // 
            // textBoxRoomNO2
            // 
            this.textBoxRoomNO2.Location = new System.Drawing.Point(93, 152);
            this.textBoxRoomNO2.Name = "textBoxRoomNO2";
            this.textBoxRoomNO2.Size = new System.Drawing.Size(64, 20);
            this.textBoxRoomNO2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(12, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Room Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(266, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Activate or Deactivate";
            // 
            // checkBox2DEACT
            // 
            this.checkBox2DEACT.AutoSize = true;
            this.checkBox2DEACT.Location = new System.Drawing.Point(385, 158);
            this.checkBox2DEACT.Name = "checkBox2DEACT";
            this.checkBox2DEACT.Size = new System.Drawing.Size(47, 17);
            this.checkBox2DEACT.TabIndex = 10;
            this.checkBox2DEACT.Text = "YES";
            this.checkBox2DEACT.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Location = new System.Drawing.Point(2, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 37);
            this.panel1.TabIndex = 11;
            // 
            // buttonAddRoom
            // 
            this.buttonAddRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonAddRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddRoom.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddRoom.Image")));
            this.buttonAddRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddRoom.Location = new System.Drawing.Point(376, 57);
            this.buttonAddRoom.Name = "buttonAddRoom";
            this.buttonAddRoom.Size = new System.Drawing.Size(64, 24);
            this.buttonAddRoom.TabIndex = 13;
            this.buttonAddRoom.Text = "Add Room";
            this.buttonAddRoom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddRoom.UseVisualStyleBackColor = false;
            this.buttonAddRoom.Click += new System.EventHandler(this.buttonAddRoom_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonSearch.Font = new System.Drawing.Font("Modern No. 20", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.Location = new System.Drawing.Point(163, 147);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(97, 28);
            this.buttonSearch.TabIndex = 14;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(594, 214);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(80, 23);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdate.Image")));
            this.buttonUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdate.Location = new System.Drawing.Point(504, 214);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(84, 23);
            this.buttonUpdate.TabIndex = 16;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClose.Location = new System.Drawing.Point(686, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(35, 23);
            this.buttonClose.TabIndex = 17;
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Visible = false;
            this.buttonClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "ADMIN";
            // 
            // labelroomExist
            // 
            this.labelroomExist.AutoSize = true;
            this.labelroomExist.Location = new System.Drawing.Point(111, 45);
            this.labelroomExist.Name = "labelroomExist";
            this.labelroomExist.Size = new System.Drawing.Size(42, 13);
            this.labelroomExist.TabIndex = 19;
            this.labelroomExist.Text = "setText";
            // 
            // labelroom
            // 
            this.labelroom.AutoSize = true;
            this.labelroom.Location = new System.Drawing.Point(110, 175);
            this.labelroom.Name = "labelroom";
            this.labelroom.Size = new System.Drawing.Size(42, 13);
            this.labelroom.TabIndex = 20;
            this.labelroom.Text = "setText";
            // 
            // dataGridView1R
            // 
            this.dataGridView1R.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dataGridView1R.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1R.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1R.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dataGridView1R.Location = new System.Drawing.Point(15, 243);
            this.dataGridView1R.Name = "dataGridView1R";
            this.dataGridView1R.Size = new System.Drawing.Size(642, 195);
            this.dataGridView1R.TabIndex = 21;
            // 
            // functionBindingSource
            // 
            this.functionBindingSource.DataSource = typeof(LogReg.Function);
            // 
            // Newroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.Controls.Add(this.dataGridView1R);
            this.Controls.Add(this.labelroom);
            this.Controls.Add(this.labelroomExist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonAddRoom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox2DEACT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRoomNO2);
            this.Controls.Add(this.labelNewRoom);
            this.Controls.Add(this.labelActivateDeactivate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelUpdateRoom);
            this.Controls.Add(this.labelRoomNumber);
            this.Controls.Add(this.textBox1RoomNO1);
            this.Controls.Add(this.checkBoxAciveDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Newroom";
            this.Text = "Newroom";
            this.Load += new System.EventHandler(this.Newroom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNewRoom;
        private System.Windows.Forms.CheckBox checkBoxAciveDe;
        private System.Windows.Forms.TextBox textBox1RoomNO1;
        private System.Windows.Forms.Label labelRoomNumber;
        private System.Windows.Forms.Label labelUpdateRoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelActivateDeactivate;
        private System.Windows.Forms.TextBox textBoxRoomNO2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox2DEACT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAddRoom;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelroomExist;
        private System.Windows.Forms.Label labelroom;
        private System.Windows.Forms.BindingSource functionBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1R;
    }
}