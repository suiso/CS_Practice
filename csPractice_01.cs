// 伊藤ちゃん課題1　どんどん増えてくやつ

using System;

public class RepeatN {
  static void Main() {
    Console.WriteLine(	"数字を入れてください");
    var input = int.Parse(Console.ReadLine());
    string kome = "";

    for (int i = 0; i < input; i = i + 1) {
      kome += "*";
      Console.WriteLine(kome);
      }
    }
  }
