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
  }
}