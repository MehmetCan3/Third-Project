using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyaçKrediManager = new İhtiyaçKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyaçKrediManager, fileLoggerService);
            

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyaçKrediManager,tasitKrediManager};
           // basvuruManager.KrediOnbilgilendirmesiYap(krediler);
        }
    }
}
