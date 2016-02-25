// paiza girlFriend yes no vote

using System;

public class RepeatN {
  static void Main() {
    string[] a = new string[5];

    for (int i = 0; i < a.Length; i++) {
      a[i] = Console.ReadLine();
      }
      Array.Sort(a);
    if (a[2] == "yes") {
      Console.WriteLine("yes");
    }
    else {
      Console.WriteLine("no");

    }
  }
}
