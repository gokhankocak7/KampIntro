using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method Injection
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService) 
        {
            //Başvuran bilgilerini değerlendirme
            //
             krediManager.Hesapla();
             loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

        internal void BasvuruYap(IKrediManager konutKrediManager, object fileLoggerService)
        {
            throw new NotImplementedException();
        }

        internal void BasvuruYap(IKrediManager konutKrediManager, DatabaseLoggerService databaseLoggerService)
        {
            throw new NotImplementedException();
        }
    }
}
