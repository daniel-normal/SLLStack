using System;

namespace SLLStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack? stack = null;
            byte optionStacks = 0;
            while (optionStacks != 6)
            {
                optionStacks = Convert.ToByte(menuStacks());
                switch (optionStacks)
                {
                    case 1:
                        Console.Clear();
                        stack = new Stack();
                        Console.WriteLine("-------------> u created your stack successfully :) <-------------");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("insert a value");
                        int info = Convert.ToInt32(Console.ReadLine());
                        stack?.Push(info);
                        break;
                    case 3:
                        Console.Clear();
                        stack?.Pop();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("u will see the value of the top element of the stack");
                        stack?.Peek();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("u will see the current stack");
                        stack?.Size();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("u entered a not valid option");
                        break;
                }
            }
        }

        static int menuStacks()
        {
            try
            {
                Console.WriteLine("\t\t\t\tstacks");
                Console.WriteLine("1. create a stack");
                Console.WriteLine("2. push");
                Console.WriteLine("3. pop");
                Console.WriteLine("4. peek");
                Console.WriteLine("5. size");
                Console.WriteLine("6. exit");
                Console.WriteLine("choose an option...");
                byte option = Convert.ToByte(Console.ReadLine());
                return option;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.StackTrace);
                return 0;
            }
        }
    }
}



