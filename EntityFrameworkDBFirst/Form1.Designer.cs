namespace EntityFrameworkDBFirst
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
            this.components = new System.ComponentModel.Container();
            this.dgv_urunler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_tedarikciler = new System.Windows.Forms.ComboBox();
            this.cmb_kategoriler = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_urunadi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nud_fiyat = new System.Windows.Forms.NumericUpDown();
            this.nud_stok = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.txt_ara = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdb_Artan = new System.Windows.Forms.RadioButton();
            this.rdb_Azalan = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btn_ilk10 = new System.Windows.Forms.Button();
            this.btn_son10 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_urunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_fiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stok)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_urunler
            // 
            this.dgv_urunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_urunler.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_urunler.Location = new System.Drawing.Point(12, 76);
            this.dgv_urunler.Name = "dgv_urunler";
            this.dgv_urunler.Size = new System.Drawing.Size(766, 338);
            this.dgv_urunler.TabIndex = 1;
            this.dgv_urunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_urunler_CellClick);
            this.dgv_urunler.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_urunler_CellLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategoriler";
            // 
            // cmb_tedarikciler
            // 
            this.cmb_tedarikciler.FormattingEnabled = true;
            this.cmb_tedarikciler.Location = new System.Drawing.Point(290, 38);
            this.cmb_tedarikciler.Name = "cmb_tedarikciler";
            this.cmb_tedarikciler.Size = new System.Drawing.Size(158, 21);
            this.cmb_tedarikciler.TabIndex = 3;
            // 
            // cmb_kategoriler
            // 
            this.cmb_kategoriler.FormattingEnabled = true;
            this.cmb_kategoriler.Location = new System.Drawing.Point(458, 38);
            this.cmb_kategoriler.Name = "cmb_kategoriler";
            this.cmb_kategoriler.Size = new System.Drawing.Size(158, 21);
            this.cmb_kategoriler.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tedarikçiler";
            // 
            // txt_urunadi
            // 
            this.txt_urunadi.Location = new System.Drawing.Point(12, 38);
            this.txt_urunadi.Name = "txt_urunadi";
            this.txt_urunadi.Size = new System.Drawing.Size(100, 20);
            this.txt_urunadi.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ürün Adı";
            // 
            // nud_fiyat
            // 
            this.nud_fiyat.Location = new System.Drawing.Point(125, 38);
            this.nud_fiyat.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_fiyat.Name = "nud_fiyat";
            this.nud_fiyat.Size = new System.Drawing.Size(68, 20);
            this.nud_fiyat.TabIndex = 6;
            // 
            // nud_stok
            // 
            this.nud_stok.Location = new System.Drawing.Point(209, 38);
            this.nud_stok.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_stok.Name = "nud_stok";
            this.nud_stok.Size = new System.Drawing.Size(68, 20);
            this.nud_stok.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fiyat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Stok";
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(622, 38);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_Ekle.TabIndex = 7;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(703, 38);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_guncelle.TabIndex = 7;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // txt_ara
            // 
            this.txt_ara.Location = new System.Drawing.Point(119, 432);
            this.txt_ara.Name = "txt_ara";
            this.txt_ara.Size = new System.Drawing.Size(186, 20);
            this.txt_ara.TabIndex = 8;
            this.txt_ara.TextChanged += new System.EventHandler(this.txt_ara_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ürün adına göre ara";
            // 
            // rdb_Artan
            // 
            this.rdb_Artan.AutoSize = true;
            this.rdb_Artan.Location = new System.Drawing.Point(390, 432);
            this.rdb_Artan.Name = "rdb_Artan";
            this.rdb_Artan.Size = new System.Drawing.Size(107, 17);
            this.rdb_Artan.TabIndex = 10;
            this.rdb_Artan.TabStop = true;
            this.rdb_Artan.Text = "Fiyata Göre Artan";
            this.rdb_Artan.UseVisualStyleBackColor = true;
            this.rdb_Artan.CheckedChanged += new System.EventHandler(this.rdb_Artan_CheckedChanged);
            // 
            // rdb_Azalan
            // 
            this.rdb_Azalan.AutoSize = true;
            this.rdb_Azalan.Location = new System.Drawing.Point(503, 432);
            this.rdb_Azalan.Name = "rdb_Azalan";
            this.rdb_Azalan.Size = new System.Drawing.Size(120, 17);
            this.rdb_Azalan.TabIndex = 10;
            this.rdb_Azalan.TabStop = true;
            this.rdb_Azalan.Text = "Fiayata Göre Azalan";
            this.rdb_Azalan.UseVisualStyleBackColor = true;
            this.rdb_Azalan.CheckedChanged += new System.EventHandler(this.rdb_Azalan_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(311, 433);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Varsayılan";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btn_ilk10
            // 
            this.btn_ilk10.Location = new System.Drawing.Point(629, 434);
            this.btn_ilk10.Name = "btn_ilk10";
            this.btn_ilk10.Size = new System.Drawing.Size(75, 23);
            this.btn_ilk10.TabIndex = 11;
            this.btn_ilk10.Text = "İlk 10 Kayıt";
            this.btn_ilk10.UseVisualStyleBackColor = true;
            this.btn_ilk10.Click += new System.EventHandler(this.btn_ilk10_Click);
            // 
            // btn_son10
            // 
            this.btn_son10.Location = new System.Drawing.Point(713, 434);
            this.btn_son10.Name = "btn_son10";
            this.btn_son10.Size = new System.Drawing.Size(75, 23);
            this.btn_son10.TabIndex = 11;
            this.btn_son10.Text = "Son 10 Kayıt";
            this.btn_son10.UseVisualStyleBackColor = true;
            this.btn_son10.Click += new System.EventHandler(this.btn_son10_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.btn_son10);
            this.Controls.Add(this.btn_ilk10);
            this.Controls.Add(this.rdb_Azalan);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.rdb_Artan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ara);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.nud_stok);
            this.Controls.Add(this.nud_fiyat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_urunadi);
            this.Controls.Add(this.cmb_tedarikciler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_kategoriler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_urunler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_urunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_fiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stok)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_urunler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_tedarikciler;
        private System.Windows.Forms.ComboBox cmb_kategoriler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_urunadi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud_fiyat;
        private System.Windows.Forms.NumericUpDown nud_stok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.TextBox txt_ara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdb_Artan;
        private System.Windows.Forms.RadioButton rdb_Azalan;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btn_ilk10;
        private System.Windows.Forms.Button btn_son10;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}

