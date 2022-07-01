string[] CreateOutputArray(string[] inArr)
{
    int inLength = inArr.Length;
    int outLength = 0;
    int count = 0;
    for (int i = 0; i < inLength; i++)
    {
        if (inArr[i].Length <= 3) outLength++;
    }
    string[] outputArray = new string[outLength];
    for (int i = 0; i < inLength; i++)
    {
        if (inArr[i].Length <= 3)
        {
            outputArray[count] = inArr[i];
            count++;
        }

    }
    return outputArray;
}

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
            Console.Write($"{array[i]}");
        }
    }
    Console.Write("]");
}

Console.WriteLine("Enter number of rows:");
int length = int.Parse(Console.ReadLine());
string[] inputArray = new string[length];
for (int i = 0; i < length; i++)
{
    Console.WriteLine($"Enter the {i + 1}th string:");
    inputArray[i] = Console.ReadLine();
}

PrintArray(inputArray);
Console.Write(" -> ");
PrintArray(CreateOutputArray(inputArray));
