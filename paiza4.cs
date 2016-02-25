// stick words

using System;

public class RepeatN {
  static void Main() {
    int inputNum = int.Parse(Console.ReadLine());
    string[] word = new string[inputNum];
    string stickWords = "";

    for (int i = 0; i < inputNum; i++) {
      word[i] = Console.ReadLine();
      stickWords = string.Join("_",word);
    }
    Console.WriteLine(stickWords);
  }
}
