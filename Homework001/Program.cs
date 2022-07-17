//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
void Zadacha2()
{
    Console.WriteLine("Введите первое число: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    if (number1 > number2)
    {
        Console.WriteLine("max = " + number1);
    }
    else
    {
        Console.WriteLine("max = " + number2);
    }
}

//Задача 4: Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.
void Zadacha4()
{
    Console.WriteLine("Введите первое число: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите третье число: ");
    int number3 = Convert.ToInt32(Console.ReadLine());
    int max = number1;
    if (number2 > max && number3 < number2)
    {
        max = number2;
    }
    else if (number3 > max)
    {
        max = number3;
    }
    Console.WriteLine("max = " + max);
}

//Задача 6: Напишите программу, которая на вход принимает число 
//и выдаёт, является ли число чётным (делится ли оно на два без остатка).
void Zadacha6()
{
    Console.WriteLine("Введите число для проверки: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number %2 == 0)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}

//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
void Zadacha8()
{
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int count = 2;
    while (count < number + 1)
    {
        Console.Write(count + " ");
        count = count + 2;
    }
}


//Zadacha2();
//Zadacha4();
//Zadacha6();
//Zadacha8();