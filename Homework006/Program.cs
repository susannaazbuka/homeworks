// Задача 41: Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
void Zadacha41()
{
    Console.WriteLine("Введите количество вводимых чисел: ");
    int numberM = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    for (int i = 0; i< numberM; i++)
    {
        Console.WriteLine("Введите число и нажмите Enter: ");
        int numb = Convert.ToInt32(Console.ReadLine());
        if (numb > 0) count++; 
    }
    Console.WriteLine($"Введено {count} чисел/числа больше 0.");
}

//Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
void Zadacha43()
{
    Console.WriteLine("Введите параметры первой прямой: ");
    int b1 = Convert.ToInt32(Console.ReadLine());
    int k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите параметры второй прямой: ");
    int b2 = Convert.ToInt32(Console.ReadLine());
    int k2 = Convert.ToInt32(Console.ReadLine());

    if (k1 == k2)
    {
        Console.WriteLine("По данным параметрам прямых нет точек пересечения.");
    }
    else
    {
        double x = (b2 - b1)/(k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Координаты точки пересечения А ({Math.Round(x, 2)}, {Math.Round(y, 2)}).");
    }

}


//Zadacha41();
//Zadacha43();
