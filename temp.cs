// 伊藤ちゃん課題7
using System;

class Demo {
  public int average(int[] speachTime) {
    //int speakerCount = int.Parse(Console.ReadLine());
    int allTime = 0;
    int hours = 10;
    int minutes = 0;
    int endHour = 10;
    int endMinutes = 0;

    for (int i = 0; i < speachTime.Length; i++) {
      //string[] speaker = new string [speachTime.Length];
      //Console.WriteLine("name please");

      allTime += speachTime[i];
      endMinutes += speachTime[i];

      if ( endMinutes >= 60) {
        endMinutes = endMinutes - 60;
        endHour++;
      }
      if ( hours >= 12) {
        hours++;
        minutes = endMinutes -= 10;
      }

      string[] name = new string[speachTime.Length];
      Console.WriteLine("name");
      name[i] = Console.ReadLine();
      string who = name[i];

      //Console.WriteLine(elapsedTime);
      Console.WriteLine(string.Format("{0:00}さんのお話は{1:00}時{2:00}分から{3:00}時{4:00}分まで: ", i,　hours,　minutes, endHour, endMinutes));

      hours = endHour;
      minutes = endMinutes += 10;
    }
    return allTime;
  }
  static void Main() {
    Demo demo = new Demo();
    int speakerCount = int.Parse(Console.ReadLine());
    int[] hasTime = new int[speakerCount];
  //  string[] speakerDate = new string[speakerCount];

    for (int j = 0; j < speakerCount; j++) {
      Console.WriteLine("time");
      hasTime[j] = int.Parse(Console.ReadLine());
    }

    int result = demo.average(hasTime);
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
