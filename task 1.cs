//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

using static System.Console;
Clear();

Write("Enter the number one ");
int num1 = int.Parse(ReadLine());

Write("Enter the number two ");
int num2 = int.Parse(ReadLine());

if(num1 > num2){
    WriteLine(" The number one is greater then the number two ");
}

else
{
    WriteLine("The number two is greater then the number two");
}
