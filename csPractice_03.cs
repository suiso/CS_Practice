// 伊藤ちゃん課題３　素数かどうかを判定するやつ

using System;

public class IsPrime {
  static void Main() {
    Console.WriteLine("数字を入れてください");
    int input = int.Parse(Console.ReadLine());
    int[] num = new int[input];
    int rest;
    int isPrimeCounter = 0;

    for (int i = 2; i < input -1; i += 1) {
      num[i] = i;
      rest = input % i;
      if (rest == 0) {
        isPrimeCounter ++;
      }
    }
      if( isPrimeCounter > 0) {
        Console.WriteLine("素数じゃない！");
      }
      else if (input == 2) {
        Console.WriteLine("素数じゃない！");
      }
      else {
        Console.WriteLine("素数！");
      }
    }
  }
