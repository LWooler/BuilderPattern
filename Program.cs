using System;

namespace BuilderPattern
{
  class Program
  {

    static void Main(string[] args)
    {
      Director direct = new Director(new ComputerBuilder());

      direct.BuildGamingComputer();
    }
  }
}
