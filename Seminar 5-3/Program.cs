
// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и
//  последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] arr = { 1, 2, 3, 4, 5, };
int[] result = new int[(int)Math.Ceiling((double)arr.Length / 2)];

for (int i = 0; i < result.Length; i++)
{
    if (i == result.Length - 1 && arr.Length % 2 != 0)
    {
        result[i] = arr[arr.Length / 2];
    }
    else
    {
        result[i] = arr[i] * arr[arr.Length - i - 1];
    }
}

Console.WriteLine("Результат:");
for (int i = 0; i < result.Length; i++)
{
    Console.Write(result[i] + " ");
}