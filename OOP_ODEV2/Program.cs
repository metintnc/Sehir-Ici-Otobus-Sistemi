Otobus o = new Otobus();
int duraksayısı = 1;
o.baslangıc();
while (true)
{

    Console.WriteLine("Biniş(1)\nİniş(2)\nOtobüsteki ve beklemelistesindeki yolcuları göster(3)\nBugün Otobuse Binen Yolcuların Kayıtlarını Göster(4)\nHangi işlemi yapmak istiyorsunuz?");
    int islem = Convert.ToInt32(Console.ReadLine());


    if (islem == 1)
    {
        Yolcu y = new Yolcu();
        y.BinisYolcu();
        o.otobusekle(y);
        Console.WriteLine("Bindiğiniz Durak: " + duraksayısı + ".Durak");
        y.binisno = duraksayısı;
    }
    else if (islem == 2)
    {
        Console.WriteLine("Kart numaranız: ");
        int kartno = Convert.ToInt32(Console.ReadLine());
        o.Otobustenİn(kartno,duraksayısı);
        Console.WriteLine("İndiğiniz Durak: " + duraksayısı + ".Durak");
    }
    else if (islem == 3)
    {
        o.YolcularıGöster();
    }
    else if (islem == 4)
    {
        o.GunSonundaOtobusuKullananKişiler();
    }
    else
    {
        Console.WriteLine("Yanlış işlem yaptınız lütfen tekrar deneyin");
        continue;
    }
    Console.WriteLine("Başka işlem yapmak istiyormusunuz? \nEvet(1) Hayır(2)");
    int son = Convert.ToInt32(Console.ReadLine());
    if (son == 1)
    {
        Console.WriteLine("Başa dönülüyor.");
        duraksayısı++;
        continue;
    }
    else if (son == 2)
    {
        Console.WriteLine("Program kapatılıyor.");
        break;
    }
}



public class Yolcu
{
    public string name, surname;
    public int kartno, binisno, inisno;
    public void BinisYolcu()
    {
        Console.WriteLine("Adınız: ");
        name = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Soyadınız: ");
        surname = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Kart numaranız: ");
        kartno = Convert.ToInt32(Console.ReadLine());
    }

}

public class Otobus
{
    LinkedList<Yolcu> otobuslist = new LinkedList<Yolcu>();
    LinkedList<Yolcu> beklemelist = new LinkedList<Yolcu>();
    LinkedList<Yolcu> bugunotobusebinenler = new LinkedList<Yolcu>();

    public void baslangıc()
    {
        string[] isimler = { "Ahmet", "Mehmet", "Ayşe", "Fatma", "Ali", "Zeynep", "Emre", "Elif", "Mustafa", "Cem", "Yasemin", "Oğuz", "Berk", "Ece", "Deniz", "Selin", "Burak", "Ceren", "Onur", "Gamze", "Serkan", "Aslı", "Can", "Melis", "Tolga", "Derya", "İrem", "Hakan", "Gül", "Yunus", "Pelin", "Kaan", "Esra", "Volkan", "Seda", "Furkan", "Buse", "Cemre", "Okan", "Simge", "Mert", "Hande", "Tuna", "Sibel", "Kerem", "Mine", "Batuhan", "Naz", "Rıza" };
        string[] soyadlar = { "Demir", "Yılmaz", "Kaya", "Çelik", "Şahin", "Yıldız", "Aydın", "Arslan", "Öztürk", "Polat", "Doğan", "Kurt", "Taş", "Eren", "Güneş", "Koç", "Bozkurt", "Keskin", "Ergin", "Yalçın", "Demir", "Yılmaz", "Kaya", "Çelik", "Şahin", "Yıldız", "Aydın", "Arslan", "Öztürk", "Polat", "Doğan", "Kurt", "Taş", "Eren", "Güneş", "Koç", "Bozkurt", "Keskin", "Ergin", "Yalçın", "Demir", "Yılmaz", "Kaya", "Çelik", "Şahin", "Yıldız", "Aydın", "Arslan", "Öztürk", "Polat" };
        for(int i = 0; i < 49; i++)
        {
            otobuslist.AddLast(new Yolcu { name = isimler[i],surname = soyadlar[i],kartno=i , binisno=1});
            bugunotobusebinenler.AddLast(new Yolcu {name = isimler[i],surname=soyadlar[i],kartno = i , binisno=1});
        }
    }
    public void otobusekle(Yolcu i)
    {
        if (otobuslist.Count < 50)
        {
            otobuslist.AddLast(i);
            Console.WriteLine(i.name + " " + i.surname + " otobüse bindi.");
            bugunotobusebinenler.AddLast(i);
        }
        else
        {
            beklemelist.AddLast(i);
            Console.WriteLine(i.name + " " + i.surname + " için yer yok. Bekleme sırası:" + beklemelist.Count);
        }

    }

    public void Otobustenİn(int kartno,int binis)
    {
        bool indimi = false;
        bool a = false;
        LinkedListNode<Yolcu> liste = otobuslist.First;
        if (liste == null)
        {
            a = true;
            Console.WriteLine("Otobuste şuanda yolcu yok.");
        }

        while (a == false && liste != null)
        {
            if (liste.Value.kartno == kartno)
            {
                bugunotobusebinenler.Remove(liste.Value);
                liste.Value.inisno = binis;
                bugunotobusebinenler.AddLast(liste.Value);
                Console.WriteLine(liste.Value.name + " " + liste.Value.surname + " otobusten indi.");
                otobuslist.Remove(liste);
                indimi = true;


                if (beklemelist.Count < 1)
                {
                    Console.WriteLine("Bekleme listesinde bekleyen kimse yok.");
                }
                else
                {
                    Console.WriteLine("Beklem Listesinden "+beklemelist.First.Value.name + " " + beklemelist.First.Value.surname + " otobuse bindi.");
                    otobuslist.AddLast(beklemelist.First.Value);
                    beklemelist.RemoveFirst();
                }
                a = true;
            }
            else
            {
                liste = liste.Next;
            }

        }
        if (indimi == false)
        {
            Console.WriteLine("kart numarasına ait otobuste yolcu yok.");
        }

    }
    public void YolcularıGöster()
    {
        int sıra = 1;
        Console.WriteLine("Otobüsteki Yolcular: ");
        foreach (var x in otobuslist)
        {
            Console.WriteLine($"{sıra}- Adı:{x.name}, Soyadı:{ x.surname}, KartNo:{ x.kartno}, Bindiği Durak:{ x.binisno}.Durak");
            sıra++;
        }
        sıra = 1;
        Console.WriteLine("\nBeklemeListesindekiler: \n");
        foreach (var y in beklemelist)
        {
            Console.WriteLine($"{sıra}- Adı:{y.name}, Soyadı:{y.surname}, KartNo:{y.kartno}");
            sıra++;
        }
    }
    public void GunSonundaOtobusuKullananKişiler()
    {
        int sıra = 1;
        Console.WriteLine("Gün içinde otobüsü kullanan Yolcular: \n");
        foreach (var x in bugunotobusebinenler)
        {
            if(x.inisno == 0)
            {
                Console.WriteLine($"{sıra}- Adı:{x.name}, Soyadı:{x.surname}, KartNo:{x.kartno}, Bindiği Durak:{x.binisno}.Durak, İndiği Durak: İnmedi");
            }
            else
                Console.WriteLine($"{sıra}- Adı:{x.name}, Soyadı:{x.surname}, KartNo:{x.kartno}, Bindiği Durak:{x.binisno}.Durak, İndiği Durak:{x.inisno}");
            sıra++;
        }
    }
}