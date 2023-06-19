namespace LoginApp
{
    partial class Main
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
            this.lbluserid = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblconfirmpass = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtuserid = new System.Windows.Forms.TextBox();
            this.txtconfirmpass = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.cboxsecurity = new System.Windows.Forms.ComboBox();
            this.txtsecurityanswer = new System.Windows.Forms.TextBox();
            this.lboxuserid = new System.Windows.Forms.ListBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.lblsecurityq = new System.Windows.Forms.Label();
            this.lblsecuritya = new System.Windows.Forms.Label();
            this.btnremoveuser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbluserid
            // 
            this.lbluserid.AutoSize = true;
            this.lbluserid.Location = new System.Drawing.Point(47, 63);
            this.lbluserid.Name = "lbluserid";
            this.lbluserid.Size = new System.Drawing.Size(43, 13);
            this.lbluserid.TabIndex = 0;
            this.lbluserid.Text = "User ID";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(37, 104);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(53, 13);
            this.lblpassword.TabIndex = 1;
            this.lblpassword.Text = "Password";
            // 
            // lblconfirmpass
            // 
            this.lblconfirmpass.AutoSize = true;
            this.lblconfirmpass.Location = new System.Drawing.Point(21, 146);
            this.lblconfirmpass.Name = "lblconfirmpass";
            this.lblconfirmpass.Size = new System.Drawing.Size(91, 13);
            this.lblconfirmpass.TabIndex = 2;
            this.lblconfirmpass.Text = "Confirm Password";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(130, 101);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(246, 20);
            this.txtpassword.TabIndex = 3;
            // 
            // txtuserid
            // 
            this.txtuserid.Location = new System.Drawing.Point(130, 60);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.Size = new System.Drawing.Size(246, 20);
            this.txtuserid.TabIndex = 2;
            // 
            // txtconfirmpass
            // 
            this.txtconfirmpass.Location = new System.Drawing.Point(130, 142);
            this.txtconfirmpass.Name = "txtconfirmpass";
            this.txtconfirmpass.PasswordChar = '*';
            this.txtconfirmpass.Size = new System.Drawing.Size(246, 20);
            this.txtconfirmpass.TabIndex = 5;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(146, 248);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(100, 36);
            this.btnlogin.TabIndex = 6;
            this.btnlogin.Text = "Log In";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click_1);
            // 
            // cboxsecurity
            // 
            this.cboxsecurity.FormattingEnabled = true;
            this.cboxsecurity.Items.AddRange(new object[] {
            "What is your mother maiden name?",
            "What was your first pet\'s name?",
            "What was the name of the street you grew up on?"});
            this.cboxsecurity.Location = new System.Drawing.Point(130, 183);
            this.cboxsecurity.Name = "cboxsecurity";
            this.cboxsecurity.Size = new System.Drawing.Size(246, 21);
            this.cboxsecurity.TabIndex = 7;
            // 
            // txtsecurityanswer
            // 
            this.txtsecurityanswer.Location = new System.Drawing.Point(130, 219);
            this.txtsecurityanswer.Name = "txtsecurityanswer";
            this.txtsecurityanswer.Size = new System.Drawing.Size(246, 20);
            this.txtsecurityanswer.TabIndex = 8;
            // 
            // lboxuserid
            // 
            this.lboxuserid.FormattingEnabled = true;
            this.lboxuserid.Location = new System.Drawing.Point(404, 60);
            this.lboxuserid.Name = "lboxuserid";
            this.lboxuserid.Size = new System.Drawing.Size(190, 225);
            this.lboxuserid.TabIndex = 9;
            this.lboxuserid.SelectedIndexChanged += new System.EventHandler(this.lboxuserid_SelectedIndexChanged);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(252, 248);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(100, 36);
            this.btnexit.TabIndex = 10;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lblsecurityq
            // 
            this.lblsecurityq.AutoSize = true;
            this.lblsecurityq.Location = new System.Drawing.Point(23, 186);
            this.lblsecurityq.Name = "lblsecurityq";
            this.lblsecurityq.Size = new System.Drawing.Size(90, 13);
            this.lblsecurityq.TabIndex = 11;
            this.lblsecurityq.Text = "Security Question";
            // 
            // lblsecuritya
            // 
            this.lblsecuritya.AutoSize = true;
            this.lblsecuritya.Location = new System.Drawing.Point(47, 222);
            this.lblsecuritya.Name = "lblsecuritya";
            this.lblsecuritya.Size = new System.Drawing.Size(42, 13);
            this.lblsecuritya.TabIndex = 12;
            this.lblsecuritya.Text = "Answer";
            // 
            // btnremoveuser
            // 
            this.btnremoveuser.Enabled = false;
            this.btnremoveuser.Location = new System.Drawing.Point(192, 288);
            this.btnremoveuser.Name = "btnremoveuser";
            this.btnremoveuser.Size = new System.Drawing.Size(112, 23);
            this.btnremoveuser.TabIndex = 13;
            this.btnremoveuser.Text = "Remove User";
            this.btnremoveuser.UseVisualStyleBackColor = true;
            this.btnremoveuser.Visible = false;
            this.btnremoveuser.Click += new System.EventHandler(this.btnremoveuser_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 315);
            this.Controls.Add(this.btnremoveuser);
            this.Controls.Add(this.lblsecuritya);
            this.Controls.Add(this.lblsecurityq);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.lboxuserid);
            this.Controls.Add(this.txtsecurityanswer);
            this.Controls.Add(this.cboxsecurity);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtconfirmpass);
            this.Controls.Add(this.txtuserid);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.lblconfirmpass);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lbluserid);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbluserid;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblconfirmpass;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtuserid;
        private System.Windows.Forms.TextBox txtconfirmpass;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.ComboBox cboxsecurity;
        private System.Windows.Forms.TextBox txtsecurityanswer;
        private System.Windows.Forms.ListBox lboxuserid;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label lblsecurityq;
        private System.Windows.Forms.Label lblsecuritya;
        private System.Windows.Forms.Button btnremoveuser;
    }
}

