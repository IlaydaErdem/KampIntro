using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
           
            //TasitKrediManager
            IKrediManager tasitKrediManager = new TasitKrediManager();
            
            //KonutKrediManager
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager,databaseLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager , tasitKrediManager };

           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
