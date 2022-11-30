// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int[] FormArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-1000, 1000);
    }
    return arr;
}

Console.WriteLine("Введите количество элементов для массива: ");
int count = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int[] array = FormArray(count);
Console.Write("[" + string.Join(", ", array) + "]");
Console.WriteLine();

int counter = 0;
for (int i = 0; i < count; i++)
{
    if(array[i] > 0) counter++;
}
Console.WriteLine(counter);