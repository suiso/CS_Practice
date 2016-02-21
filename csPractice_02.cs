// 伊藤ちゃん課題２　ピラミッドみたいなやつを作るやつ

using System;

public class RepeatN {
  static void Main() {
    Console.WriteLine("数字を入れてください");
    int input = int.Parse(Console.ReadLine());

    for (int i = 1; i < input + 1; i = i + 1) {
      Console.WriteLine(new String('*',i));
    }
    for (int j = input; j > 0; j -=1) {
      Console.WriteLine(new String('*',j));
    }
  }
}
