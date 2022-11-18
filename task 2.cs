// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

using static System.Console;
Clear();

Write("Enter the number one ");
int num1 = int.Parse(ReadLine());

Write("Enter the number two ");
int num2 = int.Parse(ReadLine());

Write("Enter the number three ");
int num3 = int.Parse(ReadLine());

if(num1 > num2 && num1 >num3)
    {
        WriteLine($" The biggest number is {num1} ");
    }
if(num2>num1 && num2>num3)
{
    WriteLine($"The biggest number is {num2} ");
}
else
{
    Write($"The biggest number is {num3}");
}
