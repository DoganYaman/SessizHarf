using System;
using System.Linq;

namespace sessiz_harf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir cümle giriniz : ");
            string ifade = Console.ReadLine();
            SessizHarYanyana(ifade);
        }

        static void SessizHarYanyana(string ifade)
        {
            string[] kelimeDizisi = ifade.Split(' ');
            char[] sessizHarfler = new char[] {'b','c','ç','d','f','g','ğ','h','j','k','l','m','n','p','r','s','ş','t','v','w','y','z','q'};
            bool durum;
            Console.Write("Çıktı : ");
            foreach (string kelime in kelimeDizisi)
            {
                durum = false;
                for (int i = 0; i < kelime.Length -1; i++)
                {
                    if(sessizHarfler.Contains(kelime[i]) && sessizHarfler.Contains(kelime[i+1]))
                    {
                        durum = true;
                        break;
                    }
                }

                Console.Write(durum + " ");
            }

        }
    }
}
