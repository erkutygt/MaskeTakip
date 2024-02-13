//Degiskenler();


using Business.Concrete;
using Entities.Concrete;

static void Degiskenler()
{
    string mesaj = "Selam";
    double tutar = 100000.5;
    int sayi = 100;
    bool isAuthenticated = false;

    string ad = "Erkut";
    string soyad = "Can";
    int dogumYili = 1991;
    long tcNO = 12345678910;

    Console.WriteLine(tutar * 1.18);
}


Vatandas vatandas1 = new Vatandas();



SelamVer(isim: "Erkut") ;
SelamVer(isim: "Ahmet") ;
SelamVer(isim: "Engin") ;
SelamVer() ;



static void SelamVer(string isim = "isimsiz")  //buradaki isim parametredir. merhaba+ ilgili kisinin ismi yazilir. "isimsiz" ise default olarak atanmistir.
{
    Console.WriteLine("Merhaba " + isim);
}



static int Topla(int sayi1 = 5, int sayi2 = 10)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam: " + sonuc.ToString());
    return sonuc;
}

int sonuc = Topla(6,58);



//Diziler //Arrays


string[] ogrenciler = new string[3];
ogrenciler[0] = "Engin";
ogrenciler[1] = "Erkut";
ogrenciler[2] = "Burcu";



for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}



string[] sehirler1 = new[] { "Ankara", "istanbul", "izmir" };
string[] sehirler2 = new[] {"Bursa", "Antalya", "Diyarbakir" };

sehirler2 = sehirler1;
sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]); // Adana


int sayi1 = 10;
int sayi2 = 20;
sayi2 = sayi1;
sayi1 = 30;
Console.WriteLine (sayi2); //10


foreach (string s in sehirler2)  //dii formatindaki yapilar icindir.
{ 
    Console.WriteLine(s);
}


List<string> yeniSehirler1 = new List<string> { "Ankara1", "istanbul1", "Izmir1" };
yeniSehirler1.Add("Adana1");
foreach (var sehir in yeniSehirler1)
{
    Console.WriteLine (sehir);
}






List<string> meyveler = new List<string> { "elma", "armut", "karpuz" };
meyveler.Add("cilek");
foreach (var meyve in meyveler)
{
    Console.WriteLine(meyve);
}


Person person1 = new Person();
person1.FirstName = "Erkut";
person1.LastName = "Yiğit";
person1.DateOfBirthYear = 1991;
person1.NationalIdentity = 1234;

Person person2 = new Person();
person2.FirstName = "Ahmet";



PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);





Console.ReadLine();
//pascal casing
public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNO { get; set; }

}



