﻿// Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и еденицами в случайном порядке

// [1,0,1,1,0,1,0,0]

int[] array = new int[8]; // создаем массив; если мы хотим создать массив строк - string[] array = new string[]; [8] - размер нашего массива;
// пример заполнение массива, если это требует условие int[] array = new int[] {3,5,5,6,3,2,1,5};
for (int i = 0; i < array.Length; i++) // цикл выполняется пока наша переменная счетчик не достигла длины нашего массива, max число переменной i это 7
{
  array[i]=new Random().Next(0,2);// переберет все элементы массива, и присвоит значение 1 либо 0; Next(0,2) - крайнее правое число -1
  Console.WriteLine(array[i]); // выводим наш массив на экран
}

