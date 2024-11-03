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
    public partial class Muayene : Form
    {
        public Muayene()
        {
            InitializeComponent();
        }
        public NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; DataBase=mbys; user ID=postgres; password=1234");
        private void btnkaydet_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into muayene (receteno,tc,muayenetarihi,hastaninsikayeti,onerilentedavi,tanısı) values(@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut1.Parameters.AddWithValue("@p1", Convert.ToInt64(txtreceteno.Text));
            komut1.Parameters.AddWithValue("@p2", Convert.ToInt64(txttc.Text));
            komut1.Parameters.AddWithValue("@p3", DateTime.Parse(txttarih.Text));
            komut1.Parameters.AddWithValue("@p4", richtxtsikayet.Text);
            komut1.Parameters.AddWithValue("@p5", richtxttedavi.Text);
            komut1.Parameters.AddWithValue("@p6", txttani.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme İşlemi Başarılı");
     
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from muayene";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
