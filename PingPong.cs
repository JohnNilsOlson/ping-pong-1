using System;
using System.Collections.Generic;

class PingPong
{
  static void Main()
  {
    Console.WriteLine("Please enter an integer between 0 -> 10000");
    string stringUserNumber = Console.ReadLine();
    int intUserNumber;
    bool convert = int.TryParse(stringUserNumber, out intUserNumber);
    

    List<string> numbers = new List<string> {};

    if (!convert || intUserNumber == 0 || intUserNumber > 9999)
    {
      Main();
    }

    for (int index = 1; index <= intUserNumber; index++)
    {
      if (index%3 == 0 && index%5 == 0)
      {
        numbers.Add("ping-pong");
      } 
      else if (index%3 == 0)
      {
        numbers.Add("ping");
      } 
      else if (index%5 == 0)
      {
        numbers.Add("pong");
      }
      else
      {
        numbers.Add(index.ToString());
      }
    }
    foreach (string number in numbers)
    {
      Console.WriteLine(number);
    }
  }
}