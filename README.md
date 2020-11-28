"# Proje_Hastane" 
C# dili kullanılarak Hastane Randevu otomasyonu yapıldı. Ssms veritabanı kullanıldı ve proje için gerekli olan 6 adet tablo oluşturuldu. Otomasyon Hasta, Doktor ve Sekreter olmak üzere üç farklı girişe sahiptir, seçilen girişlere göre detaylar;

1-Hasta Giriş;
Hasta, kayıt değilse giriş ekranında üye ol ile üye olabilir.
Hasta Sisteme Tc ve şifresiyle giriş yapar. Şifre veya Tc hatalı ise sistem uyarı verecektir.
Sisteme başarılı bir şekilde giriş yapan hasta geçmiş randevularını görüntüleyebilir, branş ve doktor seçerek aktif randevulardan randevuya çift tıklayıp, şikayetini belirterek randevu alabilir.
Hasta Bilgilerimi düzenle ile bilgilerini düzenleyebilir.
Hasta için toplamda 4 form bulunmaktadır;
*Hasta Giriş paneli
*Hasta Detay Paneli
*Hasta Bilgi Düzenleme Paneli
*Hasta Kayıt Paneli

2-Doktor Giriş;
Doktor, sisteme Tc ve şifresiyle giriş yapabilir. Şifre veya Tc hatalı ise sistem uyarı verecektir.
Sisteme başaralı bir şekilde giriş yapan doktor, kendisine ait randevu listesini görüntüleyebilir. Randevu listesinde yer alan randevuya çift tıklayarak hastanın girmiş olduğu şikayeti randevu detay ile görüntüleyebilir.
Doktorun 3 farklı butonu mevcuttur. Doktor Bilgi düzenle ile bilgilerini güncelleyebilir. Duyurular butonuyla, sekreterin yayınlamış olduğu duyuruları görüntüleyebilir. Çıkış butonuyla sistemden çıkış yapabilir.

Doktor için toplamda 4 form bulunmaktadır.
*Doktor Giriş Paneli
*Doktor Detay Paneli
*Bilgi Düzenleme Paneli
*Duyurular paneli

3-Sekreter Giriş;
Sekreter, sisteme Tc ve şifresiyle giriş yapabilir. Şifre veya Tc hatalı ise sistem uyarı verecektir.
Sisteme başarılı bir şekilde giriş yapan Sekreter, Duyuru oluşturabilir, Randevu kaydedebilir. Branşlar ve doktorların Listesini görüntüleyebilir. Ayrıca Doktor Panelinden Doktor kaydedebilir, silebilir, güncelleyebilir. Branş Panelinden Branş Kaydedebilir, silebilir, Güncelleyebilir. Tüm doktorlara ait Randevu listesini görüntüleyebilir. Duyuru Panelinden duyuruları görüntüleyebilir.

Sekreter için toplamda 6 form bulunmaktadır
*Sekreter Giriş Paneli
*Sekreter Detay Paneli
*Doktor Paneli
*Branş Paneli
*Randevu Listesi
*Duyuru Paneli

Sistemde daha önce alınmış olan branş ve saat için durum pasif olarak aktarılacak ve aktif randevularda görünmeyecektir.
Tablolar;
-Doktorlar; id, Ad, Soyad, Branş, Tc, Şifre
-Hastalar; id, Ad, Soyad, Tc, Telefon, Şifre, Cinsiyet
-Sekreterler; id, AdSoyad, Tc, Şifre
-Branşlar ; id, BranşAd
-Randevular; id, Tarih, Saat, Branş, Doktor, Durum, HastaTc, Şikayet
-Duyurular; id, Duyuru






 
