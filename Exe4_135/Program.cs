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
        }
    }
}
