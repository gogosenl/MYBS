using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBYS
{
    public partial class İlacBilgi : Form
    {
        public İlacBilgi()
        {
            InitializeComponent();
        }
        public NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; DataBase=mbys; user ID=postgres; password=1234");
        private void btnekle_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into ilaclar(barkodno,ilacadi,ilactipi)values(@p1,@p2,@p3)", baglanti);
            komut1.Parameters.AddWithValue("@p1", Convert.ToInt64(txtbarkodno.Text));
            komut1.Parameters.AddWithValue("@p2", txtad.Text);
            komut1.Parameters.AddWithValue("@p3", txttip.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme İşlemi Başarılı");
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from ilaclar";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
