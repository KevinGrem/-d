using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoMatizz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Данные от пользователя

            double valume;
            Console.Write("Введите стоимость Магнитолы: ");
            valume = double.Parse(Console.ReadLine());


            Console.Write("Введите год покупки: ");
            int date = int.Parse(Console.ReadLine());

            Console.Write("Введите год окончания гарантии: ");
            int DateOfGrandOfOldShit = int.Parse(Console.ReadLine());
            int YearsOfGrand = DateOfGrandOfOldShit - date;`

            Console.Write("Введите колличество лет предсказания: ");
            int years = int.Parse(Console.ReadLine());

            double Inf = 0.04;



            //Вероятность поломки

            Console.WriteLine();
            Console.WriteLine("Вычесление стоимости Магнитолы.....");
            Console.WriteLine();

            for (int i = 1; i <= years; i++)
            {
                date += 1;

                Random Rand = new Random();

                int Palomka = Rand.Next(10);

                //Console.WriteLine(Palomka);


                Console.WriteLine();

                if (date <= 2000)
                {
                    valume *= Inf;
                }

                if (date > 2000)
                {
                    valume += 300;
                }

                if (YearsOfGrand >= 1 && Palomka == 1)
                {
                    Console.WriteLine("Произошла поломка, стоимость починки бесплатно.");
                    YearsOfGrand--;
                }

                else if (date >= 1994 && Palomka <= 3)
                {
                    Console.WriteLine("Произошла поломка, стоимость починки 100.");
                    valume -= 100;
                }

                Console.WriteLine("Год: " + date);


                if (i == years)
                {
                    Console.WriteLine("------------------------------------------------------------------------------------------------");

                    Console.WriteLine("Стоимость Магнитолы в " + date + " году = " + Math.Round(valume, 0));
                }

            }


        }
    }
}

