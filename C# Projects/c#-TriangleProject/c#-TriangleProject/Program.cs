using System;

Console.WriteLine("Enter a number.");
int integer = Convert.ToInt32(Console.ReadLine());
string Output = "";
for (int i = integer; i > 0; i--)
{
    Console.WriteLine(new String('*', i));
}
for (int i = 0; i < integer; i++)
{
    Output = "";

    for (i = 0; i < integer; i++)
    {
        Output += "*";
        Console.WriteLine(Output);
    }

}