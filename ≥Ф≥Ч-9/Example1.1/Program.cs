﻿// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

void GetValues(int number){
    Console.WriteLine($"{number}");
    number -=1;
    if (number > 0){
     GetValues(number);   
    }
    
}

GetValues(numberN);
