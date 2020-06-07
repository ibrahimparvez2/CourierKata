using CourierSolution.Factory;
using CourierSolution.Interfaces;
using CourierSolution.Models;
using Moq;
using NUnit.Framework;

namespace CourierUnitTest
{
    public class ParcelTests
    {
        [SetUp]
        public void Setup()
        {
           
        }


        [Test]
        public void IsParcelLimitStatus()
        {
            IParcel smallParcel = ParcelFactoryHelper.CreateParcel(2,1,1,51);
            
            Assert.IsTrue(smallParcel.IsParcelLimit);
        }
        
    }
}