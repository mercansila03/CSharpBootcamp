using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            //Console.WriteLine("Hello world");
            //Console.Write("Merhaba dünya");
            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion

            #region String Değişkenler

            //string name = "Sıla";
            //Console.Write(name);
            //string customerName="Ali"; //camelCase 
            //string customerSurname = "Çınar";
            //string customerPhone = "+90 430 566 92 87";
            //string customerEmail, district, city;

            //customerEmail="deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";
            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine("------------------------------------------");
            //Console.WriteLine("Müşteri: "+ customerName +" " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("Adres: "+  district +"/"+city);
            //Console.WriteLine("------------------------------------------");

            //customerName = "Ayşegül";
            //Console.WriteLine(customerName);
            #endregion

            
           #region Int Değişkenler

            //int number = 24;
            //Console.WriteLine(number);
            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("*Hambuger: " + hamburgerPrice + "TL");
            Console.WriteLine("*Patates Kızartması: " + friesPrice + "TL");
            Console.WriteLine("*Pizza: " + pizzaPrice + "TL");
            Console.WriteLine("*Kola: " + cokePrice + "TL");
            Console.WriteLine("*Lİmonata: " + lemonadePrice + "TL");
            Console.WriteLine("*Su: " + waterPrice + "TL");
            Console.WriteLine("***********************************");
            Console.WriteLine("**** Restoran Menü Fiyatı ****");

            Console.WriteLine();
            int totalHamburgerPrice = 0;
            int totalFriesPrice = 0; 
            int totalPizzaPrice = 0;
            int totalCokePrice = 0;
            int totalLemonadePrice = 0;
            int totalWaterPrice = 0;
               
                    
            int hamburgerCount = 3;
            int friesCount=1; 
            int pizzaCount=0;
            int cokeCount=3;
            int lemonadeCount=0;
            int waterCount=3;   


            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;
            totalWaterPrice = waterCount * waterPrice;
            int total = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice;

            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + "TL");
            Console.WriteLine("Patates Kızartması Tutarı: " + totalFriesPrice + "TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + "TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + "TL");
           Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + "TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + "TL");

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Toplam Tutar: " + total + "TL");








            #endregion

            Console.Read();




        }
    }
}
