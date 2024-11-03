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

using System.Data.SqlClient;
namespace MBYS
{
    public partial class HastaKayit : Form
    {
        
        public HastaKayit()
        {
            InitializeComponent();
        }
        public NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; DataBase=mbys; user ID=postgres; password=1234");
        private void HastaKayit_Load(object sender, EventArgs e)
        {

        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into hasta (tc,ad,soyad,dogumyeri,dogumtarihi,medenidurum,telefon,adres) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglanti);
            komut1.Parameters.AddWithValue("@p1", Convert.ToInt64(txttc.Text));
            komut1.Parameters.AddWithValue("@p2", txtad.Text);
            komut1.Parameters.AddWithValue("@p3", txtsoyad.Text);
            komut1.Parameters.AddWithValue("@p4", txtdogumyeri.Text);
            komut1.Parameters.AddWithValue("@p5", DateTime.Parse(txttarihi.Text));
            komut1.Parameters.AddWithValue("@p6", txtmedenidurum.Text);
            komut1.Parameters.AddWithValue("@p7", Convert.ToInt64(txttelefon.Text));
            komut1.Parameters.AddWithValue("@p8", txtadres.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Eklemi İşlemi Başarılı");

        }

       
    }
}
