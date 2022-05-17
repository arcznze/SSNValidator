string input;
Console.WriteLine("Enter a string: ");
input = Console.ReadLine();

string[] hyphen = input.Split("-");

if (hyphen[0].Length == 3 && hyphen[1].Length == 2 && hyphen[2].Length == 4)
{
    Console.WriteLine("Valid.");
}
else
    Console.WriteLine("Invalid.");
