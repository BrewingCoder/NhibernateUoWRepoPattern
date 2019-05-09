using NUnit.Framework;

namespace BrewingCoder.netCore.NHibernateUowRepo.Tests
{
    [TestFixture]
    public class TestRepository
    {
        [SetUp]
        public void SetUp()
        {
        }

        [TearDown]
        public void TearDown()
        {

        }

        [Test]
        public void AlwaysAFailureTest()
        {
            Assert.IsTrue(false);
        }
    }
}
