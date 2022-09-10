void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i += 1)
    {
        Console.Write($"Введите {i+1} элемент:");
        array[i] = double.Parse(Console.ReadLine() ?? "0");
    }
}
void DifferFind(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i += 1)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    Console.WriteLine(max-min);
}


Console.WriteLine("Введите длинну массива");
int length = int.Parse(Console.ReadLine() ?? "0");
double[] array = new double[length];
FillArray(array);
DifferFind(array);