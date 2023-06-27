namespace _2210733074
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dikdörtgenÇizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çizgileriSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dikdörtgenÇizToolStripMenuItem,
            this.çizgileriSilToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Menü";
            // 
            // dikdörtgenÇizToolStripMenuItem
            // 
            this.dikdörtgenÇizToolStripMenuItem.Name = "dikdörtgenÇizToolStripMenuItem";
            this.dikdörtgenÇizToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dikdörtgenÇizToolStripMenuItem.Text = "Dikdörtgen Çiz";
            this.dikdörtgenÇizToolStripMenuItem.Click += new System.EventHandler(this.dikdörtgenÇizToolStripMenuItem_Click);
            this.dikdörtgenÇizToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dikdörtgenÇizToolStripMenuItem_MouseMove);
            // 
            // çizgileriSilToolStripMenuItem
            // 
            this.çizgileriSilToolStripMenuItem.Name = "çizgileriSilToolStripMenuItem";
            this.çizgileriSilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.çizgileriSilToolStripMenuItem.Text = "Çizgileri Sil";
            this.çizgileriSilToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.çizgileriSilToolStripMenuItem_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dikdörtgenÇizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çizgileriSilToolStripMenuItem;
    }
}

