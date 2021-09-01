using BilgeKafe.Data;
using BilgeKafe.UI.Properties;
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
    public partial class AnaForm : Form
    {
        KafeVeri db = new KafeVeri();   //db=database
        public AnaForm()
        {
            OrnekUrunleriOlustur();
            InitializeComponent();
            MasalariOlustur();
        }
        private void OrnekUrunleriOlustur()
        {
            db.Urunler.Add(new Urun() { UrunAd = "Kola", BirimFiyat = 5.99m });
            db.Urunler.Add(new Urun() { UrunAd = "Çay", BirimFiyat = 4.50m });
        }
        private void MasalariOlustur()
        {
            ImageList imagelist = new ImageList();
            imagelist.Images.Add("bos", Resources.bos);
            imagelist.Images.Add("dolu", Resources.dolu);
            imagelist.ImageSize = new Size(64,64);
            lvwMasalar.LargeImageList = imagelist;
            for (int i = 1; i <= db.MasaAdet; i++)
            {
                ListViewItem lvi = new ListViewItem($"Masa {i}");
                lvi.Tag = i;
                lvi.ImageKey = "bos";
                lvwMasalar.Items.Add(lvi);
            }
        }
        private void lvwMasalar_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem lvi = lvwMasalar.SelectedItems[0];
            lvi.ImageKey = "dolu";
            int masaNo = (int)lvi.Tag;
            //MessageBox.Show(masaNo.ToString());
            //Tıklanan masaya aıt varsa sıparısı bul.
            Siparis siparis = db.AktifSiparisler.FirstOrDefault(x => x.MasaNo == masaNo);
            //Eger sıparıs henuz olusturulmadıysa (o masaya ait)
            if (siparis ==null)
            {
                siparis = new Siparis() { MasaNo = masaNo };
                db.AktifSiparisler.Add(siparis);
            }
            SiparisForm frmsiparis = new SiparisForm(db, siparis);
            frmsiparis.ShowDialog();
            if (siparis.Durum != SiparisDurum.Aktif )
            {
                lvi.ImageKey = "bos"; 
            }
        }

        private void tsmiGecmisSiparisler_Click(object sender, EventArgs e)
        {
            new GecmisSiparislerForm(db).ShowDialog();
        }
    }
}
