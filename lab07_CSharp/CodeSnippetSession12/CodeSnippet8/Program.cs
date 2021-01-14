﻿using System;

namespace CodeSnippet8
{
    public delegate void Display(string msg);
    class Parent
    {
        event Display Print;
        protected void InvokeMethod()
        {
            Print += new Display(PrintMessage);
            Check(); 
        }
        void Check()
        {
            if (Print != null)
            {
                PrintMessage("Welcome to C#");
            }
        }
        void PrintMessage(string msg)
        {
            Console.WriteLine(msg);
        }
    }
    class Child : Parent
    {
        static void Main(string[] args)
        {
            Child objChild = new Child();
            objChild.InvokeMethod();
        }
    }
}
