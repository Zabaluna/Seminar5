//  Задача 38: Задайте массив чисел.
//   Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] CreateRandomArray(int N, double start, double end)
{
    double[] RandomArray = new double[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = Convert.ToDouble(new Random().Next(-100,1000)) / 100; 
    }  
    return RandomArray;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double[] myArray = CreateRandomArray(100, -100, 100);
ShowArray(myArray);

double MaxNumber = myArray[0];
double MinNumber = myArray[0];

for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] > MaxNumber)
    {
        MaxNumber = myArray[i];
    }
    else if (myArray[i] < MinNumber)
    {
        MinNumber = myArray[i];
    }
}
Console.WriteLine($"{MaxNumber} максимальное чиcло в массиве;");
Console.WriteLine($"{MinNumber} минимальное число в массиве");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива:{MaxNumber - MinNumber}");
