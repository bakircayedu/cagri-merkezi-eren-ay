namespace CagriMerkeziUyg
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CagriMerkezitabcntrl = new System.Windows.Forms.TabControl();
            this.Musteripage = new System.Windows.Forms.TabPage();
            this.lblTicariSira = new System.Windows.Forms.Label();
            this.lblBireyselSira = new System.Windows.Forms.Label();
            this.lboxTicariSira = new System.Windows.Forms.ListBox();
            this.lboxBireyselSira = new System.Windows.Forms.ListBox();
            this.lblMustSiraNo = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnArama = new System.Windows.Forms.Button();
            this.txtMustTel = new System.Windows.Forms.TextBox();
            this.cmbboxMustTur = new System.Windows.Forms.ComboBox();
            this.lblMusteriTuru = new System.Windows.Forms.Label();
            this.MusTellbl = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCagriBitir = new System.Windows.Forms.Button();
            this.rtxtTemsilciNotu = new System.Windows.Forms.RichTextBox();
            this.lblGorusmeNotu = new System.Windows.Forms.Label();
            this.listboxTemsilci = new System.Windows.Forms.ListBox();
            this.btnCagriAta = new System.Windows.Forms.Button();
            this.listviewCagri = new System.Windows.Forms.ListView();
            this.colCagriTanim = new System.Windows.Forms.ColumnHeader();
            this.colMusteriTuru = new System.Windows.Forms.ColumnHeader();
            this.colMusteriTanim = new System.Windows.Forms.ColumnHeader();
            this.colCagriZamani = new System.Windows.Forms.ColumnHeader();
            this.colMustTemsTanim = new System.Windows.Forms.ColumnHeader();
            this.colGorusmeBasZaman = new System.Windows.Forms.ColumnHeader();
            this.colGorusmeBitZaman = new System.Windows.Forms.ColumnHeader();
            this.pageRapor = new System.Windows.Forms.TabPage();
            this.rtxtAranilan = new System.Windows.Forms.RichTextBox();
            this.btnKelimeAra = new System.Windows.Forms.Button();
            this.lblAraKelime = new System.Windows.Forms.Label();
            this.txtAraKelime = new System.Windows.Forms.TextBox();
            this.btnGunlukSirala = new System.Windows.Forms.Button();
            this.btnGunlukTopla = new System.Windows.Forms.Button();
            this.listviewToplamArama = new System.Windows.Forms.ListView();
            this.colTarih = new System.Windows.Forms.ColumnHeader();
            this.colToplamArama = new System.Windows.Forms.ColumnHeader();
            this.timerMusteri = new System.Windows.Forms.Timer(this.components);
            this.CagriMerkezitabcntrl.SuspendLayout();
            this.Musteripage.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pageRapor.SuspendLayout();
            this.SuspendLayout();
            // 
            // CagriMerkezitabcntrl
            // 
            this.CagriMerkezitabcntrl.Controls.Add(this.Musteripage);
            this.CagriMerkezitabcntrl.Controls.Add(this.tabPage2);
            this.CagriMerkezitabcntrl.Controls.Add(this.pageRapor);
            this.CagriMerkezitabcntrl.Location = new System.Drawing.Point(39, 30);
            this.CagriMerkezitabcntrl.Name = "CagriMerkezitabcntrl";
            this.CagriMerkezitabcntrl.SelectedIndex = 0;
            this.CagriMerkezitabcntrl.Size = new System.Drawing.Size(1726, 863);
            this.CagriMerkezitabcntrl.TabIndex = 0;
            // 
            // Musteripage
            // 
            this.Musteripage.Controls.Add(this.lblTicariSira);
            this.Musteripage.Controls.Add(this.lblBireyselSira);
            this.Musteripage.Controls.Add(this.lboxTicariSira);
            this.Musteripage.Controls.Add(this.lboxBireyselSira);
            this.Musteripage.Controls.Add(this.lblMustSiraNo);
            this.Musteripage.Controls.Add(this.dateTimePicker1);
            this.Musteripage.Controls.Add(this.btnArama);
            this.Musteripage.Controls.Add(this.txtMustTel);
            this.Musteripage.Controls.Add(this.cmbboxMustTur);
            this.Musteripage.Controls.Add(this.lblMusteriTuru);
            this.Musteripage.Controls.Add(this.MusTellbl);
            this.Musteripage.Location = new System.Drawing.Point(4, 34);
            this.Musteripage.Name = "Musteripage";
            this.Musteripage.Padding = new System.Windows.Forms.Padding(3);
            this.Musteripage.Size = new System.Drawing.Size(1718, 825);
            this.Musteripage.TabIndex = 0;
            this.Musteripage.Text = "Musteri Tanimlayici";
            this.Musteripage.UseVisualStyleBackColor = true;
            // 
            // lblTicariSira
            // 
            this.lblTicariSira.AutoSize = true;
            this.lblTicariSira.Location = new System.Drawing.Point(1010, 42);
            this.lblTicariSira.Name = "lblTicariSira";
            this.lblTicariSira.Size = new System.Drawing.Size(86, 25);
            this.lblTicariSira.TabIndex = 13;
            this.lblTicariSira.Text = "Ticari Sira";
            // 
            // lblBireyselSira
            // 
            this.lblBireyselSira.AutoSize = true;
            this.lblBireyselSira.Location = new System.Drawing.Point(618, 42);
            this.lblBireyselSira.Name = "lblBireyselSira";
            this.lblBireyselSira.Size = new System.Drawing.Size(105, 25);
            this.lblBireyselSira.TabIndex = 12;
            this.lblBireyselSira.Text = "Bireysel Sira";
            // 
            // lboxTicariSira
            // 
            this.lboxTicariSira.FormattingEnabled = true;
            this.lboxTicariSira.ItemHeight = 25;
            this.lboxTicariSira.Location = new System.Drawing.Point(1010, 78);
            this.lboxTicariSira.Name = "lboxTicariSira";
            this.lboxTicariSira.Size = new System.Drawing.Size(329, 329);
            this.lboxTicariSira.TabIndex = 11;
            // 
            // lboxBireyselSira
            // 
            this.lboxBireyselSira.FormattingEnabled = true;
            this.lboxBireyselSira.ItemHeight = 25;
            this.lboxBireyselSira.Location = new System.Drawing.Point(617, 78);
            this.lboxBireyselSira.Name = "lboxBireyselSira";
            this.lboxBireyselSira.Size = new System.Drawing.Size(340, 329);
            this.lboxBireyselSira.TabIndex = 10;
            // 
            // lblMustSiraNo
            // 
            this.lblMustSiraNo.AutoSize = true;
            this.lblMustSiraNo.Location = new System.Drawing.Point(672, 22);
            this.lblMustSiraNo.Name = "lblMustSiraNo";
            this.lblMustSiraNo.Size = new System.Drawing.Size(0, 25);
            this.lblMustSiraNo.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(55, 185);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(396, 31);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // btnArama
            // 
            this.btnArama.Location = new System.Drawing.Point(55, 242);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(396, 34);
            this.btnArama.TabIndex = 6;
            this.btnArama.Text = "Arama Yap";
            this.btnArama.UseVisualStyleBackColor = true;
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // txtMustTel
            // 
            this.txtMustTel.Location = new System.Drawing.Point(269, 78);
            this.txtMustTel.Name = "txtMustTel";
            this.txtMustTel.Size = new System.Drawing.Size(182, 31);
            this.txtMustTel.TabIndex = 5;
            // 
            // cmbboxMustTur
            // 
            this.cmbboxMustTur.BackColor = System.Drawing.SystemColors.Info;
            this.cmbboxMustTur.FormattingEnabled = true;
            this.cmbboxMustTur.Items.AddRange(new object[] {
            "Bireysel",
            "Ticari"});
            this.cmbboxMustTur.Location = new System.Drawing.Point(269, 131);
            this.cmbboxMustTur.Name = "cmbboxMustTur";
            this.cmbboxMustTur.Size = new System.Drawing.Size(182, 33);
            this.cmbboxMustTur.TabIndex = 3;
            this.cmbboxMustTur.Text = "Bireysel";
            // 
            // lblMusteriTuru
            // 
            this.lblMusteriTuru.AutoSize = true;
            this.lblMusteriTuru.Location = new System.Drawing.Point(52, 139);
            this.lblMusteriTuru.Name = "lblMusteriTuru";
            this.lblMusteriTuru.Size = new System.Drawing.Size(115, 25);
            this.lblMusteriTuru.TabIndex = 2;
            this.lblMusteriTuru.Text = "Musteri Turu:";
            // 
            // MusTellbl
            // 
            this.MusTellbl.AutoSize = true;
            this.MusTellbl.Location = new System.Drawing.Point(52, 84);
            this.MusTellbl.Name = "MusTellbl";
            this.MusTellbl.Size = new System.Drawing.Size(100, 25);
            this.MusTellbl.TabIndex = 1;
            this.MusTellbl.Text = "Musteri Tel:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCagriBitir);
            this.tabPage2.Controls.Add(this.rtxtTemsilciNotu);
            this.tabPage2.Controls.Add(this.lblGorusmeNotu);
            this.tabPage2.Controls.Add(this.listboxTemsilci);
            this.tabPage2.Controls.Add(this.btnCagriAta);
            this.tabPage2.Controls.Add(this.listviewCagri);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1718, 825);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cagri Merkezi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCagriBitir
            // 
            this.btnCagriBitir.Location = new System.Drawing.Point(206, 540);
            this.btnCagriBitir.Name = "btnCagriBitir";
            this.btnCagriBitir.Size = new System.Drawing.Size(153, 34);
            this.btnCagriBitir.TabIndex = 5;
            this.btnCagriBitir.Text = "Cagriyi Bitir";
            this.btnCagriBitir.UseVisualStyleBackColor = true;
            this.btnCagriBitir.Click += new System.EventHandler(this.btnCagriBitir_Click);
            // 
            // rtxtTemsilciNotu
            // 
            this.rtxtTemsilciNotu.Location = new System.Drawing.Point(1233, 536);
            this.rtxtTemsilciNotu.Name = "rtxtTemsilciNotu";
            this.rtxtTemsilciNotu.Size = new System.Drawing.Size(404, 205);
            this.rtxtTemsilciNotu.TabIndex = 4;
            this.rtxtTemsilciNotu.Text = "";
            // 
            // lblGorusmeNotu
            // 
            this.lblGorusmeNotu.AutoSize = true;
            this.lblGorusmeNotu.Location = new System.Drawing.Point(997, 545);
            this.lblGorusmeNotu.Name = "lblGorusmeNotu";
            this.lblGorusmeNotu.Size = new System.Drawing.Size(211, 25);
            this.lblGorusmeNotu.TabIndex = 3;
            this.lblGorusmeNotu.Text = "Temsilci Gorusme Notlari:";
            // 
            // listboxTemsilci
            // 
            this.listboxTemsilci.FormattingEnabled = true;
            this.listboxTemsilci.ItemHeight = 25;
            this.listboxTemsilci.Location = new System.Drawing.Point(25, 24);
            this.listboxTemsilci.Name = "listboxTemsilci";
            this.listboxTemsilci.Size = new System.Drawing.Size(334, 479);
            this.listboxTemsilci.TabIndex = 2;
            // 
            // btnCagriAta
            // 
            this.btnCagriAta.Location = new System.Drawing.Point(25, 540);
            this.btnCagriAta.Name = "btnCagriAta";
            this.btnCagriAta.Size = new System.Drawing.Size(160, 34);
            this.btnCagriAta.TabIndex = 1;
            this.btnCagriAta.Text = "Cagriyi Ata";
            this.btnCagriAta.UseVisualStyleBackColor = true;
            this.btnCagriAta.Click += new System.EventHandler(this.btnCagriAta_Click);
            // 
            // listviewCagri
            // 
            this.listviewCagri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCagriTanim,
            this.colMusteriTuru,
            this.colMusteriTanim,
            this.colCagriZamani,
            this.colMustTemsTanim,
            this.colGorusmeBasZaman,
            this.colGorusmeBitZaman});
            this.listviewCagri.FullRowSelect = true;
            this.listviewCagri.GridLines = true;
            this.listviewCagri.Location = new System.Drawing.Point(381, 24);
            this.listviewCagri.Name = "listviewCagri";
            this.listviewCagri.Size = new System.Drawing.Size(1256, 479);
            this.listviewCagri.TabIndex = 0;
            this.listviewCagri.UseCompatibleStateImageBehavior = false;
            this.listviewCagri.View = System.Windows.Forms.View.Details;
            this.listviewCagri.SelectedIndexChanged += new System.EventHandler(this.listviewCagri_SelectedIndexChanged);
            // 
            // colCagriTanim
            // 
            this.colCagriTanim.Text = "Cagri Tanimlayici";
            this.colCagriTanim.Width = 200;
            // 
            // colMusteriTuru
            // 
            this.colMusteriTuru.Text = "Musteri Turu";
            this.colMusteriTuru.Width = 150;
            // 
            // colMusteriTanim
            // 
            this.colMusteriTanim.Text = "Musteri Tanimlayici";
            this.colMusteriTanim.Width = 200;
            // 
            // colCagriZamani
            // 
            this.colCagriZamani.Text = "Cagri Zamani";
            this.colCagriZamani.Width = 150;
            // 
            // colMustTemsTanim
            // 
            this.colMustTemsTanim.Text = "Temsilci Tanimlayici";
            this.colMustTemsTanim.Width = 200;
            // 
            // colGorusmeBasZaman
            // 
            this.colGorusmeBasZaman.Text = "Gorusme Baslangic";
            this.colGorusmeBasZaman.Width = 180;
            // 
            // colGorusmeBitZaman
            // 
            this.colGorusmeBitZaman.Text = "Gorusme Bitis";
            this.colGorusmeBitZaman.Width = 170;
            // 
            // pageRapor
            // 
            this.pageRapor.Controls.Add(this.rtxtAranilan);
            this.pageRapor.Controls.Add(this.btnKelimeAra);
            this.pageRapor.Controls.Add(this.lblAraKelime);
            this.pageRapor.Controls.Add(this.txtAraKelime);
            this.pageRapor.Controls.Add(this.btnGunlukSirala);
            this.pageRapor.Controls.Add(this.btnGunlukTopla);
            this.pageRapor.Controls.Add(this.listviewToplamArama);
            this.pageRapor.Location = new System.Drawing.Point(4, 34);
            this.pageRapor.Name = "pageRapor";
            this.pageRapor.Padding = new System.Windows.Forms.Padding(3);
            this.pageRapor.Size = new System.Drawing.Size(1718, 825);
            this.pageRapor.TabIndex = 2;
            this.pageRapor.Text = "Rapor";
            this.pageRapor.UseVisualStyleBackColor = true;
            // 
            // rtxtAranilan
            // 
            this.rtxtAranilan.Location = new System.Drawing.Point(493, 140);
            this.rtxtAranilan.Name = "rtxtAranilan";
            this.rtxtAranilan.Size = new System.Drawing.Size(478, 191);
            this.rtxtAranilan.TabIndex = 6;
            this.rtxtAranilan.Text = "";
            // 
            // btnKelimeAra
            // 
            this.btnKelimeAra.Location = new System.Drawing.Point(493, 77);
            this.btnKelimeAra.Name = "btnKelimeAra";
            this.btnKelimeAra.Size = new System.Drawing.Size(478, 34);
            this.btnKelimeAra.TabIndex = 5;
            this.btnKelimeAra.Text = "Kelime Ara";
            this.btnKelimeAra.UseVisualStyleBackColor = true;
            this.btnKelimeAra.Click += new System.EventHandler(this.btnKelimeAra_Click);
            // 
            // lblAraKelime
            // 
            this.lblAraKelime.AutoSize = true;
            this.lblAraKelime.Location = new System.Drawing.Point(493, 25);
            this.lblAraKelime.Name = "lblAraKelime";
            this.lblAraKelime.Size = new System.Drawing.Size(141, 25);
            this.lblAraKelime.TabIndex = 4;
            this.lblAraKelime.Text = "Aranacak Kelime";
            // 
            // txtAraKelime
            // 
            this.txtAraKelime.Location = new System.Drawing.Point(664, 22);
            this.txtAraKelime.Name = "txtAraKelime";
            this.txtAraKelime.Size = new System.Drawing.Size(307, 31);
            this.txtAraKelime.TabIndex = 3;
            // 
            // btnGunlukSirala
            // 
            this.btnGunlukSirala.Location = new System.Drawing.Point(39, 628);
            this.btnGunlukSirala.Name = "btnGunlukSirala";
            this.btnGunlukSirala.Size = new System.Drawing.Size(306, 34);
            this.btnGunlukSirala.TabIndex = 2;
            this.btnGunlukSirala.Text = "Sirala";
            this.btnGunlukSirala.UseVisualStyleBackColor = true;
            this.btnGunlukSirala.Click += new System.EventHandler(this.btnGunlukSirala_Click);
            // 
            // btnGunlukTopla
            // 
            this.btnGunlukTopla.Location = new System.Drawing.Point(39, 563);
            this.btnGunlukTopla.Name = "btnGunlukTopla";
            this.btnGunlukTopla.Size = new System.Drawing.Size(306, 34);
            this.btnGunlukTopla.TabIndex = 1;
            this.btnGunlukTopla.Text = "Gunluk Toplam Arama";
            this.btnGunlukTopla.UseVisualStyleBackColor = true;
            this.btnGunlukTopla.Click += new System.EventHandler(this.btnGunlukTopla_Click);
            // 
            // listviewToplamArama
            // 
            this.listviewToplamArama.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTarih,
            this.colToplamArama});
            this.listviewToplamArama.FullRowSelect = true;
            this.listviewToplamArama.GridLines = true;
            this.listviewToplamArama.Location = new System.Drawing.Point(39, 22);
            this.listviewToplamArama.Name = "listviewToplamArama";
            this.listviewToplamArama.Size = new System.Drawing.Size(306, 524);
            this.listviewToplamArama.TabIndex = 0;
            this.listviewToplamArama.UseCompatibleStateImageBehavior = false;
            this.listviewToplamArama.View = System.Windows.Forms.View.Details;
            // 
            // colTarih
            // 
            this.colTarih.Text = "Tarih";
            this.colTarih.Width = 150;
            // 
            // colToplamArama
            // 
            this.colToplamArama.Text = "Toplam Arama";
            this.colToplamArama.Width = 150;
            // 
            // timerMusteri
            // 
            this.timerMusteri.Interval = 3000;
            this.timerMusteri.Tick += new System.EventHandler(this.timerMusteri_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1857, 993);
            this.Controls.Add(this.CagriMerkezitabcntrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CagriMerkezitabcntrl.ResumeLayout(false);
            this.Musteripage.ResumeLayout(false);
            this.Musteripage.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.pageRapor.ResumeLayout(false);
            this.pageRapor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl CagriMerkezitabcntrl;
        private TabPage Musteripage;
        private TabPage tabPage2;
        private Label lblMusteriTuru;
        private Label MusTellbl;
        private ComboBox cmbboxMustTur;
        private TextBox txtMustTel;
        private DateTimePicker dateTimePicker1;
        private Button btnArama;
        private System.Windows.Forms.Timer timerMusteri;
        private Label lblMustSiraNo;
        private ListBox listboxTemsilci;
        private Button btnCagriAta;
        private ListView listviewCagri;
        private ColumnHeader colCagriTanim;
        private ColumnHeader colMusteriTuru;
        private ColumnHeader colMusteriTanim;
        private ColumnHeader colCagriZamani;
        private ListBox lboxBireyselSira;
        private TabPage pageRapor;
        private RichTextBox rtxtTemsilciNotu;
        private Label lblGorusmeNotu;
        private ColumnHeader colMustTemsTanim;
        private ColumnHeader colGorusmeBasZaman;
        private ColumnHeader colGorusmeBitZaman;
        private Button btnCagriBitir;
        private Button btnGunlukTopla;
        private ListView listviewToplamArama;
        private ColumnHeader colTarih;
        private ColumnHeader colToplamArama;
        private Button btnGunlukSirala;
        private ListBox lboxTicariSira;
        private Label lblTicariSira;
        private Label lblBireyselSira;
        private RichTextBox rtxtAranilan;
        private Button btnKelimeAra;
        private Label lblAraKelime;
        private TextBox txtAraKelime;
    }
}