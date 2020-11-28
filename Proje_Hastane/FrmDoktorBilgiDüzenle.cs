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

namespace Proje_Hastane
{
    public partial class FrmDoktorBilgiDüzenle : Form
    {
        public FrmDoktorBilgiDüzenle()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string tcc;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmDoktorBilgiDüzenle_Load(object sender, EventArgs e)
        {
            MskTC.Text = tcc;
            SqlCommand komut = new SqlCommand("select *from Tbl_Doktorlar where DoktorTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read()) {
                TxtAd.Text = dr[1].ToString();
                TxtSoyad.Text = dr[2].ToString();
                CmbBrans.Text = dr[3].ToString();
                TxtSifre.Text = dr[5].ToString();
                    }
            bgl.baglanti().Close();
        }

        private void BtnBilgiGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("update Tbl_Doktorlar set DoktorAd=@a1,DoktorSoyad=@a2,DoktorBrans=@a3,DoktorSifre=@a4 where DoktorTc=@a5", bgl.baglanti());
            komut1.Parameters.AddWithValue("@a1", TxtAd.Text);
            komut1.Parameters.AddWithValue("@a2", TxtSoyad.Text);
            komut1.Parameters.AddWithValue("@a3", CmbBrans.Text);
            komut1.Parameters.AddWithValue("@a4", TxtSifre.Text);
            komut1.Parameters.AddWithValue("@a5", MskTC.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellenmiştir.");
        }

        private void TxtAd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
