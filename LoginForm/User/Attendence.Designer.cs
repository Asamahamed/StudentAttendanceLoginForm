
namespace Macro_Institute_Project
{
    partial class Attendence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendence));
            btnAttendence = new System.Windows.Forms.Button();
            stdID = new System.Windows.Forms.TextBox();
            time = new System.Windows.Forms.TextBox();
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnAttendence
            // 
            btnAttendence.BackColor = System.Drawing.SystemColors.InactiveBorder;
            btnAttendence.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            btnAttendence.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            btnAttendence.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAttendence.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnAttendence.Location = new System.Drawing.Point(405, 458);
            btnAttendence.Name = "btnAttendence";
            btnAttendence.Size = new System.Drawing.Size(264, 61);
            btnAttendence.TabIndex = 2;
            btnAttendence.Text = "Mark Attendence";
            btnAttendence.UseVisualStyleBackColor = false;
            btnAttendence.Click += btnAttendence_Click;
            // 
            // stdID
            // 
            stdID.Location = new System.Drawing.Point(6, 35);
            stdID.Name = "stdID";
            stdID.Size = new System.Drawing.Size(238, 27);
            stdID.TabIndex = 3;
            stdID.TextChanged += stdID_TextChanged;
            // 
            // time
            // 
            time.Location = new System.Drawing.Point(6, 35);
            time.Name = "time";
            time.Size = new System.Drawing.Size(238, 27);
            time.TabIndex = 4;
            time.TextChanged += time_TextChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new System.Drawing.Point(103, 35);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new System.Drawing.Size(10, 27);
            dateTimePicker2.TabIndex = 5;
            dateTimePicker2.Value = new System.DateTime(2021, 9, 28, 9, 49, 31, 0);
            dateTimePicker2.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(stdID);
            groupBox1.Location = new System.Drawing.Point(405, 201);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(250, 89);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Id";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(time);
            groupBox2.Controls.Add(dateTimePicker2);
            groupBox2.Location = new System.Drawing.Point(405, 336);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(250, 89);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Time";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Chocolate;
            label1.Location = new System.Drawing.Point(501, 52);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(228, 54);
            label1.TabIndex = 10;
            label1.Text = "Attendence";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(414, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(95, 84);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(1067, 562);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(82, 62);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
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
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // Attendence
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.HighlightText;
            ClientSize = new System.Drawing.Size(1182, 653);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnAttendence);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Attendence";
            Text = "Attendence";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnAttendence;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.TextBox stdID;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}