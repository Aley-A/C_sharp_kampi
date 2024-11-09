using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region metotlar 

            //( ) 
            // geriye değer döndürmeyen metotlar 
            //customer ---> Listele, ekle, sil , güncelle 
            // void metotlar 

            //void customerList()
            //{
            //    Console.WriteLine("Ali yıldız");
            //    Console.WriteLine("Ayşe yıldız");
            //    Console.WriteLine("hakan çalhanoğlu");
            //    Console.WriteLine("merve çınar");


            //}

            //customerList();
            //customerList();
            //customerList();
            //customerList();

            //void Sum()
            //{
            //    int x = 1; 
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();




            #endregion

            #region geriye dönülmeyen string parametreli metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("mehmet yıldırım");

            //void CustomerCard(string name,string Surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + Surname);

            //}
            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Ayşegül", "kaya");


            #endregion

            #region geriye dönülmeyen int parametreli metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(4, 5, 6);



            #endregion

            #region geriye değer döndüren metotlar

            //string CustomerName()
            //{
            //    return "hakan çalhanoğlu";
            //}
            //CustomerName() 

            //string StudentCard()
            //{
            //    string name = "Ali ";
            //    string surname = "kaya ";

            //    return name + " " + surname;    

            //}
            //Console.WriteLine(StudentCard());


            #endregion

            #region geriye değer döndüren parametreli metotlar

            //string CountryCard(string countryName , string capital , string flagcolor)
            //{
            //    string cardInfo = "ülke: " + countryName + " - Başkent: " + capital + " -  bayrak rengi: " + flagcolor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.WriteLine("ülke adını giriniz: ");
            //x = Console.ReadLine();

            //Console.WriteLine("başkenti giriniz: ");
            //y = Console.ReadLine();

            //Console.WriteLine("bayrak rengini giriniz: ");
            //z = Console.ReadLine();
            //Console.WriteLine( CountryCard(x, y, z) );

            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "kırmızı-beyaz"));
            #endregion

            #region geriye değer döndüren int parametreli metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(36, 35));
            //Console.WriteLine(Sum(44, 75));
            //Console.WriteLine(Sum(14, 90));


            #endregion

            #region örnek uygulama 

            //string ExamResult(string student, int exam1, int exam2, int exam3) {
            //    int result = (exam1 + exam2  + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + "isimli öğrenci sınavı geçti " + "ortalama: "+ result;

            //    }
            //    else
            //    {
            //        return student + "isimli öğrenci sınavı geçemedi " + "ortalama: " + result;
            //    }

            //    Console.WriteLine(ExamResult("ali", 25, 46, 89));
            //    Console.WriteLine(ExamResult("ayşe", 36, 88, 33));

                #endregion


                Console.ReadLine();
        }
    }
}
