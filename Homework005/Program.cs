//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
void Zadacha34()
{
    Random rand = new Random();
    int size = rand.Next(3,6);;
    int[] array = new int[size];
    FillArray(array, 100, 999);
    PrintArray(array);
    
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
        
    }
    Console.WriteLine($"В массиве {count} четных чисел.");
}

//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
void Zadacha36()
{
    Random rand = new Random();
    int size = rand.Next(3,6);;
    int[] array = new int[size];
    FillArray(array, 0, 10);
    PrintArray(array);

    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        if (i % 2 == 1)
        {
            sum += array[i];
        }
        
    }
    Console.WriteLine($"Сумма элементов нечетных чисел в массиве равна {sum}.");
}

//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
void Zadacha38()
{
    Random rand = new Random();
    int size = rand.Next(3,6);;
    double[] array = new double[size];
    FillArrayD(array, 0, 10);
    PrintArrayD(array);
    
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < size; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min )
        {
            min  = array[i];
        }    
    }
    Console.WriteLine($"Разница между максимальным и минимальным элементов массива равна {max - min }.");

}

void FillArray(int[] array, int startNumber, int finishNumber)
{
    finishNumber++;
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(startNumber,finishNumber);
    }
}

void PrintArray(int[] array)
{
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void FillArrayD(double[] array, int startNumber, int finishNumber)
{
    finishNumber++;
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rand.NextDouble() * 10, 3);
    }
}

void PrintArrayD(double[] array)
{
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//Zadacha34();
//Zadacha36();
//Zadacha38();