// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int recurcion (int m, int n)
{
    if(m==0)
    {
        return n+1;
    }
    else if(n==0 && m>0)
    {
        return recurcion(m-1,1);
    }
    else 
    {
        return recurcion( m-1, recurcion(m,n-1));
    }
    
}

int m =Prompt("Введите значение m=:");
int n =Prompt("Введите значение n=:");
System.Console.WriteLine(recurcion(m,n));