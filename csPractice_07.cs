// 伊藤ちゃん課題7
using System;

class Demo {
  public int average(int[] speachTime) {
    //int speakerCount = int.Parse(Console.ReadLine());
    int allTime = 0;
    int hours = 10;
    int minutes = 0;
    for (int i = 0; i < speachTime.Length; i++) {
      allTime += speachTime[i];
      minutes += speachTime[i];
      //Console.WriteLine(elapsedTime);
      Console.WriteLine(string.Format("{0:00}さんのお話は{1:00}時{2:00}分まで: ", i,hours, minutes));

    }
    return allTime;
  }
  static void Main() {
    Demo demo = new Demo();
    int speakerCount = int.Parse(Console.ReadLine());
    int[] data = new int[speakerCount];
    for (int j = 0; j < speakerCount; j++) {
      data[j] = int.Parse(Console.ReadLine());
    }

    int result = demo.average(data);
    Console.WriteLine(result);
  }
}
/*

class Demo {
  public int endTime = 0;

  public int inputInfo(int speakerCount) {
    //int speakerCount = int.Parse(Console.ReadLine());
    string[] speakerName = new string[speakerCount];
    int[] speachTime = new int[0];
  //  public int endTime = 0;

    for (int i = 0; i < speakerCount; i++) {
      Console.WriteLine("誰が喋る？");
      speakerName[i] = Console.ReadLine();
      Console.WriteLine("何分喋る？");
      speachTime[i] =  int.Parse(Console.ReadLine());
      endTime += speachTime[i];
    }
    return endTime;
  }

  static void Main() {
    Demo test = new Demo();
    int num = int.Parse(Console.ReadLine());
    test.inputInfo(num);
  }
}

*/
