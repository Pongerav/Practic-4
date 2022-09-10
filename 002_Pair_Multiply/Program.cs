void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(1, 11);
}
void PrintArray( int[] array)
{
    for (int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");
}
void MultiplyFinder(int[] array)
{
    for (int i = 0; i < array.Length/2; i += 1)
    {
        Console.WriteLine($"\n {array[i]} * {array[array.Length - 1 - i]} = {array[i] * array[array.Length - 1 - i]}");
    }
}
Console.WriteLine("Введите длину массива");
int length = int.Parse(Console.ReadLine() ?? "0");

int[] massiv = new int[length];
FillArray(massiv);
PrintArray(massiv);
MultiplyFinder(massiv);