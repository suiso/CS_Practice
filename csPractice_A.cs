using System;

public class Rectangle{
  static void Main(){
    Console.WriteLine("横の長さを入れてください");
    int inputRow = int.Parse(Console.ReadLine());
    Console.WriteLine("縦の長さを入れてください");
    int inputColumn = int.Parse(Console.ReadLine());


    for (int i = 0; i < inputRow; i++) {
       for (int j = 0; j < inputColumn; j++) {
         Console.Write("#");
         }
       }
      //  Console.WriteLine(row[1])
    }
  }
