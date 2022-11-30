// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// int Sum (int num)
// {
//     int sum = 0;
//     for (int i = num; i > 0; i /= 10)
//     {
//         sum = sum + i % 10;
//     }
//     return sum;
// }

// Console.WriteLine("Введите число: ");
// int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// int result = Sum(number);
// Console.WriteLine("Сумма цифр в введенном числе равна: " + result);

int Sum (int num)
{
    int sum = 0;
    if(num < 0)
    {
        int firstSum = 0;
        int firstNum = 0;
        for (int j = num; j <= -10; j/=10)
        {
            firstSum = firstSum + j % 10;
        }
        while (num <= -10)
        {
            firstNum = num/=10;
        }
        
        sum = firstNum + firstSum * (-1);
        return sum;
    }
    else 
    {
        for (int i = num; i > 0; i /= 10)
        {
            sum = sum + i % 10;
        }
        return sum;
    }
    
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = Sum(number);
Console.WriteLine("Сумма цифр в введенном числе равна: " + result);
