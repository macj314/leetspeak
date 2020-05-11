using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leet;

namespace Leet.Tests
{
  [TestClass]
  public class LeetspeakTests
  {
    [TestMethod]
    public void Replaceecharwith3()
    {
      LeetspeakTranslator testTranslation = new LeetspeakTranslator();
      Assert.AreEqual("l33t", testTranslation.Translate("leet"));
    }

    [TestMethod]
    public void Replaceocharwith0()
    {
      LeetspeakTranslator testTranslation = new LeetspeakTranslator();
      Assert.AreEqual("g0", testTranslation.Translate("go"));
    }

    [TestMethod]
    public void ReplaceIcharwith1()
    {
      LeetspeakTranslator testTranslation = new LeetspeakTranslator();
      Assert.AreEqual("1llit3rat3", testTranslation.Translate("Illiterate"));
    }
  }
}