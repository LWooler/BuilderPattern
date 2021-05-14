namespace BuilderPattern
{
  public class Director
  {
    private IBuilder _builder;

    public Director(IBuilder builder)
    {
      _builder = builder;
    }

    public void BuildGamingComputer()
    {
      _builder.GetOperatingSystem("Windows");
      _builder.GetGraphicsCards("NVidia");
      _builder.GetCPU("Intel");
      _builder.GetRAM(32);
      _builder.GetStorage("SSD");
    }
    public void BuildDevelopmentComputer()
    {
      _builder.GetOperatingSystem("Linux");
      _builder.GetGraphicsCards("AMD");
      _builder.GetCPU("AMD");
      _builder.GetRAM(16);
      _builder.GetStorage("NVME");
    }
    public void BuildCustomComputer(string os, string gpu, string cpu, int ram, string storage)
    {
      _builder.GetOperatingSystem(os);
      _builder.GetGraphicsCards(gpu);
      _builder.GetCPU(cpu);
      _builder.GetRAM(ram);
      _builder.GetStorage(storage);
    }
  }
}