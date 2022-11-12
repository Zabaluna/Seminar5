// Задайте массив. Напишите программу, которая определяет,
//  присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] myArray = CreateRandomArray(10, -100, 100);
ShowArray(myArray);
{
Console.WriteLine("Введите число, которое хотите проверить в массиве");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] == num)
    {
        Console.WriteLine($"Число {num} есть в массиве");
        return;
    }
}
 Console.WriteLine($"Числа {num} нет в массиве");
}
// ShowArray(myArray);