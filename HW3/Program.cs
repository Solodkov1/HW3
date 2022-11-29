/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да


void isPaidrom(int[] array)
{
    int count = array.Length - 1;
    string isPalidrom = "Yes, this is Palidrom number";

    for (int i = 0; i < array.Length/2; i++)
    {
           if (array[i] != array[count - i])
        {
            isPalidrom = "NO, this is not Palidrom number";
            break;
        }
        
    }
    Console.WriteLine(isPalidrom);
    
}
int[] arr= {1, 4, 2, 4, 1};
isPaidrom (arr);

*/

/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/
/*
double Rasstoianie(double xa, double ya, double za, double xb, double yb, double zb)
{

    double dlinna = Math.Sqrt((xb - xa)*(xb-xa) + (yb-ya)*(yb-ya) +(zb-za)*(zb-za));
    return dlinna;
}
Console.WriteLine("Input coordinates point A");
Console.Write("X1= ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Y1= ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Z1= ");
double za = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinates point B");
Console.Write("X2= ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Y2= ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Z2= ");
double zb = Convert.ToDouble(Console.ReadLine());
double result = Rasstoianie(xa, ya, za, xb, yb, zb);
Console.Write($"Distnce A or B ={result}");
*/
/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

void Kub(int N)
{

    for (int i = 0; i <= N ; i++)
    {
        Console.Write($"{i*i*i} ");
    }
}
Kub(5);
