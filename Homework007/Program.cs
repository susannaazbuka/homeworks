// Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
void Zadacha47()
{
    Random random = new Random();
    int m = random.Next(3, 9);
    int n = random.Next(3, 9);
    double [,] array = new double[m, n];
    Console.WriteLine($"Размер массива {m}x{n}.");
    FillArray(array);
    PrintArray(array);

}

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
void Zadacha50()
{
    Random random = new Random();  //создание переменной random, которая определяет размер массива
    int m = random.Next(3, 5);     //rows
    int n = random.Next(3, 5);     //columns
    double[,] array = new double[m, n];   //задаем тип данных массива
    FillArray(array);
    PrintArray(array);
    Console.WriteLine("Введите позицию элемента по строкам:");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите позицию элемента по столбцам:");
    int j = Convert.ToInt32(Console.ReadLine());
    if (i < m && j < n)
    {
        Console.WriteLine($"Искомый элемент равен {array[i, j]}.");
    }
    else
    {
        Console.WriteLine($"Искомого элемента не существует.");
    }
}

//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
void Zadacha52()
{
    Random random = new Random();  //создание переменной random, которая определяет размер массива
    int m = random.Next(3, 5);     //rows
    int n = random.Next(3, 5);     //columns
    int[,] array = new int[m, n];   //задаем тип данных массива
    Console.WriteLine($"Размер массива {m}x{n}.");
    FillArray1(array);
    PrintArray1(array);
    Console.WriteLine("Среднее арифметическое в каждом столце: ");
    for (int j = 0; j < array.GetLength(1); j++)     //перебираем массив по столбцам
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        Console.Write(Math.Round(sum/array.GetLength(0), 1) + "\t");
    }
}

void FillArray(double[,] array, int startNumber = 0, int finishNumber = 10)
{
    finishNumber++;
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math. Round(rand.NextDouble() * 10 - 5, 2);  //заполнение числами от -5 до 5
        }
    }
}

void PrintArray(double[,] array)
{
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");  //выводим с символом табуляции для красивого массива
        }
        Console.WriteLine();
    }
}

void FillArray1(int[,] array, int startNumber = 0, int finishNumber = 9)
{
    finishNumber++;
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)  //цикл для перебора массива
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rand.Next(startNumber,finishNumber); //вызываем случайное заполнение для элемента i,j
        }
    }
}

void PrintArray1(int[,] array)
{
    Console.WriteLine("Вывод массива: ");
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)  //цикл для перебора массива
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");  //выводим с символом табуляции для красивого массива
        }
        Console.WriteLine();
    }   
}


//Zadacha47();
//Zadacha50();
//Zadacha52();