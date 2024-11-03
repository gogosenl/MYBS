
namespace MBYS
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnhastakayit = new System.Windows.Forms.Button();
            this.btnhastalistele = new System.Windows.Forms.Button();
            this.btnilaclar = new System.Windows.Forms.Button();
            this.btnrecete = new System.Windows.Forms.Button();
            this.btnmuayeneler = new System.Windows.Forms.Button();
            this.btnarama = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(851, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnhastakayit
            // 
            this.btnhastakayit.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnhastakayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhastakayit.Location = new System.Drawing.Point(56, 211);
            this.btnhastakayit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnhastakayit.Name = "btnhastakayit";
            this.btnhastakayit.Size = new System.Drawing.Size(100, 29);
            this.btnhastakayit.TabIndex = 1;
            this.btnhastakayit.Text = "Hasta Kayıt";
            this.btnhastakayit.UseVisualStyleBackColor = false;
            this.btnhastakayit.Click += new System.EventHandler(this.btnhastakayit_Click);
            // 
            // btnhastalistele
            // 
            this.btnhastalistele.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnhastalistele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhastalistele.Location = new System.Drawing.Point(397, 211);
            this.btnhastalistele.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnhastalistele.Name = "btnhastalistele";
            this.btnhastalistele.Size = new System.Drawing.Size(113, 29);
            this.btnhastalistele.TabIndex = 2;
            this.btnhastalistele.Text = "HastaListele";
            this.btnhastalistele.UseVisualStyleBackColor = false;
            this.btnhastalistele.Click += new System.EventHandler(this.btnhastalistele_Click);
            // 
            // btnilaclar
            // 
            this.btnilaclar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnilaclar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnilaclar.Location = new System.Drawing.Point(314, 296);
            this.btnilaclar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnilaclar.Name = "btnilaclar";
            this.btnilaclar.Size = new System.Drawing.Size(196, 29);
            this.btnilaclar.TabIndex = 3;
            this.btnilaclar.Text = "Hastanın Aldığı İlaç Kaydı";
            this.btnilaclar.UseVisualStyleBackColor = false;
            this.btnilaclar.Click += new System.EventHandler(this.btnilaclar_Click);
            // 
            // btnrecete
            // 
            this.btnrecete.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnrecete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrecete.Location = new System.Drawing.Point(688, 250);
            this.btnrecete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnrecete.Name = "btnrecete";
            this.btnrecete.Size = new System.Drawing.Size(119, 29);
            this.btnrecete.TabIndex = 4;
            this.btnrecete.Text = "Receteler";
            this.btnrecete.UseVisualStyleBackColor = false;
            this.btnrecete.Click += new System.EventHandler(this.btnrecete_Click);
            // 
            // btnmuayeneler
            // 
            this.btnmuayeneler.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnmuayeneler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmuayeneler.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnmuayeneler.Location = new System.Drawing.Point(557, 250);
            this.btnmuayeneler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnmuayeneler.Name = "btnmuayeneler";
            this.btnmuayeneler.Size = new System.Drawing.Size(104, 29);
            this.btnmuayeneler.TabIndex = 5;
            this.btnmuayeneler.Text = "Muayeneler";
            this.btnmuayeneler.UseVisualStyleBackColor = false;
            this.btnmuayeneler.Click += new System.EventHandler(this.btnmuayeneler_Click);
            // 
            // btnarama
            // 
            this.btnarama.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnarama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnarama.Location = new System.Drawing.Point(140, 296);
            this.btnarama.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnarama.Name = "btnarama";
            this.btnarama.Size = new System.Drawing.Size(177, 29);
            this.btnarama.TabIndex = 6;
            this.btnarama.Text = "İlacı Alan Hastaları Listele";
            this.btnarama.UseVisualStyleBackColor = false;
            this.btnarama.Click += new System.EventHandler(this.btnarama_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(148, 211);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Hastanın Aldığı İlaçları Listele";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(48, 296);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "İlaclar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(608, 197);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Diğer İşlemler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hasta İşlemleri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(178, 251);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "İlaç İşlemleri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(183, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(472, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Yalvaç Hastanesini Tercih Ettiğiniz İçin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(286, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Teşekkür Ederiz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(263, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Lütfen Yapmak İstediğiniz İşlemi Seçiniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(851, 384);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnarama);
            this.Controls.Add(this.btnmuayeneler);
            this.Controls.Add(this.btnrecete);
            this.Controls.Add(this.btnilaclar);
            this.Controls.Add(this.btnhastalistele);
            this.Controls.Add(this.btnhastakayit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "w";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnhastakayit;
        private System.Windows.Forms.Button btnhastalistele;
        private System.Windows.Forms.Button btnilaclar;
        private System.Windows.Forms.Button btnrecete;
        private System.Windows.Forms.Button btnmuayeneler;
        private System.Windows.Forms.Button btnarama;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

