using System;
using System.Data;
using System.Data.SqlClient;

namespace Ders_9_SQL_Veri_Tabani_ve_Tablo_Olusturma_Csharp_Kismina_Baglama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // sql yapılarını kullanma (Ado.net)

            Console.WriteLine("***** C# veri tabanlı ürün-kategori bilgi sistemi *****");
            Console.WriteLine("\n\n");

            Console.WriteLine("--------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.WriteLine("Lütfen girmek istediğiniz tablo numarasını giriniz: ");
            int tableNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------------");

            SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * from TblCategory", connection);
            //adapter -> c# tarafındaki kodlar ile sql suunucu arasında bir köprü görevi görür.
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            Console.WriteLine(dataTable);
            // Burdaki amaç bu sorguyu ram bellek üzerinden user'a gösterebilmek.

            connection.Close();


            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine($"{row["CategoryId"]} - {row["CategoryName"]}");
            }



            Console.ReadKey();

        }
    }
}
