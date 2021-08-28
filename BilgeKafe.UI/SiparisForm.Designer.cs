
namespace BilgeKafe.UI
{
    partial class SiparisForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMasaNo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lnlOdemeTutari = new System.Windows.Forms.Label();
            this.btnDetayEkle = new System.Windows.Forms.Button();
            this.btnMasaTasi = new System.Windows.Forms.Button();
            this.btnSiparisIptal = new System.Windows.Forms.Button();
            this.btnOdemeAl = new System.Windows.Forms.Button();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.dgvSiparisDetaylari = new System.Windows.Forms.DataGridView();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.cboUrun = new System.Windows.Forms.ComboBox();
            this.cboMasaNo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Masa No:";
            // 
            // lblMasaNo
            // 
            this.lblMasaNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMasaNo.BackColor = System.Drawing.Color.White;
            this.lblMasaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.75F, System.Drawing.FontStyle.Bold);
            this.lblMasaNo.ForeColor = System.Drawing.Color.PowderBlue;
            this.lblMasaNo.Location = new System.Drawing.Point(534, 84);
            this.lblMasaNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMasaNo.Name = "lblMasaNo";
            this.lblMasaNo.Size = new System.Drawing.Size(259, 171);
            this.lblMasaNo.TabIndex = 3;
            this.lblMasaNo.Text = "03";
            this.lblMasaNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(539, 277);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ödeme Tutarı:";
            // 
            // lnlOdemeTutari
            // 
            this.lnlOdemeTutari.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lnlOdemeTutari.AutoSize = true;
            this.lnlOdemeTutari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnlOdemeTutari.Location = new System.Drawing.Point(687, 277);
            this.lnlOdemeTutari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnlOdemeTutari.Name = "lnlOdemeTutari";
            this.lnlOdemeTutari.Size = new System.Drawing.Size(89, 20);
            this.lnlOdemeTutari.TabIndex = 5;
            this.lnlOdemeTutari.Text = "119.99 TL";
            // 
            // btnDetayEkle
            // 
            this.btnDetayEkle.Location = new System.Drawing.Point(396, 36);
            this.btnDetayEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDetayEkle.Name = "btnDetayEkle";
            this.btnDetayEkle.Size = new System.Drawing.Size(95, 28);
            this.btnDetayEkle.TabIndex = 6;
            this.btnDetayEkle.Text = "EKLE";
            this.btnDetayEkle.UseVisualStyleBackColor = true;
            // 
            // btnMasaTasi
            // 
            this.btnMasaTasi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMasaTasi.Location = new System.Drawing.Point(638, 39);
            this.btnMasaTasi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMasaTasi.Name = "btnMasaTasi";
            this.btnMasaTasi.Size = new System.Drawing.Size(78, 28);
            this.btnMasaTasi.TabIndex = 7;
            this.btnMasaTasi.Text = "TAŞI";
            this.btnMasaTasi.UseVisualStyleBackColor = true;
            // 
            // btnSiparisIptal
            // 
            this.btnSiparisIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiparisIptal.BackColor = System.Drawing.Color.Red;
            this.btnSiparisIptal.ForeColor = System.Drawing.Color.White;
            this.btnSiparisIptal.Location = new System.Drawing.Point(540, 322);
            this.btnSiparisIptal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSiparisIptal.Name = "btnSiparisIptal";
            this.btnSiparisIptal.Size = new System.Drawing.Size(116, 72);
            this.btnSiparisIptal.TabIndex = 8;
            this.btnSiparisIptal.Text = "SİPARİŞ \r\nİPTAL";
            this.btnSiparisIptal.UseVisualStyleBackColor = false;
            // 
            // btnOdemeAl
            // 
            this.btnOdemeAl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdemeAl.BackColor = System.Drawing.Color.ForestGreen;
            this.btnOdemeAl.ForeColor = System.Drawing.Color.White;
            this.btnOdemeAl.Location = new System.Drawing.Point(681, 322);
            this.btnOdemeAl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOdemeAl.Name = "btnOdemeAl";
            this.btnOdemeAl.Size = new System.Drawing.Size(112, 72);
            this.btnOdemeAl.TabIndex = 9;
            this.btnOdemeAl.Text = "ÖDEME AL";
            this.btnOdemeAl.UseVisualStyleBackColor = false;
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnasayfa.BackColor = System.Drawing.Color.Gold;
            this.btnAnasayfa.Location = new System.Drawing.Point(540, 402);
            this.btnAnasayfa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(253, 58);
            this.btnAnasayfa.TabIndex = 10;
            this.btnAnasayfa.Text = "ANASAYFAYA DÖN";
            this.btnAnasayfa.UseVisualStyleBackColor = false;
            // 
            // dgvSiparisDetaylari
            // 
            this.dgvSiparisDetaylari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisDetaylari.Location = new System.Drawing.Point(12, 69);
            this.dgvSiparisDetaylari.Name = "dgvSiparisDetaylari";
            this.dgvSiparisDetaylari.Size = new System.Drawing.Size(515, 388);
            this.dgvSiparisDetaylari.TabIndex = 11;
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(236, 36);
            this.nudAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(123, 23);
            this.nudAdet.TabIndex = 12;
            this.nudAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cboUrun
            // 
            this.cboUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUrun.FormattingEnabled = true;
            this.cboUrun.Location = new System.Drawing.Point(12, 39);
            this.cboUrun.Name = "cboUrun";
            this.cboUrun.Size = new System.Drawing.Size(195, 24);
            this.cboUrun.TabIndex = 13;
            // 
            // cboMasaNo
            // 
            this.cboMasaNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMasaNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMasaNo.FormattingEnabled = true;
            this.cboMasaNo.Location = new System.Drawing.Point(534, 40);
            this.cboMasaNo.Name = "cboMasaNo";
            this.cboMasaNo.Size = new System.Drawing.Size(97, 24);
            this.cboMasaNo.TabIndex = 14;
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.cboMasaNo);
            this.Controls.Add(this.cboUrun);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.dgvSiparisDetaylari);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.btnOdemeAl);
            this.Controls.Add(this.btnSiparisIptal);
            this.Controls.Add(this.btnMasaTasi);
            this.Controls.Add(this.btnDetayEkle);
            this.Controls.Add(this.lnlOdemeTutari);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMasaNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SiparisForm";
            this.Text = "Masa 3";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMasaNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lnlOdemeTutari;
        private System.Windows.Forms.Button btnDetayEkle;
        private System.Windows.Forms.Button btnMasaTasi;
        private System.Windows.Forms.Button btnSiparisIptal;
        private System.Windows.Forms.Button btnOdemeAl;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.DataGridView dgvSiparisDetaylari;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.ComboBox cboUrun;
        private System.Windows.Forms.ComboBox cboMasaNo;
    }
}