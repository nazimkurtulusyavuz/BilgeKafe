using BilgeKafe.Data;
using BilgeKafe.UI.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            VerileriOku();
            //OrnekUrunleriOlustur();
            InitializeComponent();
            MasalariOlustur();
        }

        private void VerileriOku()
        {
            try
            {
                string json = File.ReadAllText("veri.json");  //DİSKTEN OKUMA
                db = JsonConvert.DeserializeObject<KafeVeri>(json);  //JSON DESERIALIZATION
            }
            catch (Exception)
            {


            };
        }

        private void OrnekUrunleriOlustur()
        {
            db.Urunler.Add(new Urun() { UrunAd = "Kola", BirimFiyat = 5.99m });
            db.Urunler.Add(new Urun() { UrunAd = "Çay", BirimFiyat = 4.50m });
        }
        private void MasalariOlustur()
        {
            #region Imaj Listesinin Oluşturulması
            ImageList imagelist = new ImageList();
            imagelist.Images.Add("bos", Resources.bos);
            imagelist.Images.Add("dolu", Resources.dolu);
            imagelist.ImageSize = new Size(64, 64);
            lvwMasalar.LargeImageList = imagelist;
            #endregion
            for (int i = 1; i <= db.MasaAdet; i++)
            {
                ListViewItem lvi = new ListViewItem($"Masa {i}");
                lvi.Tag = i;
                lvi.ImageKey = db.AktifSiparisler.Any(s => s.MasaNo == i) ? "dolu" : "bos";
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
            if (siparis == null)
            {
                siparis = new Siparis() { MasaNo = masaNo };
                db.AktifSiparisler.Add(siparis);
            }
            SiparisForm frmsiparis = new SiparisForm(db, siparis);
            frmsiparis.MasaTasindi += Frmsiparis_MasaTasindi;
            frmsiparis.ShowDialog();
            if (siparis.Durum != SiparisDurum.Aktif)
            {
                lvi.ImageKey = "bos";
            }
        }

        private void Frmsiparis_MasaTasindi(object sender, MasaTasindiEventArgs e)
        {
            foreach (ListViewItem lvi in lvwMasalar.Items)
            {
                if ((int)lvi.Tag == e.EskiMasaNo)
                {
                    lvi.ImageKey = "bos";
                }
                if ((int)lvi.Tag == e.YeniMasaNo)
                {
                    lvi.ImageKey = "dolu";
                }
            }
        }

        private void tsmiGecmisSiparisler_Click(object sender, EventArgs e)
        {
            new GecmisSiparislerForm(db).ShowDialog();
        }

        private void tsmiUrunler_Click(object sender, EventArgs e)
        {
            new UrunlerForm(db).ShowDialog();
        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string json = JsonConvert.SerializeObject(db);  // JSON SERİALİZATİON
            File.WriteAllText("veri.json", json);  //DİSKE YAZILMASI
        }
    }
}
