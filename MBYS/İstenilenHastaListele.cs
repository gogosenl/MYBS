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
    public partial class İstenilenHastaListele : Form
    {
        public İstenilenHastaListele()
        {
            InitializeComponent();
        }
        public NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; DataBase=mbys; user ID=postgres; password=1234");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            NpgsqlCommand komut1 = new NpgsqlCommand("Select * From ilac where ilacadi like '%" + txtbarkod.Text + "%'", baglanti);

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut1);

            DataSet ds = new DataSet();

            da.Fill(ds);

            this.dataGridView1.DataSource = ds.Tables[0];

            baglanti.Close();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
