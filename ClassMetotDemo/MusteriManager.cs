using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Listele(List<Musteri> listMusteri)
        {
            foreach (var list in listMusteri) 
            {
                Console.WriteLine(list.Id+" "+list.Ad+" "+list.MusteriNo);
            }
        }
        public void Ekle(Musteri musteri, List<Musteri> listMusteri)
        {
            listMusteri.Add(musteri);
            Console.WriteLine(musteri.Ad + " eklendi");
        }
        public void Sil(Musteri musteri, List<Musteri> listMusteri)
        {
            listMusteri.Remove(musteri);
            Console.WriteLine(musteri.Ad + " silindi");
        }
    }
}
