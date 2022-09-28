using ECS.Legacy;

namespace ECS.Unit.Test
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
            IFakeHeater  fakeHeater = new FakeHeater();
            bool variable = fakeHeater.FakeTurnOn(1);
            bool test2 = fakeHeater.FakeTurnOn(2);
            bool test3 = fakeHeater.FakeTurnOn(3);
            Assert.That(true,Is.EqualTo(variable));
            Assert.That(false, Is.EqualTo(test2));
            Assert.That(false, Is.EqualTo(test3));
        }
    }
}