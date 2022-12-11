// Задача 1. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
Console.Clear();

double Distance (double xA, double yA, double zA, double xB, double yB, double zB)
{
    double length = Math.Sqrt(Math.Pow (xB - xA,2) + Math.Pow (yB - yA,2) + Math.Pow (zB - zA,2));
    return Math.Round(length, 2);
}

Console.Write("Input a x - coordinate of point A: ");
double xA = Convert.ToDouble(Console.ReadLine());

Console.Write("Input a y - coordinate of point A: ");
double yA = Convert.ToDouble(Console.ReadLine());

Console.Write("Input a z - coordinate of point A: ");
double zA = Convert.ToDouble(Console.ReadLine());

Console.Write("Input a x - coordinate of point B: ");
double xB = Convert.ToDouble(Console.ReadLine());

Console.Write("Input a y - coordinate of point B: ");
double yB = Convert.ToDouble(Console.ReadLine());

Console.Write("Input a z - coordinate of point B: ");
double zB = Convert.ToDouble(Console.ReadLine());

double diztanceBetweenAB = Distance(xA, yA, zA, xB, yB, zB);

Console.WriteLine($"Distance between points A and B is {diztanceBetweenAB}.");
*/

// Задача 2. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
Console.Clear();

void Squares(int number)
{
    int count = 1;
    while (count <= number)
    {
        Console.Write($"{Math.Pow(count,3)} ");
        if(count != number) Console.Write(",");
        count++;
    }
}

Console.Write("Input an integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The series of square of numbers: ");
Squares(num);
*/

// Задача 3. Напишите программу, которая принимает на вход число и проверяет, является ли оно палиндромом.
/*
Console.Clear();

void PalindromNumber (int number)
    {
        int old_number = number;
        int reverse = 0;
        
            while (number > 0)
            {   
                int temp = number % 10;
                reverse = reverse * 10 + temp;
                number = number / 10;
            }
            if (reverse == old_number) 
            {
                Console.WriteLine("Yes");
            }
            else 
            {
                Console.WriteLine("No");
            }
    }

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

PalindromNumber(num);
*/
