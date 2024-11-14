//Завдання1
//using System;
//
//class Program
//{
//static void Main()
//{
//Console.Write("Enter a number from 1 to 100: ");
//if (int.TryParse(Console.ReadLine(), out int number))
//{
//if (number < 1 || number > 100)
//{
//Console.WriteLine("The number must be in the range from 1 to 100.");
//            }
//            else
//{
//if (number % 3 == 0 && number % 5 == 0)
//{
//Console.WriteLine("FizzBuzz");
//                }
//                else if (number % 3 == 0)
//{
//Console.WriteLine("Fizz");
//                }
//                else if (number % 5 == 0)
//{
//Console.WriteLine("Buzz");
//                }
//                else
//{
//Console.WriteLine(number);
//                }
//            }
//        }
//        else
//{
//Console.WriteLine("Invalid value entered");
//        }
//    }
//}
//Завдання 2
//using System;
//
//class Program
//{
//static void Main()
//{
//Console.Write("Enter the value: ");
//if (double.TryParse(Console.ReadLine(), out double value))
//{
//Console.Write("Enter the percentage: ");
//if (double.TryParse(Console.ReadLine(), out double percentage))
//{
//double result = value * (percentage / 100);
//Console.WriteLine($"{percentage}% from {value} is equal to {result}");
//            }
//            else
//{
//Console.WriteLine("Invalid value for percentage entered");
//            }
//        }
//        else
//{
//Console.WriteLine("Invalid value entered.");
//        }
//    }
//}
//Завдання 3
//using System;
//
//class Program
//{
//static void Main()
//{
//int result = 0;
//
//for (int i = 1; i <= 4; i++)
//{
//Console.Write($"Enter a number {i}: ");
//if (int.TryParse(Console.ReadLine(), out int digit) && digit >= 0 && digit <= 9)
//{
//result = result * 10 + digit;
//            }
//            else
//{
//Console.WriteLine("Invalid digit entered. Please try again.");
//i--;
//            }
//        }
//
//Console.WriteLine($"The generated number: {result}");
//    }
//}
//Завдання 4 
using System;

class Program
{
    static void Main()
    {
        int result = 0;

        for (int i = 1; i <= 4; i++)
        {
            Console.Write($"Enter a number {i}: ");
            if (int.TryParse(Console.ReadLine(), out int digit) && digit >= 0 && digit <= 9)
            {
                result = result * 10 + digit;
            }
            else
            {
                Console.WriteLine("Invalid digit entered. Please try again.");
                i--;
            }
        }

        Console.WriteLine($"The generated number: {result}");
    }
}
