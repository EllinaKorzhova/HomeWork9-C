// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int summ = default;

int GetValues(int number1, int number2, int sum){ 
while (number1 < number2-1){
    GetValues(number1 + 1, number2, sum);
    sum = sum + number1+1;
    number1 ++;
    }
    return sum;
}
int summa = GetValues(numberM, numberN, summ);
Console.WriteLine($"наша сумма - {summa}");