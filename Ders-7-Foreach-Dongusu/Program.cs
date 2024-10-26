namespace Ders_7_Foreach_Dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Each Loop Examples
            string[] cities = { "Milano", "Roma", "Budapest", "Ankara", "Istanbul" };

            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }

            int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 1094 };

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }

            int total = 0;
            foreach (int i in numbers)
            {
                total += i;
            }
            Console.WriteLine(total);

            List<int> numbersList = new List<int> { 1, 2, 3, 4, 5, 8 };
            // List<int> numbersList = [1, 2, 3, 4, 5, 8];

            foreach (int number in numbersList)
            {
                Console.WriteLine(number);
            }

            string word = "Merhaba";
            foreach (char c in word)
            {
                Console.WriteLine(c);
            }
            #endregion

            #region Exam System Application
            Console.WriteLine("CP Eğitim Kampı Sınav Uygulaması");
            Console.WriteLine("------------------------------");

            Console.Write("Sınıfınızda kaç öğrenci var: ");
            int studentCount = int.Parse(Console.ReadLine());

            string[] studentNames = new string[studentCount];
            double[] studentExamAverage = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;
                }

                studentExamAverage[i] = totalExamResult / 3;
                Console.WriteLine();
            }

            Console.WriteLine("Sınav Ortalamaları:");
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"'{studentNames[i]}' adlı öğrencinin ortalaması: {studentExamAverage[i]:F2}");

                if (studentExamAverage[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
                }
                Console.WriteLine("------------------------------");
            }

            #endregion

            Console.ReadKey();
        }
    }
}
