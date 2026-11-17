/*
2.3.1. 
Write a console application to create a text file and save your basic details like name, age, address ( use dummy data). 
Read the details from same file and print on console.
*/

//allows you to run program from different directory
string projectFolder = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..")); 
string filePath = Path.Combine(projectFolder, "newfile.txt");

string[] details = ["Name: Bob Alice", "Age: 25", "Address: 123 Main"];

using (StreamWriter myWriter = new(filePath))
{
    foreach (string dataLine in details)
    {
        myWriter.WriteLine(dataLine);        
    }
 
}

using (StreamReader myReader = new(filePath)) 
{
    string contents = myReader.ReadToEnd();
    Console.WriteLine(contents);
} // File is automatically closed here
