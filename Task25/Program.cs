//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите два числа: ");
Console.Write("A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int result = Degree(numberA, numberB);
Console.WriteLine(result != 0 ? result : "Введите натуральное число.");

int Degree(int a, int b)
{
    if (a != 0)
    {
        int numA = a;
        int i = 1;
        while (i < b)
        {
            a = a * numA;
            i++;
        }
        Console.WriteLine($"Степень равна - {a}");
        return a;
    }
    else return 0;
}