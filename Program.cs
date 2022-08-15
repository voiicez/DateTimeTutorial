using System.Globalization;

namespace DateTimeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime tarih = new DateTime(2022, 8, 11);
            tarih = new DateTime(2022, 8, 11, 14, 15, 55, 123);

            Console.WriteLine(tarih);
            Console.WriteLine(tarih.ToShortDateString()); //11.08.2022
            Console.WriteLine(tarih.ToLongDateString()); //11 Ağustos 2022 Perşembe
            Console.WriteLine(tarih.ToLongTimeString()); //14:15:55
            Console.WriteLine(tarih.ToShortTimeString()); //14:155
            Console.WriteLine(tarih.ToString("yyyy-MM-dd HH:mm:ss")); 
            Console.WriteLine(tarih.Month+"/"+tarih.Day+"/"+tarih.Year); // Kendimiz AA/GG/YYYY formatında yazdırdık.

            DateTime tarih1 = DateTime.Parse("15.08.2022");
            Console.WriteLine(tarih1);
            tarih1 = DateTime.Parse("08/15/2022", new CultureInfo("en-US"));//CultureInfo class'ını using system.Globalization çağırarak kullanıyoruz. //tr-TR
            double sayi = 1.2; // Pc türkiye ayarlı olduğundan 1,2 olarak yazacak.
            string sayiStr = sayi.ToString(new CultureInfo("en-US")); // Burada 1.2 olarak yazdırmasını sağladık.
            Console.WriteLine(sayiStr); //1.2

                                        
            
        }
    }
}