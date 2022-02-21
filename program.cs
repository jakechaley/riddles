using System;
using System.Collections.Generic;
using RiddlesApp;

public class Program
{
  public static void Main()
  {
    Riddle riddle1 = new Riddle("I'm a wee wee man in a red red coat with a stick in my hand and a stone in my throat. What am I?", "a cherry");
    Riddle riddle2 = new Riddle("The more of me you take, the more of me you leave behind. What am I?", "footsteps");
    Riddle riddle3 = new Riddle("What question can you never answer yes to?", "are you asleep yet");

    Console.WriteLine("BEHOLD! I am the Sphinx, great and terrible, etc etc. I wanna ask you a question, bub. Press ENTER to continue");
    Console.ReadKey();
    Console.WriteLine(riddle1.RiddlePrompt);
    string stringUserInput = Console.ReadLine();

    if (stringUserInput == riddle1.RiddleAnswer)
    {
      Console.WriteLine("That's correct! You've defeated me this time. BUT WAIT! I have another riddle for you. Press ENTER to continue.");
      Console.ReadKey();
    }
    else
    {
      Console.WriteLine("That's incorrect. How sad for you. Thank goodness I had sushi for lunch and I could eat again.");
    }

    Console.WriteLine(riddle2.RiddlePrompt);
    string stringUserInput2 = Console.ReadLine();

    if (stringUserInput2 == riddle2.RiddleAnswer)
    {
      Console.WriteLine("That's correct! Man, you're clever! Let's do one more. All or nothing! Press ENTER to continue.");
      Console.ReadKey();
    }
    else
    {
      Console.WriteLine("That's incorrect. How sad for you. Thank goodness I had sushi for lunch and I could eat again.");
    }

    Console.WriteLine(riddle3.RiddlePrompt);
    string stringUserInput3 = Console.ReadLine();

    if (stringUserInput3 == riddle3.RiddleAnswer)
    {
      Console.WriteLine("That's correct! You've defeated me!");
    }
    else
    {
      Console.WriteLine("That's incorrect. How sad for you. Thank goodness I had sushi for lunch and I could eat again.");
    }


  }

}