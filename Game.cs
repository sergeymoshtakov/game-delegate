using System;

namespace GameNamespace
{
  public class Game
  {
    private string name;
    private string rules;
    private string author;
    public Game(string name, string rules, string author)
    {
      Name = name;
      Rules = rules;
      Author = author;
    }
    public string Name
    {
      get
      {
        return name;
      }
      set
      {
        name = value;
      }
    }
    public string Rules
    {
      get
      {
        return rules;
      }
      set
      {
        rules = value;
      }
    }
    public string Author
    {
      get
      {
        return author;
      }
      set
      {
        author = value;
      }
    }
  }
}