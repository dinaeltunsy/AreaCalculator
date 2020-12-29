using System;
using System.Collections.Generic;


namespace ConsoleApp1
{
    class Program
    {

 

        public static void Main(string[] args)
        {

            String S_Search;

            List<Shape> Shapes = new List<Shape>();

            Shapes.Add(new Shape());
            Shapes[0].Shape_name = "Triangle";
            Shapes[0].a_Side = 4;
            Shapes[0].b_Height = 3;
            Shapes[0].Shape_D = "2D";

            Shapes.Add(new Shape());
            Shapes[1].Shape_name = "Square";
            Shapes[1].a_Side = 5;
            Shapes[1].Shape_D = "2D";

            Shapes.Add(new Shape());
            Shapes[2].Shape_name = "Cube";
            Shapes[2].a_Side = 3;
            Shapes[2].Shape_D = "3D";

            Console.WriteLine("Please Enter whether you want '2D' or '3D' shape: ");
            S_Search = Console.ReadLine();

            for (int iCount = 0; iCount < Shapes.Count; iCount++)
            {
                if (Shapes[iCount].Shape_D.Equals(S_Search))
                {
                    Console.WriteLine(Shapes[iCount].getData());


                }
;
            }
            Console.ReadLine();
            Console.WriteLine("Please choose the required shape from the list results:");
            string shapea = Console.ReadLine();

            if (shapea == "Square")
            {
                int Sqr_area = Shapes[1].a_Side * Shapes[1].a_Side;
                Console.WriteLine("Area of " + Shapes[1].Shape_name + ":" + Sqr_area + "(Side * Side)");
            }
            else if (shapea == "Triangle")
            {
                int Multi = Shapes[0].a_Side * Shapes[0].b_Height;
                int Tr_area = Multi / 2;
                Console.WriteLine("Area of " + Shapes[0].Shape_name + ":" + Tr_area + "((Side * Height)/2)");
            }
            else if (shapea == "Cube")
            {
                int Cb_area = Shapes[2].a_Side * Shapes[2].a_Side * Shapes[2].a_Side;
                Console.WriteLine("Area of " + Shapes[2].Shape_name + ":" + Cb_area + "(Side * Side * Side)");
            }
            else
            {
                Console.WriteLine("Results Not Found");
            }
            Console.ReadLine();
       





        }




        
    }
}
