using NUnit.Framework;
using Entity;

namespace Test
{
    public class Tests
    {
        public History history;
        [SetUp]
        public void Setup()
        {
            history = new History();
        }

        [TestCase("Valledupar", "17/10/2021")]
        [TestCase("New York", "17/10/2021")]
        [Test]
        public void Test1(string ciudad, string info)
        {
            history.City = ciudad;
            history.Info = info;
            History historyEsperado = new History(){City = "Valledupar", Info = "17/10/2021"};
            Assert.AreEqual(historyEsperado.City, history.City);
        }
    }
}