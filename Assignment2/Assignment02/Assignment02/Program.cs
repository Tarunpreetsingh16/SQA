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
            string[] menu = { "Enter triangle dimensions",
                              "Exit" };
            ShowMenu(menu);
        }

        //show menu to the user
        static void ShowMenu(string[] menuOptions) 
        {
            for (int i = 0;i < menuOptions.Length;i++)
            {
                Console.Write("\n" + i+1 + ". " + menuOptions[i]);
            }
        }
    }
}
