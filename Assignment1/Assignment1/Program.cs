using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //get user input of length and width
            int[] attributes = GetRectangleAttributes();

            /*create an instance of the rectangle with the attributes provided by the user
             * attributes[0] = length
             * attributes[1] = width
            */
            Rectangle rectangle = new Rectangle(attributes[0],attributes[1]);

            //Call method to run menu section
            Menu(rectangle);

            Console.ReadKey();

        }

        private static int[] GetRectangleAttributes()
        {
            int length = 0;
            int width = 0;

            //get length of the rectangle
            length = GetLengthFromUser();

            //get the width of the rectangle
            width = GetWidthFromUser();

            return new int[] {length,width};
        }

        private static int GetWidthFromUser()
        {
            int width = 0;

            do
            {
                try
                {
                    //get the width of the rectangle
                    Console.Write("\nEnter the width of the rectangle :");
                    width = Int32.Parse(Console.ReadLine());

                    //check if the user has entered 0 
                    if (width <= 0)
                    {
                        throw new Exception();
                    }
                    break;
                }
                catch (Exception e)   //something unexpected happened
                {
                    Console.Write("\nPlease enter a positive integer value greater than 0 less than  2,147,483,648\n\n");
                }
            } while (true);

            return width;
        }

        private static int GetLengthFromUser()
        {
            int length = 0;

            do
            {
                try
                {
                    //get the length of the rectangle
                    Console.Write("\nEnter the length of the rectangle :");
                    length = Int32.Parse(Console.ReadLine());

                    //check if the user has entered 0 
                    if (length <= 0)
                    {
                        throw new Exception();
                    }

                    break;
                }
                catch (Exception e)             //something unexpected happened
                {
                    Console.Write("\nPlease enter a positive integer value greater than 0 less than  2,147,483,648\n\n");
                }
            } while (true);

            return length;
        }

        public static void Menu(Rectangle rectangle)
        {
            int choice = 0;

            string[] options = {
                                "Get Rectangle Length",
                                "Change Rectangle Length",
                                "Get Rectangle Width",
                                "Change Rectangle Width",
                                "Get Rectangle Perimeter",
                                "Get Rectangle Area",
                                "Exit"
                                };
            while(true)
            {
                ShowMenu(options);
                try
                {
                    Console.Write("\n\nEnter a valid choice - ");

                    //get the user input
                    choice = Int32.Parse(Console.ReadLine());

                    //check if user has entered a valid input
                    if (choice <= 0 && choice > options.Length)
                    {
                        throw new Exception();
                    }

                    //show output according to user input
                    ShowOutput(rectangle,choice);
                }
                catch(Exception e)
                {
                    Console.Write("\n\nPlease enter a valid choice!");
                }
            }
        }

        private static void ShowOutput(Rectangle rectangle, int choice)
        {
            //give output according to the input provided
            switch (choice)
            {
                case 1: Console.Write("\n\nLength of Rectangle : " + rectangle.GetLength());
                        break;
                case 2: int length = rectangle.SetLength(GetLengthFromUser());
                        Console.Write("\n\nRectangle's length set to : " + length);
                        break;
                case 3: Console.Write("\n\nWidth of Rectangle : " + rectangle.GetWidth());
                        break;
                case 4: int width = rectangle.SetWidth(GetWidthFromUser());
                        Console.Write("\n\nRectangle's width set to : " + width);
                        break;
                case 5: Console.Write("\n\nPerimeter of the rectangle : " + rectangle.GetPerimeter());
                        break;
                case 6: Console.Write("\n\nArea of the rectangle " + rectangle.GetArea());
                        break;
                case 7: Environment.Exit(0);
                        break;
            }
        }

        private static void ShowMenu(string[] options)
        {
            Console.Write("\n\n Menu: \n");

            //show the menu to the user
            for (int i =0;i<options.Length;i++)
            {
                Console.WriteLine(i+1 + "." + options[i]);
            }
        }
    }
}
