
namespace LoginForm
{
    partial class Student_Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Registration));
            f_Name = new System.Windows.Forms.TextBox();
            age = new System.Windows.Forms.TextBox();
            NIC_Number = new System.Windows.Forms.TextBox();
            address = new System.Windows.Forms.TextBox();
            telephone_Number = new System.Windows.Forms.TextBox();
            course = new System.Windows.Forms.TextBox();
            register = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            groupBox4 = new System.Windows.Forms.GroupBox();
            groupBox5 = new System.Windows.Forms.GroupBox();
            groupBox6 = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // f_Name
            // 
            f_Name.Location = new System.Drawing.Point(6, 26);
            f_Name.Name = "f_Name";
            f_Name.Size = new System.Drawing.Size(253, 27);
            f_Name.TabIndex = 6;
            f_Name.TextChanged += f_Name_TextChanged;
            // 
            // age
            // 
            age.Location = new System.Drawing.Point(6, 32);
            age.Name = "age";
            age.Size = new System.Drawing.Size(253, 27);
            age.TabIndex = 7;
            age.TextChanged += age_TextChanged;
            // 
            // NIC_Number
            // 
            NIC_Number.Location = new System.Drawing.Point(6, 32);
            NIC_Number.Name = "NIC_Number";
            NIC_Number.Size = new System.Drawing.Size(253, 27);
            NIC_Number.TabIndex = 8;
            NIC_Number.TextChanged += NIC_Number_TextChanged;
            // 
            // address
            // 
            address.Location = new System.Drawing.Point(6, 26);
            address.Name = "address";
            address.Size = new System.Drawing.Size(253, 27);
            address.TabIndex = 9;
            // 
            // telephone_Number
            // 
            telephone_Number.Location = new System.Drawing.Point(6, 26);
            telephone_Number.Name = "telephone_Number";
            telephone_Number.Size = new System.Drawing.Size(253, 27);
            telephone_Number.TabIndex = 10;
            // 
            // course
            // 
            course.Location = new System.Drawing.Point(6, 26);
            course.Name = "course";
            course.Size = new System.Drawing.Size(259, 27);
            course.TabIndex = 11;
            // 
            // register
            // 
            register.BackColor = System.Drawing.SystemColors.InactiveBorder;
            register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            register.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            register.Location = new System.Drawing.Point(412, 565);
            register.Name = "register";
            register.Size = new System.Drawing.Size(268, 42);
            register.TabIndex = 12;
            register.Text = "Register";
            register.UseVisualStyleBackColor = false;
            register.Click += register_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            groupBox1.Controls.Add(f_Name);
            groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            groupBox1.ForeColor = System.Drawing.Color.OrangeRed;
            groupBox1.Location = new System.Drawing.Point(49, 178);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(271, 83);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Full Name";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            groupBox2.Controls.Add(NIC_Number);
            groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            groupBox2.ForeColor = System.Drawing.Color.OrangeRed;
            groupBox2.Location = new System.Drawing.Point(754, 178);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(265, 83);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "NIC Number";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            groupBox3.Controls.Add(age);
            groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            groupBox3.ForeColor = System.Drawing.Color.OrangeRed;
            groupBox3.Location = new System.Drawing.Point(412, 178);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(268, 83);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Age";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            groupBox4.Controls.Add(address);
            groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            groupBox4.ForeColor = System.Drawing.Color.OrangeRed;
            groupBox4.Location = new System.Drawing.Point(43, 331);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(277, 82);
            groupBox4.TabIndex = 17;
            groupBox4.TabStop = false;
            groupBox4.Text = "Address";
            // 
            // groupBox5
            // 
            groupBox5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            groupBox5.Controls.Add(telephone_Number);
            groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            groupBox5.ForeColor = System.Drawing.Color.OrangeRed;
            groupBox5.Location = new System.Drawing.Point(412, 331);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new System.Drawing.Size(268, 82);
            groupBox5.TabIndex = 19;
            groupBox5.TabStop = false;
            groupBox5.Text = "Telephone Number";
            // 
            // groupBox6
            // 
            groupBox6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            groupBox6.Controls.Add(course);
            groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            groupBox6.ForeColor = System.Drawing.Color.OrangeRed;
            groupBox6.Location = new System.Drawing.Point(748, 331);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new System.Drawing.Size(271, 82);
            groupBox6.TabIndex = 17;
            groupBox6.TabStop = false;
            groupBox6.Text = "Course";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Chocolate;
            label1.Location = new System.Drawing.Point(471, 38);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(276, 62);
            label1.TabIndex = 20;
            label1.Text = "Registration";
            label1.Click += label1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(392, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(73, 65);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(1023, 552);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(68, 55);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(1104, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(62, 62);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // Student_Registration
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.HighlightText;
            ClientSize = new System.Drawing.Size(1178, 649);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(register);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Student_Registration";
            Text = "Student_Registration";
            Load += Student_Registration_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox f_Name;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox NIC_Number;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox telephone_Number;
        private System.Windows.Forms.TextBox course;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}