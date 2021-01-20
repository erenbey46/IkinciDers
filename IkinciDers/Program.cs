using System;

namespace IkinciDers
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim = "FerhundeHanim";
            int yas = 22;
            double sayi = 17.3;
            bool SistemGiris = false;

            double dolarDun = 7.32;
            double dolarBugun = 7.32;

            if (dolarBugun > dolarDun)
            {
                Console.WriteLine("Yükseliş Oku");
            }

            else if (dolarBugun < dolarDun)
            {
                Console.WriteLine("Düşüş Oku");
            }

            else
            {
                Console.WriteLine("Sabitlik Simgesi");
            }



        }
    }
}
