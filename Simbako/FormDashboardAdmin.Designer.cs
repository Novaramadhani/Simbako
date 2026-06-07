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
            menuStrip1 = new MenuStrip();
            panenToolStripMenuItem = new ToolStripMenuItem();
            produksiToolStripMenuItem = new ToolStripMenuItem();
            produkToolStripMenuItem = new ToolStripMenuItem();
            penjualanToolStripMenuItem = new ToolStripMenuItem();
            laporanToolStripMenuItem = new ToolStripMenuItem();
            keluarToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { panenToolStripMenuItem, produksiToolStripMenuItem, produkToolStripMenuItem, penjualanToolStripMenuItem, laporanToolStripMenuItem, keluarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(920, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // panenToolStripMenuItem
            // 
            panenToolStripMenuItem.Name = "panenToolStripMenuItem";
            panenToolStripMenuItem.Size = new Size(62, 24);
            panenToolStripMenuItem.Text = "Panen";
            panenToolStripMenuItem.Click += panenToolStripMenuItem_Click;
            // 
            // produksiToolStripMenuItem
            // 
            produksiToolStripMenuItem.Name = "produksiToolStripMenuItem";
            produksiToolStripMenuItem.Size = new Size(79, 24);
            produksiToolStripMenuItem.Text = "Produksi";
            produksiToolStripMenuItem.Click += produksiToolStripMenuItem_Click;
            // 
            // produkToolStripMenuItem
            // 
            produkToolStripMenuItem.Name = "produkToolStripMenuItem";
            produkToolStripMenuItem.Size = new Size(69, 24);
            produkToolStripMenuItem.Text = "Produk";
            produkToolStripMenuItem.Click += produkToolStripMenuItem_Click;
            // 
            // penjualanToolStripMenuItem
            // 
            penjualanToolStripMenuItem.Name = "penjualanToolStripMenuItem";
            penjualanToolStripMenuItem.Size = new Size(86, 24);
            penjualanToolStripMenuItem.Text = "Penjualan";
            penjualanToolStripMenuItem.Click += penjualanToolStripMenuItem_Click;
            // 
            // laporanToolStripMenuItem
            // 
            laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            laporanToolStripMenuItem.Size = new Size(77, 24);
            laporanToolStripMenuItem.Text = "Laporan";
            laporanToolStripMenuItem.Click += laporanToolStripMenuItem_Click;
            // 
            // keluarToolStripMenuItem
            // 
            keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            keluarToolStripMenuItem.Size = new Size(65, 24);
            keluarToolStripMenuItem.Text = "Keluar";
            keluarToolStripMenuItem.Click += keluarToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(210, 62);
            label1.TabIndex = 1;
            label1.Text = "'Selamat Datang, Admin!'";
            label1.Click += label1_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label1);
            flowLayoutPanel2.Location = new Point(331, 176);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(250, 125);
            flowLayoutPanel2.TabIndex = 4;
            flowLayoutPanel2.Paint += flowLayoutPanel2_Paint;
            // 
            // FormDashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(920, 553);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormDashboardAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SIMBAKO - Dashboard Admin";
            Load += Form2_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
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
        private FlowLayoutPanel flowLayoutPanel2;
    }
}