using System;

namespace PratikDeğiskenler
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen aşağıdaki bilgileri giriniz: ");
            Console.Write("T.C. Kimlik Numarası: ");
            string identityNumber = Console.ReadLine();
            
            Console.Write("Adı: ");            
            string name = Console.ReadLine();
            
            Console.Write("Soyadı: ");
            string surname = Console.ReadLine();

            // Telefon numarasıyla başka bir işlem yapmayacağımız için direk string olarak depoladım.
            Console.Write("Telefon Numarası: ");
            string telNumber = Console.ReadLine();

            Console.Write("Yaş: ");
            string age = Console.ReadLine();

            // Ürün fiyatlarını string veri tipini kullanarak olarak aldım daha sonrasında int veri tipine dönüştürmek için TryParse metodunu kullandım.
            Console.Write("İlk Aldığı Ürünün Fiyatı: ");
            string firstProduct = Console.ReadLine();

            Console.Write("İkinci Aldığı Ürünün Fiyatı: ");
            string secondProduct = Console.ReadLine();


            int.TryParse(firstProduct, out int firstProductPrice);
            int.TryParse(secondProduct, out int secondProductPrice);

            int sum = (firstProductPrice + secondProductPrice);

            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"{identityNumber} Tc numaralı {name} {surname} isimli kişi için kayıt oluturulmuştur.");
            Console.WriteLine($"{telNumber} telefon numarasına bildirim mesajı gönderilmiştir.");
            Console.WriteLine($"{sum} toplam harcama karşılığı kazanılan 10% patika puan miktarı -> {sum * 0.10} TL'dir.");

        }

    }
}