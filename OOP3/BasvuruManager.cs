using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediTipi, ILoggerService loggerService)
        {
            krediTipi.Hesapla();
            loggerService.Log();

            //kreditipine konut gönderirsek konut kredisinin hesaplama kısmı çalışır
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler )
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }

            
        }
    }
}
