// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

using static System.Console;
Clear();

WriteLine("Enter the number: ");
int n = Convert.ToInt32(ReadLine());
int a = 1;
while (n >= a)
{
    if (a % 2==0)
    {
        WriteLine(a);
    }    
    a++;
}