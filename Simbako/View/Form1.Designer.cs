namespace Simbako
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbUsername = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            lbPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnPetani = new Button();
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            label5 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            lb = new Label();
            btnCustomer = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUsername.ForeColor = SystemColors.ControlLightLight;
            lbUsername.Location = new Point(388, 208);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(99, 23);
            lbUsername.TabIndex = 0;
            lbUsername.Text = "Username :";
            lbUsername.Click += label1_Click;
            // 
            // txtUsername
            // 
            txtUsername.Cursor = Cursors.No;
            txtUsername.Font = new Font("Segoe UI", 15F);
            txtUsername.ForeColor = SystemColors.WindowFrame;
            txtUsername.Location = new Point(388, 234);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(421, 41);
            txtUsername.TabIndex = 1;
            txtUsername.Tag = "";
            txtUsername.TextAlign = HorizontalAlignment.Center;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 2;
            label2.Click += label2_Click;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPassword.ForeColor = SystemColors.ControlLightLight;
            lbPassword.Location = new Point(388, 279);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(95, 23);
            lbPassword.TabIndex = 3;
            lbPassword.Text = "Password :";
            lbPassword.Click += lbPassword_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Window;
            txtPassword.Font = new Font("Segoe UI", 15F);
            txtPassword.ForeColor = SystemColors.WindowFrame;
            txtPassword.Location = new Point(388, 305);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(421, 41);
            txtPassword.TabIndex = 4;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ControlText;
            btnLogin.Image = (Image)resources.GetObject("btnLogin.Image");
            btnLogin.Location = new Point(388, 352);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(421, 57);
            btnLogin.TabIndex = 5;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnPetani
            // 
            btnPetani.BackColor = Color.Transparent;
            btnPetani.BackgroundImage = (Image)resources.GetObject("btnPetani.BackgroundImage");
            btnPetani.BackgroundImageLayout = ImageLayout.None;
            btnPetani.FlatAppearance.BorderSize = 0;
            btnPetani.FlatStyle = FlatStyle.Flat;
            btnPetani.ForeColor = SystemColors.AppWorkspace;
            btnPetani.Location = new Point(361, 150);
            btnPetani.Name = "btnPetani";
            btnPetani.Size = new Size(138, 39);
            btnPetani.TabIndex = 6;
            btnPetani.UseVisualStyleBackColor = false;
            btnPetani.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.AccessibleDescription = "";
            panel1.AccessibleRole = AccessibleRole.None;
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(lbUsername);
            panel1.Controls.Add(lbPassword);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lb);
            panel1.Controls.Add(btnPetani);
            panel1.Controls.Add(btnCustomer);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(txtPassword);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(3, 186);
            panel1.Name = "panel1";
            panel1.Size = new Size(1176, 455);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Center;
            pictureBox5.Enabled = false;
            pictureBox5.ErrorImage = null;
            pictureBox5.InitialImage = null;
            pictureBox5.Location = new Point(560, 59);
            pictureBox5.Margin = new Padding(0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(75, 75);
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            pictureBox5.UseWaitCursor = true;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(505, 15);
            label5.Name = "label5";
            label5.Size = new Size(186, 35);
            label5.TabIndex = 13;
            label5.Text = "Login Sebagai:";
            label5.TextAlign = ContentAlignment.TopCenter;
            label5.Click += label5_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImageLayout = ImageLayout.None;
            pictureBox4.Enabled = false;
            pictureBox4.ErrorImage = null;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.InitialImage = null;
            pictureBox4.Location = new Point(505, 148);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(184, 44);
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            pictureBox4.UseWaitCursor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Enabled = false;
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(-72, 234);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(271, 261);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            pictureBox2.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Image = Properties.Resources.Admin_button;
            label1.Location = new Point(543, 168);
            label1.Name = "label1";
            label1.Size = new Size(0, 23);
            label1.TabIndex = 6;
            label1.Click += label1_Click_2;
            // 
            // lb
            // 
            lb.AutoSize = true;
            lb.Font = new Font("Segoe UI Light", 7F, FontStyle.Italic);
            lb.ForeColor = SystemColors.ButtonShadow;
            lb.Location = new Point(245, 439);
            lb.Name = "lb";
            lb.Size = new Size(262, 15);
            lb.TabIndex = 6;
            lb.Text = "© 2026 SIMBAKO · Sistem Pengelolahan Tembakau";
            lb.Click += label1_Click_1;
            // 
            // btnCustomer
            // 
            btnCustomer.AutoEllipsis = true;
            btnCustomer.BackColor = Color.Transparent;
            btnCustomer.BackgroundImage = (Image)resources.GetObject("btnCustomer.BackgroundImage");
            btnCustomer.BackgroundImageLayout = ImageLayout.Center;
            btnCustomer.FlatAppearance.BorderSize = 0;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.ForeColor = SystemColors.ControlDark;
            btnCustomer.ImageAlign = ContentAlignment.MiddleRight;
            btnCustomer.Location = new Point(695, 148);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.RightToLeft = RightToLeft.No;
            btnCustomer.Size = new Size(140, 43);
            btnCustomer.TabIndex = 8;
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Enabled = false;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(553, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 89);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 37.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(437, 79);
            label3.Name = "label3";
            label3.Size = new Size(313, 84);
            label3.TabIndex = 9;
            label3.Text = "SIMBAKO";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Variable Display", 14F);
            label4.ForeColor = Color.LightGreen;
            label4.Location = new Point(391, 151);
            label4.Name = "label4";
            label4.Size = new Size(399, 32);
            label4.TabIndex = 10;
            label4.Text = "SISTEM PENGELOLAHAN TEMBAKAU";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Enabled = false;
            pictureBox3.ErrorImage = null;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.InitialImage = null;
            pictureBox3.Location = new Point(985, 40);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(271, 261);
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            pictureBox3.UseWaitCursor = true;
            // 
            // Form1
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.DarkOliveGreen;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            CausesValidation = false;
            ClientSize = new Size(1182, 653);
            Controls.Add(label4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label3);
            DoubleBuffered = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SIMBAKO - Login Admin";
            Load += Form1_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUsername;
        private TextBox txtUsername;
        private Label label2;
        private Label lbPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnPetani;
        private Panel panel1;
        private Button btnCustomer;
        private Label lb;
        private Label label1;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}
