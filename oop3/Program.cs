using System;
namespace oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            FractionWork fraction = new FractionWork();
            do
            {
                Console.WriteLine("Действия\n1 - Сокращение\n2 - Умножение\n3 - Деление");
                string line = Console.ReadLine();
                if (CheckInt(line) && (int.Parse(line) > 0 && int.Parse(line) < 3))
                {
                    switch (line)
                    {
                        case "1":
                            {
                                Console.WriteLine(fraction.Reduction());
                                break;
                            }
                        case "2":
                            {
                                Console.WriteLine(fraction.Multiplication());
                                break;

                            }
                        case "3":
                            {
                                Console.WriteLine(fraction.Division());
                                break;
                            }
                        default: break;
                    }
                }
                else
                {
                    Console.WriteLine("Такого варианта нет\n");
                }
            } while (true);
        }
        private static bool CheckInt(string number)
        {
            try
            {
                int.Parse(number);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static int EnterInt(string text)
        {
            Console.WriteLine(text);
            do
            {
                string line = Console.ReadLine();
                if (CheckInt(line))
                {
                    return int.Parse(line);
                }
                else { Console.WriteLine("Это не число"); }
            } while (true);
        }
    }
}
    

