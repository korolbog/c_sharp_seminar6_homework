/*

Задача 41:
Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/
int counter = 0;
int m = new Random().Next(5,6);
int size = m;
int[] array = new int[m];
Console.WriteLine($"Введите следующее количество чисел: {m}");
for (int i = 0; i < size; i++)
{
    Console.Write($"Введите число {i+1}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > 0)
    {
        counter++;
    }
}
Console.WriteLine($"Количество положительных чисел: {counter}");
