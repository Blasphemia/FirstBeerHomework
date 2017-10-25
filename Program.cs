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
            string quit = "n";
            string readkey;
            bool BoolOne;
            bool BoolTwo;
            while (quit != "y")
            {
                BoolOne = false;
                BoolTwo = false;
                  Console.WriteLine("t = TRUE, f = FALSE. Enter 't' or 'f' : ");

                    readkey = Console.ReadLine();
                    if (readkey == "t")
                    {
                        BoolOne = true;
                    }
                else if ((readkey != "t") & (readkey != "f")) { Console.WriteLine("Incorrect input! Press Enter to quit. "); break; }

                Console.WriteLine("t = TRUE, f = FALSE. Enter 't' or 'f' : ");
                    readkey = Console.ReadLine();
                    if (readkey == "t")
                    {
                        BoolTwo = true;
                    } else if ((readkey != "t") & (readkey != "f")) { Console.WriteLine("Incorrect input! Press Enter to quit. "); break; }

                    Console.WriteLine("BoolOne   " + "BoolTwo   " + "AND       " + "OR         " + "XOR     " + "NOT BoolOne     " + "NOT BoolTwo");

                    if ((BoolOne) & (BoolTwo))
                    {
                        Console.WriteLine("true      " + "true      " + "true      " + "true     " + "false       " + "false          " + "false");
                    
                }
                    else if ((BoolOne) & (!(BoolTwo)))
                    {
                        Console.WriteLine("true      " + "false     " + "false     " + "true       " + "true        " + "false          " + "true");
                   
                }
                    else if ((!(BoolOne)) & (!(BoolTwo)))
                    {
                        Console.WriteLine("false     " + "false     " + "false     " + "false    " + "false       " + "true           " + "true");
                    
                }
                    else if ((!(BoolOne)) & (BoolTwo))
                    {
                        Console.WriteLine("false     " + "true      " + "false     " + "true     " + "true        " + "true           " + "false");
                   
                }
                   
                   
                
                Console.WriteLine(" ");
                Console.WriteLine("Do you want to quit? y - yes, n - no");
                quit = Console.ReadLine();
                if ((quit != "n") & (quit != "y") ){ Console.WriteLine("Incorrect input! Press Enter to quit. "); break; }
                Console.WriteLine(" ");
            }
            //{ Console.WriteLine("BoolOne   " + "BoolTwo   " + "AND       " + "OR         " + "XOR     " + "NOT BoolOne     " + "NOT BoolTwo");
            //    Console.WriteLine("true      " + "true      " + "true      " + "true     " + "false       " + "false          " + "false");

            //    Console.WriteLine("false     " + "false     " + "false     " + "false    " + "false       " + "true           "+ "true");

            //    Console.WriteLine("true      " + "false     " + "false     " + "true     " + "true        " + "false          "+ "true");

            //    Console.WriteLine("false     " + "true      " + "false     " + "true     " + "true        " + "true           "+ "false");
            //}


            Console.WriteLine("Press any key to quit.");
            Console.ReadKey();
             }
        
        

    }
    }
