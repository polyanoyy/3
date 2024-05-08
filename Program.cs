namespace ConsoleApp3
{
    using System;
    class Program
    {
        static void Main()
        {
            char choice; do
            {
                Console.WriteLine("Меню выбора:");
                Console.WriteLine("1. Ввести А");
                Console.WriteLine("2. Ввести B");
                Console.WriteLine("3. Выполнить  '+'");
                Console.WriteLine("4. Выполнить  '-'");
                Console.WriteLine("5. Выполнить  '*'");
                Console.WriteLine("6. Выполнить  '/'");
                Console.WriteLine("7. Выйти");
                Console.Write("Выберите пункт: ");
                choice = Convert.ToChar(Console.ReadLine());
                switch (choice)
                {
                    case '1':
                        Console.WriteLine("Вы выбрали ввести A");
                        break;
                    case '2':
                        Console.WriteLine("Вы выбрали ввести B");
                        break;
                    case '3':
                        Console.WriteLine("Вы выбрали  '+'");
                        break;
                    case '4':
                        Console.WriteLine("Вы выбрали  '-'");
                        break;
                    case '5':
                        Console.WriteLine("Вы выбрали  '*'");
                        break;
                    case '6':
                        Console.WriteLine("Вы выбрали  '/'");
                        break;
                    case '7':
                        Console.WriteLine("Выход из программы");
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                        break;
                }

            } while (choice != '7');
        }
    }
}