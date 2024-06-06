namespace Pharmacy
{
    partial class pharmacist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pharmacist));
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginName = new System.Windows.Forms.Label();
            this.add_medicine1 = new Pharmacy.Pharmacist_gui.add_medicine();
            this.sellMedicine = new System.Windows.Forms.Button();
            this.pharmacistLogout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.modifyMedicine = new System.Windows.Forms.Button();
            this.viewmedicine = new System.Windows.Forms.Button();
            this.addMedicine = new System.Windows.Forms.Button();
            this.pharmacistDashboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pharmacistPanel = new System.Windows.Forms.Panel();
            this.sellMedicine1 = new Pharmacy.Pharmacist_gui.sellMedicine();
            this.modifyMedicine1 = new Pharmacy.Pharmacist_gui.modifyMedicine();
            this.viewMedicine1 = new Pharmacy.Pharmacist_gui.viewMedicine();
            this.add_medicine2 = new Pharmacy.Pharmacist_gui.add_medicine();
            this.pharmacist_dashboard1 = new Pharmacy.Pharmacist_gui.pharmacist_dashboard();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pharmacistPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Controls.Add(this.loginName);
            this.panel1.Controls.Add(this.add_medicine1);
            this.panel1.Controls.Add(this.sellMedicine);
            this.panel1.Controls.Add(this.pharmacistLogout);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.modifyMedicine);
            this.panel1.Controls.Add(this.viewmedicine);
            this.panel1.Controls.Add(this.addMedicine);
            this.panel1.Controls.Add(this.pharmacistDashboard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 770);
            this.panel1.TabIndex = 0;
            // 
            // loginName
            // 
            this.loginName.AutoSize = true;
            this.loginName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginName.ForeColor = System.Drawing.Color.White;
            this.loginName.Location = new System.Drawing.Point(23, 569);
            this.loginName.Name = "loginName";
            this.loginName.Size = new System.Drawing.Size(209, 22);
            this.loginName.TabIndex = 11;
            this.loginName.Text = "Logged in as Pharmacist";
            this.loginName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // add_medicine1
            // 
            this.add_medicine1.BackColor = System.Drawing.Color.BlueViolet;
            this.add_medicine1.Location = new System.Drawing.Point(280, 0);
            this.add_medicine1.Name = "add_medicine1";
            this.add_medicine1.Size = new System.Drawing.Size(723, 600);
            this.add_medicine1.TabIndex = 1;
            // 
            // sellMedicine
            // 
            this.sellMedicine.BackColor = System.Drawing.Color.Red;
            this.sellMedicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sellMedicine.FlatAppearance.BorderSize = 0;
            this.sellMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellMedicine.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellMedicine.ForeColor = System.Drawing.Color.White;
            this.sellMedicine.Image = ((System.Drawing.Image)(resources.GetObject("sellMedicine.Image")));
            this.sellMedicine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sellMedicine.Location = new System.Drawing.Point(33, 467);
            this.sellMedicine.Name = "sellMedicine";
            this.sellMedicine.Size = new System.Drawing.Size(199, 46);
            this.sellMedicine.TabIndex = 1;
            this.sellMedicine.Text = "Sell Medicine";
            this.sellMedicine.UseVisualStyleBackColor = false;
            this.sellMedicine.Click += new System.EventHandler(this.sellMedicine_Click);
            // 
            // pharmacistLogout
            // 
            this.pharmacistLogout.BackColor = System.Drawing.Color.Red;
            this.pharmacistLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pharmacistLogout.FlatAppearance.BorderSize = 0;
            this.pharmacistLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pharmacistLogout.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pharmacistLogout.ForeColor = System.Drawing.Color.White;
            this.pharmacistLogout.Image = ((System.Drawing.Image)(resources.GetObject("pharmacistLogout.Image")));
            this.pharmacistLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pharmacistLogout.Location = new System.Drawing.Point(33, 519);
            this.pharmacistLogout.Name = "pharmacistLogout";
            this.pharmacistLogout.Size = new System.Drawing.Size(199, 46);
            this.pharmacistLogout.TabIndex = 6;
            this.pharmacistLogout.Text = "Log Out";
            this.pharmacistLogout.UseVisualStyleBackColor = false;
            this.pharmacistLogout.Click += new System.EventHandler(this.pharmacistLogout_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(280, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 1;
            // 
            // modifyMedicine
            // 
            this.modifyMedicine.BackColor = System.Drawing.Color.Red;
            this.modifyMedicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modifyMedicine.FlatAppearance.BorderSize = 0;
            this.modifyMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyMedicine.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyMedicine.ForeColor = System.Drawing.Color.White;
            this.modifyMedicine.Image = ((System.Drawing.Image)(resources.GetObject("modifyMedicine.Image")));
            this.modifyMedicine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modifyMedicine.Location = new System.Drawing.Point(33, 415);
            this.modifyMedicine.Name = "modifyMedicine";
            this.modifyMedicine.Size = new System.Drawing.Size(199, 46);
            this.modifyMedicine.TabIndex = 7;
            this.modifyMedicine.Text = "Modify Medicines";
            this.modifyMedicine.UseVisualStyleBackColor = false;
            this.modifyMedicine.Click += new System.EventHandler(this.modifyMedicine_Click);
            // 
            // viewmedicine
            // 
            this.viewmedicine.BackColor = System.Drawing.Color.Red;
            this.viewmedicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewmedicine.FlatAppearance.BorderSize = 0;
            this.viewmedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewmedicine.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewmedicine.ForeColor = System.Drawing.Color.White;
            this.viewmedicine.Image = ((System.Drawing.Image)(resources.GetObject("viewmedicine.Image")));
            this.viewmedicine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewmedicine.Location = new System.Drawing.Point(33, 363);
            this.viewmedicine.Name = "viewmedicine";
            this.viewmedicine.Size = new System.Drawing.Size(199, 46);
            this.viewmedicine.TabIndex = 8;
            this.viewmedicine.Text = "View Bills";
            this.viewmedicine.UseVisualStyleBackColor = false;
            this.viewmedicine.Click += new System.EventHandler(this.viewmedicine_Click);
            // 
            // addMedicine
            // 
            this.addMedicine.BackColor = System.Drawing.Color.Red;
            this.addMedicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addMedicine.FlatAppearance.BorderSize = 0;
            this.addMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMedicine.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMedicine.ForeColor = System.Drawing.Color.White;
            this.addMedicine.Image = ((System.Drawing.Image)(resources.GetObject("addMedicine.Image")));
            this.addMedicine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addMedicine.Location = new System.Drawing.Point(33, 311);
            this.addMedicine.Name = "addMedicine";
            this.addMedicine.Size = new System.Drawing.Size(199, 46);
            this.addMedicine.TabIndex = 9;
            this.addMedicine.Text = "Validity Check";
            this.addMedicine.UseVisualStyleBackColor = false;
            this.addMedicine.Click += new System.EventHandler(this.addMedicine_Click);
            // 
            // pharmacistDashboard
            // 
            this.pharmacistDashboard.BackColor = System.Drawing.Color.Red;
            this.pharmacistDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pharmacistDashboard.FlatAppearance.BorderSize = 0;
            this.pharmacistDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pharmacistDashboard.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pharmacistDashboard.ForeColor = System.Drawing.Color.White;
            this.pharmacistDashboard.Image = ((System.Drawing.Image)(resources.GetObject("pharmacistDashboard.Image")));
            this.pharmacistDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pharmacistDashboard.Location = new System.Drawing.Point(33, 259);
            this.pharmacistDashboard.Name = "pharmacistDashboard";
            this.pharmacistDashboard.Size = new System.Drawing.Size(199, 46);
            this.pharmacistDashboard.TabIndex = 10;
            this.pharmacistDashboard.Text = "Dashboard";
            this.pharmacistDashboard.UseVisualStyleBackColor = false;
            this.pharmacistDashboard.Click += new System.EventHandler(this.pharmacistDashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pharmacist";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(199, 217);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pharmacistPanel
            // 
            this.pharmacistPanel.Controls.Add(this.sellMedicine1);
            this.pharmacistPanel.Controls.Add(this.modifyMedicine1);
            this.pharmacistPanel.Controls.Add(this.viewMedicine1);
            this.pharmacistPanel.Controls.Add(this.add_medicine2);
            this.pharmacistPanel.Controls.Add(this.pharmacist_dashboard1);
            this.pharmacistPanel.Location = new System.Drawing.Point(280, 0);
            this.pharmacistPanel.Name = "pharmacistPanel";
            this.pharmacistPanel.Size = new System.Drawing.Size(723, 600);
            this.pharmacistPanel.TabIndex = 1;
            this.pharmacistPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.pharmacistPanel_Paint);
            // 
            // sellMedicine1
            // 
            this.sellMedicine1.BackColor = System.Drawing.Color.BlueViolet;
            this.sellMedicine1.Location = new System.Drawing.Point(-4, 6);
            this.sellMedicine1.Name = "sellMedicine1";
            this.sellMedicine1.Size = new System.Drawing.Size(730, 591);
            this.sellMedicine1.TabIndex = 4;
            // 
            // modifyMedicine1
            // 
            this.modifyMedicine1.BackColor = System.Drawing.Color.BlueViolet;
            this.modifyMedicine1.Location = new System.Drawing.Point(3, 0);
            this.modifyMedicine1.Name = "modifyMedicine1";
            this.modifyMedicine1.Size = new System.Drawing.Size(723, 600);
            this.modifyMedicine1.TabIndex = 3;
            // 
            // viewMedicine1
            // 
            this.viewMedicine1.BackColor = System.Drawing.Color.BlueViolet;
            this.viewMedicine1.Location = new System.Drawing.Point(0, 0);
            this.viewMedicine1.Name = "viewMedicine1";
            this.viewMedicine1.Size = new System.Drawing.Size(723, 600);
            this.viewMedicine1.TabIndex = 2;
            // 
            // add_medicine2
            // 
            this.add_medicine2.BackColor = System.Drawing.Color.BlueViolet;
            this.add_medicine2.Location = new System.Drawing.Point(3, 3);
            this.add_medicine2.Name = "add_medicine2";
            this.add_medicine2.Size = new System.Drawing.Size(723, 600);
            this.add_medicine2.TabIndex = 1;
            // 
            // pharmacist_dashboard1
            // 
            this.pharmacist_dashboard1.BackColor = System.Drawing.Color.BlueViolet;
            this.pharmacist_dashboard1.Location = new System.Drawing.Point(0, 3);
            this.pharmacist_dashboard1.Name = "pharmacist_dashboard1";
            this.pharmacist_dashboard1.Size = new System.Drawing.Size(723, 600);
            this.pharmacist_dashboard1.TabIndex = 0;
            this.pharmacist_dashboard1.Load += new System.EventHandler(this.pharmacist_dashboard1_Load);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(264, -85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 770);
            this.panel3.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1009, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pharmacist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pharmacistPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pharmacist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pharmacist";
            this.Load += new System.EventHandler(this.pharmacist_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pharmacistPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button viewmedicine;
        private System.Windows.Forms.Button pharmacistDashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pharmacistPanel;
        private System.Windows.Forms.Button pharmacistLogout;
        private System.Windows.Forms.Button sellMedicine;
        private Pharmacist_gui.add_medicine add_medicine1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label loginName;
        private System.Windows.Forms.Button modifyMedicine;
        private Pharmacist_gui.pharmacist_dashboard pharmacist_dashboard1;
        private System.Windows.Forms.Button addMedicine;
        private Pharmacist_gui.sellMedicine sellMedicine1;
        private Pharmacist_gui.modifyMedicine modifyMedicine1;
        private Pharmacist_gui.viewMedicine viewMedicine1;
        private Pharmacist_gui.add_medicine add_medicine2;
    }
}