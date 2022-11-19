//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Ведите число:");
var num = Convert.ToInt32(Console.ReadLine());
int count = 0;

//не стал проверять на пятизначное а написал для любой длины
var temp = num;
while (temp > 0)
{
    count = count + 1;
    temp = temp / 10;
}

bool isPalindrome = true;

int[] array = new int[count];
for (int i = 0; i < count; i++)
{
    array[i] = num % 10;
    num = num / 10;
}

for (int i = 0; i < count / 2; i++)
{
    isPalindrome = (isPalindrome && (array[i] == array[count - i - 1]));
}

if (isPalindrome)
    Console.WriteLine("Это палиндром");
else
    Console.WriteLine("Это не палиндром");
