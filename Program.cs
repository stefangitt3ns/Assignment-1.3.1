using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Assignment_1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Area Calculator";

            Console.WriteLine("The Formula for the area of a triangle is half the length of the base times the height \n\nArea = 0.5 * base * height ");
            Console.WriteLine();

            Console.WriteLine("The Formula for the area of a Rectangle and Square is length times width \n\n Area = length * width");
            Console.WriteLine(); 
            
            Console.WriteLine("Please select the shape you are working with. Press the corresponding number 1 => Triangles  2. => Rectangles  3. => Squares");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();


            Console.WriteLine("Refer to the formulas given above and enter the necessary information. If you are not working with a triangle enter \"0\" for the base. \n First enter the Length... \n Now enter the height... \n Now enter the Base of the triangle.. "); 
            double length = Convert.ToDouble(Console.ReadLine());
            double height = Convert.ToDouble(Console.ReadLine());
            double triangleBase = Convert.ToDouble(Console.ReadLine()); 

            switch (choice)
            {
                case 1:
           
                    Console.WriteLine(areaOfTriangles( triangleBase,  height));
                    break;

                case 2:
                case 3:
                    Console.WriteLine(areaOfSquares(length, height)); 
                break;
                    

            }
            Console.Read(); 
            

     
        }

        static double areaOfTriangles(double triangleBase, double height)
        {

            double answer = (triangleBase / 2) * height;
            return answer;

        }

        static double areaOfSquares(double length, double height)
        {

            double answer = length * height;
            return answer;

        }













    }


       
}
