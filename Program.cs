using System;

namespace HomeWork
{
   class Rectangle
   {
       double side1, side2;
       public Rectangle(double side1, double side2)
       {
           this.side1=side1;
           this.side2=side2;

       }
       double AreaCalculator()
       {
           return side1*side2;
       }
       double PerimeterCalculator()
       {
           return (side1+side2)*2;
       }
      
    class Program
    {
       
        static void Main(string[] args)
        {
            //Exercise_2
            Console.WriteLine("Exercise_2");
                        Console.Write("a=");
            double a=Convert.ToDouble(Console.ReadLine());
                        Console.Write("b=");
            double b=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Rectangle rectangle=new Rectangle(a,b);
            Console.WriteLine("Area="+rectangle.Area);
            Console.WriteLine("Perimeter="+rectangle.Perimeter);
            Console.ReadKey();

        }

    }
}
