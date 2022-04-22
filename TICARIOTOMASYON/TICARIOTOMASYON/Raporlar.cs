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
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();
        }

        private void Raporlar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DbOtomasyonDataSet8.TBL_BANKALAR' table. You can move, or remove it, as needed.
            this.TBL_BANKALARTableAdapter.Fill(this.DbOtomasyonDataSet8.TBL_BANKALAR);
            // TODO: This line of code loads data into the 'DbOtomasyonDataSet7.TBL_PERSONELLER' table. You can move, or remove it, as needed.
            this.TBL_PERSONELLERTableAdapter.Fill(this.DbOtomasyonDataSet7.TBL_PERSONELLER);
            // TODO: This line of code loads data into the 'DbOtomasyonDataSet6.TBL_GIDERLER' table. You can move, or remove it, as needed.
            this.TBL_GIDERLERTableAdapter.Fill(this.DbOtomasyonDataSet6.TBL_GIDERLER);
            // TODO: This line of code loads data into the 'DbOtomasyonDataSet5.TBL_FIRMALAR' table. You can move, or remove it, as needed.
            this.TBL_FIRMALARTableAdapter.Fill(this.DbOtomasyonDataSet5.TBL_FIRMALAR);
            // TODO: This line of code loads data into the 'DbOtomasyonDataSet4.TBL_MUSTERILER' table. You can move, or remove it, as needed.
            this.TBL_MUSTERILERTableAdapter.Fill(this.DbOtomasyonDataSet4.TBL_MUSTERILER);
            // TODO: This line of code loads data into the 'DbOtomasyonDataSet2.TBL_GIDERLER' table. You can move, or remove it, as needed.
            // this.TBL_GIDERLERTableAdapter.Fill(this.DbOtomasyonDataSet2.TBL_GIDERLER);
            // TODO: This line of code loads data into the 'DbOtomasyonDataSet1.TBL_MUSTERILER' table. You can move, or remove it, as needed.
            //this.TBL_MUSTERILERTableAdapter.Fill(this.DbOtomasyonDataSet1.TBL_MUSTERILER);
            // TODO: This line of code loads data into the 'DbOtomasyonDataSet.TBL_FIRMALAR' table. You can move, or remove it, as needed.
            //this.TBL_FIRMALARTableAdapter.Fill(this.DbOtomasyonDataSet.TBL_FIRMALAR);

            //this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportViewer5.RefreshReport();
        }
    }
}
