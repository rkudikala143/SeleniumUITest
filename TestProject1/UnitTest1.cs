namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine(" I am setup");
        }
        [OneTimeSetUp]
        public void oneTimeSetup()
        {
            Console.WriteLine("I am one time setup");
        }
        [OneTimeTearDown]
        public void oneTimeTearDown()
        {
            Console.WriteLine("I am one time teardown");
        }
        [TearDown]
        public void tearDown()
        {
            Console.WriteLine("I am tear down Method");

        }
        
        [Test]
        public void Test1()
        {
            Console.WriteLine(" I am a Test Method");
        }
    }
}