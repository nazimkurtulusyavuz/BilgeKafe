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
            
            
            InitializeComponent();
            MasalariOlustur();
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
                lvi.ImageKey = db.Siparisler.Any(s => s.MasaNo == i && s.Durum == SiparisDurum.Aktif) ? "dolu" : "bos";
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
            Siparis siparis = db.Siparisler.FirstOrDefault(x => x.MasaNo == masaNo && x.Durum == SiparisDurum.Aktif);
            //Eger sıparıs henuz olusturulmadıysa (o masaya ait)
            if (siparis == null)
            {
                siparis = new Siparis() { MasaNo = masaNo };
                db.Siparisler.Add(siparis);
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
        
    }
}
