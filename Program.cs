// Заполнение и вывод массива рандомными числами от (min до max)
void Mas(int[] array, int min, int max)
{
    max = max + 1;
    Random rnd = new Random();
    Console.Write("Массив: [ ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(" ];");
}
// Заполнение и вывод массива рандомными вещественными числами от (min до max)
void Masdouble(double[] array)
{
    Random rnd = new Random();
    Console.Write("Массив: [ ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble();
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(" ];");
}
// Вывод количества четных чисел в массиве
void Kolchet(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            sum = sum + 1;
        }
    }
    Console.WriteLine($"В данном массиве находится {sum} четное(четных) число(числа)");
}
// Нахождение суммы элементов с нечетными индексами
void Nechetindex(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    Console.WriteLine($"Сумма элементов массива с нечетными индексами равна: {sum}");
}
// Нахождение разности между максимальным и минимальным элементами массива
void Razmaxmin(double[] array)
{
    int i = 0;
    double min = array[i];
    double max = array[i];
    for (int k = 0; k < (array.Length - 1); k++)
    {
        if (array[k + 1] < min)
        {
            min = array[k + 1];
        }
        if (array[k + 1] > max)
        {
            max = array[k + 1];
        }
    }
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {max - min}");
}


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
void Task34()
{
    int min = 100;
    int max = 1000;
    int size = 4;
    int[] array = new int[size];
    Mas(array, min, max);
    Kolchet(array);
}

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.
void Task36()
{
    int min = -99;
    int max = 99;
    int size = 4;
    int[] array = new int[size];
    Mas(array, min, max);
    Nechetindex(array);
}

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
//[3,21 7,04 22,93 -2,71 78,24] -> 80,95
void Task38()
{
    int size = 5;
    double[] array = new double[size];
    Masdouble(array);
    Razmaxmin(array);
}

// Для выбора программы:
Console.WriteLine("Выберите программу:");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 34)
{
    Task34();
}
else if (number == 36)
{
    Task36();
}
else if (number == 38)
{
    Task38();
}
else
{
    Console.WriteLine("Ошибка (такой программы не существует)");
}
