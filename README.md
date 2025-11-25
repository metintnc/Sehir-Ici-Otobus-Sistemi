# 🚌 Şehir İçi Otobüs Yolcu Takip Sistemi

Bu proje, şehir içi bir otobüs hattındaki yolcu biniş ve iniş işlemlerini simüle eden, kapasite ve bekleme listesi yönetimini **Linked List (Bağlı Liste)** veri yapısı kullanarak gerçekleştiren bir C# Konsol uygulamasıdır.

## 📝 Proje Hakkında

Uygulama, 50 yolcu kapasiteli bir otobüsü simüle eder. Yolcular otobüse binmek istediklerinde kapasite kontrol edilir; eğer otobüs doluysa yolcular **Bekleme Listesine** alınır. Otobüsten inenler olduğunda, bekleme listesindeki ilk yolcu otomatik olarak otobüse dahil edilir.

Bu proje, **Veri Yapıları** dersi kapsamında **LinkedList** kullanımını pekiştirmek amacıyla geliştirilmiştir.

## 🚀 Özellikler

* **Yolcu Kaydı:** Ad, soyad, kart numarası, biniş durağı ve iniş durağı bilgileri tutulur.
* **Kapasite Kontrolü:** Otobüs kapasitesi 50 kişi ile sınırlandırılmıştır.
* **Bekleme Listesi (Queue Mantığı):** Kapasite dolduğunda yeni gelen yolcular bekleme listesine eklenir.
* **Otomatik Yerleşim:** Bir yolcu indiğinde, bekleme listesinin başındaki kişi otomatik olarak boşalan yere geçer.
* **Günlük Raporlama:** Gün sonunda otobüsü kullanan tüm yolcuların (binen, inen ve hala içeride olan) dökümü alınabilir.
* **Hazır Veri Seti:** Program başlatıldığında test kolaylığı sağlaması açısından otobüs 49 yolcu ile otomatik olarak doldurulur.

## 🛠 Kullanılan Teknolojiler ve Yapılar

* **Dil:** C# (.NET)
* **Veri Yapısı:** `LinkedList<T>` (Hem otobüs içi yolcular hem de bekleme listesi için)
* **Platform:** Console Application

## 💻 Nasıl Çalışır?

Program çalıştırıldığında kullanıcıyı bir menü karşılar:

1.  **Biniş İşlemi:** Yeni yolcu bilgilerini girer.
2.  **İniş İşlemi:** Kart numarası girilen yolcuyu otobüsten indirir (ve bekleme listesinden yolcu alır).
3.  **Durum Görüntüleme:** Anlık olarak otobüsteki ve bekleme listesindeki yolcuları listeler.
4.  **Gün Sonu Raporu:** Gün boyu işlem gören tüm yolcu hareketlerini gösterir.

## 📸 Örnek Senaryo

```text
> Biniş(1)
> İniş(2)
> Otobüsteki ve beklemelistesindeki yolcuları göster(3)
> Hangi işlemi yapmak istiyorsunuz?
