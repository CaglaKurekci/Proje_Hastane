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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Tbl_Doktorlar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            SqlCommand k1 = new SqlCommand("select BransAd from Tbl_Branslar", bgl.baglanti());
            SqlDataReader d1 = k1.ExecuteReader();
            while (d1.Read())
            {
                CmbBrans.Items.Add(d1[0]);
            }
            bgl.baglanti().Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Doktorlar(DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre)values(@d1,@d2,@d3,@d4,@d5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", TxtAd.Text);
            komut.Parameters.AddWithValue("@d2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@d3", CmbBrans.Text);
            komut.Parameters.AddWithValue("@d4", MskTC.Text);
            komut.Parameters.AddWithValue("@d5", TxtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Başarıyla eklenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MskTC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("Delete From Tbl_Doktorlar where DoktorTc=@p1", bgl.baglanti());
            sil.Parameters.AddWithValue("@p1", MskTC.Text);
            sil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silinmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand gunce = new SqlCommand("update Tbl_Doktorlar set DoktorAd=@z1,DoktorSoyad=@z2,DoktorBrans=@z3,DoktorSifre=@z4 where DoktorTc=@z5", bgl.baglanti());
            gunce.Parameters.AddWithValue("@z1", TxtAd.Text);
            gunce.Parameters.AddWithValue("@z2", TxtSoyad.Text);
            gunce.Parameters.AddWithValue("@z3", CmbBrans.Text);
            gunce.Parameters.AddWithValue("@z4", TxtSifre.Text);
            gunce.Parameters.AddWithValue("@z5", MskTC.Text);
            gunce.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme işlemi başarıyla gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            ///////////////////////////
            /*
            SqlCommand g = new SqlCommand("update Tbl_Branslar set BransAd=@f1 where Bransid=@f2", bgl.baglanti());
            g.Parameters.AddWithValue("@f1", TxtBrans.Text);
            g.Parameters.AddWithValue("@f2", Txtid.Text);
            g.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme işlemi yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);*/

        } 
    }
}
