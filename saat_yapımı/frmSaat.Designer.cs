namespace saat_yapimi
{
    partial class frmSaat
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
            this.components = new System.ComponentModel.Container();
            this.lblsaat = new System.Windows.Forms.Label();
            this.tmrSaat = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblsaat
            // 
            this.lblsaat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblsaat.Location = new System.Drawing.Point(0, 0);
            this.lblsaat.Name = "lblsaat";
            this.lblsaat.Size = new System.Drawing.Size(800, 450);
            this.lblsaat.TabIndex = 0;
            this.lblsaat.Text = "label1";
            this.lblsaat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblsaat.Click += new System.EventHandler(this.lblsaat_Click);
            // 
            // tmrSaat
            // 
            this.tmrSaat.Tick += new System.EventHandler(this.tmrSaat_Tick);
            // 
            // frmSaat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblsaat);
            this.Name = "frmSaat";
            this.Text = "SAAT";
            this.Load += new System.EventHandler(this.frmSaat_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSaat_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblsaat;
        private System.Windows.Forms.Timer tmrSaat;
    }
}

