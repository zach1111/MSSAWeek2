/*
2. Write a C# Sharp program to find the largest of three numbers.
Test Data :
Input the 1st number :25
Input the 2nd number :63
Input the 3rd number :10
Expected Output :
The 2nd Number is the greatest among three
*/



int[] myArray = new int[3];
Dictionary<int, string> indexToOrdinal = new Dictionary<int,string> //translates actual indeces to 1st/2nd/3rd 
{
    { 0, "1st" },
    { 1, "2nd" },
    { 2, "3rd" }
};



for ( int i = 0 ; i < 3 ; i++ ) //user fills in array
{
    Console.Write($"Input the {indexToOrdinal[i]} number: ");

    if (int.TryParse(Console.ReadLine(), out int userEntry)) //valid integer entered
    {
        myArray[i] = userEntry;
    }
    else //invalid entry
    {
        i--;
        Console.WriteLine("Invalid entry, try again\n");   
    }

}

int biggestIndex = 0; //defaults to 0 index

for ( int i = 0 ; i < myArray.Length ; i++)
{
    if ( myArray[i] > myArray[biggestIndex] )
    {
        biggestIndex = i;
    }
}

Console.WriteLine($"The {indexToOrdinal[biggestIndex]} number is the largest: {myArray[biggestIndex]}");