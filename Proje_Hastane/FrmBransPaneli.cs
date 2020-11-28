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
    public partial class FrmBransPaneli : Form
    {
        public FrmBransPaneli()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmBransPaneli_Load(object sender, EventArgs e)
        {
            DataTable dtt = new DataTable();
            SqlDataAdapter daa = new SqlDataAdapter("select Bransid,BransAd from Tbl_Branslar", bgl.baglanti());
            daa.Fill(dtt);
            dataGridView1.DataSource = dtt;

            
        }

       private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtBrans.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand ekomut = new SqlCommand("insert into Tbl_Branslar(BransAd)values(@b1)", bgl.baglanti());
            ekomut.Parameters.AddWithValue("@b1", TxtBrans.Text);
            ekomut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Eklenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand silkomut = new SqlCommand("Delete from Tbl_Branslar where Bransid=@bb1", bgl.baglanti());
            silkomut.Parameters.AddWithValue("@bb1", Txtid.Text);
            silkomut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Silinmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);




        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand g = new SqlCommand("update Tbl_Branslar set BransAd=@f1 where Bransid=@f2", bgl.baglanti());
            g.Parameters.AddWithValue("@f1", TxtBrans.Text);
            g.Parameters.AddWithValue("@f2", Txtid.Text);
            g.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme işlemi yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
