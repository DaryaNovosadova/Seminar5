/*Задача 37: Найдите произведение пар чисел в 
одномерном массиве. Парой считаем первый и 
последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
}
int[] array = GetArray(6, 0, 9);
Console.WriteLine();

int[] arr = new int[array.Length / 2];

int size = array.Length - 1;
int ind = 0;

for (int i = 0; i < array.Length / 2; i++)
{
    arr[ind] = array[i] * array[size];
    Console.Write($"{arr[ind]} ");
    size--;
    ind++;
}