namespace Ders_8_Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Methods (Non-Return Methods)
            /*  void CustomerList()
               {
                    Console.WriteLine("Ali Yıldız");
                    Console.WriteLine("Ayşe Yıldız");
                    Console.WriteLine("Ali Öztürk");
                }

                void Sum()
                {
                    int x = 1;
                    int y = 2;
                    int z = x + y;
                    Console.WriteLine(z);
                } */
            #endregion

            #region Void Methods with Parameters
            /* void WriteMethod(string customerName)
            {
                Console.WriteLine(customerName);
            }

            void CustomerCard(string name, string surname)
            {
                Console.WriteLine(name + " " + surname);
            }

            void Sum(int number1, int number2, int number3)
            {
                int result = number1 + number2 + number3;
                Console.WriteLine(result);
            } */

            #endregion

            #region Return Methods
            /* string CustomerCard(string customerName)
                {
                    return "Bus Yıldız";
                }

                string StudentCard()
                {
                    string name = "Ali";
                    string surname = "Kaya";
                    return name + " " + surname;
            }*/
            #endregion

            #region Return Methods with Parameters
            string CountryCard(string countryName, string capital, string flagColor)
            {
                string cardInfo = "Ülke: " + countryName + " " +
                                 "Başkent: " + capital + " - " +
                                 "Bayrak rengi: " + flagColor;
                return cardInfo;
            }

            // Usage with user input
            Console.WriteLine("Ülke adını giriniz:");
            string x = Console.ReadLine();
            Console.WriteLine("Başkenti giriniz:");
            string y = Console.ReadLine();
            Console.WriteLine("Bayrak rengini giriniz:");
            string z = Console.ReadLine();

            Console.WriteLine(CountryCard(x, y, z));

            // Direct usage
            Console.WriteLine(CountryCard("Türkiye", "Ankara", "kırmızı-beyaz"));
            #endregion
            Console.ReadKey();
        }
    }
}
