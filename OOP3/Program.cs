using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //İhtiyacKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager(); //bu şekilde de yazılabilir
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager,fileLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
