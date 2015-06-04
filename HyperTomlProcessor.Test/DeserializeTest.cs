using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HyperTomlProcessor.Test
{
    [TestClass]
    public class DeserializeXElementTest
    {
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Error0V03()
        {
            Toml.V03.Deserialize(Examples.Error0);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Error0V04()
        {
            Toml.V04.Deserialize(Examples.Error0);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Error1V03()
        {
            Toml.V03.Deserialize(Examples.Error1);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Error1V04()
        {
            Toml.V04.Deserialize(Examples.Error1);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Error2V03()
        {
            Toml.V03.Deserialize(Examples.Error2);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Error2V04()
        {
            Toml.V04.Deserialize(Examples.Error2);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Error3V03()
        {
            Toml.V03.Deserialize(Examples.Error3);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Error3V04()
        {
            Toml.V04.Deserialize(Examples.Error3);
        }

        [TestMethod]
        public void StartsWithV03()
        {
            var toml = Toml.V03;
            toml.Deserialize("#comment\n[TestTable]");
            toml.Deserialize("Test = 1\n[TestTable]");
            toml.Deserialize("[[Test]]\n[[Test]]\n[TestTable]");
            toml.Deserialize("[TestTable]\nTest = 1");
        }

        [TestMethod]
        public void StartsWithV04()
        {
            var toml = Toml.V04;
            toml.Deserialize("#comment\n[TestTable]");
            toml.Deserialize("Test = 1\n[TestTable]");
            toml.Deserialize("[[Test]]\n[[Test]]\n[TestTable]");
            toml.Deserialize("[TestTable]\nTest = 1");
        }
    }
}
