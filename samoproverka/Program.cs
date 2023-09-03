// // Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// int Exponentiation(int numberA, int numberB){
//   int result = 1;
//   for(int i=1; i <= numberB; i++){
//     result = result * numberA;
//   }
    
//     return result;
// }

//   Console.Write("Введите число A: ");
//   int numberA = Convert.ToInt32(Console.ReadLine());
//   Console.Write("Введите число B: ");
//   int numberB = Convert.ToInt32(Console.ReadLine());

//   int exponentiation = Exponentiation(numberA, numberB);
//   Console.WriteLine("Ответ: " + exponentiation);




// //  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


// Console.Write("Введите число N: ");
// int numberN = Convert.ToInt32(Console.ReadLine());

//   int SumNumber(int numberN){
    
//     int count = Convert.ToString(numberN).Length;
//     int advance = 0;
//     int result = 0;

//     for (int i = 0; i < count; i++){
//       advance = numberN - numberN % 10;
//       result = result + (numberN - advance);
//       numberN = numberN / 10;
//     }
//    return result;
//   }

// int sumNumber = SumNumber(numberN);
// Console.WriteLine("Сумма цифр в числе: " + sumNumber);


// // Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// int[] array = new int[8];
// int[] FillArray(int[] array){
//         for (int i = 0; i < array.Length; i++){
//         array[i] = new Random().Next(-9,10);
//     }
//     Console.WriteLine(String.Join(" ", array));
//     return array;   
// }
// int[] newArray = FillArray(array);


// using System;

// public class Answer
// {
//     static bool IsPalindrome(int number){
//       // Введите свое решение ниже
//         string number1 = number.ToString();
// int count = number1.Length;

// if (count >= 6){Console.WriteLine($"Число не пятизначное");
//      return false;
//   }
//   else if(number1[0]==number1[4] && number1[1]==number1[3]){return true;
//   }

// else    return false;
//     }
  
//   // Не удаляйте и не меняйте метод Main! 
//       static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 64546;
//         }

//         // Не удаляйте строки ниже
//         bool result = IsPalindrome(number);
//         System.Console.WriteLine($"{result}");
//     }
// }

