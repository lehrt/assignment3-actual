﻿
using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Rover myRover = new Rover(20);
            //Console.WriteLine(myRover.ToString());

            Command comm = new Command("NEW_MODE", "blah");
            Console.WriteLine(comm);
        }
    }
}