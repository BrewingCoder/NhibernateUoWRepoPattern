﻿using BrewingCoder.NetCore.NHibernateUowRepo;
using BrewingCoder.NetCore.NHibernateUowRepo.Contracts;
using BrewingCoder.netCore.NHibernateUowRepo.Tests.Model;
using FluentNHibernate.Testing;
using NUnit.Framework;

namespace BrewingCoder.netCore.NHibernateUowRepo.Tests
{
    [TestFixture]
    public class TestNhfManager
    {

        private IUnitOfWork _unitOfWork;

        [SetUp]
        public void Setup()
        {
            _unitOfWork = new UnitOfWork(FixtureSetup.Factory);
        }

        [TearDown]
        public void TearDown()
        {
            _unitOfWork.Dispose();
        }

        [Test]
        public void TestFactory()
        {
            Assert.NotNull(FixtureSetup.Factory);
            Assert.NotNull(_unitOfWork);
            Assert.NotNull(_unitOfWork.GetSession());
            Assert.IsTrue(_unitOfWork.GetSession().IsOpen);
        }

        [Test]
        public void TestMapping()
        {
            var foo = new Foo {FooName = Faker.StringFaker.AlphaNumeric(200)};
            new PersistenceSpecification<Foo>(_unitOfWork.GetSession())
                .CheckProperty(c => c.FooName, foo.FooName)
                .VerifyTheMappings();
        }

        [Test]
        public void TestLazyIsSame()
        {
            var instance1 = NHibernateFactoryManager.Instance(FixtureSetup.Configuration);
            var instance2 = NHibernateFactoryManager.Instance(FixtureSetup.Configuration);
            Assert.AreSame(instance1,instance2);
        }

        [Test]
        public void TestIsLazySame()
        {
            var instance1 = NHibernateFactoryManager.Instance(FixtureSetup.Configuration);
            var instance2 = NHibernateFactoryManager.Instance();
            Assert.AreSame(instance1, instance2);
        }
    }
}
