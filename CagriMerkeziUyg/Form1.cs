namespace CagriMerkeziUyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BagList TicariCagri = new BagList();

        BagList BireyselCagri = new BagList();
        
        BagList Cagri = new BagList();

        StackList Temsilci = new StackList();

        int cagriId = 1;
        int temsilciId = 1;
        int GunSayisi = 0;
        public void CagriListeEkle(Cagri cagri)
        {
            Cagri.InsertLast(cagri);
            DateTime dt = default;
            if (cagri.GorusmeBaslangicZaman == dt)
            {
                if (cagri.CagriTuru == "Bireysel") // Bireysel Musteri Bekleme sirasi
                {
                    BireyselCagri.InsertLast(cagri);
                }
                else if (cagri.CagriTuru == "Ticari") // Ticari Musteri Bekleme sirasi
                {
                    TicariCagri.InsertLast(cagri);
                }
            }  
        }

        public void OrnekVeriYukle()
        {
            Cagri cagri = new Cagri("53351688", "Bireysel", DateTime.Now, cagriId);
            cagriId++;
            CagriListeEkle(cagri);
            cagri = new Cagri("533244188", "Ticari", DateTime.Now, cagriId);
            cagriId++;
            CagriListeEkle(cagri);
            cagri = new Cagri("512351688", "Bireysel", DateTime.Now, cagriId);
            cagriId++;
            CagriListeEkle(cagri);
            cagri = new Cagri("41451688", "Ticari", DateTime.Now, cagriId);
            cagriId++;
            CagriListeEkle(cagri);
            cagri = new Cagri("98851688", "Ticari", DateTime.Now, cagriId);
            cagriId++;
            CagriListeEkle(cagri);
            cagri = new Cagri("213688", "Ticari", DateTime.Now.AddDays(-10), cagriId);
            cagriId++;
            CagriListeEkle(cagri);
            cagri = new Cagri("42423688", "Ticari", DateTime.Now.AddDays(-10), cagriId);
            cagriId++;
            CagriListeEkle(cagri);
            cagri = new Cagri("414324", "Ticari", DateTime.Now.AddDays(10), cagriId);
            cagriId++;
            CagriListeEkle(cagri);

            MusteriTemsilci temsilci = new MusteriTemsilci();
            temsilci.TemsilciId = temsilciId;
            temsilciId++;
            temsilci.TemsilciTuru = "Bireysel";
            Temsilci.Push(temsilci);
            temsilci = new MusteriTemsilci();
            temsilci.TemsilciId = temsilciId;
            temsilciId++;
            temsilci.TemsilciTuru = "Ticari";
            Temsilci.Push(temsilci);
            temsilci = new MusteriTemsilci();
            temsilci.TemsilciId = temsilciId;
            temsilciId++;
            temsilci.TemsilciTuru = "Ticari";
            Temsilci.Push(temsilci);
            temsilci = new MusteriTemsilci();
            temsilci.TemsilciId = temsilciId;
            temsilciId++;
            temsilci.TemsilciTuru = "Bireysel";
            Temsilci.Push(temsilci);


        }

        public string TemsilciToStr(MusteriTemsilci temsilci)
        {
            string TemsilciStr = temsilci.TemsilciId + "  " + temsilci.TemsilciTuru;
            return TemsilciStr;
        }

        public string[] CagriToStr(Cagri cagri)    // cagri bilgilerini string olarak sub itemlerine bolunmus sekilde dondurur
        {
            DateTime dt= default;
            if (cagri.GorusmeBaslangicZaman == dt)    //Gorusme baslangic zamani atanmamissa cevap verilmemistir
            {
                string[] row = { cagri.CagriTanimlayici.ToString(), cagri.CagriTuru, cagri.MusteriTanimlayici, cagri.AramaZamani.ToString(), "", "", "", "" };
                return row;
            }
            else
            {
                string[] row = { cagri.CagriTanimlayici.ToString(), cagri.CagriTuru, cagri.MusteriTanimlayici, cagri.AramaZamani.ToString(), cagri.MusteriTemsilciTanimlayici.TemsilciId.ToString(), cagri.GorusmeBaslangicZaman.ToString(), cagri.GorusmeBitisZaman.ToString(), cagri.GorusmeNotlari };
                return row; 
            }
        }

        public void BilgiGuncelleTemsilci()
        {
            listboxTemsilci.Items.Clear();
            string TemsilciBilgi;
            for (int i = 1; i <= Temsilci.Size; i++)
            {
                Eleman eleman = Temsilci.GetEleman(i);
                TemsilciBilgi = TemsilciToStr(eleman.Data);
                listboxTemsilci.Items.Add(TemsilciBilgi);
            }
        }

        public void BilgiGuncelleMusteri()
        {
            listviewCagri.Items.Clear();
            for (int i = 1; i<=Cagri.Size; i++)
            {
                Node Cagribil = Cagri.GetElement(i);
                string[] row = CagriToStr(Cagribil.Data);
                var satir = new ListViewItem(row);
                listviewCagri.Items.Add(satir);
                
            }
        }


        

        public void CagriAta()
        {
            int CagriAtaId;
            Cagri cagriaranilan;
            int AranilanPosition;



            if (listboxTemsilci.SelectedItems.Count > 0)  // secili Temsilci varsa
            {
                string SeciliTemsilci = listboxTemsilci.SelectedItem.ToString();
                string[] TemsilciBilgi = SeciliTemsilci.Split(' ');  //ilk index i temsilci id yi verir              
                int temsilciId = Convert.ToInt32(TemsilciBilgi[0]);
                MusteriTemsilci mustTemsilci = Temsilci.GetElemanById(temsilciId).Data;

                if (listviewCagri.SelectedItems.Count > 0)   // listview de secili cagri var ise onu alacaktir 
                {
                    if (mustTemsilci.TemsilciDurumu == false)
                    {
                        MessageBox.Show("Secilen Temsilci Baska Cagrida ");
                    }
                    else
                    {
                        CagriAtaId = Convert.ToInt32(listviewCagri.SelectedItems[0].SubItems[0].Text); //secilen cagri
                        cagriaranilan = Cagri.GetElementById(CagriAtaId).Data;
                        if (cagriaranilan.CagriTuru == "Bireysel")              //hangi sirada ise o siradan pozisyonu bulunarak silindi
                        {
                            AranilanPosition = BireyselCagri.GetPositionById(CagriAtaId);
                            BireyselCagri.DeletePos(AranilanPosition);          //Position bilgisi ile silindi sirada bir bozulma yok
                        }
                        else if (cagriaranilan.CagriTuru == "Ticari")
                        {
                            AranilanPosition = TicariCagri.GetPositionById(CagriAtaId);
                            TicariCagri.DeletePos(AranilanPosition);
                        }
                        
                    

                        cagriaranilan.GorusmeBaslangicZaman = DateTime.Now;
                        cagriaranilan.MusteriTemsilciTanimlayici = mustTemsilci;
                        mustTemsilci.cagri=cagriaranilan;    
                        mustTemsilci.TemsilciDurumu = false; //musteri atandi
                    }
                }
                else  //siradan aramayi almak
                {
                    if (mustTemsilci.TemsilciDurumu==false)
                    {
                        MessageBox.Show("Secilen Temsilci Baska Cagrida ");
                    }
                    else
                    {
                        if (mustTemsilci.TemsilciTuru=="Bireysel")
                        {
                            CagriAtaId = BireyselCagri.GetElement(1).Data.CagriTanimlayici;
                            cagriaranilan = Cagri.GetElementById(CagriAtaId).Data;
                            BireyselCagri.DeleteFirst();
                            cagriaranilan.GorusmeBaslangicZaman = DateTime.Now;
                            cagriaranilan.MusteriTemsilciTanimlayici = mustTemsilci;
                            mustTemsilci.cagri = cagriaranilan;
                            mustTemsilci.TemsilciDurumu = false; //musteri atandi

                        }
                        else if (mustTemsilci.TemsilciTuru=="Ticari")
                        {
                            CagriAtaId = TicariCagri.GetElement(1).Data.CagriTanimlayici;
                            cagriaranilan = Cagri.GetElementById(CagriAtaId).Data;
                            TicariCagri.DeleteFirst();
                            cagriaranilan.GorusmeBaslangicZaman = DateTime.Now;
                            cagriaranilan.MusteriTemsilciTanimlayici = mustTemsilci;
                            mustTemsilci.cagri = cagriaranilan;
                            mustTemsilci.TemsilciDurumu = false; //musteri atandi
                        }


                       
                    }

                }
                BilgiGuncelleMusteri();


            }

        }

        public void MusteriSiraGuncelle()
        {
            string SiraGoster;
            lboxBireyselSira.Items.Clear();
            lboxTicariSira.Items.Clear();
            for (int i = 1; i <= BireyselCagri.Size; i++)
            {
                SiraGoster = i + ".Sirada " + " Numara:" + BireyselCagri.GetElement(i).Data.MusteriTanimlayici;
                lboxBireyselSira.Items.Add(SiraGoster);
            }
            for (int i = 1; i <= TicariCagri.Size; i++)
            {
                SiraGoster = i + ".Sirada "+ " Numara:"+ TicariCagri.GetElement(i).Data.MusteriTanimlayici;
                lboxTicariSira.Items.Add(SiraGoster);
            }
        }


        public void GunlukAramaSayiTopla()
        {
            listviewToplamArama.Items.Clear();
            int Topla;
            string CagriTarihi;
            bool Kontrol;
            
            for (int i = 1; i <= Cagri.Size; i++)
            {
                Kontrol = false;
                Node Cagribil = Cagri.GetElement(i);
                CagriTarihi = Cagribil.Data.AramaZamani.ToString();
                CagriTarihi = CagriTarihi.Split(' ')[0];  //Cagrinin Arama tarihi    
                for (int j = 0; j < listviewToplamArama.Items.Count; j++)
                {
                    if (CagriTarihi==listviewToplamArama.Items[j].SubItems[0].Text)
                    {
                        Kontrol = true;
                        Topla = Convert.ToInt32(listviewToplamArama.Items[j].SubItems[1].Text) + 1;
                        listviewToplamArama.Items[j].SubItems[1].Text = Topla.ToString();
                    }
                    
                }
                if (Kontrol==false)
                {
                    string[] row = { CagriTarihi, "1"};
                    var satir = new ListViewItem(row);
                    listviewToplamArama.Items.Add(satir);
                }
            }
        }

        public int[] BubbleSortSirala(int[] dizi)
        {
            int temp;
            bool swapped = false;
            for (int i = 0; i < dizi.Length; i++)
            {
                swapped = false;
                for (int j = 0; j < dizi.Length - i - 1; j++)
                {
                    if (dizi[j] > dizi[j + 1])
                    {
                        temp = dizi[j];
                        dizi[j] = dizi[j + 1];
                        dizi[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (swapped == false)
                {
                    return dizi;
                }
            }
            
            return dizi;
        }

        public void BubbleSortSirala(int[] SayiDizi,string[] StrDizi)
        {
            int Temp;
            string strTemp;
            bool swapped = false;
            for (int i = 0; i < SayiDizi.Length; i++)
            {
                swapped = false;
                for (int j = 0; j < SayiDizi.Length - i - 1; j++)
                {
                    if (SayiDizi[j] > SayiDizi[j+1])
                    {
                        Temp = SayiDizi[j];
                        strTemp = StrDizi[j];
                        SayiDizi[j] = SayiDizi[j + 1];
                        StrDizi[j] = StrDizi[j + 1];
                        SayiDizi[j + 1] = Temp;
                        StrDizi[j + 1] = strTemp;
                        swapped = true;
                    }
                }
                if (swapped == false)
                {
                    break;
                }
            }
            for (int j = 0; j < listviewToplamArama.Items.Count; j++)
            {
                listviewToplamArama.Items[j].SubItems[0].Text = StrDizi[j];
                listviewToplamArama.Items[j].SubItems[1].Text = SayiDizi[j].ToString();
            }
        }

        public string KelimeAra(string Aranilan,string AranilanKelime)
        {
            string[] Kelimeler = Aranilan.Split(' ');
            foreach (var Kelime in Kelimeler)
            {
                if (Kelime == AranilanKelime)
                {
                    return Aranilan;
                }
            }
            return "";
        }








        private void Form1_Load(object sender, EventArgs e)
        {
            OrnekVeriYukle();
            BilgiGuncelleTemsilci();
            BilgiGuncelleMusteri();
            timerMusteri.Enabled = true;
        }
        

        private void btnArama_Click(object sender, EventArgs e)
        {
            
            string MusteriTel = txtMustTel.Text;
            string MusteriTuru = cmbboxMustTur.Text;
            DateTime date = dateTimePicker1.Value;
            Cagri cagri = new Cagri(MusteriTel,MusteriTuru,date,cagriId);
            cagriId += 1;
            Cagri.InsertLast(cagri);

            BilgiGuncelleMusteri();
        }

        private void btnCagriAta_Click(object sender, EventArgs e)
        {
            CagriAta();
        }

        private void listviewCagri_SelectedIndexChanged(object sender, EventArgs e) //secili olanin temsilci notunu richtextbox a yazdir
        {
            int index = listviewCagri.SelectedItems.Count; // secili index degistirirken once secili index sifirlanip sonra index seciliyor bu yuzden secili index sifirlanirken hata olmamasi icin 
            if (index>=1)
            rtxtTemsilciNotu.Text = listviewCagri.SelectedItems[0].SubItems[7].Text;
        }

        

        private void btnCagriBitir_Click(object sender, EventArgs e)                 //temsilcinin cagrisinda aldigi notu kaydetmek icin kullanilabilir
        {

            if (listboxTemsilci.SelectedItems.Count > 0)  // secili Temsilci varsa
            {
                string SeciliTemsilci = listboxTemsilci.SelectedItem.ToString();
                string[] TemsilciBilgi = SeciliTemsilci.Split(' ');  //ilk index i temsilci id yi verir              
                int temsilciId = Convert.ToInt32(TemsilciBilgi[0]);
                MusteriTemsilci mustTemsilci = Temsilci.GetElemanById(temsilciId).Data;
                mustTemsilci.cagri.GorusmeBitisZaman = DateTime.Now;
                mustTemsilci.cagri.GorusmeNotlari = rtxtTemsilciNotu.Text;    // cagri biterkene notlar ve bitirme zamani kaydedildi
                mustTemsilci.TemsilciDurumu = true;
            }
            BilgiGuncelleMusteri();
        }

        

        private void timerMusteri_Tick(object sender, EventArgs e)
        {
            MusteriSiraGuncelle();
        }

        private void btnGunlukTopla_Click(object sender, EventArgs e)
        {
            GunlukAramaSayiTopla();
        }

        private void btnGunlukSirala_Click(object sender, EventArgs e)
        {
            int[] GunlukToplamArama = new int[listviewToplamArama.Items.Count];
            string[] GunlukTarihi = new string[listviewToplamArama.Items.Count];

            for (int j = 0; j < listviewToplamArama.Items.Count; j++)
            {
                GunlukToplamArama[j] = Convert.ToInt32(listviewToplamArama.Items[j].SubItems[1].Text);
                GunlukTarihi[j] = listviewToplamArama.Items[j].SubItems[0].Text;
            }
            BubbleSortSirala(GunlukToplamArama, GunlukTarihi);
        }

        private void btnKelimeAra_Click(object sender, EventArgs e)
        {
            string Ara = txtAraKelime.Text;
            string BulunduguText="";
            for (int i = 0; i < listviewCagri.Items.Count; i++)
            {
                 BulunduguText = KelimeAra(listviewCagri.Items[i].SubItems[7].Text, Ara);
            }
            rtxtAranilan.Text = BulunduguText;
        }
    }
}