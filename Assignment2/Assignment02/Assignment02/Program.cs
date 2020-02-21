using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Program
    {
        static string[] menu = { "Enter triangle dimensions",
                              "Exit" };
        static void Main(string[] args)
        {
            do {
                //show the menu and get the user input
                int input = GetUserInput();
                if (input == menu.Length)
                {
                    Environment.Exit(0);
                }
                else
                {
                    //get the dimensions of the triangle
                    int[] dimensions = GetDimensions();
                    string result = TriangleSolver.Analyze(dimensions[0], dimensions[1], dimensions[2]);
                    Console.Write("\n\n" + result);
                }
            } while (true);
        }

        private static int[] GetDimensions()
        {
            Console.Write("\n\n=====Give dimensions of a triangle=====");
            int sideA = GetTriangleSide('A');
            int sideB = GetTriangleSide('B');
            int sideC = GetTriangleSide('C');
            //return the dimensions of the triangle
            return new int[] { sideA, sideB, sideC };
        }

        static int GetUserInput()
        {
            int input;
            do
            {
                try
                {
                    Console.WriteLine("\n\n========Menu========");
                    //show menu to the user
                    ShowMenu(menu);
                    Console.Write("\n\nChoose a valid option (1-2) : ");
                    input = Int32.Parse(Console.ReadLine());
                    //check input is within range
                    if(input < 1 || input > menu.Length)
                    {
                        throw new Exception();
                    }
                    //break when correct input is taken from the user
                    break;
                }
                catch(Exception exception)
                {
                    Console.Write("\n\n"+ exception.Message);
                }
            }
            while (true); //loop until correct input is taken
            return input;
        }
        //show menu to the user
        static void ShowMenu(string[] menuOptions) 
        {
            for (int i = 0;i < menuOptions.Length;i++)
            {
                Console.Write("\n" + (i+1) + ". " + menuOptions[i]);
            }
        }

        static int GetTriangleSide(char sideChar)
        {
            int sideDimension;
            do
            {
                try
                {
                    //get triangle dimension
                    Console.Write("\n\nSide {0}: ", sideChar);
                    sideDimension = Int32.Parse(Console.ReadLine());
                    break; //break when input is invalid
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Please enter correct value");
                }
            }
            while (true);
            return sideDimension;
        }
        
    }
}
