// Cost Coffein

using System;

public class RepeatN {
  static void Main() {
    string drinkA = Console.ReadLine();
    string[] Asplit = drinkA.Split(' ');
    var intA = Array.ConvertAll( Asplit, new Converter<string, int>( s => int.Parse(s)));

    string drinkB = Console.ReadLine();
    string[] Bsplit = drinkB.Split(' ');
    var intB = Array.ConvertAll( Bsplit, new Converter<string, int>( s => int.Parse(s)));

    if (intA[0]/intA[1] < intB[0]/intB[1]) {
      Console.WriteLine("2");
    }
    else {
      Console.WriteLine("1");
    }
  }
}

// 7-9行目と11-13行目の処理が冗長な気がするので、なんとか上手くやる方法があると思う。
