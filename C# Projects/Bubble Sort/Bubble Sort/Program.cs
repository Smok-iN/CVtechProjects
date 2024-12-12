// See https://aka.ms/new-console-template for more information
using System.Numerics;
//Initialize SortAmount
int SortAmount;
int Num;
//Prompt user for amount of numbers sorted
Console.WriteLine("How many numbers do you want to sort?");
if (Int32.TryParse(Console.ReadLine(), out SortAmount))
{
    Console.WriteLine("Sorting " + SortAmount + " numbers");
}
else
{
    Console.WriteLine("Please enter a smaller number or an integer");
}
//Initialize Unsorted Array and InputNumber
int[] UnsortedArray = new int[SortAmount];
int InputNumber;
//Loop for SortAmount number of times
for (int i = 0; i < SortAmount; i++)
{
    Console.WriteLine("Please enter number " + (i+1));
//Sets the value of the UnsortedArray
    if (Int32.TryParse(Console.ReadLine(), out InputNumber))
    {
        UnsortedArray[i] = InputNumber;
    }
//Catches any Formatting errors
    else 
    {
        Console.WriteLine("Please enter a smaller number or an integer");
        continue;
    }
}
//Prints the UnsortedArray values
Console.WriteLine("Unsorted array");
for (int i = 0;  i < UnsortedArray.Length; i++)
{
    Console.WriteLine(UnsortedArray[i]);
}
//Initialize Sorted Array and copy values from UnsortedArray
int[] SortedArray = new int[SortAmount];
UnsortedArray.CopyTo(SortedArray, 0);
Console.WriteLine("Ascending(asc) or Decending(desc)");
string check = Console.ReadLine();
if (check == "asc")
{
//Sorting algorithm ascending
    for (int i = 0; i < SortedArray.Length; i++)
    {
        for (int j = i + 1; j < SortedArray.Length; j++)
        {
            if (SortedArray[i] > SortedArray[j])
            {
                Num = SortedArray[i];

                SortedArray[i] = SortedArray[j];

                SortedArray[j] = Num;
            }
        }
    }
}
else if (check == "desc")
{
//Sorting algorithm descending 
    for (int write = 0; write < SortedArray.Length; write++)
    {
        for (int sort = SortedArray.Length - 1; sort > 0; sort--)
        {
            if (SortedArray[sort] > SortedArray[sort - 1])
            {
                Num = SortedArray[sort - 1];
                SortedArray[sort - 1] = SortedArray[sort];
                SortedArray[sort] = Num;
            }
        }
    }
}
else
{
    Console.WriteLine("Please enter either asc or desc");

}
//Printing SortedArray values
Console.WriteLine("Sorted array");
for (int i = 0; i < SortedArray.Length; i++)
{
    Console.WriteLine(SortedArray[i]);
}







