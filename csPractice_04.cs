// 伊藤ちゃん課題4　点数を棒グラフにする
using System;

public class RepeatN {
  static void Main() {
    int[] score = new int[] {15,8,12,18,20,20,9,16,20,17};

    for (int i = 0; i < score.Length -1; i ++) {
      Console.Write(string.Format("{0:00}番の点数は{1:00}点: ", i, score[i]));

      for (int j = 0; j < score[i]; j ++) {
        if (j % 5 == 0) {
          Console.Write("|");
        }
        Console.Write("#");
      }
      Console.WriteLine("");
    }
  }
}


/* scoreを文字列の配列に変換して、5ごとに"|"に入れ替えれば良いと思うんだけどやり方が解らない

char →　string は変換できない？



using System;

public class RepeatN {
  static void Main() {
    int[] score = new int[] {15,8,12,18,20,20,9,16,20,17};

    for (int i = 0; i < score.Length; i += 1) {
      if (score[i] % 5 == 0) {
        string graf = (new String('#',score[i]));
        char[] chars = graf.ToCharArray();

        for (int j = 0; j < graf.Length; j += 5) {
          chars[j] = "|";
          int animalIndex = graf.IndexOf("#");
        }



        Console.WriteLine(chars);

        }
      }
    }
  }

*/
