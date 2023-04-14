using System;
using GameNamespace;

class Program {
  public static void newGame(Game game)
  {
    Console.WriteLine($"New game {game.Name}");
  }
  public static void downloadGame(Game game)
  {
    Console.WriteLine($"Downloading game {game.Name}");
  }
  public static void showRules(Game game)
  {
    Console.WriteLine($"Rules:\n{game.Rules}");
  }
  public static void showAuthor(Game game)
  {
    Console.WriteLine($"The author is {game.Author}");
  }
  public static void goodBye(Game game)
  {
    Console.WriteLine($"The game {game.Name} closed\nGood bye!");
  }
  delegate void GameMethod(Game game);
  public static void Main (string[] args) {
    Game g = new Game("Mortal Combat", "вперед - клавиша W\nназад - клавиша s\nвправо - клавиша d\nвлево - клавиша a", "Sergey Moshtakov");
    GameMethod[] gm1 = new GameMethod[5] {new GameMethod(goodBye), new GameMethod(newGame), new GameMethod(downloadGame), new GameMethod(showRules), new GameMethod(showAuthor)};
    int answ = 1;
    while(answ != 0)
    {
      Console.WriteLine("1 - новая игра\n2 - загрузить игру\n3 - правила\n4 - об авторе\n0 - выход");
      answ = Convert.ToInt32(Console.ReadLine());
      if(answ>=0 && answ<5)
      {
        gm1[answ](g);
      }
      else
      Console.WriteLine("Wrong input");
    }
  }
}