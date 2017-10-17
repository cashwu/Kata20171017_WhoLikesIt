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
            Assert.AreEqual("cash likes this", result);
        }

        [TestMethod]
        public void Input_cash_cash1_should_return_cash_cash1_likes_this()
        {
            var kata = new Kata();
            var result = kata.Likes(new[] { "cash", "cash1" });
            Assert.AreEqual("cash and cash1 likes this", result);
        }

        [TestMethod]
        public void Input_cash_cash1_cash2_should_return_cash_cash1_cash2_likes_this()
        {
            var kata = new Kata();
            var result = kata.Likes(new[] { "cash", "cash1", "cash2" });
            Assert.AreEqual("cash, cash1 and cash2 likes this", result);
        }

        [TestMethod]
        public void Input_cash_cash1_cash2_cash3_should_return_cash_cash1_cash2_cash3_likes_this()
        {
            var kata = new Kata();
            var result = kata.Likes(new[] { "cash", "cash1", "cash2", "cash3" });
            Assert.AreEqual("cash, cash1 and 2 others likes this", result);
        }
    }

    public class Kata
    {
        public string Likes(string[] name)
        {
            string likes;
            switch (name.Length)
            {
                case 0:
                    likes = "no one";
                    break;
                case 1:
                    likes = $"{name[0]}"; 
                    break;
                case 2:
                    likes = $"{name[0]} and {name[1]}"; 
                    break;
                case 3:
                    likes = $"{name[0]}, {name[1]} and {name[2]}"; 
                    break;
                default:
                    likes = $"{name[0]}, {name[1]} and {name.Length - 2} others"; 
                    break;
            }

            return $"{likes} likes this";
        }
    }
}