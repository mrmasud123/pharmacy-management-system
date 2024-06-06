namespace Pharmacy
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.billBtn = new System.Windows.Forms.Button();
            this.viewProducts = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.profileBtn = new System.Windows.Forms.Button();
            this.viewuser = new System.Windows.Forms.Button();
            this.adduserBtn = new System.Windows.Forms.Button();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.loginName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bill1 = new Pharmacy.Administrator_gui.bill();
            this.profile1 = new Pharmacy.Administrator_gui.addMedicine();
            this.viewProducts1 = new Pharmacy.Administrator_gui.viewProducts();
            this.viewuser11 = new Pharmacy.Administrator_gui.viewuser1();
            this.adduser1 = new Pharmacy.Administrator_gui.adduser();
            this.administrator_uc1 = new Pharmacy.Administrator_gui.Administrator_uc();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Controls.Add(this.billBtn);
            this.panel1.Controls.Add(this.viewProducts);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.profileBtn);
            this.panel1.Controls.Add(this.viewuser);
            this.panel1.Controls.Add(this.adduserBtn);
            this.panel1.Controls.Add(this.dashboardBtn);
            this.panel1.Controls.Add(this.loginName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 770);
            this.panel1.TabIndex = 1;
            // 
            // billBtn
            // 
            this.billBtn.BackColor = System.Drawing.Color.Red;
            this.billBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.billBtn.FlatAppearance.BorderSize = 0;
            this.billBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.billBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billBtn.ForeColor = System.Drawing.Color.White;
            this.billBtn.Image = ((System.Drawing.Image)(resources.GetObject("billBtn.Image")));
            this.billBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.billBtn.Location = new System.Drawing.Point(28, 469);
            this.billBtn.Name = "billBtn";
            this.billBtn.Size = new System.Drawing.Size(185, 46);
            this.billBtn.TabIndex = 7;
            this.billBtn.Text = "View Bills";
            this.billBtn.UseVisualStyleBackColor = false;
            this.billBtn.Click += new System.EventHandler(this.billBtn_Click);
            // 
            // viewProducts
            // 
            this.viewProducts.BackColor = System.Drawing.Color.Red;
            this.viewProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewProducts.FlatAppearance.BorderSize = 0;
            this.viewProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewProducts.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewProducts.ForeColor = System.Drawing.Color.White;
            this.viewProducts.Image = ((System.Drawing.Image)(resources.GetObject("viewProducts.Image")));
            this.viewProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewProducts.Location = new System.Drawing.Point(28, 417);
            this.viewProducts.Name = "viewProducts";
            this.viewProducts.Size = new System.Drawing.Size(185, 46);
            this.viewProducts.TabIndex = 7;
            this.viewProducts.Text = "View Products";
            this.viewProducts.UseVisualStyleBackColor = false;
            this.viewProducts.Click += new System.EventHandler(this.viewProducts_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(256, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 770);
            this.panel2.TabIndex = 8;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(28, 521);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(185, 46);
            this.button5.TabIndex = 4;
            this.button5.Text = "Log Out";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // profileBtn
            // 
            this.profileBtn.BackColor = System.Drawing.Color.Red;
            this.profileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileBtn.FlatAppearance.BorderSize = 0;
            this.profileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileBtn.ForeColor = System.Drawing.Color.White;
            this.profileBtn.Image = ((System.Drawing.Image)(resources.GetObject("profileBtn.Image")));
            this.profileBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileBtn.Location = new System.Drawing.Point(28, 365);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(185, 46);
            this.profileBtn.TabIndex = 4;
            this.profileBtn.Text = "Add Medicines";
            this.profileBtn.UseVisualStyleBackColor = false;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // viewuser
            // 
            this.viewuser.BackColor = System.Drawing.Color.Red;
            this.viewuser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewuser.FlatAppearance.BorderSize = 0;
            this.viewuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewuser.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewuser.ForeColor = System.Drawing.Color.White;
            this.viewuser.Image = ((System.Drawing.Image)(resources.GetObject("viewuser.Image")));
            this.viewuser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewuser.Location = new System.Drawing.Point(28, 313);
            this.viewuser.Name = "viewuser";
            this.viewuser.Size = new System.Drawing.Size(185, 46);
            this.viewuser.TabIndex = 4;
            this.viewuser.Text = "Manufacturer";
            this.viewuser.UseVisualStyleBackColor = false;
            this.viewuser.Click += new System.EventHandler(this.viewuser_Click);
            // 
            // adduserBtn
            // 
            this.adduserBtn.BackColor = System.Drawing.Color.Red;
            this.adduserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adduserBtn.FlatAppearance.BorderSize = 0;
            this.adduserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adduserBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adduserBtn.ForeColor = System.Drawing.Color.White;
            this.adduserBtn.Image = ((System.Drawing.Image)(resources.GetObject("adduserBtn.Image")));
            this.adduserBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adduserBtn.Location = new System.Drawing.Point(28, 261);
            this.adduserBtn.Name = "adduserBtn";
            this.adduserBtn.Size = new System.Drawing.Size(185, 46);
            this.adduserBtn.TabIndex = 4;
            this.adduserBtn.Text = "Pharmacists";
            this.adduserBtn.UseVisualStyleBackColor = false;
            this.adduserBtn.Click += new System.EventHandler(this.adduserBtn_Click);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackColor = System.Drawing.Color.Red;
            this.dashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardBtn.FlatAppearance.BorderSize = 0;
            this.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.ForeColor = System.Drawing.Color.White;
            this.dashboardBtn.Image = ((System.Drawing.Image)(resources.GetObject("dashboardBtn.Image")));
            this.dashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.Location = new System.Drawing.Point(28, 210);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(185, 46);
            this.dashboardBtn.TabIndex = 4;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.UseVisualStyleBackColor = false;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // loginName
            // 
            this.loginName.AutoSize = true;
            this.loginName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginName.ForeColor = System.Drawing.Color.White;
            this.loginName.Location = new System.Drawing.Point(40, 574);
            this.loginName.Name = "loginName";
            this.loginName.Size = new System.Drawing.Size(173, 22);
            this.loginName.TabIndex = 3;
            this.loginName.Text = "Logged in as Admin";
            this.loginName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Administrator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(54, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(184, 151);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1006, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bill1
            // 
            this.bill1.BackColor = System.Drawing.Color.BlueViolet;
            this.bill1.Location = new System.Drawing.Point(275, 2);
            this.bill1.Name = "bill1";
            this.bill1.Size = new System.Drawing.Size(730, 600);
            this.bill1.TabIndex = 10;
            // 
            // profile1
            // 
            this.profile1.BackColor = System.Drawing.Color.BlueViolet;
            this.profile1.Location = new System.Drawing.Point(275, 2);
            this.profile1.Name = "profile1";
            this.profile1.Size = new System.Drawing.Size(722, 589);
            this.profile1.TabIndex = 7;
            // 
            // viewProducts1
            // 
            this.viewProducts1.BackColor = System.Drawing.Color.BlueViolet;
            this.viewProducts1.Location = new System.Drawing.Point(275, 2);
            this.viewProducts1.Name = "viewProducts1";
            this.viewProducts1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.viewProducts1.Size = new System.Drawing.Size(711, 600);
            this.viewProducts1.TabIndex = 6;
            // 
            // viewuser11
            // 
            this.viewuser11.BackColor = System.Drawing.Color.BlueViolet;
            this.viewuser11.Location = new System.Drawing.Point(275, 2);
            this.viewuser11.Name = "viewuser11";
            this.viewuser11.Size = new System.Drawing.Size(723, 600);
            this.viewuser11.TabIndex = 4;
            // 
            // adduser1
            // 
            this.adduser1.BackColor = System.Drawing.Color.BlueViolet;
            this.adduser1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.adduser1.Location = new System.Drawing.Point(275, 2);
            this.adduser1.Name = "adduser1";
            this.adduser1.Size = new System.Drawing.Size(711, 596);
            this.adduser1.TabIndex = 3;
            // 
            // administrator_uc1
            // 
            this.administrator_uc1.BackColor = System.Drawing.Color.BlueViolet;
            this.administrator_uc1.ForeColor = System.Drawing.Color.White;
            this.administrator_uc1.Location = new System.Drawing.Point(275, 2);
            this.administrator_uc1.Name = "administrator_uc1";
            this.administrator_uc1.Size = new System.Drawing.Size(698, 600);
            this.administrator_uc1.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.adduser1);
            this.Controls.Add(this.administrator_uc1);
            this.Controls.Add(this.viewProducts1);
            this.Controls.Add(this.viewuser11);
            this.Controls.Add(this.bill1);
            this.Controls.Add(this.profile1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button profileBtn;
        private System.Windows.Forms.Button viewuser;
        private System.Windows.Forms.Button adduserBtn;
        private System.Windows.Forms.Button dashboardBtn;
        private Administrator_gui.Administrator_uc administrator_uc1;
        private Administrator_gui.adduser adduser1;
        private Administrator_gui.viewuser1 viewuser11;
        private Administrator_gui.viewProducts viewProducts1;
        private Administrator_gui.addMedicine profile1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label loginName;
        private System.Windows.Forms.Button billBtn;
        private Administrator_gui.bill bill1;
        private System.Windows.Forms.Button viewProducts;
    }
}