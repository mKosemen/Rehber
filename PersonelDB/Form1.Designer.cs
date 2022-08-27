namespace PersonelDB
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabRehber = new System.Windows.Forms.TabControl();
            this.tabEkle = new System.Windows.Forms.TabPage();
            this.txtETelefon = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtESehir = new System.Windows.Forms.TextBox();
            this.txtESoyad = new System.Windows.Forms.TextBox();
            this.txtEAd = new System.Windows.Forms.TextBox();
            this.lblSehir = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabAra = new System.Windows.Forms.TabPage();
            this.txtASehir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtATelefon = new System.Windows.Forms.TextBox();
            this.txtASoyad = new System.Windows.Forms.TextBox();
            this.txtAAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabGuncelle = new System.Windows.Forms.TabPage();
            this.btnGetir = new System.Windows.Forms.Button();
            this.txtİkinciAd = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbxSil = new System.Windows.Forms.CheckBox();
            this.txtGSehir = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGTelefon = new System.Windows.Forms.TextBox();
            this.txtGSoyad = new System.Windows.Forms.TextBox();
            this.txtGAd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.tabRehber.SuspendLayout();
            this.tabEkle.SuspendLayout();
            this.tabAra.SuspendLayout();
            this.tabGuncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // tabRehber
            // 
            this.tabRehber.Controls.Add(this.tabEkle);
            this.tabRehber.Controls.Add(this.tabAra);
            this.tabRehber.Controls.Add(this.tabGuncelle);
            this.tabRehber.Location = new System.Drawing.Point(465, 12);
            this.tabRehber.Name = "tabRehber";
            this.tabRehber.SelectedIndex = 0;
            this.tabRehber.Size = new System.Drawing.Size(253, 322);
            this.tabRehber.TabIndex = 0;
            // 
            // tabEkle
            // 
            this.tabEkle.BackColor = System.Drawing.Color.LightSalmon;
            this.tabEkle.Controls.Add(this.txtETelefon);
            this.tabEkle.Controls.Add(this.label11);
            this.tabEkle.Controls.Add(this.btnEkle);
            this.tabEkle.Controls.Add(this.txtESehir);
            this.tabEkle.Controls.Add(this.txtESoyad);
            this.tabEkle.Controls.Add(this.txtEAd);
            this.tabEkle.Controls.Add(this.lblSehir);
            this.tabEkle.Controls.Add(this.label2);
            this.tabEkle.Controls.Add(this.label1);
            this.tabEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabEkle.ForeColor = System.Drawing.Color.White;
            this.tabEkle.Location = new System.Drawing.Point(4, 22);
            this.tabEkle.Name = "tabEkle";
            this.tabEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tabEkle.Size = new System.Drawing.Size(245, 282);
            this.tabEkle.TabIndex = 0;
            this.tabEkle.Text = "Kişi Kayıt";
            // 
            // txtETelefon
            // 
            this.txtETelefon.Location = new System.Drawing.Point(81, 148);
            this.txtETelefon.Name = "txtETelefon";
            this.txtETelefon.Size = new System.Drawing.Size(147, 21);
            this.txtETelefon.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(15, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Telefon";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.IndianRed;
            this.btnEkle.ForeColor = System.Drawing.Color.Black;
            this.btnEkle.Location = new System.Drawing.Point(81, 234);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(87, 41);
            this.btnEkle.TabIndex = 15;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtESehir
            // 
            this.txtESehir.Location = new System.Drawing.Point(81, 103);
            this.txtESehir.Name = "txtESehir";
            this.txtESehir.Size = new System.Drawing.Size(147, 21);
            this.txtESehir.TabIndex = 13;
            // 
            // txtESoyad
            // 
            this.txtESoyad.Location = new System.Drawing.Point(81, 56);
            this.txtESoyad.Name = "txtESoyad";
            this.txtESoyad.Size = new System.Drawing.Size(147, 21);
            this.txtESoyad.TabIndex = 12;
            // 
            // txtEAd
            // 
            this.txtEAd.Location = new System.Drawing.Point(81, 11);
            this.txtEAd.Name = "txtEAd";
            this.txtEAd.Size = new System.Drawing.Size(147, 21);
            this.txtEAd.TabIndex = 11;
            // 
            // lblSehir
            // 
            this.lblSehir.AutoSize = true;
            this.lblSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSehir.Location = new System.Drawing.Point(15, 106);
            this.lblSehir.Name = "lblSehir";
            this.lblSehir.Size = new System.Drawing.Size(43, 16);
            this.lblSehir.TabIndex = 10;
            this.lblSehir.Text = "Şehir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Soyadı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ad:";
            // 
            // tabAra
            // 
            this.tabAra.BackColor = System.Drawing.Color.PeachPuff;
            this.tabAra.Controls.Add(this.txtASehir);
            this.tabAra.Controls.Add(this.label3);
            this.tabAra.Controls.Add(this.txtID);
            this.tabAra.Controls.Add(this.label10);
            this.tabAra.Controls.Add(this.btnAra);
            this.tabAra.Controls.Add(this.txtATelefon);
            this.tabAra.Controls.Add(this.txtASoyad);
            this.tabAra.Controls.Add(this.txtAAd);
            this.tabAra.Controls.Add(this.label4);
            this.tabAra.Controls.Add(this.label5);
            this.tabAra.Controls.Add(this.label6);
            this.tabAra.Location = new System.Drawing.Point(4, 22);
            this.tabAra.Name = "tabAra";
            this.tabAra.Padding = new System.Windows.Forms.Padding(3);
            this.tabAra.Size = new System.Drawing.Size(245, 282);
            this.tabAra.TabIndex = 1;
            this.tabAra.Text = "Arama";
            // 
            // txtASehir
            // 
            this.txtASehir.Location = new System.Drawing.Point(85, 140);
            this.txtASehir.Name = "txtASehir";
            this.txtASehir.Size = new System.Drawing.Size(147, 20);
            this.txtASehir.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(19, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Şehir";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(85, 27);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(147, 20);
            this.txtID.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(19, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "ID:";
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.Sienna;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(85, 235);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(87, 41);
            this.btnAra.TabIndex = 24;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtATelefon
            // 
            this.txtATelefon.Location = new System.Drawing.Point(85, 175);
            this.txtATelefon.Name = "txtATelefon";
            this.txtATelefon.Size = new System.Drawing.Size(147, 20);
            this.txtATelefon.TabIndex = 22;
            // 
            // txtASoyad
            // 
            this.txtASoyad.Location = new System.Drawing.Point(85, 102);
            this.txtASoyad.Name = "txtASoyad";
            this.txtASoyad.Size = new System.Drawing.Size(147, 20);
            this.txtASoyad.TabIndex = 21;
            // 
            // txtAAd
            // 
            this.txtAAd.Location = new System.Drawing.Point(85, 65);
            this.txtAAd.Name = "txtAAd";
            this.txtAAd.Size = new System.Drawing.Size(147, 20);
            this.txtAAd.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(19, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(19, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Soyadı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(19, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ad:";
            // 
            // tabGuncelle
            // 
            this.tabGuncelle.BackColor = System.Drawing.Color.LightPink;
            this.tabGuncelle.Controls.Add(this.btnGetir);
            this.tabGuncelle.Controls.Add(this.txtİkinciAd);
            this.tabGuncelle.Controls.Add(this.label14);
            this.tabGuncelle.Controls.Add(this.cbxSil);
            this.tabGuncelle.Controls.Add(this.txtGSehir);
            this.tabGuncelle.Controls.Add(this.label7);
            this.tabGuncelle.Controls.Add(this.txtGID);
            this.tabGuncelle.Controls.Add(this.label8);
            this.tabGuncelle.Controls.Add(this.txtGTelefon);
            this.tabGuncelle.Controls.Add(this.txtGSoyad);
            this.tabGuncelle.Controls.Add(this.txtGAd);
            this.tabGuncelle.Controls.Add(this.label9);
            this.tabGuncelle.Controls.Add(this.label12);
            this.tabGuncelle.Controls.Add(this.label13);
            this.tabGuncelle.Controls.Add(this.button3);
            this.tabGuncelle.Controls.Add(this.btnGüncelle);
            this.tabGuncelle.Location = new System.Drawing.Point(4, 22);
            this.tabGuncelle.Name = "tabGuncelle";
            this.tabGuncelle.Size = new System.Drawing.Size(245, 296);
            this.tabGuncelle.TabIndex = 2;
            this.tabGuncelle.Text = "Güncelleme";
            // 
            // btnGetir
            // 
            this.btnGetir.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetir.Location = new System.Drawing.Point(19, 242);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(89, 44);
            this.btnGetir.TabIndex = 42;
            this.btnGetir.Text = "GETİR";
            this.btnGetir.UseVisualStyleBackColor = false;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // txtİkinciAd
            // 
            this.txtİkinciAd.Location = new System.Drawing.Point(82, 93);
            this.txtİkinciAd.Name = "txtİkinciAd";
            this.txtİkinciAd.Size = new System.Drawing.Size(147, 20);
            this.txtİkinciAd.TabIndex = 41;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(16, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 16);
            this.label14.TabIndex = 40;
            this.label14.Text = "İkinci Ad:";
            // 
            // cbxSil
            // 
            this.cbxSil.AutoSize = true;
            this.cbxSil.Location = new System.Drawing.Point(122, 226);
            this.cbxSil.Name = "cbxSil";
            this.cbxSil.Size = new System.Drawing.Size(66, 17);
            this.cbxSil.TabIndex = 39;
            this.cbxSil.Text = "Kaydı Sil";
            this.cbxSil.UseVisualStyleBackColor = true;
            this.cbxSil.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // txtGSehir
            // 
            this.txtGSehir.Location = new System.Drawing.Point(82, 166);
            this.txtGSehir.Name = "txtGSehir";
            this.txtGSehir.Size = new System.Drawing.Size(147, 20);
            this.txtGSehir.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(16, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "Şehir";
            // 
            // txtGID
            // 
            this.txtGID.Location = new System.Drawing.Point(82, 23);
            this.txtGID.Name = "txtGID";
            this.txtGID.Size = new System.Drawing.Size(147, 20);
            this.txtGID.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(16, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "ID:";
            // 
            // txtGTelefon
            // 
            this.txtGTelefon.Location = new System.Drawing.Point(82, 201);
            this.txtGTelefon.Name = "txtGTelefon";
            this.txtGTelefon.Size = new System.Drawing.Size(147, 20);
            this.txtGTelefon.TabIndex = 34;
            // 
            // txtGSoyad
            // 
            this.txtGSoyad.Location = new System.Drawing.Point(82, 128);
            this.txtGSoyad.Name = "txtGSoyad";
            this.txtGSoyad.Size = new System.Drawing.Size(147, 20);
            this.txtGSoyad.TabIndex = 33;
            // 
            // txtGAd
            // 
            this.txtGAd.Location = new System.Drawing.Point(82, 61);
            this.txtGAd.Name = "txtGAd";
            this.txtGAd.Size = new System.Drawing.Size(147, 20);
            this.txtGAd.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(16, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 31;
            this.label9.Text = "Telefon";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(16, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 16);
            this.label12.TabIndex = 30;
            this.label12.Text = "Soyadı:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(16, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 16);
            this.label13.TabIndex = 29;
            this.label13.Text = "Ad:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(570, 311);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 41);
            this.button3.TabIndex = 24;
            this.button3.Text = "REHBERE EKLE";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.Location = new System.Drawing.Point(140, 242);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(89, 44);
            this.btnGüncelle.TabIndex = 23;
            this.btnGüncelle.Text = "GÜNCELLE";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.Thistle;
            this.btnYenile.ForeColor = System.Drawing.Color.Black;
            this.btnYenile.Location = new System.Drawing.Point(551, 336);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(75, 41);
            this.btnYenile.TabIndex = 14;
            this.btnYenile.Text = "YENİLE";
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(12, 12);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(447, 365);
            this.dgvData.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(720, 385);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.tabRehber);
            this.Controls.Add(this.btnYenile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabRehber.ResumeLayout(false);
            this.tabEkle.ResumeLayout(false);
            this.tabEkle.PerformLayout();
            this.tabAra.ResumeLayout(false);
            this.tabAra.PerformLayout();
            this.tabGuncelle.ResumeLayout(false);
            this.tabGuncelle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabRehber;
        private System.Windows.Forms.TabPage tabEkle;
        private System.Windows.Forms.TabPage tabAra;
        private System.Windows.Forms.TabPage tabGuncelle;
        private System.Windows.Forms.TextBox txtETelefon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.TextBox txtESehir;
        private System.Windows.Forms.TextBox txtESoyad;
        private System.Windows.Forms.TextBox txtEAd;
        private System.Windows.Forms.Label lblSehir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtATelefon;
        private System.Windows.Forms.TextBox txtASoyad;
        private System.Windows.Forms.TextBox txtAAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.TextBox txtASehir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGSehir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGTelefon;
        private System.Windows.Forms.TextBox txtGSoyad;
        private System.Windows.Forms.TextBox txtGAd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox cbxSil;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TextBox txtİkinciAd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnGetir;
    }
}

