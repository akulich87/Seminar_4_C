// Напишите программу, которая принимает на вход число N
// и выдает произведение чисел от 1 до N

// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine()); // конвертируем в полноценное число
int factorial = 1;
int count = 1; 

while(count<=num)
{
  factorial *=count; 
  count++;
}

Console.WriteLine($"Произведение чисел равно {factorial}"); 