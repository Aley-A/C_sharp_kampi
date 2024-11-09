using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_main_subjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma komutları
            //Console.Write("merhaba dünya ");
            //Console.Write("Selam");

            //Console.WriteLine("***** Yemek katagorileri ****");
            //Console.WriteLine();
            //Console.WriteLine("1-çorbalar");
            //Console.WriteLine("2-ana yemekler");
            //Console.WriteLine("3-soğuk başlangıçlar");
            //Console.WriteLine("4- salatalar");
            //Console.WriteLine("5-tatlılar");
            //Console.WriteLine("6-içecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** yemek kategorileri****");
            #endregion

            #region Değişkenler 

            //string
            //Değişken_türü değişken_adı;

            //string name;
            //name = "Aleyna";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerEmail, district, city;
            //string customerPhone;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerEmail = "deneme@gmail.com";
            //district = "kadıköy";
            //city = "istanbul";
            //customerPhone = "+039520809";

            //Console.WriteLine("**** rezervsyon kartı***");
            //Console.WriteLine();
            //Console.WriteLine("-----------");
            //Console.WriteLine("müşteri:  " + customerName + " " + customerSurname);
            //Console.WriteLine("iletişim:  "+ customerPhone + " " + customerPhone);
            //Console.WriteLine("adres:    " + district "/" + city);
            //Console.WriteLine("------------------");




            #endregion

            #region Int değişkenler 

            //int 
            //int number = 24;
            //Console.WriteLine(number);

            //int hamburgerPrice = 300;
            //int cokePrice = 35;
            //int waterPrice = 10;
            //int friesPrice = 50;
            //int pizzaPrice = 250;
            //int lemonadePrice = 30;

            //Console.WriteLine("******* restoran menü fiyatı*****");
            //Console.WriteLine();
            //Console.WriteLine("---pizza:  " + pizzaPrice + "tl ");
            //Console.WriteLine("---hamburger:  " + hamburgerPrice + "tl ");
            //Console.WriteLine("---kola:  " + cokePrice + "tl ");
            //Console.WriteLine("---su:  " + waterPrice + "tl ");
            //Console.WriteLine("---limonata:  " + lemonadePrice + "tl ");
            //Console.WriteLine("---kızartma:  " + friesPrice + "tl ");

            //Console.WriteLine();
            //int hamburgerCount;
            //int cokeCount;
            //int waterCount;
            //int friesCount;
            //int pizzaCount;
            //int lemonadeCount;

            //int totalHamburgerPrice = 0;
            //int totalcokePrice = 0;
            //int totalwaterPrice = 0;
            //int totalfriesPrice = 0;
            //int totalpizzaPrice = 0;
            //int totallemonadePrice = 0;

            //hamburgerCount = 3;
            //cokeCount = 3;
            //waterCount = 3;
            //friesCount = 1;
            //pizzaCount = 0;
            //lemonadeCount = 0;

            //totalHamburgerPrice = hamburgerCount + hamburgerPrice;
            //totalcokePrice = cokePrice + cokeCount;
            //totalwaterPrice = waterPrice + waterCount;
            //totalfriesPrice = friesPrice + friesCount;
            //totalpizzaPrice = pizzaPrice + pizzaCount;
            //totallemonadePrice = lemonadePrice + lemonadeCount;

            //Console.WriteLine("--------");
            //Console.WriteLine("hamburger tutarı : " + totalHamburgerPrice + " Tl ");
            //Console.WriteLine("kola tutarı : " + totalcokePrice + " Tl ");
            //Console.WriteLine("su tutarı : " + totalwaterPrice + " Tl ");
            //Console.WriteLine("kızartma tutarı : " + totalfriesPrice + " Tl ");
            //Console.WriteLine("pizza tutarı : " + totalpizzaPrice + " Tl ");
            //Console.WriteLine("limonata tutarı : " + totallemonadePrice + " Tl ");

            //Console.WriteLine();
            //int totalPrice = totalcokePrice + totalfriesPrice + totalHamburgerPrice + totallemonadePrice + totalpizzaPrice + totalwaterPrice;

            //Console.WriteLine("toplam ödenecek tutar : " + totalPrice + "tl");

            #endregion

            #region double değişkeni
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);  
            //Console.WriteLine("******* fiyat listesi ****");
            //Console.WriteLine();

            //double applePrice, orangePrice, StrawberyPrice, patato, tomato;
            //applePrice = 14.85;
            //orangePrice = 29.95;
            //StrawberyPrice = 45;
            //patato = 9.74;
            //tomato = 6.88;

            //Console.WriteLine("------ elma birim fiyatı :" + applePrice + "Tl");
            //Console.WriteLine("------ portakal birim fiyatı :" + orangePrice + "Tl");
            //Console.WriteLine("------ çilek birim fiyatı :" + StrawberyPrice + "Tl");
            //Console.WriteLine("------ patates birim fiyatı :" + patato +"Tl");
            //Console.WriteLine("------ domates birim fiyatı :" + tomato + "Tl");

            //double appleGram, orangeGram, tomatoGram ,StrawberyGram ,patatoGram ;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //patatoGram = 4.859;
            //StrawberyGram = 0.750;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double patatoTotalPrice = patatoGram * patato;
            //double tomatoTotalPrice = tomatoGram * tomato;
            //double StrawberyTotalPrice = StrawberyGram * StrawberyPrice;

            //Console.WriteLine("Alınan ürün : elma -" + appleTotalPrice + "gramı :" + appleGram);
            //Console.WriteLine("Alınan ürün : portakal -" + orangeTotalPrice + "gramı :" + orangeGram);
            //Console.WriteLine("Alınan ürün : patates -" + patatoTotalPrice + "gramı :" + patatoGram);
            //Console.WriteLine("Alınan ürün : çilek -" + StrawberyTotalPrice + "gramı :" + StrawberyGram);
            //Console.WriteLine("Alınan ürün : domates -" + tomatoTotalPrice + "gramı :" + tomatoGram);

            #endregion

            #region char değişkinleri

            //char symbol;
            //symbol = 'A';
            //Console.WriteLine(symbol);  

            #endregion


            Console.Read();
        }
    }
}

//yazdırma komutları 