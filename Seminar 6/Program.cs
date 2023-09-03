// Задача 39: Напишите программу, которая перевернёт одномерный
// массив (последний элемент будет на первом месте, а первый - на
// последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


int[] array = new int[5];

void FillArray (int[] array){
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(1, 10);
    }
}
void Reverse (int[] array){
    int temp;
    for (int i = 0; i < array.Length / 2; i++){
        temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }

}
int[] ReverseNew (int[] array){
    int[] newArray = new int[array.Length];
    for (int i = 0; i < newArray.Length; i++){
        newArray[array.Length - 1 - i] = array[i];
    }
    return newArray;
}

FillArray(array);
Console.WriteLine( string.Join(" ", array));
Console.WriteLine(string.Join(" ", ReverseNew(array)));
Reverse(array);
Console.WriteLine( string.Join(" ", array));