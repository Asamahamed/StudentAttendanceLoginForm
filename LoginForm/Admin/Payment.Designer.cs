
namespace Macro_Institute_Project.Admin
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            label1 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            stdID = new System.Windows.Forms.TextBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            stdName = new System.Windows.Forms.TextBox();
            groupBox4 = new System.Windows.Forms.GroupBox();
            course = new System.Windows.Forms.TextBox();
            groupBox5 = new System.Windows.Forms.GroupBox();
            courseFee = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Chocolate;
            label1.Location = new System.Drawing.Point(524, 51);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(182, 59);
            label1.TabIndex = 0;
            label1.Text = "Payment";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(421, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(75, 62);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // stdID
            // 
            stdID.Location = new System.Drawing.Point(6, 26);
            stdID.Name = "stdID";
            stdID.Size = new System.Drawing.Size(238, 27);
            stdID.TabIndex = 7;
            stdID.TextChanged += stdID_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(stdID);
            groupBox1.ForeColor = System.Drawing.Color.OrangeRed;
            groupBox1.Location = new System.Drawing.Point(132, 141);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(250, 67);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student ID";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(stdName);
            groupBox2.ForeColor = System.Drawing.Color.OrangeRed;
            groupBox2.Location = new System.Drawing.Point(132, 239);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(250, 67);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Student Name";
            // 
            // stdName
            // 
            stdName.Location = new System.Drawing.Point(6, 26);
            stdName.Name = "stdName";
            stdName.Size = new System.Drawing.Size(238, 27);
            stdName.TabIndex = 7;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(course);
            groupBox4.ForeColor = System.Drawing.Color.OrangeRed;
            groupBox4.Location = new System.Drawing.Point(132, 341);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(250, 69);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "Course";
            // 
            // course
            // 
            course.Location = new System.Drawing.Point(6, 26);
            course.Name = "course";
            course.Size = new System.Drawing.Size(238, 27);
            course.TabIndex = 7;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(courseFee);
            groupBox5.ForeColor = System.Drawing.Color.OrangeRed;
            groupBox5.Location = new System.Drawing.Point(132, 455);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new System.Drawing.Size(250, 68);
            groupBox5.TabIndex = 11;
            groupBox5.TabStop = false;
            groupBox5.Text = "Course Fee";
            // 
            // courseFee
            // 
            courseFee.Location = new System.Drawing.Point(6, 26);
            courseFee.Name = "courseFee";
            courseFee.Size = new System.Drawing.Size(238, 27);
            courseFee.TabIndex = 7;
            courseFee.TextChanged += courseFee_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(128, 255, 128);
            button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(524, 554);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(152, 52);
            button1.TabIndex = 12;
            button1.Text = "Payed";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(1075, 544);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(68, 62);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(1108, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(62, 62);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // Payment
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.HighlightText;
            ClientSize = new System.Drawing.Size(1182, 653);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Payment";
            Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox stdID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox stdName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox course;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox courseFee;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}