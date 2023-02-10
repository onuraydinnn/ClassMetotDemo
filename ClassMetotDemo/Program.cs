using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1= new Musteri() {Id=1, Ad="Onur", MusteriNo="12345"};
            Musteri musteri2 = new Musteri() { Id = 2, Ad = "Ahmet", MusteriNo = "83702" };
            Musteri musteri3 = new Musteri() { Id = 3, Ad = "Mehmet", MusteriNo = "23836" };
            Musteri musteri4 = new Musteri() { Id = 4, Ad = "Ayse", MusteriNo = "28128" };
            Musteri musteri5 = new Musteri() { Id = 5, Ad = "Fatma", MusteriNo = "35125" };

            List<Musteri> listMusteri = new List<Musteri>();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri4, listMusteri);
            musteriManager.Ekle(musteri5, listMusteri);
            musteriManager.Listele(listMusteri);
            musteriManager.Sil(musteri4, listMusteri);




            Console.ReadKey();
        }
    }
}
