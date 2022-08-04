int sum = 0;

Console.WriteLine("Enter x:");
string? strnum = Console.ReadLine();
bool isTrue = int.TryParse(strnum, out int x);
Console.WriteLine("Enter y: ");
string? strnum1 = Console.ReadLine();
bool isTrue1 = int.TryParse(strnum1, out int y);

if (isTrue == true && isTrue1 == true)
{
    for (int i = x; i < y + 1; i++)
    {
        sum += i;

    }
    Console.WriteLine($"Summary of your input is {sum}");
    
}

else
{
    Console.WriteLine("Invalid input!");
}


