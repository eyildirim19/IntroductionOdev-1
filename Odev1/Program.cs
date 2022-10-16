namespace Odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Öğrenci Vize Final Notu Hesaplama");

            // Console'^dan girilen vize ve final notları ile ortalamayı hesaplayan bu ortalamaya göre harfnotunu bulup ekrana ortalama ve harfnotunu yazan prog. yazınız.. tanımladığım değişkenleri kullanınız... 

            string harfNotu;
            float vize, final, ort=0;
            
            // vize notu isteyiniz
            Console.WriteLine("vize notu giriniz");
            vize = Convert.ToInt32(Console.ReadLine());
            
            // final notu isteyiniz
            Console.WriteLine("final notunu giriniz");
            final = Convert.ToInt32(Console.ReadLine());
            
            // ortalama hesaplayınız
            ort = (float)((vize * 0.4) + (final * 0.6));


            // ortalam vize notunun %40 finalnotunun %60 formülü ile hesaplanır. Formül (vizenotu * 0.4) + (finalnotu * 0.6)
            if (ort < 25)
            {
                harfNotu = "FF";

                // harfNotu =  Eğer ortalama 85 ile 100 arasında ise AA, 75 ile 84 arasında ise BA,65 ile 74 arasında ise BB,50 ile 64 arasında ise CC,25 ile 49 arasında ise DC, 25'ten küçük ise FF olarak bulunmalıdır..

                Console.WriteLine($"Ortalamanız ={ort} HarfNotunuz = {harfNotu}");
            }

            if (25 <= ort && ort<50)
            {
                 harfNotu = "DC";

                // harfNotu =  Eğer ortalama 85 ile 100 arasında ise AA, 75 ile 84 arasında ise BA,65 ile 74 arasında ise BB,50 ile 64 arasında ise CC,25 ile 49 arasında ise DC, 25'ten küçük ise FF olarak bulunmalıdır..

                Console.WriteLine($"Ortalamanız ={ort} HarfNotunuz = {harfNotu}");
            }

            else if (50<=ort && ort<65)
            {
                 harfNotu = "CC";

                // harfNotu =  Eğer ortalama 85 ile 100 arasında ise AA, 75 ile 84 arasında ise BA,65 ile 74 arasında ise BB,50 ile 64 arasında ise CC,25 ile 49 arasında ise DC, 25'ten küçük ise FF olarak bulunmalıdır..

                Console.WriteLine($"Ortalamanız ={ort} HarfNotunuz = {harfNotu}");
            }

            else if (65<=ort && ort<75)
            {
                 harfNotu = "BB";

                // harfNotu =  Eğer ortalama 85 ile 100 arasında ise AA, 75 ile 84 arasında ise BA,65 ile 74 arasında ise BB,50 ile 64 arasında ise CC,25 ile 49 arasında ise DC, 25'ten küçük ise FF olarak bulunmalıdır..

                Console.WriteLine($"Ortalamanız ={ort} HarfNotunuz = {harfNotu}");
            }

            else if (75<=ort && ort < 85)
            {
                 harfNotu = "BA";

                // harfNotu =  Eğer ortalama 85 ile 100 arasında ise AA, 75 ile 84 arasında ise BA,65 ile 74 arasında ise BB,50 ile 64 arasında ise CC,25 ile 49 arasında ise DC, 25'ten küçük ise FF olarak bulunmalıdır..

                Console.WriteLine($"Ortalamanız ={ort} HarfNotunuz = {harfNotu}");
            }
            else
            { 
                 harfNotu = "AA";

                // harfNotu =  Eğer ortalama 85 ile 100 arasında ise AA, 75 ile 84 arasında ise BA,65 ile 74 arasında ise BB,50 ile 64 arasında ise CC,25 ile 49 arasında ise DC, 25'ten küçük ise FF olarak bulunmalıdır..

                Console.WriteLine($"Ortalamanız ={ort} HarfNotunuz = {harfNotu}");
            }

            switch (ort)
            {
                case >0 and < 25:
                    
                     harfNotu = "FF";

                    // harfNotu =  Eğer ortalama 85 ile 100 arasında ise AA, 75 ile 84 arasında ise BA,65 ile 74 arasında ise BB,50 ile 64 arasında ise CC,25 ile 49 arasında ise DC, 25'ten küçük ise FF olarak bulunmalıdır..

                    Console.WriteLine($"Ortalamanız ={ort} HarfNotunuz = {harfNotu}");
                    break;
            
                case >= 25 and < 50:

                     harfNotu = "DC";

                    // harfNotu =  Eğer ortalama 85 ile 100 arasında ise AA, 75 ile 84 arasında ise BA,65 ile 74 arasında ise BB,50 ile 64 arasında ise CC,25 ile 49 arasında ise DC, 25'ten küçük ise FF olarak bulunmalıdır..

                    Console.WriteLine($"Ortalamanız ={ort} HarfNotunuz = {harfNotu}");
                    break;
            
                case >= 50 and < 65:

                     harfNotu = "CC";

                    // harfNotu =  Eğer ortalama 85 ile 100 arasında ise AA, 75 ile 84 arasında ise BA,65 ile 74 arasında ise BB,50 ile 64 arasında ise CC,25 ile 49 arasında ise DC, 25'ten küçük ise FF olarak bulunmalıdır..

                    Console.WriteLine($"Ortalamanız ={ort} HarfNotunuz = {harfNotu}");
                    break;
            
                case >= 65 and < 75:

                     harfNotu = "BB";

                    // harfNotu =  Eğer ortalama 85 ile 100 arasında ise AA, 75 ile 84 arasında ise BA,65 ile 74 arasında ise BB,50 ile 64 arasında ise CC,25 ile 49 arasında ise DC, 25'ten küçük ise FF olarak bulunmalıdır..

                    Console.WriteLine($"Ortalamanız ={ort} HarfNotunuz = {harfNotu}");
                    break;
            
                case >=75 and < 85:

                     harfNotu = "BA";

                    // harfNotu =  Eğer ortalama 85 ile 100 arasında ise AA, 75 ile 84 arasında ise BA,65 ile 74 arasında ise BB,50 ile 64 arasında ise CC,25 ile 49 arasında ise DC, 25'ten küçük ise FF olarak bulunmalıdır..

                    Console.WriteLine($"Ortalamanız ={ort} HarfNotunuz = {harfNotu}");
                    break;
           
                case >= 85 and <= 100:

                     harfNotu = "AA";

                    // harfNotu =  Eğer ortalama 85 ile 100 arasında ise AA, 75 ile 84 arasında ise BA,65 ile 74 arasında ise BB,50 ile 64 arasında ise CC,25 ile 49 arasında ise DC, 25'ten küçük ise FF olarak bulunmalıdır..

                    Console.WriteLine($"Ortalamanız ={ort} HarfNotunuz = {harfNotu}");
                    break;
            }

            // todo: bütün  istenilenleri switch-case ve if karar mekanizmaları kullanarak yapınız
            Console.WriteLine("Kapatmak için bir tuşa basınız");
            Console.ReadKey();
        }
    }
}