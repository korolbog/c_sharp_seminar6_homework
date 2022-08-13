/*

Задача 41:
Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.

*/
int sum = 0;
int m = new Random().Next(4,6);
int size = m;
int[] array = new int[m];
Console.WriteLine($"Введите следующее количество чисел: {m}");
for (int i = 0; i < size; i++)
{
    Console.Write($"Введите число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > 0)
    {
        sum += array[i];
    }
}
Console.WriteLine($"Сумма положительных чисел = {sum}");
