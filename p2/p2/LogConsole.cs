using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2
{
  public class ConsoleLog : ILog
  {
    public void Log(string mensagem)
    {
      Console.WriteLine($"LOG: {mensagem}");
    }
  }
}
