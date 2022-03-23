using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            float anaParaMarjin,cüzdanBakiyesi, kaldiracOrani,pozisyonGiris,pozisyonCikis, pozisyonLikidasyon=0f, sonucKarZarar=0f;
            bool pozisyonLong = false;
            bool pozisyonShort = false;
            bool pozisyonModuIzole = false;
            bool pozisyonModuCapraz = false;

            Console.Write("Lütfen Cüzdan Bakiyenizi girin : ");
            cüzdanBakiyesi = float.Parse(Console.ReadLine());

            Console.Write("Lütfen Anapara (Marjin) Bakiyenizi girin : ");
            anaParaMarjin = float.Parse(Console.ReadLine());

            Console.Write("Lütfen Pozisyon tercihinizi (Long : 'L', Short : 'S') girin : ");
            string pozisyonTercih = Console.ReadLine();

            try
            {
                if(pozisyonTercih == "l" || pozisyonTercih == "L")
                {
                    pozisyonLong = true;
                }
                else if(pozisyonTercih == "s" || pozisyonTercih == "S")
                {
                    pozisyonShort = true;
                }
                else
                    Console.Write("Hatalı bir Pozisyon tecihi yaptınız! Lütfen doğru tercih yapınız (Long : 'L', Short : 'S')");
            }
            catch (System.Exception e)
            {
                Console.Write("Hatalı bir Pozisyon tecihi yaptınız! Lütfen doğru tercih yapınız (Long : 'L', Short : 'S')");
            }

            Console.Write("Lütfen Pozisyon Modu tercihinizi (İzole : 'İ', Çapraz : 'Ç') girin : ");
            string pozisyonModu = Console.ReadLine();

            try
            {
                if(pozisyonModu == "i" || pozisyonModu == "İ")
                {
                    pozisyonModuIzole = true;
                }
                else if(pozisyonModu == "ç" || pozisyonModu == "Ç")
                {
                    pozisyonModuCapraz = true;
                }
                else
                    Console.Write("Hatalı bir Pozisyon Modu tecihi yaptınız! Lütfen doğru tercih yapınız (İzole : 'İ', Çapraz : 'Ç')");
            }
            catch (System.Exception e)
            {
                Console.Write("Hatalı bir Pozisyon Modu tecihi yaptınız! Lütfen doğru tercih yapınız (İzole : 'İ', Çapraz : 'Ç')");
            }

            Console.Write("Lütfen Kaldıraç Oranını girin : ");
            kaldiracOrani = float.Parse(Console.ReadLine());

            Console.Write("Lütfen 'Pozisyon Giriş Fiyatınızı' girin : ");
            pozisyonGiris = float.Parse(Console.ReadLine());

            Console.Write("Lütfen 'Pozisyon Çıkış Fiyatınızı' girin : ");
            pozisyonCikis = float.Parse(Console.ReadLine());

            pozisyonLikidasyon = (pozisyonGiris-((100/kaldiracOrani)/100))+((pozisyonGiris/100)*0.4f);
            //pozisyonLikidasyon += pozisyonGiris/100*(40/100); 
            
            Console.Write($"Likidasyon Pozisyonuz : ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(pozisyonLikidasyon);


            if (pozisyonLong)
            {
                sonucKarZarar =1f*((anaParaMarjin/100)*(((pozisyonCikis-pozisyonGiris)/(pozisyonGiris/100))*kaldiracOrani));
            }
            else if (pozisyonShort)
            {
                sonucKarZarar =1f*((anaParaMarjin/100)*(((pozisyonGiris-pozisyonCikis)/(pozisyonGiris/100))*kaldiracOrani));
            }
            if (sonucKarZarar>0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("%"+(sonucKarZarar/(anaParaMarjin/100))+" +"+sonucKarZarar);
            }
                
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("%"+((sonucKarZarar/(anaParaMarjin/100))*-1)+" "+sonucKarZarar);
            }      
            Console.ForegroundColor = ConsoleColor.White;            
        }
    }
}
