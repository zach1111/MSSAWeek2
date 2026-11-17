/*
Write a abstract base class: ‘Shape’ and add properties like id, name and color and method ‘calculate area’ .
Inherit circle shape from base class and add properties like radius. override calculate area logic for circle.
Inherit square class from shape and change the calculate area logic. Add property like side of square.
Take the input from user to select circle or square and display the calculated area . no hard coded values!
*/


string selection;
while (true)
{    
    Console.Write("\nSelect \"s\"quare, \"c\"ircle, \"e\"xit: ");
    selection = Console.ReadLine();
    switch (selection.ToLower()) 
    {
        case "s": //square selected
            Square mySquare = new Square();
            Console.Write("Enter side length: ");
            mySquare.SideLength = Double.Parse(Console.ReadLine());
            Console.WriteLine($"Square area with side length {mySquare.SideLength} is {mySquare.CalculateArea()}");
            break; 

        case "c": //circle selected
            Circle myCircle = new Circle();
            Console.Write("Enter radius: ");
            myCircle.Radius = Double.Parse(Console.ReadLine());
            Console.WriteLine($"Circle area with radius {myCircle.Radius} is {myCircle.CalculateArea()}");
            break;
        
        case "e": //exit
            Console.WriteLine("Exiting...");
            return;

        default:
            Console.WriteLine("Error, incorrect selection. Try again");
            break;
    }
}


public abstract class Shape
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }

    public virtual double CalculateArea() //to be overridden
    {
        return 0.0;
    }

}


public class Circle : Shape
{
    public double Radius { get; set; }
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Square : Shape
{
    public double SideLength { get; set; }
    public override double CalculateArea()
    {
        return SideLength * SideLength;
    }
}




