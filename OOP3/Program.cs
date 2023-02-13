using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager(); //IKrediManager yerine IhtiyacKrediManager yazıyordu.
            IKrediManager konutKrediManager = new KonutKrediManager(); //IKrediManager yerine KonutKrediManager yazıyordu.
            IKrediManager tasitKrediManager = new TasitKrediManager(); //IKrediManager yerine TasitKrediManager yazıyordu.

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager, fileLoggerService); //neyi verisen ekranda onun çıktısı olacak, hangi krediyi verisen onun Hesap'lası çalışacak

            //List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            //foreach (var kredi in krediler)
            //{
            //    kredi.Hesapla();
            //}

        }
    }
}
