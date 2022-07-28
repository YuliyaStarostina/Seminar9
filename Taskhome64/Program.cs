/* Задача 64: Задайте значения M и N. 
Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine("Введите значение числа М: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение числа N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма натуральных элементов равна {SumNaturalNumberRecursivno(M,N)}"); 

int SumNaturalNumberRecursivno(int numberFirst, int numberSecond)
{
    if (numberFirst == numberSecond) return numberSecond;
    else return (numberFirst + SumNaturalNumberRecursivno(numberFirst + 1, numberSecond));
}
