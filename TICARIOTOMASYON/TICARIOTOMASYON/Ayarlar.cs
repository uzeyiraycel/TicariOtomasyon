using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TICARIOTOMASYON
{
    public partial class Ayarlar : Form
    {
        public Ayarlar()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_ADMIN",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void Ayarlar_Load(object sender, EventArgs e)
        {
            listele();
            txtkullaniciadi.Text = "";
            txtsifre.Text = "";
        }

        private void islem_Click(object sender, EventArgs e)
        {
            if(islem.Text=="KAYDET")
            {
                SqlCommand komut = new SqlCommand("insert into TBL_ADMIN values (@p1,@p2)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtkullaniciadi.Text);
                komut.Parameters.AddWithValue("@p2", txtsifre.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Yeni Admin Sisteme Kaydedildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            if(islem.Text=="GÜNCELLE")
            {
                SqlCommand komut1 = new SqlCommand("update TBL_ADMIN set Sifre=@p2 where KullaniciAdi=@p1",bgl.baglanti());
                komut1.Parameters.AddWithValue("@p1", txtkullaniciadi.Text);
                komut1.Parameters.AddWithValue("@p2", txtsifre.Text);
                komut1.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Güncellendi", "",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                listele();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr!=null)
            {
                txtkullaniciadi.Text = dr["KullaniciAdi"].ToString();
                txtsifre.Text = dr["Sifre"].ToString();
            }
        }

        private void txtkullaniciadi_TextChanged(object sender, EventArgs e)
        {
            if(txtkullaniciadi.Text!="")
            {
                islem.Text = "GÜNCELLE";
                islem.BackColor = Color.NavajoWhite;
            }
            else
            {
                islem.Text = "KAYDET";
                islem.BackColor = Color.Aquamarine;
            }
        }
    }
}
