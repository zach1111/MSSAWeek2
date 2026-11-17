/*
2.3.2. 2. 
Design a tip calculator : enter the bill total, tip % and display grand total after adding tip.
Use the format specifiers to display currency, % symbol.
*/

while (true)
{

    Console.Write("Enter bill (or \"e\" to exit): ");
    string initialInput = Console.ReadLine().ToLower();

    if (initialInput == "e")
    {
        return;
    }

    double billAmount = double.Parse(initialInput);
    Console.Write("Enter tip %: ");
    double tipPercent = double.Parse(Console.ReadLine()) / 100;
    double tipAmount = tipPercent * billAmount;
    double grandTotal = tipAmount + billAmount;
    Console.WriteLine($"\n\nBill: {billAmount:C2}\nTip percent: {tipPercent:P0}\nTip amount: {tipAmount:C2}\nGrand total: {grandTotal:C2} ");


}