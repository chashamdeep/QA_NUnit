using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8170_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int length, width, choice;
            String lengthEntered, widthEntered;
            try
            {
                //get length
                SetLengthFromUser();
                //get Width
                SetWidthFromUser();

                //Rectangle Object
                Rectangle rObj = new Rectangle(length, width);
                do
                {
                    //Menu
                    Console.Write("\n___________________________________________\n");
                    Console.Write("Welcome to rectangle calculations!");
                    Console.Write("\n 1. Get Length of Rectangle");
                    Console.Write("\n 2. Change Length");
                    Console.Write("\n 3. Get Width of Rectangle");
                    Console.Write("\n 4. Change Width");
                    Console.Write("\n 5. Get Rectangle Perimeter");
                    Console.Write("\n 6. Get Rectangle Area");
                    Console.Write("\n 7. Exit");
                    Console.Write("\n___________________________________________\n");
                    Console.Write("\n Enter Your Choice from 1 to 7 : ");
                    choice = int.Parse(Console.ReadLine());


                    //Switch to control menu options
                    int result;
                    switch (choice)
                    {
                        case 1:
                            result = rObj.GetLength();
                            Console.Write("\n Length of Rectangle :" + result);
                            break;
                        case 2:

                            result = rObj.SetLength(length);
                            Console.Write("\n Length changed to :" + result);
                            break;
                        case 3:
                            result = rObj.GetWidth();
                            Console.Write("\n Width of Rectangle : " + result);
                            break;
                        case 4:
                            SetWidthFromUser();
                            result = rObj.SetWidth(width);
                            Console.Write("\n Width changed to :" + result);
                            break;
                        case 5:
                            result = rObj.GetPerimeter();
                            Console.Write("\n Perimeter of Rectangle : " + result);
                            break;
                        case 6:
                            result = rObj.GetArea();
                            Console.Write("\n Area of Rectangle : " + result);
                            break;
                        case 7:
                            Console.Write("\n Thank you! \n ");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("\n Invalid Choice");
                            break;
                    }
                }
                while (choice != 7);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //validator for width entered by User
            void SetWidthFromUser()
            {
                Console.WriteLine("\n Enter Width: ");
                do
                {
                    widthEntered = Console.ReadLine();
                    if (!int.TryParse(widthEntered, out width) || width < 1)
                    {
                        Console.WriteLine("Width can be only int and greater than 0");
                        Console.WriteLine("Enter Width again: ");
                    }
                }
                while (!int.TryParse(widthEntered, out width) || width < 1);
            }

            //validator for length entered by user
            void SetLengthFromUser()
            {
                Console.WriteLine("\n Enter Length: ");
                do
                {
                    lengthEntered = Console.ReadLine();
                    if (!int.TryParse(lengthEntered, out length) || length < 1)
                    {
                        Console.WriteLine("Invalid Length. Can only be an integer and gretaer than 0");
                        Console.WriteLine("Enter Length again: ");
                    }
                }
                while (!int.TryParse(lengthEntered, out length) || length < 1);
            }
        }
    }
}
