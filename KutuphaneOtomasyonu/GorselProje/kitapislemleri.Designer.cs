namespace GorselProje
{
    partial class kitapislemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kitapislemleri));
            this.lblBaslik = new System.Windows.Forms.Label();
            this.tabControlKtp = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtpEklemeTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpYayinTarihi = new System.Windows.Forms.DateTimePicker();
            this.radioBtnHasarli = new System.Windows.Forms.RadioButton();
            this.radioBtnKullmz = new System.Windows.Forms.RadioButton();
            this.radioBtnTemiz = new System.Windows.Forms.RadioButton();
            this.comboBoxKtpTur = new System.Windows.Forms.ComboBox();
            this.lblUyelikTarihi = new System.Windows.Forms.Label();
            this.txtYynEviAdi = new System.Windows.Forms.TextBox();
            this.lblKitapTuru = new System.Windows.Forms.Label();
            this.lblKitapDurum = new System.Windows.Forms.Label();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.txtYazarAdi = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.lblSayfaSayisi = new System.Windows.Forms.Label();
            this.lblYynTarihi = new System.Windows.Forms.Label();
            this.lblYynEviAdi = new System.Windows.Forms.Label();
            this.lblYazarAdi = new System.Windows.Forms.Label();
            this.lblKitapAdi = new System.Windows.Forms.Label();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.groupBoxKitapGuncelle = new System.Windows.Forms.GroupBox();
            this.dtpDEklemeTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpDYayinTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblKitapDuzenleSonuc = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.radioBtnDHasarlii = new System.Windows.Forms.RadioButton();
            this.btnDKitapDuzenle = new System.Windows.Forms.Button();
            this.radioBtnDKullmz = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.radioBtnDTemiz = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxDKitapTur = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDKitapAdi = new System.Windows.Forms.TextBox();
            this.txtDYayinEvi = new System.Windows.Forms.TextBox();
            this.txtDYazarAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDSayfaSayisi = new System.Windows.Forms.TextBox();
            this.txtDKitapBarkod = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblSilSonuc = new System.Windows.Forms.Label();
            this.btnKitapSilSonuc = new System.Windows.Forms.Button();
            this.txtSKitapBarkod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKitapEkleSonuc = new System.Windows.Forms.Label();
            this.tabControlKtp.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxKitapGuncelle.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(15, 15);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(161, 25);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Kitap İşlemleri";
            // 
            // tabControlKtp
            // 
            this.tabControlKtp.Controls.Add(this.tabPage1);
            this.tabControlKtp.Controls.Add(this.tabPage2);
            this.tabControlKtp.Controls.Add(this.tabPage3);
            this.tabControlKtp.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControlKtp.Location = new System.Drawing.Point(20, 75);
            this.tabControlKtp.Name = "tabControlKtp";
            this.tabControlKtp.SelectedIndex = 0;
            this.tabControlKtp.Size = new System.Drawing.Size(820, 460);
            this.tabControlKtp.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtpEklemeTarihi);
            this.tabPage1.Controls.Add(this.dtpYayinTarihi);
            this.tabPage1.Controls.Add(this.radioBtnHasarli);
            this.tabPage1.Controls.Add(this.radioBtnKullmz);
            this.tabPage1.Controls.Add(this.radioBtnTemiz);
            this.tabPage1.Controls.Add(this.lblKitapEkleSonuc);
            this.tabPage1.Controls.Add(this.comboBoxKtpTur);
            this.tabPage1.Controls.Add(this.lblUyelikTarihi);
            this.tabPage1.Controls.Add(this.txtYynEviAdi);
            this.tabPage1.Controls.Add(this.lblKitapTuru);
            this.tabPage1.Controls.Add(this.lblKitapDurum);
            this.tabPage1.Controls.Add(this.txtSayfaSayisi);
            this.tabPage1.Controls.Add(this.txtYazarAdi);
            this.tabPage1.Controls.Add(this.txtKitapAdi);
            this.tabPage1.Controls.Add(this.lblSayfaSayisi);
            this.tabPage1.Controls.Add(this.lblYynTarihi);
            this.tabPage1.Controls.Add(this.lblYynEviAdi);
            this.tabPage1.Controls.Add(this.lblYazarAdi);
            this.tabPage1.Controls.Add(this.lblKitapAdi);
            this.tabPage1.Controls.Add(this.btnKitapEkle);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(812, 430);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kitap Ekle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtpEklemeTarihi
            // 
            this.dtpEklemeTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEklemeTarihi.Location = new System.Drawing.Point(217, 275);
            this.dtpEklemeTarihi.Name = "dtpEklemeTarihi";
            this.dtpEklemeTarihi.Size = new System.Drawing.Size(300, 24);
            this.dtpEklemeTarihi.TabIndex = 43;
            // 
            // dtpYayinTarihi
            // 
            this.dtpYayinTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpYayinTarihi.Location = new System.Drawing.Point(217, 186);
            this.dtpYayinTarihi.Name = "dtpYayinTarihi";
            this.dtpYayinTarihi.Size = new System.Drawing.Size(300, 24);
            this.dtpYayinTarihi.TabIndex = 38;
            // 
            // radioBtnHasarli
            // 
            this.radioBtnHasarli.AutoSize = true;
            this.radioBtnHasarli.Location = new System.Drawing.Point(314, 245);
            this.radioBtnHasarli.Name = "radioBtnHasarli";
            this.radioBtnHasarli.Size = new System.Drawing.Size(70, 21);
            this.radioBtnHasarli.TabIndex = 41;
            this.radioBtnHasarli.TabStop = true;
            this.radioBtnHasarli.Text = "Hasarlı";
            this.radioBtnHasarli.UseVisualStyleBackColor = true;
            // 
            // radioBtnKullmz
            // 
            this.radioBtnKullmz.AutoSize = true;
            this.radioBtnKullmz.Location = new System.Drawing.Point(411, 245);
            this.radioBtnKullmz.Name = "radioBtnKullmz";
            this.radioBtnKullmz.Size = new System.Drawing.Size(106, 21);
            this.radioBtnKullmz.TabIndex = 42;
            this.radioBtnKullmz.Text = "Kullanılamaz";
            this.radioBtnKullmz.UseVisualStyleBackColor = true;
            // 
            // radioBtnTemiz
            // 
            this.radioBtnTemiz.AutoSize = true;
            this.radioBtnTemiz.Checked = true;
            this.radioBtnTemiz.Location = new System.Drawing.Point(217, 245);
            this.radioBtnTemiz.Name = "radioBtnTemiz";
            this.radioBtnTemiz.Size = new System.Drawing.Size(62, 21);
            this.radioBtnTemiz.TabIndex = 40;
            this.radioBtnTemiz.TabStop = true;
            this.radioBtnTemiz.Text = "Temiz";
            this.radioBtnTemiz.UseVisualStyleBackColor = true;
            // 
            // comboBoxKtpTur
            // 
            this.comboBoxKtpTur.FormattingEnabled = true;
            this.comboBoxKtpTur.Items.AddRange(new object[] {
            "Aforizmalar",
            "Ahlak",
            "Aile Bilgileri",
            "Aile/İnsan",
            "Aile/İnsan - Kadın",
            "Aksiyon ve Macera",
            "Anı",
            "Anı ve İnceleme",
            "Anı ve Seyahatname",
            "Anı, Mektup, Müzik",
            "Anı-Günlük-Mektup",
            "Anı/Gezi",
            "Anılar ve Biyografiler",
            "Anlatı",
            "Ansiklopedi",
            "Antoloji",
            "Antropoloji",
            "Araştırma",
            "Aritmetik,Cebir,Geometri",
            "Arkeoloji",
            "Arkeoloji ve Eski Çağ",
            "Askerlik Bilimi",
            "Askerlik ve Ordu",
            "Astroloji",
            "Astronomi ve YerBilimleri",
            "Aşk / Roman",
            "Aşk Şiirleri",
            "Aşk ve Romantizm",
            "Atatürk",
            "Atatürkçülük / Kemalizm",
            "Atlaslar, Planlar, Rehber",
            "Avcılık / Balıkçılık / Sp",
            "Avrupa Tarihi",
            "Azınlıklar ve Etnik Grup",
            "Balkanlar Tarihi",
            "Bankacılık",
            "Basın Yayın Tarihi",
            "Başvuru Eserleri",
            "Batı Resim Sanatı",
            "Belge/İnceleme",
            "Belgesel",
            "Belirtilmemiş",
            "Bilgi Kuramı/Epistemoloji",
            "Bilgisayar",
            "Bilim",
            "Bilim - Astronomi",
            "Bilim - Jeoloji - Deprem",
            "Bilim - Popüler bilim",
            "Bilim - Teknoloji",
            "Bilim Kurgu",
            "Bilim Tarihi",
            "Bilim-Biyoloji ve Genetik",
            "Bilim-Teknik",
            "Bilim/Ekoloji",
            "Bitkiler Alemi",
            "Biyografi",
            "Biyografi ve Anı",
            "Biyografi/Otobiyografi",
            "Büro ve Yönetimi",
            "Büyü,Gizem ve Kehanet",
            "Ceza Hukuku",
            "Cinsellik",
            "Cinsellik ve Üreme Etiği",
            "Coğrafya ve Seyahat",
            "Cumhuriyet Dönemi Öykü",
            "Cumhuriyet Tarihi",
            "Çağdaş Klasikler",
            "Çeviri Şiirler",
            "Çevre ve Ekoloji",
            "Çizgi Roman",
            "Çocuk Edebiyatı",
            "Çocuk Eğitimi",
            "Çocuk Eğitimi/Okul Öncesi",
            "Çocuk Eğitimi/Okul Sonras",
            "Çocuk Gelişimi",
            "Çocuk Kitapları",
            "Çocuk Psikolojisi",
            "Çocuk ve Ergen Gelişimi",
            "Demokrasi",
            "Deneme",
            "Derleme",
            "Devlet/Ordu",
            "Devrim/İhtilal",
            "Dış Politika/Uluslararası",
            "Diğer",
            "Diğer Dillerin Edebiyatı",
            "Dil",
            "Dil / Kurs Kitapları",
            "Dil Bilgisi",
            "Dil/Etimoloji",
            "Dilbilim",
            "Din",
            "Din / Araştırma",
            "Din / Budizm",
            "Din / Hırıstiyanlık",
            "Din / İslam",
            "Din-İslamiyet",
            "Din-Metafizik-Ruhbilim",
            "Din: İslam Araştırmaları",
            "Din: İslam Fıkıh (Hukuk)",
            "Din: İslam Mezhepleri",
            "Din: İslam Tarihi",
            "Din: İslam-Tasavvuf",
            "Din: Kuran ve Hadis",
            "Divan Edebiyatı",
            "Doğa Bilimleri",
            "Doğaüstü-Gizem",
            "Duygu Bozuklukları",
            "Dünya Dinleri",
            "Dünya Edebiyatı-Toplumsal",
            "Dünya Klasikleri",
            "Dünya Siyaseti",
            "Düşünce",
            "Düşünürler",
            "Edebiyat",
            "Edebiyat (Öykü - Roman)",
            "Edebiyat İncelemesi",
            "Edebiyat: Osmanlı Divan Ş",
            "Edebiyat: Türk Şiiri",
            "Efsaneler/Destanlar",
            "Eğitim",
            "Eğitim - Eğitim Bilim",
            "Eğitim - KPDS-ÜDS",
            "Eğitim > Dil Eğitimi",
            "Eğitim ve Ders Kitapları",
            "Eğlence",
            "Eğlence ve Gülmece",
            "Eğlence-Mizah",
            "Ekoloji",
            "Ekonomi",
            "Ekonomi Politikaları",
            "Ekonomi ve Finans",
            "Ekonomi-Emek-İş Dünyası",
            "Eleştiri",
            "Emperyalizm",
            "Ermeni Sorunu",
            "Estetik ve SanatFelsefesi",
            "Etik (Ahlak Felsefesi)",
            "Etnik Gruplar",
            "Fal / Rüya / Astroloji",
            "Fal-Burç-Büyü",
            "Fantastik",
            "Fantastik Roman",
            "Felsefe",
            "Felsefe ve Psikoloji",
            "Felsefe-Düşünce",
            "Fıkra",
            "Fizik, Kimya Bilimleri",
            "Folklor ve Gelenekler",
            "Fotoğraf",
            "Gazeteci Kitapları-Makale",
            "Gazeteci Yazarlar",
            "Gazetecilik, Yayıncılık",
            "Gençlik Edebiyatı",
            "Gençlik Kitapları",
            "Gençlik-Macera",
            "Genel Hukuk",
            "Genel Konular",
            "Gerilim ve Korku",
            "Gezi-Yorum",
            "Gizli Cemiyetler",
            "Gösteri Sanatları",
            "Günlük-Günce",
            "Güzel Sanatlar",
            "Güzel-Özlü Sözler",
            "Haber, Medya",
            "Halı, Kilim ve Dokuma",
            "Halk Edebiyatı",
            "Halkla İlişkiler",
            "Hatıra",
            "Hayvanlar Alemi",
            "Hiciv ve Mizah",
            "Hikaye",
            "Hobi",
            "Hobi - Briç-Satranç",
            "Hobi - El Sanatları",
            "Hobi - Fotoğrafçılık",
            "Hobi - Yemek kitapları",
            "Hobi / Bakım",
            "Hobi / Bakım-Güzellik",
            "Hobi ve Eğlence",
            "Hobi,Eğlence-SofraKültürü",
            "Hobi:Moda ve Giyim",
            "Hukuk",
            "Hukuk Felsefesi",
            "İç Politika",
            "İktisadi Düşünceler",
            "İktisadi Teoriler",
            "İletişim",
            "İnceleme-Araştırma",
            "İncelemeler, Tenkidler",
            "İnsan Kaynakları",
            "İnsan ve Toplum",
            "İslam",
            "İslâmiyet/Dua-İbadet",
            "İslâmiyet/Kuran-Hadisler",
            "İslâmiyet/Mezhep-Tarikat",
            "İstanbul Kitapları",
            "İstihbarat ve Casusluk",
            "İş Dünyası",
            "İş Dünyası-Kariyer",
            "İş İdaresi, Yöneticilik",
            "Kadın",
            "Kadın-Erkek İlişkileri",
            "Karikatür",
            "Kariyer ve Liderlik",
            "Katalog-Bibliyografya",
            "Kent /Çevre / Turizm",
            "Kent, Yerel Yönetim",
            "Keşif ve İcatlar",
            "Kişisel Gelişim",
            "Klasik Polisiye Romanlar",
            "Klasik Türk Edebiyatı",
            "Klavuz Kitaplar",
            "Kolektif",
            "Korku",
            "Korku-Gerilim",
            "Kuşkuculuk",
            "Kültür",
            "Kültür Sanat - Albüm",
            "Kültür Sanat-Mimari",
            "Kültür Tarihi",
            "Kültür-Sanat",
            "Küreselleşme",
            "Laiklik-Şeriat",
            "Macera",
            "Macera / Korku",
            "Makale",
            "Mantık",
            "Marksizm / Sol",
            "Masal",
            "Masal ve Fıkra",
            "Meditasyon/Yoga",
            "Medya ve İletişim",
            "Mektup",
            "Mesleki-Referans",
            "Metafizik-Ufo ve Uzay",
            "Meyvecilik ve Bahçecilik",
            "Mitoloji",
            "Mitolojik Masallar",
            "Mizah",
            "Modern Türkiye Tarihi",
            "Modern Türkiye ve Atatürk",
            "Müze - Sergi - Bienal",
            "Müzik",
            "Okkültizm (Gizlicilik)",
            "Okul Öncesi Eğitim",
            "Ordu-Polis-İstihbarat Örg",
            "Orta Asya Türk Tarihi",
            "Osmanlı Divan Şiiri",
            "Osmanlı Tarihi",
            "Otobiyografi",
            "Oyun",
            "Öykü",
            "Özdeyişler",
            "Parapsikoloji",
            "Periyodik Yayınlar",
            "PEYZAJ MİMARLIĞI",
            "Polisiye",
            "Polisiye - Macera",
            "Polisiye / Roman",
            "Polisiye Gerilim",
            "Polisiye-Casusluk",
            "Politika",
            "Politika - Devlet Yönetim",
            "Politika - Siyasi Tarih",
            "Politika - Siyasi Yazılar",
            "Politika-Devlet Yönetimi",
            "Politika-Devrim-İhtilal",
            "Politika-İç Politika",
            "Politika-Laiklik-Şeriat",
            "Politika-Siyaset",
            "Politika-Siyasi İdeoloji",
            "Politika-Siyasi Partiler",
            "Politika-Sosyal Politika",
            "Popüler Bilim",
            "Popüler Kültür",
            "Postmodernizm",
            "Psikanaliz",
            "Psikoloji",
            "Psikoloji - Davranışbilim",
            "Psikoloji - İletişim",
            "Psikoloji - Motivasyon",
            "Psikoloji - Psikanaliz",
            "Psikoloji - Psikiyatri",
            "Psikoloji > İnceleme",
            "Psikoloji Kuramları",
            "Psikoloji ve Pedagoji",
            "Psikoloji-Düşünce",
            "Psikoloji-Kişilik ve Zeka",
            "Psikoloji-Yaklaşımlar",
            "Reklamcılık",
            "Resimli Tarih",
            "Roman",
            "Röportaj",
            "Röportaj-Söyleşi",
            "Rus ve Slav Dilleri Edb.",
            "Sağlık",
            "Sağlık/Tıp",
            "Sahhaf",
            "Sanat",
            "Sanat - Fotoğraf",
            "Sanat - Resim",
            "Sanat - Sinema",
            "Sanat - Tarih",
            "Sanat - Tiyatro",
            "Sanat Tarihi",
            "Sanat ve Mimari",
            "Sanat ve Mimari: Hat",
            "Sanat ve Mimari:Ebru",
            "Sanat ve Mimari:Minyatür",
            "Sanat ve Mimari:Tezhib",
            "Sanat ve Mimarlık üzerine",
            "Sanat-Resim-Ressamlar",
            "Satranç, Briç, Oyun",
            "Senaryo-Sinema",
            "Senaryo/Oyun",
            "Serbest",
            "Seyahatname",
            "Sinema / Belgesel",
            "Sinema / Televizyon",
            "Sinema/Tiyatro",
            "Siyasal Akımlar",
            "Siyasal Bilimler",
            "Siyaset",
            "Siyaset Bilimi",
            "Siyaset-Doğu-Güneydoğu",
            "Siyasi İdeolojiler",
            "Siyasi Partiler",
            "Siyasi Tarih",
            "Sosyal Bilimler",
            "Sosyal Psikoloji",
            "Sosyoloji",
            "Söyleşi-Röportaj",
            "Söylev ve Mektuplar",
            "Sözlük",
            "Spor - Bireysel Sporlar",
            "Spor - Futbol",
            "Spor - Takım Sporları",
            "Şehir Tarihi",
            "Şiir",
            "Tarih",
            "Tarih - I. Dünya Savaşı",
            "Tarih - İlkçağ ve Öncesi",
            "Tarih - İnceleme",
            "Tarih - İslam Tarihi",
            "Tarih - Kurtuluş Savaşı",
            "Tarih - Medeniyetler",
            "Tarih - Mitoloji",
            "Tarih - Ortaçağ Tarihi",
            "Tarih - Ortadoğu",
            "Tarih - Osmanlı ve Öncesi",
            "Tarih - Popüler Tarih",
            "Tarih - Savaşlar/İsyanlar",
            "Tarih - Toplumsal Tarih",
            "Tarih - Türk Tarihi",
            "Tarih - Uygarlık Tarihi",
            "Tarih - Yakın Tarih",
            "Tarih / Anadolu Uygarlık l",
            "Tarih / Anı",
            "Tarih / Araştırma",
            "Tarih / Cumhuriyet Tarihi",
            "Tarih ve Politika",
            "Tarih-Türkiye Cumhuriyeti",
            "Tarih: Antik Çağ",
            "Tarih: Askeri Tarih",
            "Tarih: Asya Tarihi",
            "Tarih: Bilim Tarihi",
            "Tarih: Dünya Tarihi",
            "Tarih: Osmanlı Tarihi",
            "Tarih: Şehir Tarihleri",
            "Tarihi roman",
            "Tarihi Seyahatnameler",
            "Tasavvuf",
            "Tasavvuf Edebiyatı",
            "Tasavvuf ve Tarikatlar",
            "Tenkidler",
            "Terör ve Suç Örgütleri",
            "Tiyatro",
            "Tiyatro / Oyun",
            "Tiyatro Oyunu-Piyes",
            "Toplumbilim (Sosyoloji)",
            "Toplumsal Değişimler",
            "Toplumsal Sorunlar",
            "Turizm",
            "Türk Dili Grameri,Lehçe",
            "Türk Edebiyatı",
            "Türk Resim Sanatı",
            "Türkiye Cumhuriyeti Tarih",
            "Türkiye Ekonomisi",
            "Türkiye Tarihi",
            "Türkiye Üzerine",
            "Türkiye Üzerine Araştırma",
            "Uluslararası İlişkiler",
            "Ussalcılık (Rasyonalizm)",
            "Uygarlık Tarihi",
            "Uygulamalı Bilimler",
            "Varoluşçuluk",
            "Yabancı Dil Öğrenim",
            "Yasa- Mevzuat",
            "Yaşam ve Psikoloji",
            "Yaşamöykü/Anı/Mektup",
            "Yaşamöyküsü",
            "Yeme, İçme ve Gurme",
            "Yemek",
            "Yeni Dünya Düzeni",
            "Yönetim",
            "Zooloji "});
            this.comboBoxKtpTur.Location = new System.Drawing.Point(217, 94);
            this.comboBoxKtpTur.Name = "comboBoxKtpTur";
            this.comboBoxKtpTur.Size = new System.Drawing.Size(300, 25);
            this.comboBoxKtpTur.TabIndex = 35;
            // 
            // lblUyelikTarihi
            // 
            this.lblUyelikTarihi.AutoSize = true;
            this.lblUyelikTarihi.Location = new System.Drawing.Point(29, 282);
            this.lblUyelikTarihi.Name = "lblUyelikTarihi";
            this.lblUyelikTarihi.Size = new System.Drawing.Size(89, 17);
            this.lblUyelikTarihi.TabIndex = 48;
            this.lblUyelikTarihi.Text = "Ekleme Tarihi";
            // 
            // txtYynEviAdi
            // 
            this.txtYynEviAdi.Location = new System.Drawing.Point(217, 155);
            this.txtYynEviAdi.MaxLength = 20;
            this.txtYynEviAdi.Name = "txtYynEviAdi";
            this.txtYynEviAdi.Size = new System.Drawing.Size(300, 24);
            this.txtYynEviAdi.TabIndex = 37;
            // 
            // lblKitapTuru
            // 
            this.lblKitapTuru.AutoSize = true;
            this.lblKitapTuru.Location = new System.Drawing.Point(29, 102);
            this.lblKitapTuru.Name = "lblKitapTuru";
            this.lblKitapTuru.Size = new System.Drawing.Size(72, 17);
            this.lblKitapTuru.TabIndex = 43;
            this.lblKitapTuru.Text = "Kitap Türü";
            // 
            // lblKitapDurum
            // 
            this.lblKitapDurum.AutoSize = true;
            this.lblKitapDurum.Location = new System.Drawing.Point(29, 249);
            this.lblKitapDurum.Name = "lblKitapDurum";
            this.lblKitapDurum.Size = new System.Drawing.Size(93, 17);
            this.lblKitapDurum.TabIndex = 41;
            this.lblKitapDurum.Text = "Kitap Durumu";
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.Location = new System.Drawing.Point(217, 215);
            this.txtSayfaSayisi.MaxLength = 11;
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(300, 24);
            this.txtSayfaSayisi.TabIndex = 39;
            // 
            // txtYazarAdi
            // 
            this.txtYazarAdi.Location = new System.Drawing.Point(217, 125);
            this.txtYazarAdi.MaxLength = 25;
            this.txtYazarAdi.Name = "txtYazarAdi";
            this.txtYazarAdi.Size = new System.Drawing.Size(300, 24);
            this.txtYazarAdi.TabIndex = 36;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(217, 64);
            this.txtKitapAdi.MaxLength = 25;
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(300, 24);
            this.txtKitapAdi.TabIndex = 34;
            // 
            // lblSayfaSayisi
            // 
            this.lblSayfaSayisi.AutoSize = true;
            this.lblSayfaSayisi.Location = new System.Drawing.Point(29, 222);
            this.lblSayfaSayisi.Name = "lblSayfaSayisi";
            this.lblSayfaSayisi.Size = new System.Drawing.Size(78, 17);
            this.lblSayfaSayisi.TabIndex = 32;
            this.lblSayfaSayisi.Text = "Sayfa Sayısı";
            // 
            // lblYynTarihi
            // 
            this.lblYynTarihi.AutoSize = true;
            this.lblYynTarihi.Location = new System.Drawing.Point(29, 192);
            this.lblYynTarihi.Name = "lblYynTarihi";
            this.lblYynTarihi.Size = new System.Drawing.Size(82, 17);
            this.lblYynTarihi.TabIndex = 31;
            this.lblYynTarihi.Text = "Yayın Tarihi";
            // 
            // lblYynEviAdi
            // 
            this.lblYynEviAdi.AutoSize = true;
            this.lblYynEviAdi.Location = new System.Drawing.Point(29, 162);
            this.lblYynEviAdi.Name = "lblYynEviAdi";
            this.lblYynEviAdi.Size = new System.Drawing.Size(90, 17);
            this.lblYynEviAdi.TabIndex = 30;
            this.lblYynEviAdi.Text = "Yayın Evi Adı";
            // 
            // lblYazarAdi
            // 
            this.lblYazarAdi.AutoSize = true;
            this.lblYazarAdi.Location = new System.Drawing.Point(29, 132);
            this.lblYazarAdi.Name = "lblYazarAdi";
            this.lblYazarAdi.Size = new System.Drawing.Size(68, 17);
            this.lblYazarAdi.TabIndex = 29;
            this.lblYazarAdi.Text = "Yazar Adı";
            // 
            // lblKitapAdi
            // 
            this.lblKitapAdi.AutoSize = true;
            this.lblKitapAdi.Location = new System.Drawing.Point(29, 72);
            this.lblKitapAdi.Name = "lblKitapAdi";
            this.lblKitapAdi.Size = new System.Drawing.Size(65, 17);
            this.lblKitapAdi.TabIndex = 28;
            this.lblKitapAdi.Text = "Kitap Adı";
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.BackColor = System.Drawing.Color.SpringGreen;
            this.btnKitapEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitapEkle.Location = new System.Drawing.Point(32, 327);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(485, 27);
            this.btnKitapEkle.TabIndex = 44;
            this.btnKitapEkle.Text = "Ekle";
            this.btnKitapEkle.UseVisualStyleBackColor = false;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnTemizle);
            this.tabPage2.Controls.Add(this.btnBul);
            this.tabPage2.Controls.Add(this.groupBoxKitapGuncelle);
            this.tabPage2.Controls.Add(this.txtDKitapBarkod);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(812, 430);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kitap Düzenle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Location = new System.Drawing.Point(473, 35);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(64, 24);
            this.btnTemizle.TabIndex = 77;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnBul
            // 
            this.btnBul.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBul.Location = new System.Drawing.Point(413, 35);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(54, 24);
            this.btnBul.TabIndex = 76;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = false;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // groupBoxKitapGuncelle
            // 
            this.groupBoxKitapGuncelle.Controls.Add(this.dtpDEklemeTarihi);
            this.groupBoxKitapGuncelle.Controls.Add(this.dtpDYayinTarihi);
            this.groupBoxKitapGuncelle.Controls.Add(this.lblKitapDuzenleSonuc);
            this.groupBoxKitapGuncelle.Controls.Add(this.label9);
            this.groupBoxKitapGuncelle.Controls.Add(this.radioBtnDHasarlii);
            this.groupBoxKitapGuncelle.Controls.Add(this.btnDKitapDuzenle);
            this.groupBoxKitapGuncelle.Controls.Add(this.radioBtnDKullmz);
            this.groupBoxKitapGuncelle.Controls.Add(this.label8);
            this.groupBoxKitapGuncelle.Controls.Add(this.radioBtnDTemiz);
            this.groupBoxKitapGuncelle.Controls.Add(this.label7);
            this.groupBoxKitapGuncelle.Controls.Add(this.comboBoxDKitapTur);
            this.groupBoxKitapGuncelle.Controls.Add(this.label6);
            this.groupBoxKitapGuncelle.Controls.Add(this.label1);
            this.groupBoxKitapGuncelle.Controls.Add(this.label5);
            this.groupBoxKitapGuncelle.Controls.Add(this.txtDKitapAdi);
            this.groupBoxKitapGuncelle.Controls.Add(this.txtDYayinEvi);
            this.groupBoxKitapGuncelle.Controls.Add(this.txtDYazarAdi);
            this.groupBoxKitapGuncelle.Controls.Add(this.label2);
            this.groupBoxKitapGuncelle.Controls.Add(this.label4);
            this.groupBoxKitapGuncelle.Controls.Add(this.txtDSayfaSayisi);
            this.groupBoxKitapGuncelle.Location = new System.Drawing.Point(32, 75);
            this.groupBoxKitapGuncelle.Name = "groupBoxKitapGuncelle";
            this.groupBoxKitapGuncelle.Size = new System.Drawing.Size(505, 349);
            this.groupBoxKitapGuncelle.TabIndex = 75;
            this.groupBoxKitapGuncelle.TabStop = false;
            this.groupBoxKitapGuncelle.Text = "Güncelle";
            // 
            // dtpDEklemeTarihi
            // 
            this.dtpDEklemeTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDEklemeTarihi.Location = new System.Drawing.Point(194, 232);
            this.dtpDEklemeTarihi.Name = "dtpDEklemeTarihi";
            this.dtpDEklemeTarihi.Size = new System.Drawing.Size(300, 24);
            this.dtpDEklemeTarihi.TabIndex = 77;
            // 
            // dtpDYayinTarihi
            // 
            this.dtpDYayinTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDYayinTarihi.Location = new System.Drawing.Point(194, 145);
            this.dtpDYayinTarihi.Name = "dtpDYayinTarihi";
            this.dtpDYayinTarihi.Size = new System.Drawing.Size(300, 24);
            this.dtpDYayinTarihi.TabIndex = 76;
            // 
            // lblKitapDuzenleSonuc
            // 
            this.lblKitapDuzenleSonuc.AutoSize = true;
            this.lblKitapDuzenleSonuc.Location = new System.Drawing.Point(6, 295);
            this.lblKitapDuzenleSonuc.Name = "lblKitapDuzenleSonuc";
            this.lblKitapDuzenleSonuc.Size = new System.Drawing.Size(0, 17);
            this.lblKitapDuzenleSonuc.TabIndex = 75;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 56;
            this.label9.Text = "Kitap Adı";
            // 
            // radioBtnDHasarlii
            // 
            this.radioBtnDHasarlii.AutoSize = true;
            this.radioBtnDHasarlii.Location = new System.Drawing.Point(291, 205);
            this.radioBtnDHasarlii.Name = "radioBtnDHasarlii";
            this.radioBtnDHasarlii.Size = new System.Drawing.Size(70, 21);
            this.radioBtnDHasarlii.TabIndex = 74;
            this.radioBtnDHasarlii.TabStop = true;
            this.radioBtnDHasarlii.Text = "Hasarlı";
            this.radioBtnDHasarlii.UseVisualStyleBackColor = true;
            // 
            // btnDKitapDuzenle
            // 
            this.btnDKitapDuzenle.BackColor = System.Drawing.Color.SpringGreen;
            this.btnDKitapDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDKitapDuzenle.Location = new System.Drawing.Point(9, 265);
            this.btnDKitapDuzenle.Name = "btnDKitapDuzenle";
            this.btnDKitapDuzenle.Size = new System.Drawing.Size(485, 27);
            this.btnDKitapDuzenle.TabIndex = 55;
            this.btnDKitapDuzenle.Text = "Düzenle";
            this.btnDKitapDuzenle.UseVisualStyleBackColor = false;
            this.btnDKitapDuzenle.Click += new System.EventHandler(this.btnKitapDuzenle_Click);
            // 
            // radioBtnDKullmz
            // 
            this.radioBtnDKullmz.AutoSize = true;
            this.radioBtnDKullmz.Location = new System.Drawing.Point(388, 205);
            this.radioBtnDKullmz.Name = "radioBtnDKullmz";
            this.radioBtnDKullmz.Size = new System.Drawing.Size(106, 21);
            this.radioBtnDKullmz.TabIndex = 73;
            this.radioBtnDKullmz.Text = "Kullanılamaz";
            this.radioBtnDKullmz.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 57;
            this.label8.Text = "Yazar Adı";
            // 
            // radioBtnDTemiz
            // 
            this.radioBtnDTemiz.AutoSize = true;
            this.radioBtnDTemiz.Checked = true;
            this.radioBtnDTemiz.Location = new System.Drawing.Point(194, 205);
            this.radioBtnDTemiz.Name = "radioBtnDTemiz";
            this.radioBtnDTemiz.Size = new System.Drawing.Size(62, 21);
            this.radioBtnDTemiz.TabIndex = 72;
            this.radioBtnDTemiz.TabStop = true;
            this.radioBtnDTemiz.Text = "Temiz";
            this.radioBtnDTemiz.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 58;
            this.label7.Text = "Yayın Evi Adı";
            // 
            // comboBoxDKitapTur
            // 
            this.comboBoxDKitapTur.FormattingEnabled = true;
            this.comboBoxDKitapTur.Items.AddRange(new object[] {
            "Aforizmalar",
            "Ahlak",
            "Aile Bilgileri",
            "Aile/İnsan",
            "Aile/İnsan - Kadın",
            "Aksiyon ve Macera",
            "Anı",
            "Anı ve İnceleme",
            "Anı ve Seyahatname",
            "Anı, Mektup, Müzik",
            "Anı-Günlük-Mektup",
            "Anı/Gezi",
            "Anılar ve Biyografiler",
            "Anlatı",
            "Ansiklopedi",
            "Antoloji",
            "Antropoloji",
            "Araştırma",
            "Aritmetik,Cebir,Geometri",
            "Arkeoloji",
            "Arkeoloji ve Eski Çağ",
            "Askerlik Bilimi",
            "Askerlik ve Ordu",
            "Astroloji",
            "Astronomi ve YerBilimleri",
            "Aşk / Roman",
            "Aşk Şiirleri",
            "Aşk ve Romantizm",
            "Atatürk",
            "Atatürkçülük / Kemalizm",
            "Atlaslar, Planlar, Rehber",
            "Avcılık / Balıkçılık / Sp",
            "Avrupa Tarihi",
            "Azınlıklar ve Etnik Grup",
            "Balkanlar Tarihi",
            "Bankacılık",
            "Basın Yayın Tarihi",
            "Başvuru Eserleri",
            "Batı Resim Sanatı",
            "Belge/İnceleme",
            "Belgesel",
            "Belirtilmemiş",
            "Bilgi Kuramı/Epistemoloji",
            "Bilgisayar",
            "Bilim",
            "Bilim - Astronomi",
            "Bilim - Jeoloji - Deprem",
            "Bilim - Popüler bilim",
            "Bilim - Teknoloji",
            "Bilim Kurgu",
            "Bilim Tarihi",
            "Bilim-Biyoloji ve Genetik",
            "Bilim-Teknik",
            "Bilim/Ekoloji",
            "Bitkiler Alemi",
            "Biyografi",
            "Biyografi ve Anı",
            "Biyografi/Otobiyografi",
            "Büro ve Yönetimi",
            "Büyü,Gizem ve Kehanet",
            "Ceza Hukuku",
            "Cinsellik",
            "Cinsellik ve Üreme Etiği",
            "Coğrafya ve Seyahat",
            "Cumhuriyet Dönemi Öykü",
            "Cumhuriyet Tarihi",
            "Çağdaş Klasikler",
            "Çeviri Şiirler",
            "Çevre ve Ekoloji",
            "Çizgi Roman",
            "Çocuk Edebiyatı",
            "Çocuk Eğitimi",
            "Çocuk Eğitimi/Okul Öncesi",
            "Çocuk Eğitimi/Okul Sonras",
            "Çocuk Gelişimi",
            "Çocuk Kitapları",
            "Çocuk Psikolojisi",
            "Çocuk ve Ergen Gelişimi",
            "Demokrasi",
            "Deneme",
            "Derleme",
            "Devlet/Ordu",
            "Devrim/İhtilal",
            "Dış Politika/Uluslararası",
            "Diğer",
            "Diğer Dillerin Edebiyatı",
            "Dil",
            "Dil / Kurs Kitapları",
            "Dil Bilgisi",
            "Dil/Etimoloji",
            "Dilbilim",
            "Din",
            "Din / Araştırma",
            "Din / Budizm",
            "Din / Hırıstiyanlık",
            "Din / İslam",
            "Din-İslamiyet",
            "Din-Metafizik-Ruhbilim",
            "Din: İslam Araştırmaları",
            "Din: İslam Fıkıh (Hukuk)",
            "Din: İslam Mezhepleri",
            "Din: İslam Tarihi",
            "Din: İslam-Tasavvuf",
            "Din: Kuran ve Hadis",
            "Divan Edebiyatı",
            "Doğa Bilimleri",
            "Doğaüstü-Gizem",
            "Duygu Bozuklukları",
            "Dünya Dinleri",
            "Dünya Edebiyatı-Toplumsal",
            "Dünya Klasikleri",
            "Dünya Siyaseti",
            "Düşünce",
            "Düşünürler",
            "Edebiyat",
            "Edebiyat (Öykü - Roman)",
            "Edebiyat İncelemesi",
            "Edebiyat: Osmanlı Divan Ş",
            "Edebiyat: Türk Şiiri",
            "Efsaneler/Destanlar",
            "Eğitim",
            "Eğitim - Eğitim Bilim",
            "Eğitim - KPDS-ÜDS",
            "Eğitim > Dil Eğitimi",
            "Eğitim ve Ders Kitapları",
            "Eğlence",
            "Eğlence ve Gülmece",
            "Eğlence-Mizah",
            "Ekoloji",
            "Ekonomi",
            "Ekonomi Politikaları",
            "Ekonomi ve Finans",
            "Ekonomi-Emek-İş Dünyası",
            "Eleştiri",
            "Emperyalizm",
            "Ermeni Sorunu",
            "Estetik ve SanatFelsefesi",
            "Etik (Ahlak Felsefesi)",
            "Etnik Gruplar",
            "Fal / Rüya / Astroloji",
            "Fal-Burç-Büyü",
            "Fantastik",
            "Fantastik Roman",
            "Felsefe",
            "Felsefe ve Psikoloji",
            "Felsefe-Düşünce",
            "Fıkra",
            "Fizik, Kimya Bilimleri",
            "Folklor ve Gelenekler",
            "Fotoğraf",
            "Gazeteci Kitapları-Makale",
            "Gazeteci Yazarlar",
            "Gazetecilik, Yayıncılık",
            "Gençlik Edebiyatı",
            "Gençlik Kitapları",
            "Gençlik-Macera",
            "Genel Hukuk",
            "Genel Konular",
            "Gerilim ve Korku",
            "Gezi-Yorum",
            "Gizli Cemiyetler",
            "Gösteri Sanatları",
            "Günlük-Günce",
            "Güzel Sanatlar",
            "Güzel-Özlü Sözler",
            "Haber, Medya",
            "Halı, Kilim ve Dokuma",
            "Halk Edebiyatı",
            "Halkla İlişkiler",
            "Hatıra",
            "Hayvanlar Alemi",
            "Hiciv ve Mizah",
            "Hikaye",
            "Hobi",
            "Hobi - Briç-Satranç",
            "Hobi - El Sanatları",
            "Hobi - Fotoğrafçılık",
            "Hobi - Yemek kitapları",
            "Hobi / Bakım",
            "Hobi / Bakım-Güzellik",
            "Hobi ve Eğlence",
            "Hobi,Eğlence-SofraKültürü",
            "Hobi:Moda ve Giyim",
            "Hukuk",
            "Hukuk Felsefesi",
            "İç Politika",
            "İktisadi Düşünceler",
            "İktisadi Teoriler",
            "İletişim",
            "İnceleme-Araştırma",
            "İncelemeler, Tenkidler",
            "İnsan Kaynakları",
            "İnsan ve Toplum",
            "İslam",
            "İslâmiyet/Dua-İbadet",
            "İslâmiyet/Kuran-Hadisler",
            "İslâmiyet/Mezhep-Tarikat",
            "İstanbul Kitapları",
            "İstihbarat ve Casusluk",
            "İş Dünyası",
            "İş Dünyası-Kariyer",
            "İş İdaresi, Yöneticilik",
            "Kadın",
            "Kadın-Erkek İlişkileri",
            "Karikatür",
            "Kariyer ve Liderlik",
            "Katalog-Bibliyografya",
            "Kent /Çevre / Turizm",
            "Kent, Yerel Yönetim",
            "Keşif ve İcatlar",
            "Kişisel Gelişim",
            "Klasik Polisiye Romanlar",
            "Klasik Türk Edebiyatı",
            "Klavuz Kitaplar",
            "Kolektif",
            "Korku",
            "Korku-Gerilim",
            "Kuşkuculuk",
            "Kültür",
            "Kültür Sanat - Albüm",
            "Kültür Sanat-Mimari",
            "Kültür Tarihi",
            "Kültür-Sanat",
            "Küreselleşme",
            "Laiklik-Şeriat",
            "Macera",
            "Macera / Korku",
            "Makale",
            "Mantık",
            "Marksizm / Sol",
            "Masal",
            "Masal ve Fıkra",
            "Meditasyon/Yoga",
            "Medya ve İletişim",
            "Mektup",
            "Mesleki-Referans",
            "Metafizik-Ufo ve Uzay",
            "Meyvecilik ve Bahçecilik",
            "Mitoloji",
            "Mitolojik Masallar",
            "Mizah",
            "Modern Türkiye Tarihi",
            "Modern Türkiye ve Atatürk",
            "Müze - Sergi - Bienal",
            "Müzik",
            "Okkültizm (Gizlicilik)",
            "Okul Öncesi Eğitim",
            "Ordu-Polis-İstihbarat Örg",
            "Orta Asya Türk Tarihi",
            "Osmanlı Divan Şiiri",
            "Osmanlı Tarihi",
            "Otobiyografi",
            "Oyun",
            "Öykü",
            "Özdeyişler",
            "Parapsikoloji",
            "Periyodik Yayınlar",
            "PEYZAJ MİMARLIĞI",
            "Polisiye",
            "Polisiye - Macera",
            "Polisiye / Roman",
            "Polisiye Gerilim",
            "Polisiye-Casusluk",
            "Politika",
            "Politika - Devlet Yönetim",
            "Politika - Siyasi Tarih",
            "Politika - Siyasi Yazılar",
            "Politika-Devlet Yönetimi",
            "Politika-Devrim-İhtilal",
            "Politika-İç Politika",
            "Politika-Laiklik-Şeriat",
            "Politika-Siyaset",
            "Politika-Siyasi İdeoloji",
            "Politika-Siyasi Partiler",
            "Politika-Sosyal Politika",
            "Popüler Bilim",
            "Popüler Kültür",
            "Postmodernizm",
            "Psikanaliz",
            "Psikoloji",
            "Psikoloji - Davranışbilim",
            "Psikoloji - İletişim",
            "Psikoloji - Motivasyon",
            "Psikoloji - Psikanaliz",
            "Psikoloji - Psikiyatri",
            "Psikoloji > İnceleme",
            "Psikoloji Kuramları",
            "Psikoloji ve Pedagoji",
            "Psikoloji-Düşünce",
            "Psikoloji-Kişilik ve Zeka",
            "Psikoloji-Yaklaşımlar",
            "Reklamcılık",
            "Resimli Tarih",
            "Roman",
            "Röportaj",
            "Röportaj-Söyleşi",
            "Rus ve Slav Dilleri Edb.",
            "Sağlık",
            "Sağlık/Tıp",
            "Sahhaf",
            "Sanat",
            "Sanat - Fotoğraf",
            "Sanat - Resim",
            "Sanat - Sinema",
            "Sanat - Tarih",
            "Sanat - Tiyatro",
            "Sanat Tarihi",
            "Sanat ve Mimari",
            "Sanat ve Mimari: Hat",
            "Sanat ve Mimari:Ebru",
            "Sanat ve Mimari:Minyatür",
            "Sanat ve Mimari:Tezhib",
            "Sanat ve Mimarlık üzerine",
            "Sanat-Resim-Ressamlar",
            "Satranç, Briç, Oyun",
            "Senaryo-Sinema",
            "Senaryo/Oyun",
            "Serbest",
            "Seyahatname",
            "Sinema / Belgesel",
            "Sinema / Televizyon",
            "Sinema/Tiyatro",
            "Siyasal Akımlar",
            "Siyasal Bilimler",
            "Siyaset",
            "Siyaset Bilimi",
            "Siyaset-Doğu-Güneydoğu",
            "Siyasi İdeolojiler",
            "Siyasi Partiler",
            "Siyasi Tarih",
            "Sosyal Bilimler",
            "Sosyal Psikoloji",
            "Sosyoloji",
            "Söyleşi-Röportaj",
            "Söylev ve Mektuplar",
            "Sözlük",
            "Spor - Bireysel Sporlar",
            "Spor - Futbol",
            "Spor - Takım Sporları",
            "Şehir Tarihi",
            "Şiir",
            "Tarih",
            "Tarih - I. Dünya Savaşı",
            "Tarih - İlkçağ ve Öncesi",
            "Tarih - İnceleme",
            "Tarih - İslam Tarihi",
            "Tarih - Kurtuluş Savaşı",
            "Tarih - Medeniyetler",
            "Tarih - Mitoloji",
            "Tarih - Ortaçağ Tarihi",
            "Tarih - Ortadoğu",
            "Tarih - Osmanlı ve Öncesi",
            "Tarih - Popüler Tarih",
            "Tarih - Savaşlar/İsyanlar",
            "Tarih - Toplumsal Tarih",
            "Tarih - Türk Tarihi",
            "Tarih - Uygarlık Tarihi",
            "Tarih - Yakın Tarih",
            "Tarih / Anadolu Uygarlık l",
            "Tarih / Anı",
            "Tarih / Araştırma",
            "Tarih / Cumhuriyet Tarihi",
            "Tarih ve Politika",
            "Tarih-Türkiye Cumhuriyeti",
            "Tarih: Antik Çağ",
            "Tarih: Askeri Tarih",
            "Tarih: Asya Tarihi",
            "Tarih: Bilim Tarihi",
            "Tarih: Dünya Tarihi",
            "Tarih: Osmanlı Tarihi",
            "Tarih: Şehir Tarihleri",
            "Tarihi roman",
            "Tarihi Seyahatnameler",
            "Tasavvuf",
            "Tasavvuf Edebiyatı",
            "Tasavvuf ve Tarikatlar",
            "Tenkidler",
            "Terör ve Suç Örgütleri",
            "Tiyatro",
            "Tiyatro / Oyun",
            "Tiyatro Oyunu-Piyes",
            "Toplumbilim (Sosyoloji)",
            "Toplumsal Değişimler",
            "Toplumsal Sorunlar",
            "Turizm",
            "Türk Dili Grameri,Lehçe",
            "Türk Edebiyatı",
            "Türk Resim Sanatı",
            "Türkiye Cumhuriyeti Tarih",
            "Türkiye Ekonomisi",
            "Türkiye Tarihi",
            "Türkiye Üzerine",
            "Türkiye Üzerine Araştırma",
            "Uluslararası İlişkiler",
            "Ussalcılık (Rasyonalizm)",
            "Uygarlık Tarihi",
            "Uygulamalı Bilimler",
            "Varoluşçuluk",
            "Yabancı Dil Öğrenim",
            "Yasa- Mevzuat",
            "Yaşam ve Psikoloji",
            "Yaşamöykü/Anı/Mektup",
            "Yaşamöyküsü",
            "Yeme, İçme ve Gurme",
            "Yemek",
            "Yeni Dünya Düzeni",
            "Yönetim",
            "Zooloji "});
            this.comboBoxDKitapTur.Location = new System.Drawing.Point(194, 54);
            this.comboBoxDKitapTur.Name = "comboBoxDKitapTur";
            this.comboBoxDKitapTur.Size = new System.Drawing.Size(300, 25);
            this.comboBoxDKitapTur.TabIndex = 71;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 59;
            this.label6.Text = "Yayın Tarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 70;
            this.label1.Text = "Ekleme Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 60;
            this.label5.Text = "Sayfa Sayısı";
            // 
            // txtDKitapAdi
            // 
            this.txtDKitapAdi.Location = new System.Drawing.Point(194, 24);
            this.txtDKitapAdi.MaxLength = 20;
            this.txtDKitapAdi.Name = "txtDKitapAdi";
            this.txtDKitapAdi.Size = new System.Drawing.Size(300, 24);
            this.txtDKitapAdi.TabIndex = 62;
            // 
            // txtDYayinEvi
            // 
            this.txtDYayinEvi.Location = new System.Drawing.Point(194, 115);
            this.txtDYayinEvi.MaxLength = 20;
            this.txtDYayinEvi.Name = "txtDYayinEvi";
            this.txtDYayinEvi.Size = new System.Drawing.Size(300, 24);
            this.txtDYayinEvi.TabIndex = 68;
            // 
            // txtDYazarAdi
            // 
            this.txtDYazarAdi.Location = new System.Drawing.Point(194, 85);
            this.txtDYazarAdi.MaxLength = 15;
            this.txtDYazarAdi.Name = "txtDYazarAdi";
            this.txtDYazarAdi.Size = new System.Drawing.Size(300, 24);
            this.txtDYazarAdi.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 67;
            this.label2.Text = "Kitap Türü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 66;
            this.label4.Text = "Kitap Durumu";
            // 
            // txtDSayfaSayisi
            // 
            this.txtDSayfaSayisi.Location = new System.Drawing.Point(194, 175);
            this.txtDSayfaSayisi.MaxLength = 11;
            this.txtDSayfaSayisi.Name = "txtDSayfaSayisi";
            this.txtDSayfaSayisi.Size = new System.Drawing.Size(300, 24);
            this.txtDSayfaSayisi.TabIndex = 65;
            // 
            // txtDKitapBarkod
            // 
            this.txtDKitapBarkod.Location = new System.Drawing.Point(141, 35);
            this.txtDKitapBarkod.MaxLength = 10;
            this.txtDKitapBarkod.Name = "txtDKitapBarkod";
            this.txtDKitapBarkod.Size = new System.Drawing.Size(266, 24);
            this.txtDKitapBarkod.TabIndex = 61;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 17);
            this.label10.TabIndex = 54;
            this.label10.Text = "Kitap Barkod";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblSilSonuc);
            this.tabPage3.Controls.Add(this.btnKitapSilSonuc);
            this.tabPage3.Controls.Add(this.txtSKitapBarkod);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(812, 430);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Kitap Sil";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblSilSonuc
            // 
            this.lblSilSonuc.AutoSize = true;
            this.lblSilSonuc.Location = new System.Drawing.Point(35, 118);
            this.lblSilSonuc.Name = "lblSilSonuc";
            this.lblSilSonuc.Size = new System.Drawing.Size(0, 17);
            this.lblSilSonuc.TabIndex = 81;
            // 
            // btnKitapSilSonuc
            // 
            this.btnKitapSilSonuc.BackColor = System.Drawing.Color.IndianRed;
            this.btnKitapSilSonuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitapSilSonuc.Location = new System.Drawing.Point(38, 88);
            this.btnKitapSilSonuc.Name = "btnKitapSilSonuc";
            this.btnKitapSilSonuc.Size = new System.Drawing.Size(485, 27);
            this.btnKitapSilSonuc.TabIndex = 80;
            this.btnKitapSilSonuc.Text = "Sil";
            this.btnKitapSilSonuc.UseVisualStyleBackColor = false;
            this.btnKitapSilSonuc.Click += new System.EventHandler(this.btnKitapSilSonuc_Click);
            // 
            // txtSKitapBarkod
            // 
            this.txtSKitapBarkod.Location = new System.Drawing.Point(223, 32);
            this.txtSKitapBarkod.MaxLength = 10;
            this.txtSKitapBarkod.Name = "txtSKitapBarkod";
            this.txtSKitapBarkod.Size = new System.Drawing.Size(300, 24);
            this.txtSKitapBarkod.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 77;
            this.label3.Text = "Kitap Barkod";
            // 
            // lblKitapEkleSonuc
            // 
            this.lblKitapEkleSonuc.AutoSize = true;
            this.lblKitapEkleSonuc.Location = new System.Drawing.Point(29, 367);
            this.lblKitapEkleSonuc.Name = "lblKitapEkleSonuc";
            this.lblKitapEkleSonuc.Size = new System.Drawing.Size(0, 17);
            this.lblKitapEkleSonuc.TabIndex = 50;
            // 
            // kitapislemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.tabControlKtp);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(10, 120);
            this.Name = "kitapislemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Kitap İşlemleri";
            this.Load += new System.EventHandler(this.kitapislemleri_Load);
            this.tabControlKtp.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBoxKitapGuncelle.ResumeLayout(false);
            this.groupBoxKitapGuncelle.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.TabControl tabControlKtp;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox comboBoxKtpTur;
        private System.Windows.Forms.Label lblUyelikTarihi;
        private System.Windows.Forms.TextBox txtYynEviAdi;
        private System.Windows.Forms.Label lblKitapTuru;
        private System.Windows.Forms.Label lblKitapDurum;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.TextBox txtYazarAdi;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Label lblSayfaSayisi;
        private System.Windows.Forms.Label lblYynTarihi;
        private System.Windows.Forms.Label lblYynEviAdi;
        private System.Windows.Forms.Label lblYazarAdi;
        private System.Windows.Forms.Label lblKitapAdi;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.RadioButton radioBtnHasarli;
        private System.Windows.Forms.RadioButton radioBtnKullmz;
        private System.Windows.Forms.RadioButton radioBtnTemiz;
        private System.Windows.Forms.GroupBox groupBoxKitapGuncelle;
        private System.Windows.Forms.Label lblKitapDuzenleSonuc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioBtnDHasarlii;
        private System.Windows.Forms.Button btnDKitapDuzenle;
        private System.Windows.Forms.RadioButton radioBtnDKullmz;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioBtnDTemiz;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxDKitapTur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDKitapAdi;
        private System.Windows.Forms.TextBox txtDYayinEvi;
        private System.Windows.Forms.TextBox txtDYazarAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDSayfaSayisi;
        private System.Windows.Forms.TextBox txtDKitapBarkod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Label lblSilSonuc;
        private System.Windows.Forms.Button btnKitapSilSonuc;
        private System.Windows.Forms.TextBox txtSKitapBarkod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpEklemeTarihi;
        private System.Windows.Forms.DateTimePicker dtpYayinTarihi;
        private System.Windows.Forms.DateTimePicker dtpDEklemeTarihi;
        private System.Windows.Forms.DateTimePicker dtpDYayinTarihi;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label lblKitapEkleSonuc;
    }
}