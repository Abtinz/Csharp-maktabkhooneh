﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your first number: ");
            String firstinputsData = Console.ReadLine();
            int firstNumber = int.Parse(firstinputsData);

            Console.Write("Please enter your second number: ");
            String secondinputsData = Console.ReadLine();
            int secondNumber = int.Parse(secondinputsData);

            Console.Write("Please enter your third number: ");
            String thirdinputsData = Console.ReadLine();
            int thirdNumber = int.Parse(thirdinputsData);
        }

        //this mehtod will calculate sum of three number
        static float SumFunction(float firstNumber , float secondNumber , float thirdNumber)
        {

            float sumResult = 0;
            sumResult = firstNumber + secondNumber + thirdNumber;
            return sumResult;
        }
    }
}
