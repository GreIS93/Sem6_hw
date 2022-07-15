// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите числа через пробел");
int[] arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(i => int.Parse(i)).ToArray<int>();

void CountPositive(int[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr2.Length; i++)
    {
        if (arr2[i]>0) count = count+1;
    }
    Console.WriteLine($"Пользователь ввел {count} чисел больше 0");
}

CountPositive(arr);