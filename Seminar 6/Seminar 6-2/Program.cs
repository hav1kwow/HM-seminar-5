//  Напишите программу, которая будет создавать копию
// заданного массива с помощью поэлементного копирования.

int[] arr = { 5, 4, 7, 2, 9 };

void Main(int[] array)
{
int[] copy = new int[arr.Length];
Console.Write("[");
for (int i = 0; i < arr.Length; i++) {
copy[i] = arr[i];
}

Console.Write(String.Join(", ", copy));
Console.Write("]");
}

Main(arr);