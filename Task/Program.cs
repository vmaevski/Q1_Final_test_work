void PrintArray(string[] array)
{
    Console.Write("[");
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (i < length - 1)
        {
            Console.Write($"{array[i]}, ");
        }    
        else 
        {
            Console.Write($"{array[i]}]");
        }
    }
}

Console.WriteLine("Enter number of rows:");
int length = int.Parse(Console.ReadLine());
string[] inputArray = new string[length];
for (int i = 0; i < length; i++)
{
    Console.WriteLine("Enter the string:");
    inputArray[i] = Console.ReadLine();
}

PrintArray(inputArray);
Console.Write(" -> ");
PrintArray(inputArray);
