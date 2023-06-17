
namespace Macro_Institute_Project.User
{
    partial class userStudentDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userStudentDetails));
            label1 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            showDetails = new System.Windows.Forms.Button();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            srchById = new System.Windows.Forms.Button();
            textBox = new System.Windows.Forms.TextBox();
            btnDelete = new System.Windows.Forms.Button();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Chocolate;
            label1.Location = new System.Drawing.Point(460, 30);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(335, 56);
            label1.TabIndex = 8;
            label1.Text = "Student Details";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(370, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(84, 74);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(41, 145);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(889, 404);
            dataGridView1.TabIndex = 9;
            // 
            // showDetails
            // 
            showDetails.BackColor = System.Drawing.Color.Thistle;
            showDetails.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            showDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            showDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            showDetails.Location = new System.Drawing.Point(945, 249);
            showDetails.Name = "showDetails";
            showDetails.Size = new System.Drawing.Size(197, 101);
            showDetails.TabIndex = 10;
            showDetails.Text = "Show All The details";
            showDetails.UseVisualStyleBackColor = false;
            showDetails.Click += showDetails_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(1038, 562);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(82, 62);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // srchById
            // 
            srchById.BackColor = System.Drawing.Color.LightBlue;
            srchById.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            srchById.Location = new System.Drawing.Point(945, 414);
            srchById.Name = "srchById";
            srchById.Size = new System.Drawing.Size(197, 29);
            srchById.TabIndex = 13;
            srchById.Text = "Search";
            srchById.UseVisualStyleBackColor = false;
            srchById.Click += srchById_Click;
            // 
            // textBox
            // 
            textBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            textBox.Location = new System.Drawing.Point(945, 367);
            textBox.Name = "textBox";
            textBox.PlaceholderText = "ID";
            textBox.Size = new System.Drawing.Size(197, 27);
            textBox.TabIndex = 12;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = System.Drawing.Color.Pink;
            btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDelete.Location = new System.Drawing.Point(945, 475);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(197, 29);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(1108, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(62, 62);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // userStudentDetails
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.HighlightText;
            ClientSize = new System.Drawing.Size(1182, 653);
            Controls.Add(pictureBox3);
            Controls.Add(btnDelete);
            Controls.Add(srchById);
            Controls.Add(textBox);
            Controls.Add(pictureBox2);
            Controls.Add(showDetails);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "userStudentDetails";
            Text = "userStudentDetails";
            Load += userStudentDetails_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button showDetails;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button srchById;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}