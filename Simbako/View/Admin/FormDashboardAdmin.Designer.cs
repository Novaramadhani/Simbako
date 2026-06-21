namespace Simbako
{
    partial class FormDashboardAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboardAdmin));
            menuStrip1 = new MenuStrip();
            panenToolStripMenuItem = new ToolStripMenuItem();
            produksiToolStripMenuItem = new ToolStripMenuItem();
            produkToolStripMenuItem = new ToolStripMenuItem();
            penjualanToolStripMenuItem = new ToolStripMenuItem();
            laporanToolStripMenuItem = new ToolStripMenuItem();
            keluarToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            btnKeluar = new Button();
            pictureBox5 = new PictureBox();
            panel3 = new Panel();
            panel2 = new Panel();
            label10 = new Label();
            label8 = new Label();
            label12 = new Label();
            panel1 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Green;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { panenToolStripMenuItem, produksiToolStripMenuItem, produkToolStripMenuItem, penjualanToolStripMenuItem, laporanToolStripMenuItem, keluarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(944, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // panenToolStripMenuItem
            // 
            panenToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panenToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            panenToolStripMenuItem.Name = "panenToolStripMenuItem";
            panenToolStripMenuItem.Size = new Size(66, 24);
            panenToolStripMenuItem.Text = "Panen";
            panenToolStripMenuItem.Click += panenToolStripMenuItem_Click;
            // 
            // produksiToolStripMenuItem
            // 
            produksiToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            produksiToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            produksiToolStripMenuItem.Name = "produksiToolStripMenuItem";
            produksiToolStripMenuItem.Size = new Size(84, 24);
            produksiToolStripMenuItem.Text = "Produksi";
            produksiToolStripMenuItem.Click += produksiToolStripMenuItem_Click;
            // 
            // produkToolStripMenuItem
            // 
            produkToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            produkToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            produkToolStripMenuItem.Name = "produkToolStripMenuItem";
            produkToolStripMenuItem.Size = new Size(73, 24);
            produkToolStripMenuItem.Text = "Produk";
            produkToolStripMenuItem.Click += produkToolStripMenuItem_Click;
            // 
            // penjualanToolStripMenuItem
            // 
            penjualanToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            penjualanToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            penjualanToolStripMenuItem.Name = "penjualanToolStripMenuItem";
            penjualanToolStripMenuItem.Size = new Size(91, 24);
            penjualanToolStripMenuItem.Text = "Penjualan";
            penjualanToolStripMenuItem.Click += penjualanToolStripMenuItem_Click;
            // 
            // laporanToolStripMenuItem
            // 
            laporanToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            laporanToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            laporanToolStripMenuItem.Size = new Size(80, 24);
            laporanToolStripMenuItem.Text = "Laporan";
            laporanToolStripMenuItem.Click += laporanToolStripMenuItem_Click;
            // 
            // keluarToolStripMenuItem
            // 
            keluarToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            keluarToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            keluarToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            keluarToolStripMenuItem.Size = new Size(68, 24);
            keluarToolStripMenuItem.Text = "Keluar";
            keluarToolStripMenuItem.Click += keluarToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Historic", 30F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(555, 67);
            label1.TabIndex = 1;
            label1.Text = "Selamat Datang Admin";
            label1.Click += label1_Click;
            // 
            // btnKeluar
            // 
            btnKeluar.BackColor = Color.FromArgb(0, 64, 0);
            btnKeluar.BackgroundImage = Properties.Resources.keluar_button;
            btnKeluar.BackgroundImageLayout = ImageLayout.None;
            btnKeluar.FlatAppearance.BorderSize = 0;
            btnKeluar.FlatStyle = FlatStyle.Flat;
            btnKeluar.ForeColor = SystemColors.ControlText;
            btnKeluar.Location = new Point(72, 721);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(112, 38);
            btnKeluar.TabIndex = 71;
            btnKeluar.UseVisualStyleBackColor = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(0, 64, 0);
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.Location = new Point(-89, 19);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(1079, 53);
            pictureBox5.TabIndex = 78;
            pictureBox5.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.Line_11;
            panel3.Location = new Point(9, 324);
            panel3.Name = "panel3";
            panel3.Size = new Size(242, 13);
            panel3.TabIndex = 77;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Line_11;
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(pictureBox5);
            panel2.Location = new Point(4, 241);
            panel2.Name = "panel2";
            panel2.Size = new Size(944, 96);
            panel2.TabIndex = 76;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.DarkGreen;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Segoe UI Historic", 15F, FontStyle.Bold);
            label10.ForeColor = Color.DarkGray;
            label10.Location = new Point(270, 191);
            label10.Name = "label10";
            label10.Size = new Size(380, 35);
            label10.TabIndex = 74;
            label10.Text = "Sistem Pengelolaan Tembakau";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 28F, FontStyle.Bold | FontStyle.Italic);
            label8.ForeColor = SystemColors.ControlLight;
            label8.Location = new Point(354, 129);
            label8.Name = "label8";
            label8.Size = new Size(238, 62);
            label8.TabIndex = 73;
            label8.Text = "SIMBAKO";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.FlatStyle = FlatStyle.Flat;
            label12.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold);
            label12.ForeColor = Color.LightGreen;
            label12.Location = new Point(3, 67);
            label12.Name = "label12";
            label12.Size = new Size(384, 25);
            label12.TabIndex = 79;
            label12.Text = "SIMBAKO - Sistem Pengelolaan Tembakau";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Line_11;
            panel1.Location = new Point(244, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 13);
            panel1.TabIndex = 80;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.Transparent;
            flowLayoutPanel2.Controls.Add(label1);
            flowLayoutPanel2.Controls.Add(label12);
            flowLayoutPanel2.Location = new Point(172, 396);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(649, 120);
            flowLayoutPanel2.TabIndex = 4;
            flowLayoutPanel2.Paint += flowLayoutPanel2_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Enabled = false;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(439, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 89);
            pictureBox1.TabIndex = 78;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // FormDashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(944, 553);
            Controls.Add(pictureBox1);
            Controls.Add(btnKeluar);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormDashboardAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SIMBAKO - Dashboard Admin";
            Load += FormDashboardAdmin_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel2.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem panenToolStripMenuItem;
        private ToolStripMenuItem produksiToolStripMenuItem;
        private ToolStripMenuItem produkToolStripMenuItem;
        private ToolStripMenuItem penjualanToolStripMenuItem;
        private ToolStripMenuItem laporanToolStripMenuItem;
        private ToolStripMenuItem keluarToolStripMenuItem;
        private Label label1;
        private Button btnKeluar;
        private PictureBox pictureBox5;
        private Panel panel3;
        private Panel panel2;
        private Label label10;
        private Label label8;
        private Panel panel1;
        private Label label12;
        private FlowLayoutPanel flowLayoutPanel2;
        private PictureBox pictureBox1;
    }
}