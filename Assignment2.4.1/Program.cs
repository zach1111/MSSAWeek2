/*
2.4.1
Write a program in C# Sharp to find the sum of all array elements.
Test Data :
Input the number of elements to be stored in the array :3
Input 3 elements in the array :
element - 0 : 2
element - 1 : 5
element - 2 : 8
Expected Output :
Sum of all elements stored in the array is : 15
*/




int userNumElements = 0; //declare outside of while loop to fix scoping issue

while (true)
{
    Console.Write("Input the number of elements to be stored in the array : ");
    if (!int.TryParse(Console.ReadLine(), out userNumElements)) 
    {
        Console.WriteLine("Incorrect entry, try again...\n");
        continue;
    }
    else
    {
        break; //valid input get out of loop
    }
}


int[] myArray = new int[userNumElements]; 
int sum = 0;
for ( int i = 0 ; i <  myArray.Length ; i++ )
{
    Console.Write($"Element - {i} : ");

    if (!int.TryParse(Console.ReadLine(), out int elementValue)) //invalid input -> decrement i and continue to next loop iteration so user can try again
    {
        Console.WriteLine("Invalid entry - try again!\n");
        i--;
        continue;
    }
    else //valid input
    {
        myArray[i] = elementValue;
        sum += elementValue;
    }
}
Console.WriteLine($"Sum of all values is: {sum}");
