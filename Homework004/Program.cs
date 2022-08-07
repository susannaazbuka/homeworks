//Задача 25: Используя определение степени числа, напишите цикл, 
//который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
void Zadacha25()
{
    Console.WriteLine("Введите число и степень числа:");
    int number = Convert.ToInt32(Console.ReadLine());
    int stepen = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Math.Pow(number, stepen));
}

//Задача 27: Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.
void Zadacha27()
{
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    SumOfDigits(number);
}


//Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел 
//и выводит отсортированный по модулю массив.
void Zadacha29()
{
    int size = 8;
    int[] array = new int[size];

    FillArray(array);    
    PrintArray(array);
    Sort(array);
    PrintArray(array);
    
}

void FillArray(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-9,10);
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

void Sort(int[] array)
{
    for (int i = array.Length - 1; i > 0; i--) 
    {
        for (int k = 0; k < i; k++)
        {
            if (Math.Abs(array[k]) > Math.Abs(array[k+1]))    
            {
                int temp = array[k];
                array[k] = array[k+1];
                array[k+1] = temp;
            }
        }
    }
}

void SumOfDigits(int num)
{
    int sum = 0;
    Console.Write("Сумма цифр числа " + num);
    while (num > 0)
    {
        sum += num%10;
        num /= 10;
    }
    Console.WriteLine(" равна " + sum + ".");
}

//Zadacha25();
//Zadacha27();
//Zadacha29();