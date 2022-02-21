using System;
using System.Collections.Generic;

namespace RiddlesApp
{
  public class Riddle
  {
    public string RiddlePrompt {  get; set; }
    public string RiddleAnswer {  get; set; }

    public Riddle(string prompt, string answer)
    {
      RiddlePrompt = prompt;
      RiddleAnswer = answer;
    }
  }
}