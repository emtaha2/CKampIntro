using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //Başvuru bilgileri değerlendirme
            //
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
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
        
    }
}
