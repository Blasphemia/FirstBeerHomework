using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1

{
    class Program
    {
        static void Main(string[] args)
        {
           
            bool BoolOne=false;
            bool BoolTwo=false;

            ResultOfOperation(BoolOne, BoolTwo);




            





            Console.ReadKey();
        }

        static void ResultOfOperation(bool firstNumber, bool secondNumber)
        {
            Console.WriteLine($"  A          B             AND         OR        NOT A      NOT B");

            for(int i=0; i<2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"{firstNumber}     {secondNumber}          {firstNumber && secondNumber}         {firstNumber || secondNumber}     {!firstNumber}        {!secondNumber}");

                    
                    secondNumber = !secondNumber;
                }
                firstNumber = !firstNumber;
            }
           

        }


    }


   
}
