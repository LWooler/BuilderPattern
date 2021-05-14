using System;
using System.Collections.Generic;

namespace BuilderPattern
{
  public class ComputerBuilder : IBuilder
  {
    public List<object> _parts;

    public ComputerBuilder()
    {
      Reset();
    }

    public void Reset()
    {
      _parts = new();
    }
    public void GetCPU(string cpu)
    {
      _parts.Add(cpu);
    }

    public void GetGraphicsCards(string gpu)
    {
      _parts.Add(gpu);
    }

    public void GetOperatingSystem(string os)
    {
      _parts.Add(os);
    }

    public void GetRAM(int ramNum)
    {
      if (ramNum % 8 == 0 && ramNum < 129)
      {
        _parts.Add(ramNum);
      }
      else
      {
        throw new ApplicationException();
      }
    }

    public void GetStorage(string storage)
    {
      _parts.Add(storage);
    }

    public List<object> GetParts()
    {
      var parts = _parts;
      Reset();
      return parts;
    }
  }
}