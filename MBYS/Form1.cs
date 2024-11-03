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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; DataBase=mbys; user ID=postgres; password=1234");

        private void btnhastakayit_Click(object sender, EventArgs e)
        {
            HastaKayit hk = new HastaKayit();
            hk.Show();
        }

        private void btnmuayeneler_Click(object sender, EventArgs e)
        {
            Muayene my = new Muayene();
            my.Show();

        }

        private void btnrecete_Click(object sender, EventArgs e)
        {
            Recete recete = new Recete();
            recete.Show();
        }

        private void btnhastalistele_Click(object sender, EventArgs e)
        {
            HastaListele hl = new HastaListele();
            hl.Show();
        }

        private void btnilaclar_Click(object sender, EventArgs e)
        {
            İlaclar ilac = new İlaclar();
            ilac.Show();
        }

        private void btnarama_Click(object sender, EventArgs e)
        {
            İstenilenHastaListele ihl = new İstenilenHastaListele();
            ihl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HastaAdinaGöreAra hasta = new HastaAdinaGöreAra();
            hasta.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            İlacBilgi ib = new İlacBilgi();
            ib.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
