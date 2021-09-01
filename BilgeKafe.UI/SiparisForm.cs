﻿using BilgeKafe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeKafe.UI
{
    public partial class SiparisForm : Form
    {
        private readonly KafeVeri db;
        private readonly Siparis siparis;
        private readonly BindingList<SiparisDetay> blSiparisDetaylar;
        public SiparisForm(KafeVeri db, Siparis siparis)
        {
            this.db = db;
            this.siparis = siparis;
            blSiparisDetaylar = new BindingList<SiparisDetay>(siparis.SiparisDetaylar);
            blSiparisDetaylar.ListChanged += BlSiparisDetaylar_ListChanged;
            InitializeComponent();
            dgvSiparisDetaylari.AutoGenerateColumns = false; //otomatik sutun olusturmayı kapat
            dgvSiparisDetaylari.DataSource = blSiparisDetaylar;
            UrunleriListele();
            MasaNoyuGuncelle();
            blSiparisDetaylar.ResetBindings();
        }
        //BindingList üzerinde değisiklik yapildiğinda tetiklenir.
        private void BlSiparisDetaylar_ListChanged(object sender, ListChangedEventArgs e)
        {
            OdemeTutariniGuncelle();
        }
        private void OdemeTutariniGuncelle()
        {
            lblOdemeTutari.Text = siparis.ToplamTutarTL;
        }

        private void UrunleriListele()
        {
            cboUrun.DataSource = db.Urunler;
        }
        private void MasaNoyuGuncelle()
        {
            this.Text = $"Masa {siparis.MasaNo} (Açılış Zamanı : {siparis.AcilisZamani})";
            lblMasaNo.Text = $"{siparis.MasaNo:00}";
        }
        private void btnDetayEkle_Click(object sender, EventArgs e)
        {
            Urun urun = (Urun)cboUrun.SelectedItem;
            int adet = (int)nudAdet.Value;
            if (urun == null)
            {
                MessageBox.Show("Once Bir Urun Secmelısınız");
                return;
            }
            SiparisDetay sd = new SiparisDetay()
            {
                UrunAd = urun.UrunAd,
                BirimFiyat = urun.BirimFiyat,
                Adet = adet
            };
            blSiparisDetaylar.Add(sd);
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"{siparis.ToplamTutarTL} tutarı tahsil edildiyse sipariş kapatılacaktır.Onaylıyor musunuz?", "Ödeme Onayı",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.Yes)
            {
                SiparisiKapat(SiparisDurum.Odendi);
            }
        }
        private void btnSiparisIptal_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"Sipariş iptal edilecektir. Onaylıyor musunuz?", "İptal Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.Yes)
            {
                SiparisiKapat(SiparisDurum.Iptal);
            }
        }
        private void SiparisiKapat(SiparisDurum durum)
        {
            siparis.Durum = durum;
            siparis.OdenenTutar = durum == SiparisDurum.Odendi ? siparis.ToplamTutar() : 0;
            siparis.KapanisZamani = DateTime.Now;
            db.AktifSiparisler.Remove(siparis);  
            db.GecmisSiparisler.Add(siparis);
            Close();
        }


    }
}
