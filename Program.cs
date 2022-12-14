// See https://aka.ms/new-console-template for more information
/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
*/

Console.WriteLine("Введите трехзначное число: ");

int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Вы ввели число " + number);

// Проверка условия что введено трехзначное число

int a = 99;
int b = 1000;

if(a < number & number < b)
{
    Console.WriteLine("Число " + number + " является трехзначным.");
    
    int firstNumber = number / 10;
    int lastNumber = firstNumber % 10;
    
    Console.WriteLine("Вторая цифра введенного трехзначного числа равна: " + lastNumber);
}
else
{
    Console.WriteLine("Число не является трехзначным.");
}