// Напишите программу, которая принимаетна вход
// трехзначное число и возводить вторую цифру этого числа в степень, равную
//третьей цифре.

int a = int.Parse(Console.ReadLine()!);
int SecondNumb = a / 10 % 10;
int ThirdNumb = a % 10;
Console.WriteLine(Math.Pow(SecondNumb, ThirdNumb));

