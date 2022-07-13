using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int tryCount = 3;
            string password = "qwerty";
            string userInput;
            for (int i = 0; i < tryCount; i++)
            {
                Console.Write("Введите пароль: ");
                userInput = Console.ReadLine();
                if (password == userInput)
                {
                    Console.WriteLine("Тайное сообщение прочитано");
                    break;
                }
                else
                {
                    Console.WriteLine("Неверно, введите пароль еще раз");
                }
            }
        }
    }
}
