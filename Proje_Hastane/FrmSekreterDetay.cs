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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string tcno;
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = tcno;



            SqlCommand komut = new SqlCommand("select SekreterAdSoyad from Tbl_Sekreter where SekreterTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Branslar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            DataTable dtt = new DataTable();
            SqlDataAdapter daa = new SqlDataAdapter("select *from Tbl_Doktorlar", bgl.baglanti());
            daa.Fill(dtt);
            dataGridView2.DataSource = dtt;


            SqlCommand komut1 = new SqlCommand("select BransAd from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                CmbBrans.Items.Add(dr1[0]);
            }
            bgl.baglanti().Close();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@a1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@a1", CmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                CmbDoktor.Items.Add(dr3[0]+" "+dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand kk = new SqlCommand("insert into Tbl_Randevular(RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor)values(@r1,@r2,@r3,@r4)", bgl.baglanti());
            kk.Parameters.AddWithValue("@r1", MskTarih.Text);
            kk.Parameters.AddWithValue("@r2", MskSaat.Text);
            kk.Parameters.AddWithValue("@r3", CmbBrans.Text);
            kk.Parameters.AddWithValue("@r4", CmbDoktor.Text);
            kk.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand ol = new SqlCommand("insert into Tbl_Duyurular(duyuru)values(@d1)", bgl.baglanti());
            ol.Parameters.AddWithValue("@d1", RchDuyuru.Text);
            ol.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnDoktorPanel_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli fr = new FrmDoktorPaneli();
            fr.Show();
        }

        private void BtnBransPanel_Click(object sender, EventArgs e)
        {
            FrmBransPaneli frm = new FrmBransPaneli();
            frm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
          


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
