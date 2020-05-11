using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leet;

namespace Leet.Tests
{
  [TestClass]
  public class LeetspeakTests
  {
    [TestMethod]
    public void ReplaceeCharWith3()
    {
      LeetspeakTranslator testTranslation = new LeetspeakTranslator();
      Assert.AreEqual("l3an", testTranslation.Translate("lean"));
    }

    [TestMethod]
    public void ReplaceoCharWith0()
    {
      LeetspeakTranslator testTranslation = new LeetspeakTranslator();
      Assert.AreEqual("g0", testTranslation.Translate("go"));
    }

    [TestMethod]
    public void ReplaceICharWith1()
    {
      LeetspeakTranslator testTranslation = new LeetspeakTranslator();
      Assert.AreEqual("1'll", testTranslation.Translate("I'll"));
    }

    [TestMethod]
    public void ReplacetCharWith7()
    {
      LeetspeakTranslator testTranslation = new LeetspeakTranslator();
      Assert.AreEqual("ar7", testTranslation.Translate("art"));
    }

    [TestMethod]
    public void ReplacesCharWithz()
    {
      LeetspeakTranslator testTranslation = new LeetspeakTranslator();
      Assert.AreEqual("sazz", testTranslation.Translate("sass"));
    }

    [TestMethod]
    public void TestAllConversions()
    {
      LeetspeakTranslator testTranslation = new LeetspeakTranslator();
      Assert.AreEqual("D0n'7 y0u l0v3 7h3z3 'S7ring' 3x3rciz3z? 1 d0!", testTranslation.Translate("Don't you love these 'String' exercises? I do!"));
    }
  }
}