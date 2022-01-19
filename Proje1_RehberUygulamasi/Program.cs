using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1_RehberUygulamasi
{
    public class Program
    {
        static void Main(string[] args)
        {
            Kisiler kisi1 = new Kisiler("erkan","Kızgın","05320542243");
            Kisiler kisi2 = new Kisiler("fatih", "Gumus", "05322542243");
            List<Kisiler> rehber = new List<Kisiler>();
            rehber.Add(kisi2);
            rehber.Add(kisi1);
            Program program = new Program();
            program.islemSeciniz(rehber);
            
        }
        public void islemSeciniz(List<Kisiler> rehber)
        {
            int choose = 0;
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("******************************************* ");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak﻿");


            try
            {
                 choose = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("Lütfen Geçerli bir sayi giriniz");
                islemSeciniz(rehber);
            }
           

            if(choose<1 && choose>5)
            {
                Console.WriteLine("Lütfen Geçerli bir sayi giriniz");
            }

            switch (choose)
            {
                case 1:
                    numaraEkle(rehber);
                    break;
                case 2:
                    Console.WriteLine(" Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                    string strSil = Console.ReadLine();
                    rehber = numaraSil(strSil,rehber);
                    break;
                case 3:
                    Console.WriteLine(" Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                    string strGuncelle = Console.ReadLine();
                    rehber = numaraGuncelle(strGuncelle,rehber);
                    break;
                case 4:
                    numaraListele(rehber);
                    break;
                case 5:
                    Console.WriteLine(" Lütfen numarasını silmek istediğiniz kişinin adını, soyadını veya numarasını giriniz:");
                    string strAra= Console.ReadLine();
                    numaraAra(strAra,rehber);
                    break;
                default:
                    break;
            }
            numaraListele(rehber);
            Console.ReadLine();

            
        }

        public List<Kisiler> numaraSil(string silineceKisi,List<Kisiler> rehber)
        {
            var kisi = rehber.FirstOrDefault(x => x.isim == silineceKisi);
            if (kisi == null)
            {
                kisi = rehber.FirstOrDefault(x => x.soyIsim == silineceKisi);
            }
                
            if (kisi == null)
            {
                var onay = "";
                Console.WriteLine(" Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine(" * Silmeyi sonlandırmak için: (1)");
                Console.WriteLine(" * Yeniden denemek için: (2)");
                onay = Console.ReadLine();
                if(onay == "1")
                {
                    islemSeciniz(rehber);
                }
            }
            else
            {
                var onay = "";
                Console.WriteLine(kisi.isim + " isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                onay = Console.ReadLine();
                if(onay == "y")
                {
                    rehber.Remove(kisi);
                }
            }
            
            return rehber;
        }
        public List<Kisiler> numaraGuncelle(string guncellenecekKisi, List<Kisiler> rehber)
        {
            var kisi = rehber.FirstOrDefault(x => x.isim == guncellenecekKisi);
            if (kisi == null)
            {
                kisi = rehber.FirstOrDefault(x => x.soyIsim == guncellenecekKisi);
            }
            if (kisi == null)
            {
                var onay = "";
                Console.WriteLine(" Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine(" * Guncellemeyi sonlandırmak için: (1)");
                Console.WriteLine(" * Yeniden denemek için: (2)");
                onay = Console.ReadLine();
                if (onay == "1")
                {
                    islemSeciniz(rehber);
                }
            }
            else
            {
                Console.WriteLine("Ad:");
                kisi.isim = Console.ReadLine();
                Console.WriteLine("Soyad:");
                kisi.soyIsim = Console.ReadLine();
                Console.WriteLine("Tel:");
                kisi.tel = Console.ReadLine();
            }
            return rehber;
        }
        public List<Kisiler> numaraEkle(List<Kisiler> rehber)
        {
            Console.WriteLine("Ad:");
            var isim = Console.ReadLine();
            Console.WriteLine("Soyad:");
            var soyIsim = Console.ReadLine();
            Console.WriteLine("Tel:");
            var tel = Console.ReadLine();
            Kisiler kisi = new Kisiler(isim,soyIsim,tel);
            rehber.Add(kisi);
            return rehber;
        }
        public void numaraListele(List<Kisiler> rehber)
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");

            foreach (var kisi in rehber)
            {
                Console.WriteLine("İsim: "+ kisi.isim);
                Console.WriteLine("Soyisim: " + kisi.soyIsim);
                Console.WriteLine("Tel: " + kisi.tel);
                Console.WriteLine("----------------------------");
            }
        }
        public void numaraAra(string aramaVerisi,List<Kisiler> rehber)
        {
            List<Kisiler> filtre = new List<Kisiler>();
            Console.WriteLine("Arama Sonucu");
            Console.WriteLine("**********************************************");
            filtre = rehber.FindAll(x => x.isim == aramaVerisi);
            if (filtre.Count < 1)
            {
                filtre = rehber.FindAll(x => x.soyIsim == aramaVerisi);
            }
            if (filtre.Count < 1)
            {
                filtre = rehber.FindAll(x => x.tel == aramaVerisi);
            }
            foreach (var kisi in filtre)
            {
                Console.WriteLine("İsim: " + kisi.isim);
                Console.WriteLine("Soyisim: " + kisi.soyIsim);
                Console.WriteLine("Tel: " + kisi.tel);
                Console.WriteLine("----------------------------");
            }
        }
    }
}
