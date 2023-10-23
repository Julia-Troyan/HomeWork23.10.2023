// Задача 25: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Write("Введите число A: ");
// int A = int.Parse(Console.ReadLine());

// Console.Write("Введите степень B: ");
// int B = int.Parse(Console.ReadLine());

// int result = 1;

// for (int i = 0; i < B; i++)
// {
//     result *= A;
// }

// Console.WriteLine($"{A} в степени {B} равно {result}");



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Console.Write("Введите число: ");
// string input = Console.ReadLine();

// if (int.TryParse(input, out int number))
// {
//     int sumOfDigits = CalculateSumOfDigits(number);
//     Console.WriteLine($"Сумма цифр числа {number} равна {sumOfDigits}");
// }
// else
// {
//     Console.WriteLine("Неверный формат числа. Пожалуйста, введите целое число.");
// }


// int CalculateSumOfDigits(int num)
// {
//     int sum = 0;

//     while (num != 0)
//     {
//         sum += num % 10; // Получаем последнюю цифру числа и добавляем её к сумме.
//         num /= 10;       // Убираем последнюю цифру числа.
//     }

//     return sum;
// }


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] arr = { 1, 51, 4, 33, 22, 6, 77, 18 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);