using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Singleton;
using NUnit.Framework;

namespace DesignPatternTest
{
    [TestFixture]
    public class SingletonTestCase
    {

        [Test]
        public void IsSingletonTest()
        {
            var database1 = SingletonDatabase.Instance;
            var database2 = SingletonDatabase.Instance;

            //This tells us that it will have two 
            Assert.That(database1, Is.SameAs(database2));
            Assert.That(SingletonDatabase.InstanceCount, Is.EqualTo(1));

        }

        [Test]
        public void SingletonDependencyInjectionTest()
        {
            var dummydatabae = new ConfigurableDatabase(new DummyDatabase());
            
            Assert.AreEqual(dummydatabae.GetTotalopulation(new string[]{"data1", "data2"}),123456+3456) ;

        }

    }
}
