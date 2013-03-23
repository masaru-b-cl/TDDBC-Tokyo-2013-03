using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LTSV
{
  public class LTSV
  {
    private readonly IDictionary<string, string> store = new Dictionary<string, string>();
    public string Get(string key)
    {
      if (!store.ContainsKey(key))
      {
        return null;
      }
      return store[key];
    }
  }
}
