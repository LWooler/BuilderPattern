using System;

namespace BuilderPattern
{
  class Program
  {

    static void Main(string[] args)
    {
      ComputerBuilder build = new ComputerBuilder();
      Director direct = new Director(build);

      Console.WriteLine("Building a Gaming Computer: ");
      direct.BuildGamingComputer();
      Console.WriteLine(ComputerDisplay.Display(build.GetParts()));

      Console.WriteLine("Building a Development Computer: ");
      direct.BuildDevelopmentComputer();
      Console.WriteLine(ComputerDisplay.Display(build.GetParts()));

      Console.WriteLine("Building a Custom Computer: ");
      direct.BuildCustomComputer("Windows", "AMD", "RISC-V", 128, "HDD");
      Console.WriteLine(ComputerDisplay.Display(build.GetParts()));
    }
  }
}
