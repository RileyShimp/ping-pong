using System;
using System.Collections.Generic;

public class Program {
  public static void Main() {
    
    List<string> numberList = new List<string>{};

    Console.WriteLine("Enter a number");
    string stringNumber = Console.ReadLine();
    int number = int.Parse(stringNumber);
    
    for(int index = 0; index <= number; index++) {
      numberList.Add(index.ToString());
      if (index % 15 == 0 && index != 0) {
        numberList[index] = "ping-pong";
      }
      else if (index % 5 == 0 && index != 0) {
        numberList[index] = "pong";
      }
      else if (index % 3 == 0 && index != 0) {
        numberList[index] = "ping";
      }
    Console.WriteLine(numberList[index]);
    }
  }
}


// String s = "aaa";
// Console.WriteLine("The initial string: '{0}'", s);
// s = s.Replace("a", "b").Replace("b", "c").Replace("c", "d");
// Console.WriteLine("The final string: '{0}'", s);

// The example displays the following output:
//       The initial string: 'aaa'
//       The final string: 'ddd'

    //     SetValue("ping");
    //   }

// public string Replace (string oldValue, string? newValue);