

// Напишите программу, которая принимает на вход координаты двух
//  точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21



// Console.WriteLine("Введите координаты x,y,a,b"); 

// int x = Convert.ToInt32(Console.ReadLine());
// int y = Convert.ToInt32(Console.ReadLine());
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());


// int[] array = new int[2];
// array[0] = x;
// array[1] = y;
// int [] array1 = new int[2];
// array1[0] = a;
// array1[1] = b;

// int f = (a - x) * (a - x) + (b - y) * (b - y);

// double result = Math.Round(Math.Sqrt(f),2);

// Console.WriteLine(result);

// int f = Math.Sqrt(Math.Pow(pointA - x1, 2) + Math.Pow( - y1, 2) + Math.Pow(y3 - y3, 2));     
//       double result = Math.Round(Math.Sqrt(f), 2);
      
// using System;
// using System.Security.Cryptography.X509Certificates;

// public class Answer
// {
//     private static double Length(int[] pointA, int[] pointB)
//     {
//       // Введите свое решение ниже
// double f = Math.Sqrt(Math.Pow(pointB[0] - pointA[0], 2) + Math.Pow(pointB[1] - pointA[1], 2) + Math.Pow(pointB[2] - pointA[2], 2));     
// return f;
//     }

//   // Не удаляйте и не меняйте метод Main! 
//     public static void Main(string[] args) {
//         int x1, x2, x3, y1, y2, y3;

//         if (args.Length >= 6) {
//             x1 = int.Parse(args[0]);
//             x2 = int.Parse(args[1]);
//             x3 = int.Parse(args[2]);
//             y1 = int.Parse(args[3]);
//             y2 = int.Parse(args[4]);
//             y3 = int.Parse(args[5]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             x1 = 3;
//             x2 = 6;
//             x3 = 8;
//             y1 = 2;
//             y2 = 1;
//             y3 = -7;
//         }

//         // Не удаляйте строки ниже
//         double result = Length(new int[]{x1, x2, x3}, new int[]{y1, y2, y3});
//         Console.WriteLine($"{result:F2}");
//     }
// }






using System;

public class Answer
{
   static void ShowCube(int N)
    {
      // Введите свое решение ниже
        for(int i = 1; i <= N; i++){Console.Write(i*i*i + ", ");}
        return;
        
    }

  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int N;

        if (args.Length >= 1) {
            N = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            N = 10;
        }

        // Не удаляйте строки ниже
        ShowCube(N);
    }
}





