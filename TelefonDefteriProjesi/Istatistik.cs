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

namespace TelefonDefteriProjesi
{
    public partial class Istatistik : Form
    {
        public Istatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source = DESKTOP-ORMI4PV\SQLEXPRESS;Initial Catalog = TELEFONDEFTERI; Integrated Security = True");

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Istatistik_Load(object sender, EventArgs e)
        {
             
            grafik();

            kisiSayisi();
            farkliIlSayisi();
            mailAdresSayisi();
           

        }

        private void grafik()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT SEHIR,COUNT(*)  as 'SAYI' FROM TELEFONTBL GROUP BY SEHIR", baglanti);
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            SqlDataReader dr = komut.ExecuteReader();
            int sayac = 0;
            while (dr.Read())
            {
              
              
                chart1.Series["ILBAZINDAKISISAYISI"].Points.Add(Convert.ToInt32(dr["SAYI"]));

                chart1.Series["ILBAZINDAKISISAYISI"].Points[sayac].AxisLabel = dr["SEHIR"].ToString();
                sayac++;
            }
            baglanti.Close();



        }

        public  void mailAdresSayisi()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select count(EMAIL)from TELEFONTBL", baglanti);

            int gelen = Convert.ToInt32(komut.ExecuteScalar());
            button3.Text = gelen.ToString();
            baglanti.Close();
        }

        public void farkliIlSayisi()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select count(DISTINCT(SEHIR))from TELEFONTBL", baglanti);

            int gelen = Convert.ToInt32(komut.ExecuteScalar());
            button2.Text = gelen.ToString();
            baglanti.Close();
        }

        public void kisiSayisi()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select count(*) from TELEFONTBL", baglanti);

            int gelen = Convert.ToInt32(komut.ExecuteScalar());
            button1.Text = gelen.ToString();
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
