namespace New_Mars_Tech
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnlLogin = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.admissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAdmissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upgradeSemesterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teachersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTeachersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "COLLEGE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "MANAGEMENT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(288, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 43);
            this.label3.TabIndex = 2;
            this.label3.Text = "SYSTEM";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnlLogin);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(536, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 167);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(132, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 35);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnlLogin
            // 
            this.btnlLogin.Location = new System.Drawing.Point(230, 127);
            this.btnlLogin.Name = "btnlLogin";
            this.btnlLogin.Size = new System.Drawing.Size(75, 23);
            this.btnlLogin.TabIndex = 4;
            this.btnlLogin.Text = "Login";
            this.btnlLogin.UseVisualStyleBackColor = true;
            this.btnlLogin.Click += new System.EventHandler(this.btnlLogin_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(209, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(117, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(209, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Username";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // admissionToolStripMenuItem
            // 
            this.admissionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAdmissionToolStripMenuItem,
            this.upgradeSemesterToolStripMenuItem});
            this.admissionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("admissionToolStripMenuItem.Image")));
            this.admissionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.admissionToolStripMenuItem.Name = "admissionToolStripMenuItem";
            this.admissionToolStripMenuItem.Size = new System.Drawing.Size(75, 79);
            this.admissionToolStripMenuItem.Text = "Admission";
            this.admissionToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.admissionToolStripMenuItem.Click += new System.EventHandler(this.admissionToolStripMenuItem_Click);
            // 
            // newAdmissionToolStripMenuItem
            // 
            this.newAdmissionToolStripMenuItem.Name = "newAdmissionToolStripMenuItem";
            this.newAdmissionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newAdmissionToolStripMenuItem.Text = "New Admission";
            this.newAdmissionToolStripMenuItem.Click += new System.EventHandler(this.newAdmissionToolStripMenuItem_Click);
            // 
            // upgradeSemesterToolStripMenuItem
            // 
            this.upgradeSemesterToolStripMenuItem.Name = "upgradeSemesterToolStripMenuItem";
            this.upgradeSemesterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.upgradeSemesterToolStripMenuItem.Text = "Upgrade Semester";
            this.upgradeSemesterToolStripMenuItem.Click += new System.EventHandler(this.upgradeSemesterToolStripMenuItem_Click);
            // 
            // feesToolStripMenuItem
            // 
            this.feesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("feesToolStripMenuItem.Image")));
            this.feesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.feesToolStripMenuItem.Name = "feesToolStripMenuItem";
            this.feesToolStripMenuItem.Size = new System.Drawing.Size(72, 79);
            this.feesToolStripMenuItem.Text = "Fees";
            this.feesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.feesToolStripMenuItem.Click += new System.EventHandler(this.feesToolStripMenuItem_Click);
            // 
            // studentDetailsToolStripMenuItem
            // 
            this.studentDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchStudentToolStripMenuItem,
            this.indiToolStripMenuItem});
            this.studentDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("studentDetailsToolStripMenuItem.Image")));
            this.studentDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.studentDetailsToolStripMenuItem.Name = "studentDetailsToolStripMenuItem";
            this.studentDetailsToolStripMenuItem.Size = new System.Drawing.Size(98, 79);
            this.studentDetailsToolStripMenuItem.Text = "Student Details";
            this.studentDetailsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.studentDetailsToolStripMenuItem.Click += new System.EventHandler(this.studentDetailsToolStripMenuItem_Click);
            // 
            // searchStudentToolStripMenuItem
            // 
            this.searchStudentToolStripMenuItem.Name = "searchStudentToolStripMenuItem";
            this.searchStudentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchStudentToolStripMenuItem.Text = "Search Student";
            this.searchStudentToolStripMenuItem.Click += new System.EventHandler(this.searchStudentToolStripMenuItem_Click);
            // 
            // indiToolStripMenuItem
            // 
            this.indiToolStripMenuItem.Name = "indiToolStripMenuItem";
            this.indiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.indiToolStripMenuItem.Text = "Individual Details";
            this.indiToolStripMenuItem.Click += new System.EventHandler(this.indiToolStripMenuItem_Click);
            // 
            // teachersToolStripMenuItem
            // 
            this.teachersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTeachersToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.teachersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("teachersToolStripMenuItem.Image")));
            this.teachersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.teachersToolStripMenuItem.Name = "teachersToolStripMenuItem";
            this.teachersToolStripMenuItem.Size = new System.Drawing.Size(72, 79);
            this.teachersToolStripMenuItem.Text = "Teachers";
            this.teachersToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // addTeachersToolStripMenuItem
            // 
            this.addTeachersToolStripMenuItem.Name = "addTeachersToolStripMenuItem";
            this.addTeachersToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.addTeachersToolStripMenuItem.Text = "Add Teachers Information";
            this.addTeachersToolStripMenuItem.Click += new System.EventHandler(this.addTeachersToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem8.Image")));
            this.toolStripMenuItem8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(106, 79);
            this.toolStripMenuItem8.Text = "Remove Student";
            this.toolStripMenuItem8.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutUsToolStripMenuItem.Image")));
            this.aboutUsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(72, 79);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            this.aboutUsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // exitSystemToolStripMenuItem
            // 
            this.exitSystemToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitSystemToolStripMenuItem.Image")));
            this.exitSystemToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitSystemToolStripMenuItem.Name = "exitSystemToolStripMenuItem";
            this.exitSystemToolStripMenuItem.Size = new System.Drawing.Size(79, 79);
            this.exitSystemToolStripMenuItem.Text = "Exit System";
            this.exitSystemToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.exitSystemToolStripMenuItem.Click += new System.EventHandler(this.exitSystemToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.admissionToolStripMenuItem,
            this.feesToolStripMenuItem,
            this.studentDetailsToolStripMenuItem,
            this.teachersToolStripMenuItem,
            this.toolStripMenuItem8,
            this.aboutUsToolStripMenuItem,
            this.exitSystemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(985, 83);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(985, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnlLogin;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem admissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAdmissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upgradeSemesterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teachersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTeachersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitSystemToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}

