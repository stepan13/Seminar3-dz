//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int D = 3;
int[] p1 = new int[D];
int[] p2 = new int[D];
string coord = "xyzkmnabctlh";

for (int i = 0; i < D; i++)
{
    Console.Write("p1 " + coord[i]+":");
    p1[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < D; i++)
{
    Console.Write("p2 " + coord[i]+":");
    p2[i] = Convert.ToInt32(Console.ReadLine());
}
double SquareSum = 0;
for (int i = 0; i < D; i++)
{
    SquareSum = SquareSum + Math.Pow(p1[i]-p2[i],2);
}
var distance = Math.Sqrt(SquareSum);
Console.WriteLine("distance = " + distance);