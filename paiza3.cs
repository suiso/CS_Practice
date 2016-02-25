// CountDown

using System;

public class RepeatN {
  static void Main() {
    int inputNum = int.Parse(Console.ReadLine());

    for (int i = inputNum; i >= 0; i--) {
      if (i == 0) {
        Console.WriteLine("0!!");
      }
      else {
        Console.WriteLine(i);
      }
    }
  }
}
