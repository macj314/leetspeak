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
      Assert.AreEqual("l3an", testTranslation.Translate("lean"));
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
      Assert.AreEqual("1'll", testTranslation.Translate("I'll"));
    }

    [TestMethod]
    public void Replacetcharwith7()
    {
      LeetspeakTranslator testTranslation = new LeetspeakTranslator();
      Assert.AreEqual("ar7", testTranslation.Translate("art"));
    }
  }
}