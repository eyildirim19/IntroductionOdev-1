namespace Odev2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Console'dan alınan ay'ın mevsimini yazdıran prorgramı yapınız.
            Console.WriteLine("Lütfen ay giriniz");
            string ay = Console.ReadLine();
            
            string mevsim;
            int aysirasi;
            if (ay.ToUpper() == "OCAK")
            {
                mevsim = "KIŞ";
                aysirasi = 1;
                Console.WriteLine($"{mevsim}\n{aysirasi}.Ay ");
            }

            else if (ay.ToUpper() == "ŞUBAT")
            {
                mevsim = "KIŞ";
                aysirasi = 2;
                Console.WriteLine($"{mevsim}\n{aysirasi}.Ay ");
            }
            else if (ay.ToUpper() == "MART")
            {
                mevsim = "KIŞ";
                aysirasi = 3;
                Console.WriteLine($"{mevsim}\n{aysirasi}.Ay ");
            }
            else if (ay.ToUpper() == "NİSAN")
            {
                mevsim = "İLKBAHAR";
                aysirasi = 4;
                Console.WriteLine($"{mevsim}\n{aysirasi}.Ay ");
            }

            else if (ay.ToUpper()=="MAYIS")
            {
                mevsim = "İLKBAAR";
                aysirasi = 5;
                Console.WriteLine($"{mevsim}\n{aysirasi}.Ay ");
            }
            else if (ay.ToUpper() == "HAZİRAN")
            {
                mevsim = "İLKBAAR";
                aysirasi = 6;
                Console.WriteLine($"{mevsim}\n{aysirasi}.Ay ");
            }
            else if (ay.ToUpper() == "TEMMUZ")
            {
                mevsim = "YAZ";
                aysirasi = 7;
                Console.WriteLine($"{mevsim}\n{aysirasi}.Ay ");
            }
            else if (ay.ToUpper() == "AĞUSTOS")
            {
                mevsim = "YAZ";
                aysirasi = 8;
                Console.WriteLine($"{mevsim}\n{aysirasi}.Ay ");
            }
            else if (ay.ToUpper() == "EYLÜL")
            {
                mevsim = "YAZ";
                aysirasi = 9;
                Console.WriteLine($"{mevsim}\n{aysirasi}.Ay ");
            }

            else if (ay.ToUpper() == "EKİM")
            {
                mevsim = "SONBAHAR";
                aysirasi = 10;
                Console.WriteLine($"{mevsim}\n{aysirasi}.Ay ");
            }
            else if (ay.ToUpper() == "KASIM")
            {
                mevsim = "SONBAHAR";
                aysirasi = 11;
                Console.WriteLine($"{mevsim}\n{aysirasi}.Ay ");
            }
            else if (ay.ToUpper() =="ARALIK")
            {
                mevsim = "SONBAHAR";
                aysirasi = 12;
                Console.WriteLine($"{mevsim}\n{aysirasi}.Ay ");
            }

            switch (ay.ToUpper())
            {
                case("OCAK"):
                    mevsim = "KIŞ";
                    aysirasi=1;
                Console.WriteLine($"{mevsim}\n{aysirasi}.Ay ");
                    break;
            
            
                case ("ŞUBAT"):
                    mevsim = "KIŞ";
                    aysirasi = 2;
                    Console.WriteLine($"{mevsim}\n{aysirasi}.Ay ");
                    break;
           
                case ("MART"):
                    mevsim = "KIŞ";
                    aysirasi = 3;
                    Console.WriteLine($"{mevsim}\n{aysirasi}.Ay ");
                    break;
            
                case ("NİSAN"):
                    mevsim = "İLKBAHAR";
                    aysirasi = 4;
                    Console.WriteLine($"{mevsim}\n{aysirasi}.Ay ");
                    break;
           
                case ("MAYIS"):
                    mevsim = "İLKBAHAR";
                    aysirasi = 5;
                    Console.WriteLine($"{mevsim}\n{aysirasi}.Ay ");
                    break;
            
                case ("HAZİRAN"):
                    mevsim = "İLKBAHAR";
                    aysirasi = 6;
                    Console.WriteLine($"{mevsim}\n{aysirasi}.Ay ");
                    break;
            
       
                case ("TEMUZ"):
                    mevsim = "YAZ";
                    aysirasi = 7;
                    Console.WriteLine($"{mevsim}\n{aysirasi}.Ay ");
                    break;
            
            
                case ("AĞUSTOS"):
                    mevsim = "YAZ";
                    aysirasi = 8;
                    Console.WriteLine($"{mevsim}\n{aysirasi}.Ay ");
                    break;
            
            
            
                case ("EYLÜL"):
                    mevsim = "YAZ";
                    aysirasi = 9;
                    Console.WriteLine($"{mevsim}\n{aysirasi}.Ay ");
                    break;
                case ("EKİM"):
                    mevsim = "SONBAHAR";
                    aysirasi = 10;
                    Console.WriteLine($"{mevsim}\n{aysirasi}.Ay ");
                    break;

                case ("KASIM"):
                    mevsim = "SONBAHAR";
                    aysirasi = 11;
                    Console.WriteLine($"{mevsim}\n{aysirasi}.Ay ");
                    break;

                case ("ARALIK"):
                    mevsim = "SONBAHAR";
                    aysirasi = 12;
                    Console.WriteLine($"{mevsim}\n{aysirasi}.Ay ");
                    break;

                    default:
                    Console.WriteLine("geçerli bir ay ismi giriniz");
                    break;

            }
            
            // eğer ay;  aralık-ocak-şubat      girilirse ekrana KIŞ 
            // mart-nisan-mayıs       girilirse ekrana İLK BAHAR
            // haziran-temmuz-ağustos girilirse ekrana YAZ 
            // eylük-ekim-kasım       girilirse ekrana SON BAHAR
            // mesajlarını veren programı yazınız.. Girilen ay için kaçıncı ay olduunu yazınız ekrana n. Ay şeklinde yazınız..

            // örnek;
            // klavyeden girilen ocak ayı için çıktı aşağıdaki gibi olmalıdır;
            // KIŞ
            // 1. Ay


            // todo: bütün  istenilenleri switch-case ve if karar mekanizmaları kullanarak yapınız

            Console.WriteLine("Kapatmak için bir tuşa basınız");
            Console.ReadKey();
        }
    }
}