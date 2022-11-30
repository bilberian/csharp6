// Дополнительная задача на рекурсию (необязательная)
// Напишите программу для подсчета количества цифр в числе с помощью рекурсии.
// 12345 -> 5

Console.WriteLine("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;

int countDigits (int number)
{
    
    if (number >= 0 && number < 10) 
    {
        return count;
    }
    countDigits(number/10);
    count++;
    return count;
}

countDigits(number);
Console.WriteLine(count);
