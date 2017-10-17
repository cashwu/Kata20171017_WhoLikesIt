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

        [TestMethod]
        public void Input_cash_should_return_cash_likes_this()
        {
            var kata = new Kata();
            var result = kata.Likes(new[] { "cash" });
            Assert.AreEqual("cash Likes this", result);
        }

        [TestMethod]
        public void Input_cash_cash1_should_return_cash_cash1_likes_this()
        {
            var kata = new Kata();
            var result = kata.Likes(new[] { "cash", "cash1" });
            Assert.AreEqual("cash and cash1 Likes this", result);
        }

        [TestMethod]
        public void Input_cash_cash1_cash2_should_return_cash_cash1_cash2_likes_this()
        {
            var kata = new Kata();
            var result = kata.Likes(new[] { "cash", "cash1","cash2" });
            Assert.AreEqual("cash, cash1 and cash2 Likes this", result);
        } 
    }

    public class Kata
    {
        public string Likes(string[] name)
        {
            if (name.Length == 0)
            {
                return "no one likes this";
            }

            if (name.Length == 2)
            {
                return $"{name[0]} and {name[1]} Likes this";
            }

            if (name.Length == 3)
            {
                return $"{name[0]}, {name[1]} and {name[2]} Likes this";
            }

            return $"{name[0]} Likes this";
        }
    }
}