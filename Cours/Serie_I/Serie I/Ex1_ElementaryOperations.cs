using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    public static class ElementaryOperations
    {
        public static void BasicOperation(int a, int b, char operation)
        {
            //TODO
            int c;
            switch (operation)
            {
                case '+':
                    c = a + b;
                    Console.WriteLine($"{a} + {b} = {c}");
                    //Console.WriteLine(a + " + " + b  + " = " + c);
                    break;
                case '-':
                    c = a - b;
                    Console.WriteLine($"{a} - {b} = {c}");
                    break;
                case '*':
                    c = a * b;
                    Console.WriteLine($"{a} * {b} = {c}");
                    break;
                case '/':
                    if (b == 0)
                    {
                        Console.WriteLine($"{a} / {b} = Opération invalide.");
                    }
                    else
                    {
                        c = a / b;
                        Console.WriteLine($"{a} / {b} = {c}");
                    }
                    break;
                default:

                    Console.WriteLine($"{a} {operation} {b} = Opération invalide.");
                    break;
            }


        }

        public static void IntegerDivision(int a, int b)
        {
            //TODO
            int q;
            int r;
            if (b == 0)
            {
                Console.WriteLine($"{a} / {b} = Opération invalide.");
            }
            else
            {
                q = a / b;
                r = a % b;
                if (r == 0)
                {
                    Console.WriteLine($"{a} = {q} * {b}");
                }
                else
                {
                    Console.WriteLine($"{a} = {q} * {b} + {r}");
                }
            }

        }

        public static void Pow(int a, int b)
        {
            //TODO
            int c = 1;
            if (b < 0)
            {
                Console.WriteLine("Opération invalide.");
            }
            else
            {
                for (int i = 0; i < b; i++)
                {
                    c *= a;
                    //c = c * a;
                }
                Console.WriteLine($"{a} ^ {b} = {c}");
            }

        }
    }
}
