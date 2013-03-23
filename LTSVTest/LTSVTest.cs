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

    [TestMethod]
    public void 存在するキーで取得すると対応する値を返す()
    {
      var ltsv = new LTSV.LTSV();

      dynamic dynLtsv = ltsv.AsDynamic();
      dynLtsv.store["key"] = "value";

      ltsv.Get("key").Is("value");

    }
  }
}
