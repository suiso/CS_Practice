// 伊藤ちゃん課題５　平均点を計算
using System;

class Demo {
  public int average(int[] score) {
    int totalScore = 0;

    for (int i = 0; i < score.Length; i++) {
      totalScore += score[i];
    }
    return totalScore / score.Length;
  }
  static void Main() {
    Demo demo = new Demo();
    int[] data = new int[] {15,8,12,18,20,20,9,16,20,17};
    int result = demo.average(data);
    Console.WriteLine(result);
  }
}


/*
public class getAverage(int[] averageScore) {
    int totalScore = 0;
    for (int i = 0; i < averageScore.Length; i ++) {
      averageScore[i] = i;
      totalScore = averageScore[i];
      Console.WriteLine(totalScore);
    }
  }

score = GetAverage(averageScore);
*/
