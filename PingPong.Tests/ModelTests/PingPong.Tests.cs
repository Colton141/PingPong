using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;

namespace PingPong.Test
{
  [TestClass]
  public class PingPongTest
  {
    [TestMethod]
    public void IsPingPong_NumberIsDivisibleByThree_True()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual(true, testPingPong.IsPingPong(3));
    }
    [TestMethod]
    public void IsPingPong_NumberIsDivisibleByFive_True()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual(true, testPingPong.IsPingPong(5));
    }
    [TestMethod]
    public void IsPingPong_NumberIsDivisibleByFiveAndThree()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual(true, testPingPong.IsPingPong(15));
    }
    [TestMethod]
    public void IsPingPong_IncrementByOne()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual(true, testPingPong.IsPingPong(5));
    }
  }
}
