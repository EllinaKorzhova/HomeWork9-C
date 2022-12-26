// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n
Console.Write("Введите число M: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int number1 = Convert.ToInt32(Console.ReadLine());


int Ack(int n,int m){
while (n !=0){
if (m == 0){
    m = 1;
} else{
    m = Ack(n,m - 1);
}
n = n - 1;
  }  
 return (m + 1);
}

int res = Ack(number, number1);
Console.WriteLine(res);