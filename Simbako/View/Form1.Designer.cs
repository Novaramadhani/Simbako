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
            btnCustomer = new Button();
            lb = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUsername.Location = new Point(3, 24);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(99, 23);
            lbUsername.TabIndex = 0;
            lbUsername.Text = "Username :";
            lbUsername.Click += label1_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(108, 24);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(514, 27);
            txtUsername.TabIndex = 1;
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
            lbPassword.Location = new Point(7, 73);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(95, 23);
            lbPassword.TabIndex = 3;
            lbPassword.Text = "Password :";
            lbPassword.Click += lbPassword_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.AliceBlue;
            txtPassword.Location = new Point(108, 73);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(514, 27);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkSeaGreen;
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(528, 112);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnPetani
            // 
            btnPetani.Location = new Point(165, 312);
            btnPetani.Name = "btnPetani";
            btnPetani.Size = new Size(168, 29);
            btnPetani.TabIndex = 6;
            btnPetani.Text = "Masuk sebagai petani";
            btnPetani.UseVisualStyleBackColor = true;
            btnPetani.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(lbUsername);
            panel1.Controls.Add(lbPassword);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(txtPassword);
            panel1.Location = new Point(17, 111);
            panel1.Name = "panel1";
            panel1.Size = new Size(653, 248);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // btnCustomer
            // 
            btnCustomer.Location = new Point(339, 312);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(181, 29);
            btnCustomer.TabIndex = 8;
            btnCustomer.Text = "Masuk sebagai customer";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // lb
            // 
            lb.AutoSize = true;
            lb.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lb.Location = new Point(253, 275);
            lb.Name = "lb";
            lb.Size = new Size(177, 23);
            lb.TabIndex = 6;
            lb.Text = "- atau masuk sebagai -";
            lb.Click += label1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 85);
            label1.Name = "label1";
            label1.Size = new Size(114, 23);
            label1.TabIndex = 6;
            label1.Text = "Login Admin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(227, -4);
            label3.Name = "label3";
            label3.Size = new Size(242, 62);
            label3.TabIndex = 9;
            label3.Text = "SIMBAKO";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.YellowGreen;
            label4.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(219, 59);
            label4.Name = "label4";
            label4.Size = new Size(250, 20);
            label4.TabIndex = 10;
            label4.Text = "SISTEM PENGELOLAHAN TEMBAKAU";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
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
            ClientSize = new Size(682, 353);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lb);
            Controls.Add(btnCustomer);
            Controls.Add(btnPetani);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SIMBAKO - Login Admin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}
