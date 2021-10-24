using System;
abstract class Shape
{               
    public abstract double CalculateArea();
       
}

    class Square : Shape
    {
        private double side1;
        private double side2;
        public Square() { }
        public Square(double side1, int side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public override double CalculateArea()
        {
            int area = this.side1 * this.side2;
            return area;                      
        }
    }
   
class App
{
     static void Main()
    {
        char figure;
        char state = 'y';
        Console.WriteLine("Hello, I can calculate the Area of several geometric figures");
        while (state == 'y')
        {
            Console.WriteLine("What figure do you wish to calculate. C=cercle , T=triangle, R=rectangle");
            figure = Convert.ToChar(Console.ReadLine());
            //We must select the right constructor according the figure selected
            
            //circle

            //rectangle
            
            //triangle
            Console.WriteLine("Do you wish to continue calculating? y/n");
            state = Convert.ToChar(Console.ReadLine());
        }
    }
}