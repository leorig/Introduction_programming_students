using System;

char figure;
char state = 'y';
double Area; 
//Ask for type of figure while state is 'y'
Console.WriteLine("Hello, I can calculate the Area of several geometric figures");
while (state == 'y')
{
    Console.WriteLine("What figure do you wish to calculate. C=cercle , T=triangle, R=rectangle");
    figure = Convert.ToInt64(Console.ReadLine());

    //select the function according the figure selected
    
    Console.WriteLine("Do you wish to continue calculating? y/n");
    state = Convert.ToDouble(Console.ReadLine());
}


static double calculateTriangle()
{
    //Triangle Function
}


//rectangle function

//circle function

