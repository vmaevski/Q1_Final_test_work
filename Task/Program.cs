Console.WriteLine("Enter number of rows:");
int length = int.Parse(Console.ReadLine());
string[] inputArray = new string[length];
for (int i = 0; i < length; i++)
{
    Console.WriteLine("Enter the string:");
    inputArray[i] = Console.ReadLine();
}

for (int i = 0; i < length; i++)
{   
    Console.WriteLine(inputArray[i]);
}