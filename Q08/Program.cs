string yearText = "2023";
int year = int.Parse(yearText);
Console.WriteLine(year);

string badText = "abc";
int number;

if (int.TryParse(badText, out number))
{
    Console.WriteLine(number);
}
else
{
    Console.WriteLine("Invalid number");
}
