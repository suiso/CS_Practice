using System;

public class Rectangle{
  static void Main(){
    Console.WriteLine("横の長さを入れてください");
    int inputRow = int.Parse(Console.ReadLine());
    Console.WriteLine("縦の長さを入れてください");
    int inputColumn = int.Parse(Console.ReadLine());
    string row = "";
    string rowLast = "";
    int counter = 0;

    for (int i = 0; i < inputRow; i++) {
       row += "#"; // １.ここでこれを毎回配列に加えて、
       counter ++;
       if (counter == inputRow) {
         rowLast = row;
       }

       for (int j = 0; j < inputColumn; j++) {
         if (counter == inputRow) {
           Console.WriteLine(rowLast); // 2.ここでさっきの配列の１番最後のやつを呼べば出来るのでは？

         }
       }


      //  Console.WriteLine(row[1])
      //  Console.WriteLine(new String('#',inputColumn));
    }
  }
}
