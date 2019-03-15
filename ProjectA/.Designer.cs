namespace ProjectA
{
    partial class frmPersonInformation
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
            this.txtPFName = new System.Windows.Forms.TextBox();
            this.txtPLname = new System.Windows.Forms.TextBox();
            this.txtPContact = new System.Windows.Forms.TextBox();
            this.txtPEmail = new System.Windows.Forms.TextBox();
            this.dtPDoB = new System.Windows.Forms.DateTimePicker();
            this.cmdPGender = new System.Windows.Forms.ComboBox();
            this.PFname = new System.Windows.Forms.Label();
            this.PLname = new System.Windows.Forms.Label();
            this.PContact = new System.Windows.Forms.Label();
            this.PEmail = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblViewAll = new System.Windows.Forms.LinkLabel();
            this.lblHome = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtPFName
            // 
            this.txtPFName.Location = new System.Drawing.Point(261, 60);
            this.txtPFName.Name = "txtPFName";
            this.txtPFName.Size = new System.Drawing.Size(182, 20);
            this.txtPFName.TabIndex = 0;
            // 
            // txtPLname
            // 
            this.txtPLname.Location = new System.Drawing.Point(261, 105);
            this.txtPLname.Name = "txtPLname";
            this.txtPLname.Size = new System.Drawing.Size(182, 20);
            this.txtPLname.TabIndex = 1;
            // 
            // txtPContact
            // 
            this.txtPContact.Location = new System.Drawing.Point(261, 143);
            this.txtPContact.Name = "txtPContact";
            this.txtPContact.Size = new System.Drawing.Size(182, 20);
            this.txtPContact.TabIndex = 2;
            // 
            // txtPEmail
            // 
            this.txtPEmail.Location = new System.Drawing.Point(261, 185);
            this.txtPEmail.Name = "txtPEmail";
            this.txtPEmail.Size = new System.Drawing.Size(182, 20);
            this.txtPEmail.TabIndex = 3;
            // 
            // dtPDoB
            // 
            this.dtPDoB.Location = new System.Drawing.Point(261, 225);
            this.dtPDoB.Name = "dtPDoB";
            this.dtPDoB.Size = new System.Drawing.Size(182, 20);
            this.dtPDoB.TabIndex = 4;
            // 
            // cmdPGender
            // 
            this.cmdPGender.FormattingEnabled = true;
            this.cmdPGender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.cmdPGender.Location = new System.Drawing.Point(261, 266);
            this.cmdPGender.Name = "cmdPGender";
            this.cmdPGender.Size = new System.Drawing.Size(182, 21);
            this.cmdPGender.TabIndex = 5;
            // 
            // PFname
            // 
            this.PFname.AutoSize = true;
            this.PFname.Location = new System.Drawing.Point(116, 63);
            this.PFname.Name = "PFname";
            this.PFname.Size = new System.Drawing.Size(57, 13);
            this.PFname.TabIndex = 6;
            this.PFname.Text = "First Name";
            // 
            // PLname
            // 
            this.PLname.AutoSize = true;
            this.PLname.Location = new System.Drawing.Point(115, 108);
            this.PLname.Name = "PLname";
            this.PLname.Size = new System.Drawing.Size(58, 13);
            this.PLname.TabIndex = 7;
            this.PLname.Text = "Last Name";
            // 
            // PContact
            // 
            this.PContact.AutoSize = true;
            this.PContact.Location = new System.Drawing.Point(116, 146);
            this.PContact.Name = "PContact";
            this.PContact.Size = new System.Drawing.Size(80, 13);
            this.PContact.TabIndex = 8;
            this.PContact.Text = "Person Contact";
            // 
            // PEmail
            // 
            this.PEmail.AutoSize = true;
            this.PEmail.Location = new System.Drawing.Point(116, 188);
            this.PEmail.Name = "PEmail";
            this.PEmail.Size = new System.Drawing.Size(73, 13);
            this.PEmail.TabIndex = 9;
            this.PEmail.Text = "Email Address";
            // 
            // txtDOB
            // 
            this.txtDOB.AutoSize = true;
            this.txtDOB.Location = new System.Drawing.Point(116, 231);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(66, 13);
            this.txtDOB.TabIndex = 10;
            this.txtDOB.Text = "Date of Birth";
            // 
            // txtGender
            // 
            this.txtGender.AutoSize = true;
            this.txtGender.Location = new System.Drawing.Point(116, 269);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(42, 13);
            this.txtGender.TabIndex = 11;
            this.txtGender.Text = "Gender";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(368, 312);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblViewAll
            // 
            this.lblViewAll.AutoSize = true;
            this.lblViewAll.Location = new System.Drawing.Point(12, 60);
            this.lblViewAll.Name = "lblViewAll";
            this.lblViewAll.Size = new System.Drawing.Size(44, 13);
            this.lblViewAll.TabIndex = 13;
            this.lblViewAll.TabStop = true;
            this.lblViewAll.Text = "View All";
            this.lblViewAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblViewAll_LinkClicked);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Location = new System.Drawing.Point(12, 9);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(35, 13);
            this.lblHome.TabIndex = 14;
            this.lblHome.TabStop = true;
            this.lblHome.Text = "Home";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 31);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(101, 13);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Group CreationDate";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmPersonInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 351);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.lblViewAll);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.PEmail);
            this.Controls.Add(this.PContact);
            this.Controls.Add(this.PLname);
            this.Controls.Add(this.PFname);
            this.Controls.Add(this.cmdPGender);
            this.Controls.Add(this.dtPDoB);
            this.Controls.Add(this.txtPEmail);
            this.Controls.Add(this.txtPContact);
            this.Controls.Add(this.txtPLname);
            this.Controls.Add(this.txtPFName);
            this.Name = "frmPersonInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person Information";
            this.Load += new System.EventHandler(this.frmPersonInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPFName;
        private System.Windows.Forms.TextBox txtPLname;
        private System.Windows.Forms.TextBox txtPContact;
        private System.Windows.Forms.TextBox txtPEmail;
        private System.Windows.Forms.DateTimePicker dtPDoB;
        private System.Windows.Forms.ComboBox cmdPGender;
        private System.Windows.Forms.Label PFname;
        private System.Windows.Forms.Label PLname;
        private System.Windows.Forms.Label PContact;
        private System.Windows.Forms.Label PEmail;
        private System.Windows.Forms.Label txtDOB;
        private System.Windows.Forms.Label txtGender;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.LinkLabel lblViewAll;
        private System.Windows.Forms.LinkLabel lblHome;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

