using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_6_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* #region Temel Dizi Örnekleri
            string[] colors = { "kırmızı", "sarı", "beyaz", "mavi" };
            Console.WriteLine(colors[2]);

            string[] cities = new string[5];
            cities[0] = "Milano";
            cities[1] = "Pte";
            cities[2] = "Londra";
            cities[3] = "Kahire";
            cities[4] = "Üsküp";
            Console.WriteLine(cities[4]);

            int[] numbers = new int[10];
            numbers[0] = 50;
            numbers[1] = 48;
            numbers[2] = 698;
            numbers[3] = 24;
            numbers[7] = 748;
            Console.WriteLine(numbers[7]);

            string[] cities2 = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };
            Console.WriteLine(cities2[2]);
            #endregion */

            /* #region Dizideki Tüm Elemanları Listeleme
            string[] colors = { "sarı", "kırmızı", "beyaz", "mavi", "yeşil", "turuncu", "pembe" };

            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine(colors[i]);
            }
            //Dizideki En Büyük Elemanı Bulma
            int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
            int maximumNumber = myArray[0];

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > maximumNumber)
                {
                    maximumNumber = myArray[i];
                }
            }

            Console.WriteLine(maximumNumber);
            #endregion
 */

            /* #region Dizi Metotları
            string[] persons = { "Ali", "Veli", "Ahmet" };
            Console.WriteLine(persons.Length);

            int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            Array.Sort(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Array.Reverse(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            #endregion */

            Console.ReadKey();
        }
    }
}
