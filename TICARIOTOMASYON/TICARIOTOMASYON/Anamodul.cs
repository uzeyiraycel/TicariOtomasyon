using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TICARIOTOMASYON
{
    public partial class Anamodul : Form
    {
        public Anamodul()
        {
            InitializeComponent();
        }

        Urunler urun;
        private void Urunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (urun == null || urun.IsDisposed)
            {
                urun = new Urunler();
                urun.MdiParent = this;
                urun.Show();
            }
        }

        Musteriler musteri;
        private void Musteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (musteri == null || musteri.IsDisposed)
            {
                musteri = new Musteriler();
                musteri.MdiParent = this;
                musteri.Show();
            }
        }

        Firmalar firma;
        private void Firmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (firma == null || firma.IsDisposed)
            {
                firma = new Firmalar();
                firma.MdiParent = this;
                firma.Show();
            }
        }

        Personeller personel;

        private void Personeller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(personel==null || personel.IsDisposed)
            {
                personel = new Personeller();
                personel.MdiParent = this;
                personel.Show();
            }
        }

        Rehber rhbr;

        private void Rehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(rhbr==null || rhbr.IsDisposed)
            {
                rhbr = new Rehber();
                rhbr.MdiParent = this;
                rhbr.Show();
            }
        }

        Giderler gider;
        private void Giderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(gider==null || gider.IsDisposed)
            {
                gider = new Giderler();
                gider.MdiParent = this;
                gider.Show();
            }
        }

        Bankalar banka;
        private void Bankalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(banka==null || banka.IsDisposed)
            {
                banka = new Bankalar();
                banka.MdiParent = this;
                banka.Show();
            }
        }

        Faturalar fatura;
        private void Faturalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fatura==null || fatura.IsDisposed)
            {
                fatura = new Faturalar();
                fatura.MdiParent = this;
                fatura.Show();
            }
        }

        Notlar not;
        private void Notlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (not==null || not.IsDisposed)
            {
                not = new Notlar();
                not.MdiParent = this;
                not.Show();
            }
        }

        Hareketler hareket;
        private void hareketler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(hareket==null || hareket.IsDisposed)
            {
                hareket = new Hareketler();
                hareket.MdiParent = this;
                hareket.Show();
            }
        }

        Raporlar rapor;
        private void raporlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (rapor==null || rapor.IsDisposed)
            {
                rapor = new Raporlar();
                rapor.MdiParent = this;
                rapor.Show();
            }
        }

        Stoklar stok;
        private void Stoklar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(stok==null || stok.IsDisposed)
            {
                stok = new Stoklar();
                stok.MdiParent = this;
                stok.Show();
            }
        }

        Ayarlar ayar;
        private void Ayarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(ayar==null || ayar.IsDisposed)
            {
                ayar = new Ayarlar();
                ayar.Show();
            }
        }

        Kasa ks;
        private void Kasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(ks==null || ks.IsDisposed)
            {
                ks = new Kasa();
                ks.ad = kullanici;
                ks.MdiParent = this;
                ks.Show();
            }
        }

        public string kullanici;
        private void Anamodul_Load(object sender, EventArgs e)
        {
            if (ana == null || ana.IsDisposed)
            {
                ana = new Anasayfa();
                ana.MdiParent = this;
                ana.Show();
            }
        }

        Anasayfa ana;
        private void AnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(ana==null || ana.IsDisposed)
            {
                ana = new Anasayfa();
                ana.MdiParent = this;
                ana.Show();
            }
        }
    }
}
