using System;

public class Animal {
  protected string voice;
  protected string esa;
  public string name;


  public virtual string WhatEat() {
    esa = "...";
    return esa;
  }
  public virtual string HowToVoice() {
    voice = "...";
    return voice;
  }
}

class Dog : Animal {
  public override string HowToVoice() {
    voice = "ワンワン!";
    return voice;
  }
  public override string WhatEat() {
    esa = "肉";
    return esa;
  }
}

class Cat : Animal {
  public override string HowToVoice() {
    voice = "ミャー!";
    return voice;
  }
  public override string WhatEat() {
    esa = "魚";
    return esa;
  }
  //public string name;
}

class OverRide {
  public static void Main() {
    Cat cat = new Cat();
    cat.name = "くうちゃん";

    Dog dog = new Dog();
    dog.name = "たろう";

    Console.WriteLine("{0}は{1}と鳴き、{2}を食べる",cat.name,cat.HowToVoice(),cat.WhatEat());
    Console.WriteLine("{0}は{1}と鳴き、{2}を食べる",dog.name,dog.HowToVoice(),dog.WhatEat());
  }
}
