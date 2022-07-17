//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
void Zadacha10()
{
    Console.WriteLine("Введите трехзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 99 && number < 1000)
    {
        int result = number / 10 % 10;
        Console.WriteLine(result);
    }
    else
    {
        Console.WriteLine("Введено не трехзначное число. Попробуйте еще раз.");
    }
}

//Задача 13: Напишите программу, которая с помощью деления выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.
void Zadacha13()
{
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 99)
    {
        while (number > 999)
        {
            number /= 10;
        }
        int result = number % 10;
        Console.WriteLine(result);
     }
    else
    {
        Console.WriteLine("Третьей цифры нет.");
    }


}

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
void Zadacha15()
{
    Console.WriteLine("Введите цифру: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number <= 5)
    {
        Console.WriteLine("Будни. Работаем!");
     }
    else if (number > 5 && number <8)
    {
        Console.WriteLine("Ура, выходной!");
    }
    else
    {
        Console.WriteLine("Введена некорректная цифра.");
    }
}

//Zadacha10();
//Zadacha13();
//Zadacha15();


//Дополнительные задачи.
//Задача 1. Написать программу, которая определяет, является ли треугольник 
//со сторонами a, b, c равнобедренным.
void Zadacha1dop()
{
    Console.WriteLine("Сейчас мы проверим, является ли треугольник со сторонами a, b, c равнобедренным.");
    Console.WriteLine("Введите сторону a: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите сторону b: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите сторону c: ");
    int c = Convert.ToInt32(Console.ReadLine());
    if (a == c || a == b)
    {
        Console.WriteLine("Треугольник равнобедренный.");
    }
    else if (b == a || b == c)
    {
        Console.WriteLine("Треугольник равнобедренный.");
    }
    else
    {
        Console.WriteLine("Треугольник не равнобедренный.");
    }
}

//Задача 2. На вход подаются год, номер месяца и день рождения человека.
//Определить возраст человека на момент 1 июля 2022 года.
void Zadacha2dop()
{
    Console.WriteLine("Введите год рождения: ");
    int year = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер месяца рождения: ");
    int month = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите день рождения: ");
    int day = Convert.ToInt32(Console.ReadLine());
    DateTime dateofbirth = new DateTime(year, month, day);
    DateTime defaultdate = new DateTime(2022, 7, 1);
    int age = (int)(defaultdate - dateofbirth).TotalDays/365;
    //TimeSpan age = (defaultdate.Subtract(dateofbirth)/365);
    Console.Write("Ваш возраст на дату 01.07.2022 = " + age);
}

//Задача 3. Иван в начале года открыл счет в банке, вложив 1000 руб. 
//Через каждый месяц размер вклада увеличивается на 1.5% от имеющейся суммы. 
//Определить размер депозита через n месяцев.
void Zadacha3dop()
{
    Console.WriteLine("Первоначальный размер депозита равен 1000 рублей.");
    Console.WriteLine("Введите количество месяцев для определения будущей стоимости депозита.");
    int n = Convert.ToInt32(Console.ReadLine());
    
    int PV = 1000;
    double r = 1.5;
    double FV = Math.Round(PV * Math.Pow((1 + r/100), n), 2);
    Console.WriteLine("Размер депозита через " + n + " мес. равен " + FV + " руб.");
    
}

//Задача 4. Дано натуральное число, в котором все цифры различны. 
//Определить, какая цифра расположена в нем левее: максимальная или минимальная
void Zadacha4dop()
{
    Console.WriteLine("Введите натуральное число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int [] a = new int[n.ToString().Length];
    for (int i = 0; i < a.Length; i++)
        {
            a[i] = n % 10;
            n /= 10;
        }
    Array.Reverse(a);
    //Console.WriteLine(a);
    int maxvalue = a.Max();
    int minvalue = a.Min();
    int indexofmax = Array.IndexOf(a, maxvalue);
    int indexofmin = Array.IndexOf(a, minvalue);
    if (indexofmax < indexofmin)
    {
        Console.WriteLine("Левее находится максимальная цифра.");
    }
    else
    {
        Console.WriteLine("Левее находится минимальная цифра.");
    }
}



//Zadacha1dop();
//Zadacha2dop();
//Zadacha3dop();
//Zadacha4dop();