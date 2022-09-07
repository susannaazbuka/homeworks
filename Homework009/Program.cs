// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
//натуральные числа кратные 3-ём в промежутке от M до N.
void Zadacha64(int m, int n)
{
    if (m == n + 1) return;
    if (m%3 == 0) 
    {
        Console.Write(m + "  ");
    }
    m++;
    Zadacha64(m, n);
}
//Zadacha64(13, 20);


//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
//натуральных элементов в промежутке от M до N.
void Zadacha66(int m, int n, int sum = 0)
{
    if (m == n + 1) 
    {
        Console.Write(sum);
        return;
    }
    sum += m;
    m++;
    Zadacha66(m, n, sum);
}
//Zadacha66(4, 8);

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n. 
uint A(uint m, uint n)
{
    if (m == 0) return n + 1;
    else if ((m > 0) && (n == 0)) return A(m - 1, 1);
    else return A(m - 1, A(m, n - 1));
}
Console.Write(A(3, 2));
