using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_1._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Задание 1:
int number = int.Parse(Console.ReadLine());

            if (number < 1 || number > 100)
            {
                Console.WriteLine("Error: input must be between 1 and 100");
            }
            else if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }

           // Задание 2:

                // Запрос исходных значений
                Console.Write("Введите значение: ");
                double value = double.Parse(Console.ReadLine());
                Console.Write("Введите процент: ");
                double percent = double.Parse(Console.ReadLine());

                // Вычисление процента
                double result = value * (percent / 100);

                // Вывод результата
                Console.WriteLine("Результат: {0:0.##}", result);

                Console.ReadKey();
            }
        }
    }

    //Задание 3:
int number = int.Parse(Console.ReadLine());
    int firstNum = number / 1000;
    int secondNum = (number / 100) % 10;
    int thirdNum = (number / 10) % 10;
    int fourthNum = number % 10;

    int result = (firstNum * 1000) + (secondNum * 100) + (thirdNum * 10) + fourthNum;

    Console.WriteLine(result);

//Задание4:
public static int SwapDigits(int num, int pos1, int pos2)
    {
        // convert number into word
        string word = num.ToString();

        // check if number has 6 digits
        if (word.Length != 6)
        {
            Console.WriteLine("Error: Number needs to have 6 digits.");
            return -1;
        }

        char c1 = word[pos1];
        char c2 = word[pos2];

        word = word.Remove(pos1, 1).Insert(pos1, c2.ToString());
        word = word.Remove(pos2, 1).Insert(pos2, c1.ToString());

        int result = Int32.Parse(word);

        return result;
    }

    //Задание 5:

            {
                Console.WriteLine("Please enter a date (e.g 22.12.2021): ");
                string input = Console.ReadLine();

                DateTime date = DateTime.Parse(input);

                string season;
                if (date.Month >= 3 && date.Month <= 5)
                    season = "spring";
                else if (date.Month >= 6 && date.Month <= 8)
                    season = "summer";
                else if (date.Month >= 9 && date.Month <= 11)
                    season = "autumn";
                else
                    season = "winter";

                string day;
                switch (date.DayOfWeek)
                {
                    case DayOfWeek.Monday:
                        day = "Monday";
                        break;
                    case DayOfWeek.Tuesday:
                        day = "Tuesday";
                        break;
                    case DayOfWeek.Wednesday:
                        day = "Wednesday";
                        break;
                    case DayOfWeek.Thursday:
                        day = "Thursday";
                        break;
                    case DayOfWeek.Friday:
                        day = "Friday";
                        break;
                    case DayOfWeek.Saturday:
                        day = "Saturday";
                        break;
                    case DayOfWeek.Sunday:
                        day = "Sunday";
                        break;
                    default:
                        day = "Unknown";
                        break;
                }
                Console.WriteLine($"{season} {day}");
            }
        }
    }

    //Задание 6:

            {
                int choice;
                double temperature = 0;
                double result = 0;
                Console.WriteLine("Выберите функцию перевода: \n1. Фаренгейт в Цельсий. \n2. Цельсий в Фаренгейт.");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Введите температуру в Фаренгейтах:");
                        temperature = Convert.ToDouble(Console.ReadLine());
                        result = (temperature - 32) * 5 / 9;
                        Console.WriteLine("Температура в Цельсиях: {0}", result);
                        break;
                    case 2:
                        Console.WriteLine("Введите температуру в Цельсиях:");
                        temperature = Convert.ToDouble(Console.ReadLine());
                        result = (temperature * 9 / 5) + 32;
                        Console.WriteLine("Температура в Фаренгейтах: {0}", result);
                        break;
                    default:
                        Console.WriteLine("Вы выбрали неверную функцию перевода!");
                        break;
                }
            }
        }
    }

   // Задание 7:
Console.WriteLine("Please enter two numbers, separated by a space");
string userInput = Console.ReadLine();

    // Split the user input
    string[] nums = userInput.Split(" ");

    // Set the start and end of the range
    int start = 0;
    int end = 0;

// Perform the normalization
if (Convert.ToInt32(nums[0]) > Convert.ToInt32(nums[1]))
{
start = Convert.ToInt32(nums[1]);
end = Convert.ToInt32(nums[0]);
}
else
{
    start = Convert.ToInt32(nums[0]);
    end = Convert.ToInt32(nums[1]);
}

// Iterate through the range and display the even numbers
for (int i = start; i <= end; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
        }
    }
}
