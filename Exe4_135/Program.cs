using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe4_135
{
    class Stacks
    {
        private char[] dimas;
        private int top;
        private int max;
        private int n;
        public Stacks()
        {
            dimas = new char[26];
            top = -1;
            max = 26;
        }

        public void push()
        {
            char val;
            if (top == max - 1)
            {
                Console.WriteLine("\n Stack Full!");
            }
            else
            {
                Console.WriteLine("Enter a Data: ");
                val = Convert.ToChar(Console.ReadLine());
                top = top + 1;
                dimas[top] = val;
                Console.WriteLine("Data Pushed");

            }
        }
        public void pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Empty!");
            }
            else
            {
                top = top - 1;
                Console.WriteLine("Data Popped!");
            }
        }


        public void display()
        {
            for (int i = top; i <= 0; i--)
            {
                Console.Write(dimas[i]);
            }
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty!");
            }
        }

        static void Main(string[] args)
        {
            Stacks s = new Stacks();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\n**Stack Menu**\n");
                Console.WriteLine("1. Push.");
                Console.WriteLine("2. Pop.");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit.");
                Console.Write("\nEnter Your Choice: ");
                string sInput = Console.ReadLine();
                char ch = Convert.ToChar(sInput == "" ? "0" : sInput);
                switch (ch)
                {
                    case '1':
                        s.push();
                        break;
                    case '2':
                        s.pop();
                        break;
                    case '3':
                        s.display();
                        break;
                    case '4':
                        return;
                    default:
                        Console.WriteLine("\nInvalid Choice");
                        break;
                }

            }
        }
    }
}
