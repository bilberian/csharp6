// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int[] FormArray(int size)
{
    int[] arr = new int[size];
    arr[0] = 0;
    arr[1] = 1;
    for (int i = 2; i < arr.Length; i++)
    {
        arr[i] = arr[i-1] + arr[i-2];
    }
    return arr;
}

Console.WriteLine("Введите количество элементов для массива: ");
int count = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int[] array = FormArray(count);

Console.Write("[" + string.Join(", ", array) + "]");
Console.WriteLine();