// Напишите программу, которая на вход принимает число и выдаёт, является ли 
//число чётным (делится ли оно на два без остатка).

using static System.Console;
Clear();

Write("Enter the number  ");
int number = int.Parse(ReadLine());

int even = number % 2;

if (even == 0){
    WriteLine("The entered number is EVEN");
}
else {
    WriteLine("The enterd number is NOT EVEN");
    }