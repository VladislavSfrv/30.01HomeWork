//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = SumNumber(number);

Console.WriteLine($"Сумма всех чисел равна - {result}");

int SumNumber(int num)
{
    int sum = 0;
    int numDel = 0;
    for (; num > 0;)
    {
        numDel = num % 10;
        num = num / 10;
        sum = numDel + sum;
    }
    return sum;
}