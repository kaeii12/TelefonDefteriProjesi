
namespace TelefonDefteriProjesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtAd = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableAdapterManager1 = new TelefonDefteriProjesi.TELEFONDEFTERIDataSetTableAdapters.TableAdapterManager();
            this.tbltelefonTableAdapter1 = new TelefonDefteriProjesi.TELEFONDEFTERIDataSetTableAdapters.TBLTELEFONTableAdapter();
            this.telefondefterıDataSet1 = new TelefonDefteriProjesi.TELEFONDEFTERIDataSet();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.istatistikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPostaKod = new System.Windows.Forms.TextBox();
            this.maskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.maskIsTelefon = new System.Windows.Forms.MaskedTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txtfotograf = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefondefterıDataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtAd.Controls.Add(this.dataGridView1);
            this.txtAd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtAd.Location = new System.Drawing.Point(0, 381);
            this.txtAd.MaximumSize = new System.Drawing.Size(1047, 145);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(984, 145);
            this.txtAd.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, -5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(984, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.TBLTELEFONTableAdapter = this.tbltelefonTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = TelefonDefteriProjesi.TELEFONDEFTERIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbltelefonTableAdapter1
            // 
            this.tbltelefonTableAdapter1.ClearBeforeFill = true;
            // 
            // telefondefterıDataSet1
            // 
            this.telefondefterıDataSet1.DataSetName = "TELEFONDEFTERIDataSet";
            this.telefondefterıDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.istatistikToolStripMenuItem,
            this.yardımToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışToolStripMenuItem1});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // çıkışToolStripMenuItem1
            // 
            this.çıkışToolStripMenuItem1.Name = "çıkışToolStripMenuItem1";
            this.çıkışToolStripMenuItem1.Size = new System.Drawing.Size(99, 22);
            this.çıkışToolStripMenuItem1.Text = "Çıkış";
            // 
            // istatistikToolStripMenuItem
            // 
            this.istatistikToolStripMenuItem.Name = "istatistikToolStripMenuItem";
            this.istatistikToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.istatistikToolStripMenuItem.Text = "İstatistik";
            this.istatistikToolStripMenuItem.Click += new System.EventHandler(this.istatistikToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtisim
            // 
            this.txtisim.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtisim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtisim.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtisim.ForeColor = System.Drawing.Color.Goldenrod;
            this.txtisim.Location = new System.Drawing.Point(28, 51);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(200, 26);
            this.txtisim.TabIndex = 1;
            this.txtisim.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoyad.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoyad.ForeColor = System.Drawing.Color.Goldenrod;
            this.txtSoyad.Location = new System.Drawing.Point(264, 51);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(200, 26);
            this.txtSoyad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(260, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyİsim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(25, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMail.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.ForeColor = System.Drawing.Color.Goldenrod;
            this.txtMail.Location = new System.Drawing.Point(29, 106);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(435, 26);
            this.txtMail.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(25, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "TelefonCep:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(261, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "İş Telefonu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Adres:";
            // 
            // txtAdres
            // 
            this.txtAdres.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtAdres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdres.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdres.ForeColor = System.Drawing.Color.Goldenrod;
            this.txtAdres.Location = new System.Drawing.Point(29, 225);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(435, 41);
            this.txtAdres.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.comboBox1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Goldenrod;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Seciniz"});
            this.comboBox1.Location = new System.Drawing.Point(29, 294);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(27, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sehir:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(4, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 30);
            this.button1.TabIndex = 14;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(137, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 30);
            this.button2.TabIndex = 15;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkOrange;
            this.button3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(264, 326);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 30);
            this.button3.TabIndex = 16;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(261, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Posta Kodu:";
            // 
            // txtPostaKod
            // 
            this.txtPostaKod.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtPostaKod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPostaKod.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostaKod.ForeColor = System.Drawing.Color.Goldenrod;
            this.txtPostaKod.Location = new System.Drawing.Point(264, 294);
            this.txtPostaKod.Name = "txtPostaKod";
            this.txtPostaKod.Size = new System.Drawing.Size(200, 26);
            this.txtPostaKod.TabIndex = 18;
            // 
            // maskTelefon
            // 
            this.maskTelefon.BackColor = System.Drawing.SystemColors.MenuText;
            this.maskTelefon.ForeColor = System.Drawing.Color.Goldenrod;
            this.maskTelefon.Location = new System.Drawing.Point(29, 171);
            this.maskTelefon.Name = "maskTelefon";
            this.maskTelefon.Size = new System.Drawing.Size(199, 32);
            this.maskTelefon.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Goldenrod;
            this.label10.Location = new System.Drawing.Point(355, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "Telefon Defteri";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::TelefonDefteriProjesi.Properties.Resources.noPhoto1;
            this.pictureBox1.Location = new System.Drawing.Point(568, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 294);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // maskIsTelefon
            // 
            this.maskIsTelefon.BackColor = System.Drawing.SystemColors.MenuText;
            this.maskIsTelefon.ForeColor = System.Drawing.Color.Goldenrod;
            this.maskIsTelefon.Location = new System.Drawing.Point(264, 171);
            this.maskIsTelefon.Name = "maskIsTelefon";
            this.maskIsTelefon.Size = new System.Drawing.Size(199, 32);
            this.maskIsTelefon.TabIndex = 24;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightCoral;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(843, 316);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 26);
            this.button4.TabIndex = 25;
            this.button4.Text = "  ...";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtfotograf
            // 
            this.txtfotograf.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtfotograf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfotograf.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfotograf.ForeColor = System.Drawing.Color.Goldenrod;
            this.txtfotograf.Location = new System.Drawing.Point(568, 329);
            this.txtfotograf.Name = "txtfotograf";
            this.txtfotograf.Size = new System.Drawing.Size(269, 26);
            this.txtfotograf.TabIndex = 26;
            this.txtfotograf.TextChanged += new System.EventHandler(this.txtfotograf_TextChanged);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.IndianRed;
            this.button5.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(373, 323);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 30);
            this.button5.TabIndex = 27;
            this.button5.Text = "Temizle";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.txtfotograf);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.maskIsTelefon);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.maskTelefon);
            this.panel1.Controls.Add(this.txtPostaKod);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.txtAdres);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtMail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSoyad);
            this.panel1.Controls.Add(this.txtisim);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 353);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 526);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Telefon Defteri 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.txtAd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefondefterıDataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel txtAd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private TELEFONDEFTERIDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private TELEFONDEFTERIDataSetTableAdapters.TBLTELEFONTableAdapter tbltelefonTableAdapter1;
        private TELEFONDEFTERIDataSet telefondefterıDataSet1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem istatistikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPostaKod;
        private System.Windows.Forms.MaskedTextBox maskTelefon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox maskIsTelefon;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtfotograf;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
    }
}

