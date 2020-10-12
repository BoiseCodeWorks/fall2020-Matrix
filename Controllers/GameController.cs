using System;


namespace TheMatrix.Controllers
{
  class GameController
  {
    // PROPERTIES
    public string PlayerName { get; private set; }
    public bool Playing { get; set; }
    public int Health { get; set; }

    public void Run()
    {
      while (Playing)
      {
        Console.Clear();
        GetUserInput();
      }
    }

    private void GetUserInput()
    {
      System.Console.WriteLine("What Do you want to do?");
      var input = Console.ReadLine().ToLower();

      switch (input)
      {
        case "quit":
        case "exit":
        case "close":
          Playing = false;
          System.Console.WriteLine("The Matrix has Reclaimed You");
          break;
        case "play":
          Hack();
          break;
        default:
          System.Console.WriteLine("Invalid Command");
          break;
      }
    }

    private void Hack()
    {
      Random rnd = new Random();
      int seconds = rnd.Next(5, 11);
      Console.Clear();
      System.Console.Write($"White Rabbit: Hello {PlayerName}, how did you find me? \n {PlayerName}: ");
      Console.ReadLine();
      System.Console.WriteLine($"\n\nWhite Rabbit: It doesn't Matter, they are coming for you, you have {seconds} seconds to get out of there!");
    }

    //
    // Summary:
    //     Creates a new Game Controller, call Run when ready
    //
    // Parameters:
    //   name:
    //     The playerName
    public GameController(string name)
    {
      PlayerName = name;
      Health = 100;
      Playing = true;
    }

    /// <summary>
    /// THis is the summary
    /// </summary>
    public GameController(string name, int hp)
    {
      PlayerName = "Neo";
      Health = hp;
      Playing = true;
    }
  }
}