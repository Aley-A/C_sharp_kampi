using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_databaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Adoçnet

            Console.WriteLine("**** c# veri tabanlı ürün-kategori bilgi sistemi ****");
            Console.WriteLine();
            Console.WriteLine();


            string tableNumber;

            Console.WriteLine("********************************");
            Console.WriteLine("1-kategoriler");
            Console.WriteLine("1-ürünler");
            Console.WriteLine("1-siparişler");
            Console.WriteLine("1-çıkış yap");

            Console.Write("lütfen getirmek istediğiniz tablo numarasını giriniz");
            tableNumber = Console.ReadLine();
            Console.WriteLine("*********************************");

            SqlConnection connection = new SqlConnection("Data source=  ; initial catalog=  ; integrated secrutiry= true");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCategory " , connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            connection.Close();

            foreach ( DataRow row  in dataTable.Rows )
            {
                foreach ( var item in row.ItemArray )
                {
                    Console.WriteLine( item.ToString() );
                }
                Console.WriteLine();

            }

            Console.ReadLine();
        }
    }
}
