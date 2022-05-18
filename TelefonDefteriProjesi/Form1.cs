using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//SQL KUTUPHANESI


namespace TelefonDefteriProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // SqlConnection baglanti2 = new SqlConnection(@"Data Source = DESKTOP - ORMI4PV\SQLEXPRESS;Initial Catalog = TELEFONDEFTERI; Integrated Security = True");
        SqlConnection baglanti = new SqlConnection(@"Data Source = DESKTOP-ORMI4PV\SQLEXPRESS;Initial Catalog = TELEFONDEFTERI; Integrated Security = True");

        //Data Source = DESKTOP - ORMI4PV\SQLEXPRESS;Initial Catalog = TELEFONDEFTERI; Integrated Security = True
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
                    }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();//showdıalog penceresınıac
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            //dosyaadını pıctureboxa gonder
            txtfotograf.Text = openFileDialog1.FileName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
            sehirEkle();
        }
        
        private void sehirEkle()
        {

            baglanti.Open();//baglantıyı acar
            SqlCommand cmd = new SqlCommand("select SEHIR from TBLSEHIR", baglanti);
            //sql komutları ekler.
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["SEHIR"]);
            }
            baglanti.Close();

        }

        public void listele()
        {
            SqlCommand sqlkomutSatiri = new SqlCommand("select * from TELEFONTBL", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(sqlkomutSatiri);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        { //KAYDETME
           kaydetme();
            listele();
       
      


            
        }

     

        private void kaydetme()
        {
            try
            {
            
                baglanti.Open();//baglantiacildi
                SqlCommand sqlKomutSatiri = new SqlCommand("insert into TELEFONTBL(AD,SOYAD,EMAIL,TELEFONCEP,TELEFONIS,ADRES,SEHIR,POSTAKODU,FOTOGRAF)VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", baglanti);

                sqlKomutSatiri.Parameters.AddWithValue("@p1", txtisim.Text);
                sqlKomutSatiri.Parameters.AddWithValue("@p2", txtSoyad.Text);
                sqlKomutSatiri.Parameters.AddWithValue("@p3", txtMail.Text);
                sqlKomutSatiri.Parameters.AddWithValue("@p4", maskTelefon.Text);
                sqlKomutSatiri.Parameters.AddWithValue("@p5", maskIsTelefon.Text);
                sqlKomutSatiri.Parameters.AddWithValue("@p6", txtAdres.Text);
                sqlKomutSatiri.Parameters.AddWithValue("@p7", comboBox1.SelectedItem.ToString());
                sqlKomutSatiri.Parameters.AddWithValue("@p8", txtPostaKod.Text);
                sqlKomutSatiri.Parameters.AddWithValue("@p9", txtfotograf.Text);
                sqlKomutSatiri.ExecuteNonQuery();//sqlkomutsatırını calıstır
                MessageBox.Show("Ekleme işlemi bitti", "Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                //listele();
             
                baglanti.Close();//baglantıyıkapat
            }
            catch(Exception e)
            {
                MessageBox.Show("Bir hata belirlendi"+e.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

       

        private void txtfotograf_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtisim.Text = "";
            txtAdres.Text = "";
            txtfotograf.Text = "";
            maskIsTelefon.Text = "";
            maskTelefon.Text = "";
            txtPostaKod.Text = "";
            txtAdres.Text = "";
            txtMail.Text = "";
            comboBox1.Text = "seciniz";
            txtSoyad.Text = "";
            pictureBox1.ImageLocation = openFileDialog1.FileName;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SİLME
            silme();


        }

        private void silme()
        {
            //SqlConnection baglanti = new SqlConnection(@"Data Source = DESKTOP-ORMI4PV\SQLEXPRESS;Initial Catalog = TELEFONDEFTERI; Integrated Security = True");

                               


        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           
            txtisim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
           txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtMail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            maskTelefon.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            maskIsTelefon.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            comboBox1.Text= dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtPostaKod.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtfotograf.Text = openFileDialog1.FileName;

       
        }
    
        private void button3_Click_1(object sender, EventArgs e)
        {
            //GUNCELLEME
            guncelle();
          

        }

        private void guncelleme()
        {
            throw new NotImplementedException();
        }

        private void guncelle()
        {
            try
            {

                baglanti.Open();

                int alinanId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);



                SqlCommand sqlKomutSatiri = new SqlCommand("update TELEFONTBL set ad=@p1,soyad=@p3,EMAIL=@p4,telefoncep=@p5,TELEFONIS=@p6,adres=@p7,SEHIR=@p8,postakodu=@p9,fotograf=@p10 where ID=@p2", baglanti);
                sqlKomutSatiri.Parameters.AddWithValue("@p1", txtisim.Text);
                sqlKomutSatiri.Parameters.AddWithValue("@p3", txtSoyad.Text);
                sqlKomutSatiri.Parameters.AddWithValue("@p2", alinanId);
                sqlKomutSatiri.Parameters.AddWithValue("@p4", txtMail.Text);
                sqlKomutSatiri.Parameters.AddWithValue("@p5", maskTelefon.Text);
                sqlKomutSatiri.Parameters.AddWithValue("@p6", maskIsTelefon.Text);
                sqlKomutSatiri.Parameters.AddWithValue("@p7", txtAdres.Text);
                sqlKomutSatiri.Parameters.AddWithValue("@p8", comboBox1.Text);
                sqlKomutSatiri.Parameters.AddWithValue("@p9", txtPostaKod.Text);

                sqlKomutSatiri.Parameters.AddWithValue("@p10", txtfotograf.Text);

                sqlKomutSatiri.ExecuteNonQuery();
                MessageBox.Show("Güncelleme işlemi  işlemi bitti", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                listele();
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata belirlendi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void istatistikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            Istatistik frm = new Istatistik();
            frm.Show();
            baglanti.Close();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GÜLE GÜLE!");
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
