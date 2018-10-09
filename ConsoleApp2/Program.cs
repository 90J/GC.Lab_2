using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        
        static void Main(string[] args)
        {
        
            //Variables
            double area;
            double width;
            double length;
            double height;
            double perimeter;
            double volume;
            string widthInput;
            string lengthInput;
            string heightInput;
            string check;

            //Check
            while (true)
            {
                // Get measurements
                Console.WriteLine("Welome to Grand Circus Room Detail Generator");
                Console.Write("Enter Length: ");
                lengthInput = Console.ReadLine();

                Console.Write("Enter width: ");
                widthInput = Console.ReadLine();

                Console.Write("Enter height: ");
                heightInput = Console.ReadLine();

                width = double.Parse(widthInput);
                height = double.Parse(heightInput);
                length = double.Parse(lengthInput);

                // Calculate
                area = (length * width);
                perimeter = ((length * 2) + (width * 2));
                volume = (length * width * height);


                //print
                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter: " + perimeter);
                Console.WriteLine("Volume : " + volume);
                Console.ReadLine();

                //Check
                Console.WriteLine("Continue y/n: ");
                check = Console.ReadLine();
                if (check != "y")
                {
                    break;
                }
                else
                {
                    Console.Clear();
                }
                
           
            }
            


           
        }
    }
}
