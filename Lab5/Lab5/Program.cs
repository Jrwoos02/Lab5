//Joshua Woosley
//Lab5
//Due: 10/26/2014
//CIS 199-01
//This program using a series of nested loops creates designs out of *'s

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Created for loop for the first asterisk set by creating int's x and y with x establishing the number of *'s and y converting the numbers to symbols
            for (int x = 0; x <= 10; x++)
            {
                for (int y = 0; y <= x; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            //console line for extra spacing
            Console.WriteLine("");

            //Created for loop like previous but this time starting from 10 and counting down
            for (int x = 10; x >= 0; x--)
            {
                for (int y = 0; y <= x; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            //console line for extra spacing
            Console.WriteLine("");

            //Created another for loop like previous but this time made an additional loop with int z for creating spacing from the values of x
            for (int x = 10; x >= 0; x--)
            {
                for (int z = 0; z <= 9-x; z++)
                {
                    Console.Write(" ");
                }

                for (int y = 0; y <= x; y++)
                {

                    Console.Write("*");
                }
                

                Console.WriteLine("");
            }

            //console line for extra spacing
            Console.WriteLine("");

            //Created another for loop like previous but this time made int z do spacing opposite
            for (int x = 0; x <= 10; x++)
            {
                for (int z = 9; z >= x; z--)
                {
                    Console.Write(" ");
                }

                for (int y = 0; y <= x; y++)
                {

                    Console.Write("*");
                }


                Console.WriteLine("");
            }

        }
    }
}
