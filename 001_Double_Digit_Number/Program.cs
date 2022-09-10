void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(1, 1001);
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i += 1)
    {
        if  ((array[i] >= 10 ) && (array[i] <= 99)) Console.ForegroundColor = ConsoleColor.Green;
        else Console.ResetColor();
        Console.Write(array[i] + " ");
    } 
    
}

int FindDoubleDigitCount(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i+= 1)
    {
        if ((array[i] >= 10 ) && (array[i] <= 99)) result += 1;
    }
    return result;
}

int[] massiv = new int[123];

FillArray(massiv);
PrintArray(massiv);
Console.WriteLine($"\n{FindDoubleDigitCount(massiv)}");
