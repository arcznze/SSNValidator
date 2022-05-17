string input;
string[] x = new string[3];
string[] y = new string[2];
string[] z = new string[4];

Console.WriteLine("Enter a string: ");
input = Console.ReadLine();

string[] hyphen = input.Split("-");

if (hyphen[0].Length == 3 && hyphen[1].Length == 2 && hyphen[2].Length == 4)
{
    GetDigits();
}
else
    Console.WriteLine("Invalid.");
void GetDigits()
{
    for (int i = 0; i < 3; i++)
    {
        x[i] = input.Substring(i, 1);
    }
    for (int i = 0; i < 2; i++)
    {
        y[i] = input.Substring(i, 1);
    }
    for (int i = 0; i < 4; i++)
    {
        z[i] = input.Substring(i, 1);
    }
    Valid();
}
void Valid()
{
    if (int.Parse(x[0]) == 0 && int.Parse(x[1]) == 0 && int.Parse(x[2]) == 0 || int.Parse(x[0]) == 6 && int.Parse(x[1]) == 6 && int.Parse(x[2]) == 6 || int.Parse(hyphen[0]) >= 900)
        Console.WriteLine("Invalid.");
    else
        Console.WriteLine("Valid.");
}
