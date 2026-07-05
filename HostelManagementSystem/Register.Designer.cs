namespace LogReg
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.label1 = new System.Windows.Forms.Label();
            this.signupButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.signup_name = new System.Windows.Forms.TextBox();
            this.signup_adminno = new System.Windows.Forms.TextBox();
            this.signup_pass = new System.Windows.Forms.TextBox();
            this.signup_confirmpass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelLoginhere = new System.Windows.Forms.Label();
            this.signup_showpass = new System.Windows.Forms.CheckBox();
            this.showpass2 = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "GET STARTED TODAY!";
            // 
            // signupButton
            // 
            this.signupButton.BackColor = System.Drawing.Color.Lime;
            this.signupButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signupButton.Location = new System.Drawing.Point(412, 227);
            this.signupButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(100, 35);
            this.signupButton.TabIndex = 3;
            this.signupButton.Text = "Sign up";
            this.signupButton.UseVisualStyleBackColor = false;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(274, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(248, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Admission no";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(215, 198);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Confirm password";
            // 
            // signup_name
            // 
            this.signup_name.Location = new System.Drawing.Point(380, 74);
            this.signup_name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.signup_name.Name = "signup_name";
            this.signup_name.Size = new System.Drawing.Size(132, 23);
            this.signup_name.TabIndex = 8;
            // 
            // signup_adminno
            // 
            this.signup_adminno.Location = new System.Drawing.Point(380, 110);
            this.signup_adminno.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.signup_adminno.Name = "signup_adminno";
            this.signup_adminno.Size = new System.Drawing.Size(132, 23);
            this.signup_adminno.TabIndex = 9;
            // 
            // signup_pass
            // 
            this.signup_pass.Location = new System.Drawing.Point(380, 151);
            this.signup_pass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.signup_pass.Name = "signup_pass";
            this.signup_pass.PasswordChar = '8';
            this.signup_pass.Size = new System.Drawing.Size(132, 23);
            this.signup_pass.TabIndex = 10;
            // 
            // signup_confirmpass
            // 
            this.signup_confirmpass.Location = new System.Drawing.Point(380, 198);
            this.signup_confirmpass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.signup_confirmpass.Name = "signup_confirmpass";
            this.signup_confirmpass.PasswordChar = '8';
            this.signup_confirmpass.Size = new System.Drawing.Size(132, 23);
            this.signup_confirmpass.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(333, 47);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fill the details below to sign up";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(335, 291);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Already a member?";
            // 
            // labelLoginhere
            // 
            this.labelLoginhere.AutoSize = true;
            this.labelLoginhere.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginhere.Location = new System.Drawing.Point(474, 288);
            this.labelLoginhere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoginhere.Name = "labelLoginhere";
            this.labelLoginhere.Size = new System.Drawing.Size(92, 18);
            this.labelLoginhere.TabIndex = 14;
            this.labelLoginhere.Text = "Log in here";
            this.labelLoginhere.Click += new System.EventHandler(this.label9_Click);
            // 
            // signup_showpass
            // 
            this.signup_showpass.AutoSize = true;
            this.signup_showpass.BackColor = System.Drawing.Color.White;
            this.signup_showpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_showpass.Location = new System.Drawing.Point(520, 155);
            this.signup_showpass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.signup_showpass.Name = "signup_showpass";
            this.signup_showpass.Size = new System.Drawing.Size(114, 19);
            this.signup_showpass.TabIndex = 16;
            this.signup_showpass.Text = "Show Password";
            this.signup_showpass.UseVisualStyleBackColor = false;
            this.signup_showpass.CheckedChanged += new System.EventHandler(this.signup_showpass_CheckedChanged);
            // 
            // showpass2
            // 
            this.showpass2.AutoSize = true;
            this.showpass2.BackColor = System.Drawing.Color.White;
            this.showpass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showpass2.Location = new System.Drawing.Point(520, 202);
            this.showpass2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.showpass2.Name = "showpass2";
            this.showpass2.Size = new System.Drawing.Size(114, 19);
            this.showpass2.TabIndex = 17;
            this.showpass2.Text = "Show Password";
            this.showpass2.UseVisualStyleBackColor = false;
            this.showpass2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(908, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 23);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1064, 510);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showpass2);
            this.Controls.Add(this.signup_showpass);
            this.Controls.Add(this.labelLoginhere);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.signup_confirmpass);
            this.Controls.Add(this.signup_pass);
            this.Controls.Add(this.signup_adminno);
            this.Controls.Add(this.signup_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Register";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox signup_name;
        private System.Windows.Forms.TextBox signup_adminno;
        private System.Windows.Forms.TextBox signup_pass;
        private System.Windows.Forms.TextBox signup_confirmpass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelLoginhere;
        private System.Windows.Forms.CheckBox signup_showpass;
        private System.Windows.Forms.CheckBox showpass2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
    }
}