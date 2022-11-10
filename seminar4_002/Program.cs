//Задача 32: Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, 
//и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2] 
//
//Задача 33: Задайте массив. Напишите программу, которая определяет, 
//присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да

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
int[] array = GetArray(12, -9, 9);

//Console.WriteLine();
//
//foreach (int el in array)
//{
//    Console.Write($"{el*-1} ");
//}
Console.WriteLine();
for(int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * -1;
    Console.Write($"{array[i]} ");
}