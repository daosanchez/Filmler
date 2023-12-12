namespace Sinema1313
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblId = new System.Windows.Forms.Label();
            this.lblFilm = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblTur = new System.Windows.Forms.Label();
            this.cbBegen = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSure = new System.Windows.Forms.TextBox();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.White;
            this.lblId.Font = new System.Drawing.Font("Agency FB", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(27, 18);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(29, 25);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // lblFilm
            // 
            this.lblFilm.AutoSize = true;
            this.lblFilm.BackColor = System.Drawing.Color.White;
            this.lblFilm.Font = new System.Drawing.Font("Agency FB", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilm.Location = new System.Drawing.Point(13, 63);
            this.lblFilm.Name = "lblFilm";
            this.lblFilm.Size = new System.Drawing.Size(45, 25);
            this.lblFilm.TabIndex = 1;
            this.lblFilm.Text = "FİLM:";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.BackColor = System.Drawing.Color.White;
            this.lblSure.Font = new System.Drawing.Font("Agency FB", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSure.Location = new System.Drawing.Point(6, 105);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(50, 25);
            this.lblSure.TabIndex = 2;
            this.lblSure.Text = "SÜRE:";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.BackColor = System.Drawing.Color.White;
            this.lblTarih.Font = new System.Drawing.Font("Agency FB", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarih.Location = new System.Drawing.Point(65, 205);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(110, 25);
            this.lblTarih.TabIndex = 3;
            this.lblTarih.Text = "İZLEME TARİHİ:";
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.BackColor = System.Drawing.Color.White;
            this.lblTur.Font = new System.Drawing.Font("Agency FB", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTur.Location = new System.Drawing.Point(5, 144);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(51, 25);
            this.lblTur.TabIndex = 4;
            this.lblTur.Text = "TÜRÜ:";
            // 
            // cbBegen
            // 
            this.cbBegen.AutoSize = true;
            this.cbBegen.BackColor = System.Drawing.Color.White;
            this.cbBegen.Font = new System.Drawing.Font("Agency FB", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBegen.Location = new System.Drawing.Point(568, 399);
            this.cbBegen.Name = "cbBegen";
            this.cbBegen.Size = new System.Drawing.Size(59, 29);
            this.cbBegen.TabIndex = 5;
            this.cbBegen.Text = "LİKE";
            this.cbBegen.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Goldenrod;
            this.dataGridView1.Location = new System.Drawing.Point(237, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(390, 360);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 244);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(221, 33);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Agency FB", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(62, 18);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(121, 28);
            this.txtId.TabIndex = 11;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Agency FB", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAd.Location = new System.Drawing.Point(62, 63);
            this.txtAd.Multiline = true;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(121, 28);
            this.txtAd.TabIndex = 12;
            // 
            // txtSure
            // 
            this.txtSure.Font = new System.Drawing.Font("Agency FB", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSure.Location = new System.Drawing.Point(62, 105);
            this.txtSure.Multiline = true;
            this.txtSure.Name = "txtSure";
            this.txtSure.Size = new System.Drawing.Size(121, 28);
            this.txtSure.TabIndex = 13;
            // 
            // cmbTur
            // 
            this.cmbTur.Font = new System.Drawing.Font("Agency FB", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Items.AddRange(new object[] {
            "Aksiyon ",
            "Macera ",
            "Romantik",
            "Komedi ",
            "Suç/Polisiye ",
            "Belgesel",
            "Fantezi ",
            "Korku ",
            "Bilim Kurgu",
            "Western ",
            "Müzikal ",
            "Tarihi "});
            this.cmbTur.Location = new System.Drawing.Point(62, 144);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(121, 33);
            this.cmbTur.TabIndex = 14;
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Agency FB", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.Location = new System.Drawing.Point(32, 380);
            this.btnSil.Name = "btnSil";
            this.btnSil.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnSil.Size = new System.Drawing.Size(126, 33);
            this.btnSil.TabIndex = 29;
            this.btnSil.Text = "SİL";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Agency FB", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.Image")));
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuncelle.Location = new System.Drawing.Point(32, 337);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnGuncelle.Size = new System.Drawing.Size(126, 37);
            this.btnGuncelle.TabIndex = 28;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Agency FB", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.Image")));
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.Location = new System.Drawing.Point(32, 298);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnEkle.Size = new System.Drawing.Size(126, 33);
            this.btnEkle.TabIndex = 27;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(639, 450);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.txtSure);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbBegen);
            this.Controls.Add(this.lblTur);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.lblFilm);
            this.Controls.Add(this.lblId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblFilm;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.CheckBox cbBegen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSure;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
    }
}

