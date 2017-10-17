using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20171017_WhoLikesIt
{
    [TestClass]
    public class WhoLikesItTests
    {
        [TestMethod]
        public void Input_empty_name_should_return_no_one_likes_this()
        {
            var kata = new Kata();
            var result = kata.Likes(new string[] { });
            Assert.AreEqual("no one likes this", result);
        }
    }

    public class Kata
    {
        public string Likes(string[] name)
        {
            return "no one likes this";
        }
    }
}