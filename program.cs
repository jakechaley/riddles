using System;
using System.Collections.Generic;
// using RiddlesApp;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("I'm a wee wee man in a red red coat with a stick in my hand and a stone in my throat. What am I?");
    string stringUserInput = Console.ReadLine();

    if ((stringUserInput == "A Cherry") || (stringUserInput == "a cherry"))
    {
      Console.WriteLine("That's correct!");
    }
    else 
    {
      Console.WriteLine("That's incorrect :( Try again!");
    }
  }
  
}