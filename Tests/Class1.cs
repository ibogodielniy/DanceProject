using System;

namespace Tests
{
    using NUnit.Framework;
    using Repository;
    using ServiceLayer;
    using DomainLayer;
    ///using System.ServiceModel.DomainServices.EntityFramework;

    [TestFixture]
    public class Class1
    {
        ProfileService ps = new ProfileService(new GenericRepository<Profile>(new Context()));

        [Test]
        public void Testing()
        {
            Profile Vasya = new Profile() {Id=1, Name = "Vanya", Sex = "Male", Level = "Intermidiate" };
            ps.AddProfile(Vasya);
            object TestVasya = ps.GetProfile(Vasya.Id);
            Assert.AreEqual(TestVasya, Vasya);
        }
    }
}
