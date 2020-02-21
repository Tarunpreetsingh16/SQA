using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            //show the menu and get the user input
            int input = GetUserInput();
            Console.ReadKey();
        }

        static int GetUserInput()
        {
            int input;
            string[] menu = { "Enter triangle dimensions",
                              "Exit" };
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
        
    }
}
