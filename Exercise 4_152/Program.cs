﻿using System;
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
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
