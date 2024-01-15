// Задайте массив. Напишите программу которая определяет, присутствует ли заданное число в массиве. 
// Программа должна выдавать ответ: Да/Нет.

int[] arr = { 1, 3, 4, 19, 3, 8, 0, -7 };
int a = int.Parse(Console.ReadLine()!);
bool b = false;
for (int i = 0; i < arr.Length; i++)
{
    if (a == arr[i])
    {
        b = true;
        //brake;-почему то не работает....
    }
}
if (b)
    Console.Write("Да");
else
    Console.Write("Нет");