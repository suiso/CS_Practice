// 伊藤ちゃん課題５　フィボナッチ数列を計算
using System;

class Demo {
  public int fibonacci() {
    int input = int.Parse(Console.ReadLine());
    int pre = 1;
    int prepre = 0;
    int answer = 0;

    if (input == 0) {return 0;}
      for (int i = 0; i < input; i++) {
        answer = pre + prepre;
        prepre = pre;
        pre = answer;
      }
    return answer;
  }

  static void Main() {
    Demo test = new Demo();
    Console.WriteLine(test.fibonacci());
  }
}
