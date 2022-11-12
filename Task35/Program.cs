// Задайте одномерный массив из 123 случайных чисел.
//  Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

int[] myArray = CreateRandomArray(123, -100, 100);
void ShowArray(int[] array)
{
    int count = 1;
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write(myArray[i] + "");
        if (myArray[i] > 10 && myArray[i] < 100)
        {
            count++;
        }

    }
    Console.WriteLine();
    Console.WriteLine($"Количество элементов массива {count} от 10 до 99 ");
}
ShowArray(myArray);