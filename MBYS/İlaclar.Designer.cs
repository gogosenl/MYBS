
namespace MBYS
{
    partial class İlaclar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txttip = new System.Windows.Forms.TextBox();
            this.txtbarkodno = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnlistele = new System.Windows.Forms.Button();
            this.txthastaad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(43, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aldığı İlacın Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(483, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "İlacın Tipi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(391, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "İlacın Barkod Numarası:";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(193, 67);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(128, 22);
            this.txtad.TabIndex = 3;
            // 
            // txttip
            // 
            this.txttip.Location = new System.Drawing.Point(624, 68);
            this.txttip.Name = "txttip";
            this.txttip.Size = new System.Drawing.Size(100, 22);
            this.txttip.TabIndex = 4;
            // 
            // txtbarkodno
            // 
            this.txtbarkodno.Location = new System.Drawing.Point(624, 36);
            this.txtbarkodno.Name = "txtbarkodno";
            this.txtbarkodno.Size = new System.Drawing.Size(116, 22);
            this.txtbarkodno.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(90, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(608, 133);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.Location = new System.Drawing.Point(632, 106);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(108, 30);
            this.btnekle.TabIndex = 7;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnlistele
            // 
            this.btnlistele.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnlistele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnlistele.Location = new System.Drawing.Point(566, 325);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(132, 35);
            this.btnlistele.TabIndex = 8;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = false;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // txthastaad
            // 
            this.txthastaad.Location = new System.Drawing.Point(193, 33);
            this.txthastaad.Name = "txthastaad";
            this.txthastaad.Size = new System.Drawing.Size(128, 22);
            this.txthastaad.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(68, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hastanın Adı:";
            // 
            // İlaclar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txthastaad);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtbarkodno);
            this.Controls.Add(this.txttip);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "İlaclar";
            this.Text = "İlaclar";
            this.Load += new System.EventHandler(this.İlaclar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txttip;
        private System.Windows.Forms.TextBox txtbarkodno;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.TextBox txthastaad;
        private System.Windows.Forms.Label label4;
    }
}