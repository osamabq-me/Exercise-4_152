using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4_152
{
    class Stack
    {
        string[] oss;
        int top;
        int max;

        public Stack(int size)
        {
            oss = new string[size];
            top = -1;
            max = size;
        }
        public void push()
        {
            string Ndata;
            if (top == max - 1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            else
            {
                Console.WriteLine("Input the new data");
                Ndata = Console.ReadLine();
                oss[++top] = Ndata;
            }
        }
        public void pop()
        {
            if (top == -1)
            {
                Console.WriteLine("\n \n Stack Underflow: Cannot delete from an empty stack\n\n");
            }
            else
            {
                Console.WriteLine("\nPoped data is: " + oss[top]);
                top--;
            }
        }
        public void display()
        {
            if (top == -1)
            {
                Console.WriteLine("\nStack is Empty");
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("\nData[" + (i + 1) + "]: " + oss[i]);
                }
            }

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack OS = new Stack(72);
            while (true)
            {
                Console.WriteLine("\n****Menu****");
                Console.WriteLine("1. Add Data to stack");
                Console.WriteLine("2. Delete Data from the Stack");
                Console.WriteLine("3. Dispaly all stack data");
                Console.WriteLine("4. Exit\n");
                Console.WriteLine("Enter yor choice(1-4):");
            }

        }
    }
}
