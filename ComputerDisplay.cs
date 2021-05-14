using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
  public class ComputerDisplay
  {
    public static string Display(List<object> parts)
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append("Computer Parts: ");
      foreach (var part in parts)
      {
        stringBuilder.Append(part.ToString());
        stringBuilder.Append(", ");
      }
      stringBuilder.Remove(stringBuilder.Length - 2, 2);
      stringBuilder.Append("\n");

      return stringBuilder.ToString();
    }
  }
}