// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
//
int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int sumRecurcion (int a,int b)
{
    if(a==b)
    {
     return a;
    } 
    return b+sumRecurcion(a,b-1);
}

int a=Prompt("Введите значение M=:");
int b=Prompt("Введите значение N=:");

System.Console.Write($"Сумма чисел:{sumRecurcion(a,b)}");
