//Задача 19 Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.
void Zadacha19()
{
    Console.WriteLine("Введите пятизначное число: ");
    int number5 = Convert.ToInt32(Console.ReadLine());
    int size = number5.ToString().Length;
    if (size == 5)
    {
        int a = number5 / 10000;
        int b = number5 / 1000 % 10;
        int c = number5 / 100 % 10;
        int d = number5 / 10 % 10;
        int e = number5 % 10;
        if ( a == e && b == d)
        {
            Console.WriteLine("Число является палиндромом.");
        }    
        else
        {
            Console.WriteLine("Число не является палиндромом.");
        }
    }
    else
    {
        Console.WriteLine("Введено не пятизначное число. Попробуйте еще раз.");
    }
}

//Задача 21 Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
void Zadacha21()
{
    Console.WriteLine("Введите координаты первой точки: ");
    int x1 = Convert.ToInt32(Console.ReadLine());
    int y1 = Convert.ToInt32(Console.ReadLine());
    int z1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты второй точки: ");
    int x2 = Convert.ToInt32(Console.ReadLine());
    int y2 = Convert.ToInt32(Console.ReadLine());
    int z2 = Convert.ToInt32(Console.ReadLine());    
    
    double xx = x2-x1;
    double yy = y2-y1;
    double zz = z2-z1;
    double result = Math.Sqrt(Math.Pow(xx, 2) + Math.Pow(yy, 2) + Math.Pow(zz, 2));
    double resultt = Math.Round(result, 2);
    Console.WriteLine("Расстояние = " + resultt);

    
}

//Задача 23 Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.
void Zadacha23()
{
    Console.WriteLine("Введите число: ");
    int x = Convert.ToInt32(Console.ReadLine());
    //Random random = new Random();
    //int x = random.Next(0,10);
    double num = 1; 
    double res = 0;
    Console.WriteLine($"Число {x}");
    while (num <= x)
    {
        res = Math.Pow(num, 3);
        Console.WriteLine($"{num}x{num}x{num}={res}");
        num++;
    }
    
}

//Zadacha19();
//Zadacha21();
//Zadacha23();