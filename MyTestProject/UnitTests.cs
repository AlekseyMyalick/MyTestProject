namespace MyTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.IsTrue(new Random().Next(2) == 1);
        }

        [Test]
        public void Test2()
        {
            Assert.IsTrue(new Random().Next(2) == 1);
        }

        [Test]
        public void Test3()
        {
            Assert.IsTrue(new Random().Next(2) == 1);
        }

        [Test]
        public void Test4()
        {
            Assert.IsTrue(new Random().Next(2) == 1);
        }

        [Test]
        public void Test5()
        {
            Assert.IsTrue(new Random().Next(2) == 1);
        }
    }
}