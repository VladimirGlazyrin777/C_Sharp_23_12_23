﻿//Задайте одномерный массив, заполненный случайными числами.
//Определите количество простых чисел в этом массиве.
class Programm
{
static void Main()
{
Random random = new Random();
int[] numbers = new int[10];//Создаем массив из 10 случайных чисел.
for(int i = 0; i < numbers.Length; i++)
  {
   numbers[i]=random.Next(1, 100);
  }
  int count = 0;
  foreach(var number in numbers)
  {
    if(IsPrime(number))
    {
        Console.WriteLine(number);
        count++;
    }
  }
Console.WriteLine("Количество простых чисел в массиве:" +count);
}
//Метод для определения является ли число простым
static bool IsPrime(int number)
{
if(number <2) return false;
for (int i = 2;i <number; i++)
{
    if(number % i == 0)
    {
        return false;
    }
  }
  return true;
 }
}