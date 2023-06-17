
namespace LoginForm
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            password = new System.Windows.Forms.TextBox();
            btnLogin = new System.Windows.Forms.Button();
            userName = new System.Windows.Forms.TextBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // password
            // 
            password.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            password.Location = new System.Drawing.Point(139, 97);
            password.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            password.Multiline = true;
            password.Name = "password";
            password.PlaceholderText = "password";
            password.Size = new System.Drawing.Size(250, 27);
            password.TabIndex = 4;
            password.TextChanged += textBox2_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = System.Drawing.SystemColors.Highlight;
            btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnLogin.ForeColor = System.Drawing.Color.Snow;
            btnLogin.Location = new System.Drawing.Point(139, 143);
            btnLogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(250, 46);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Sign in";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // userName
            // 
            userName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            userName.Location = new System.Drawing.Point(139, 49);
            userName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            userName.Multiline = true;
            userName.Name = "userName";
            userName.PlaceholderText = "User Name";
            userName.Size = new System.Drawing.Size(250, 30);
            userName.TabIndex = 3;
            userName.TextChanged += userName_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(423, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(68, 69);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Chocolate;
            label1.Location = new System.Drawing.Point(497, 93);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(115, 45);
            label1.TabIndex = 6;
            label1.Text = "Login";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(userName);
            groupBox1.Controls.Add(password);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Location = new System.Drawing.Point(266, 188);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(527, 228);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.HighlightText;
            ClientSize = new System.Drawing.Size(1182, 653);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Login Form";
            TransparencyKey = System.Drawing.Color.DimGray;
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

