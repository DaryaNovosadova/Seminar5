//Задача 33: Задайте массив. Напишите программу, которая 
//определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

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

Console.WriteLine();
string text = "";

foreach (int el in array)
{
    if (el == num)
    {
        text = $"Число {num} присутствует в массиве";
        break;
    }
    else
    {
        text = $"Число {num} не присутствует в массиве";
    }

}

Console.WriteLine(text);
