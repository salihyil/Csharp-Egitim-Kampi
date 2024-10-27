using System;
using System.Data.SqlClient;

namespace Ders_10_Csharp_ile_SQL_Listeleme_Ekleme_Guncelleme_ve_Silme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****\n");

            #region Kategori Ekleme işlemi
            /* Console.WriteLine("------------------------------------------");
            Console.Write("Eklemek istediğin kategori adı: ");
            string categoryName = Console.ReadLine();

            SqlConnection connection = new SqlConnection("Data Source=SALIH;Initial Catalog=EgitimKampiDb;integrated security=true;");
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO TblCategory (CategoryName) VALUES (@p1)", connection);
            command.Parameters.AddWithValue("@p1", categoryName);
            command.ExecuteNonQuery();
            connection.Close();

            Console.WriteLine("Kategori başarıyla eklendi.");*/
            #endregion

            #region Ürün(Product) Ekleme işlemi
            /* string productName;
            decimal productPrice;
            //bool productStatus;

            Console.Write("Ürün adı: ");
            productName = Console.ReadLine();
            Console.Write("Ürün fiyatı: ");
            productPrice = Convert.ToDecimal(Console.ReadLine());
            // Console.Write("Ürün durumu (true/false): ");
            // productStatus = Convert.ToBoolean(Console.ReadLine()); 

            SqlConnection connection = new SqlConnection("Data Source=SALIH;Initial Catalog=EgitimKampiDb;integrated security=true;");
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO TblProduct (ProductName, ProductPrice, ProductStatus) VALUES (@productName , @productPrice, @productStatus)", connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productStatus", true);
            command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("Ürün başarıyla eklendi."); */
            #endregion

            #region Ürün(Product) Listeleme işlemi
            /* Console.WriteLine("***** Ürün(Product) Listeleme işlemi *****\n");
            SqlConnection connection = DatabaseHelper.GetConnection();
            connection.Open();
            SqlCommand command = DatabaseHelper.CreateCommand("SELECT * FROM TblProduct", connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"Ürün ID: {reader["ProductId"]} Ürün Adı: {reader["ProductName"]} Ürün Fiyatı: {reader["ProductPrice"]}");
            }
            connection.Close(); */
            #endregion

            #region Ürün(Product) Silme işlemi
            /* Console.WriteLine("***** Ürün(Product) Silme işlemi *****\n");
            Console.Write("Silmek istediğiniz ürün ID'si: ");
            int productId = Convert.ToInt32(Console.ReadLine());

            SqlConnection connection = DatabaseHelper.GetConnection();
            connection.Open();
            SqlCommand command = DatabaseHelper.CreateCommand("DELETE FROM TblProduct WHERE ProductId = @productId", connection);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();
            connection.Close();

            Console.WriteLine("Ürün başarıyla silindi."); */
            #endregion

            #region Ürün(Product) Güncelleme işlemi
            Console.WriteLine("***** Ürün(Product) Güncelleme işlemi *****\n");
            Console.Write("Güncellemek istediğiniz ürün ID'si: ");
            int productId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Güncellemek istediğiniz ürün adı: ");
            string productName = Console.ReadLine();
            Console.Write("Güncellemek istediğiniz ürün fiyatı: ");
            decimal productPrice = Convert.ToDecimal(Console.ReadLine());

            SqlConnection connection = DatabaseHelper.GetConnection();
            connection.Open();
            SqlCommand command = DatabaseHelper.CreateCommand("UPDATE TblProduct SET ProductName = @productName, ProductPrice = @productPrice WHERE ProductId = @productId", connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("Ürün başarıyla güncellendi.");
            #endregion


            Console.ReadKey();
        }
    }
}
