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
    public partial class Recete : Form
    {
        public Recete()
        {
            InitializeComponent();
        }
        public NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; DataBase=mbys; user ID=postgres; password=1234");
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into recete (hastatc,hastad,hastasoyad,tarih,receteno,barkodno) values(@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut1.Parameters.AddWithValue("@p1", Convert.ToInt64(txttc.Text));
            komut1.Parameters.AddWithValue("@p2", txtad.Text);
            komut1.Parameters.AddWithValue("@p3", txtsoyad.Text);
            komut1.Parameters.AddWithValue("@p4", DateTime.Parse(txttarih1.Text));
            komut1.Parameters.AddWithValue("@p5", Convert.ToInt64(txtrecete1.Text));
            komut1.Parameters.AddWithValue("@p6", Convert.ToInt64(txtbarkod1.Text));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from recete";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
