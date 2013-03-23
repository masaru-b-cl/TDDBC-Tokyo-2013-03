using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LTSV;

namespace LTSVTest
{
  [TestClass]
  public class LTSVTest
  {
    [TestMethod]
    public void 存在しないキーで取得すると値はnull()
    {
      var ltsv = new LTSV.LTSV();
      string value = ltsv.Get("key");

      value.IsNull();
    }
  }
}
