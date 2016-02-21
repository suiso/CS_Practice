// 伊藤ちゃん課題4　点数を棒グラフにする

using System;

public class RepeatN {
  static void Main() {
    int[] score = {15,8,12,18,20,20,9,16,20,17};

    for (int i = 0; i < score.Length; i = i + 1) {
      score[i] = i;
      Console.WriteLine(new String('#',{i}));
    }
  }
}
