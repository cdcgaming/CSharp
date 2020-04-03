﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProject
{
    //Defining Delegates
    //Note: The access specifies, return type and the number, order and type of parameters of delegate
    //should be same as the function it refers to.
    public delegate void AddDelegate(int a, int b);
    public delegate string GreetingsDelegate(string name);
    class Delegates01
    {
        //Defining Methods
        //NonStatic method
        public void Add(int x, int y)
        {
            Console.WriteLine(@"The Sum of {0} and {1}, is {2} ", x, y, (x + y));
        }
        //Static Method
        public static string Greetings(string name)
        {
            return "Hello @" + name;
        }


        static void Main(string[] args)
        {
            var obj = new Delegates01();
            //Instantiating delegate by passing the target function Name
            //The Add method is non static so here we are calling method using object
            AddDelegate ad = new AddDelegate(obj.Add);
            //Greetings method is static so here we are callling the method by using the class name
            GreetingsDelegate gd = new GreetingsDelegate(Delegates01.Greetings);
            //Invoking The Delegates
            ad(100, 50);
            string GreetingsMessage = gd("Pranaya");
            //We can also use Invoke method to execute delegates
            // ad.Invoke(100, 50);
            // string GreetingsMessage = gd.Invoke("Pranaya");
            Console.WriteLine(GreetingsMessage);
            Console.ReadKey();
        }
    }
}
