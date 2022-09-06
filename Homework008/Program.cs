// Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
void Zadacha54()
{
    Console.WriteLine("Задайте двумерный массив.");
    Console.WriteLine("Введите количество строк в массиве:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов в массиве:");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[m, n];  //задаем тип данных массива
    FillArray1(array);
    PrintArray1(array);
    Console.WriteLine("Построчно отсортированный по убыванию массив представлен ниже.");
    for (int i = 0; i < m; i++)  //цикл для перебора массива
    {
        for (int j = n - 1; j > 0; j--) //фиксируем последний наименьший элемент
        {
            for (int k = 0; k < j; k++) //вызываем заполнение для элемента i,j
            {
                if (array[i, k] < array [i, k + 1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
        }
    }
    PrintArray1(array);
}

//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
void Zadacha56()
{
    Console.WriteLine("Задайте прямоугольный двумерный массив.");
    Console.WriteLine("Введите количество строк в массиве:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов в массиве:");
    int n = Convert.ToInt32(Console.ReadLine());
    if (m == n) 
    {
        Console.WriteLine("Задан квадратный массив. Попробуйте еще раз.");
    }
    else
    {
        int[,] array = new int[m, n];  //задаем тип данных массива
        FillArray1(array);
        PrintArray1(array);
        Console.WriteLine("Сумма в каждой строке: ");
        int sum_min = 0;
        int ind_min = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            {
                sum_min += array[0, j];                 //нашли сумму первой строки и устанавливаем ее как минимальную сумму
            }
        Console.WriteLine(sum_min + "\t");
        for (int i = 1; i < array.GetLength(0); i++)     //перебираем массив по строкам далее
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i, j];
            }
            if (sum < sum_min)
            {
                sum_min = sum;
                ind_min = i;
            }
            Console.WriteLine(sum + "\t");
        }
        Console.WriteLine($"Минимальная сумма находится в строке {ind_min + 1} и равна {sum_min}.");
    }
}

//Задача 58: Заполните спирально массив 4 на 4 числами от 1 до 16.
void Zadacha58()
{
    int m = 4;
    int[,] array = new int[m, m];  //задаем тип данных массива
    int row = 0;
    int column = 0;
    int change_row = 0;
    int change_column = 1;
    int povorot_time = m;
    int turn = 0;
    
    for (int i = 0; i < array.Length; i++)  //перебираем значения, которые должны попасть в массив
        {
            array[row, column] = i + 1;
            povorot_time--;
            //Console.Write(array[row, column] + "\t");
            if (povorot_time ==0) 
            {
                povorot_time = m - 1 - turn/2;   
                int temp = change_row;
                change_row = change_column;
                change_column = - temp;
                turn++;

            }
            row += change_row;
            column += change_column;
        }
    
    
    //FillArray1(array, 1, 16);
    PrintArray1(array);
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
    for (int i = 0; i < array.GetLength(0); i++)  //цикл для перебора массива
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");  //выводим с символом табуляции для красивого массива
        }
        Console.WriteLine();
    }
    
}


//Zadacha54();
//Zadacha56();
Zadacha58();