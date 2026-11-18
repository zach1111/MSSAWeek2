/*
3. Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
Test Data :
Input the value for X coordinate :7                                                  2  1
Input the value for Y coordinate :9                                                  3  4       <- quadrants
Expected Output :
The coordinate point (7,9) lies in the First quadrant.
*/

double xCoord;
double yCoord;

Console.Write("Enter the value for the X coordinate: ");
double.TryParse(Console.ReadLine(), out xCoord);

Console.Write("Enter the value for the Y coordinate: ");
double.TryParse(Console.ReadLine(), out yCoord);

Console.WriteLine($"The coordinate point ({xCoord},{yCoord}) lies in the {determineQuad(xCoord, yCoord)} quadrant.");






string determineQuad(double XCoord, double YCoord)
{
    switch (XCoord, YCoord)
    {
        case ( >= 0, >= 0 ):
            return "1st";

        case ( < 0 , >= 0 ):
            return "2nd";

        case ( < 0 , < 0 ):
            return "3rd";

        case ( >= 0 , < 0 ):
            return "4th";
    }
    return "invalid";

}
