using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_making_desicion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if else 
            //Console.Write("Lütfen şifreyi giriniz");
            //string password;
            //password =  Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("şifre yanlış ");
            //}

            //string capital, country;
            //Console.WriteLine("başkenti giriniz");
            //capital = Console.ReadLine();

            //Console.WriteLine("ülkeyi giriniz");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("veriler doğrudur");
            //}
            //else
            //{
            //    Console.WriteLine("hatalı bilgi");
            //}

            //int number;
            //Console.WriteLine(" sayıyı giriniz ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("sayı doğrudur");
            //}
            //else
            //{
            //    Console.WriteLine("sayı yanlıştır");
            //}

            //int exam1, exam2, exam3, average;
            //string result = " ";

            //Console.WriteLine("sınav1: ");
            //exam1=int.Parse(Console.ReadLine());
            //Console.WriteLine("sınav2: ");
            //exam2 =int.Parse(Console.ReadLine());
            //Console.WriteLine("sınav3: ");
            //exam3 =int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("sınavların ortalaması: "+ average);

            //if (average>0 & average<= 50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if (average>50 & average<=70)
            //{
            //    result = "Sonuç orta";
            //}
            //if (average > 84)
            //{
            //    result = "sonuç çok iyi";
            //}
            //Console.WriteLine(result); //burda hata almamızın sebebi başka değer girilirse ne olacak
            //// kodu ya resulta boş değer girerek ya da else eklenerek çözülür
            ///

            //string city;
            //Console.WriteLine("lütfen şehir girişi yapınız");
            //city = Console.ReadLine();
            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon") 
            //{
            //    Console.WriteLine(" şehir mevcut ");
            //} 
            //else 
            //{
            //    Console.WriteLine("şehir mevcut değildir");
            //}

            //Console.WriteLine("lütfen kullanıcı adını giriniz: ");
            //string username = Console.ReadLine(); 
            //if (username!= "admin")
            //{
            //    Console.WriteLine("bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz ");
            //}
            #endregion

            #region mod işlemleri

            //int number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);


            //Console.WriteLine("Lütfen 1. sayıyı giriniz ");
            //int number1= int.Parse(Console.ReadLine());

            //Console.WriteLine(" lütfen 2. sayıyı giriniz ");
            //int number2= int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.WriteLine("1. sayının 2. sayıya bölümünden kalan : " + result);

            //Console.WriteLine("lütfen sayıyı giriniz: ");
            //int number=int .Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write(" sayı çifttir ");
            //}
            //else {
            //    Console.WriteLine("sayı tektir ");

            //}

            //char team;
            //Console.Write("lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());  

            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (team == 'f' | team == 'F' )
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B' )
            //{
            //    Console.WriteLine("Beşiktaş");
            //}


            #endregion


            #region switch case 

            //Console.WriteLine(" lütfen ay girişi yapınız : ");
            //int monthNumber = int.Parse(Console.ReadLine());    

            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("ocak"); break;
            //        case 2: Console.WriteLine("şubat"); break;
            //        case 3: Console.WriteLine("mart"); break;
            //    case 4: Console.WriteLine("nisan"); break;
            //        case 5: Console.WriteLine("mayıs"); break;
            //    case 6: Console.WriteLine("haziran "); break;
            //    case 7: Console.WriteLine("temmuz "); break;
            //        case 8: Console.WriteLine("ağustos"); break;
            //        case 9: Console.WriteLine("eylül"); break;
            //        case 10: Console.WriteLine("ekim"); break;
            //        case 11: Console.WriteLine("kasım"); break;
            //        case 12: Console.WriteLine("aralık"); break;
            //        default : Console.WriteLine("hatalı veri girişi"); break;


            //}

            #endregion

            #region hesap makinesi 

            //int number1, number2, result;
            //char symbol;
            //Console.WriteLine("1. sayıyı giriniz");
            //number1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("2. sayıyı giriniz");
            //number2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("lütfen yapmak istediğiniz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result =number1 + number2;
            //        Console.WriteLine("toplam: " + result);
            //        break;

            //    case '-':
            //        result =number1 - number2;
            //        Console.WriteLine("fark: " + result);
            //        break;

            //    case '*':
            //        result =number1 * number2;
            //        Console.WriteLine("çarpım: " +result);
            //        break;

            //    case '/':
            //        result =number1 / number2;
            //        Console.WriteLine("bölüm: " + result);
            //        break;



            //}

            #endregion

            Console.ReadLine();
        }
    }
}
