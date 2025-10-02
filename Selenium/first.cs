namespace SeliniumLearning
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            TestContext.Progress.WriteLine("Hello World");
        }

        [Test]
        public void Test1()
        {
            TestContext.Progress.WriteLine("Test 1 excecuted");   
        }

        [Test]
        public void Test2()
        {
            TestContext.Progress.WriteLine("Test 2 executed");
        }
        [TearDown]
        public void TearDown() 
        {
            TestContext.Progress.WriteLine("The End");
        }
    }
}
