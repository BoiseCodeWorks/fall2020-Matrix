using System;
using TheMatrix.Controllers;

namespace TheMatrix
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      System.Console.WriteLine(@"
  _____ _            __  __       _        _      
 |_   _| |__   ___  |  \/  | __ _| |_ _ __(_)_  __
   | | | '_ \ / _ \ | |\/| |/ _` | __| '__| \ \/ /
   | | | | | |  __/ | |  | | (_| | |_| |  | |>  < 
   |_| |_| |_|\___| |_|  |_|\__,_|\__|_|  |_/_/\_\ 
      ");
      Console.WriteLine("Choose Your Character (Neo, Trinity, Smith)?");
      var name = Console.ReadLine();
      GameController gc;
      switch (name)
      {
        case "admin":
          gc = new GameController("Neo", 100000);
          break;
        default:
          gc = new GameController(name);
          break;
      }
      gc.Run();
    }
  }
}
