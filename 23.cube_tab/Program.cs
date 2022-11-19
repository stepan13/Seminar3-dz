//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Введите число: ");
var num1 = Convert.ToInt32(Console.ReadLine());
if (num1 <= 0)
Console.WriteLine("Неверное число");
else
{
    for(int i = 1; i<=num1;i++)
    {
        Console.Write(Math.Pow(i,3) + ", ");
    }
}
