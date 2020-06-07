using System;
using System.Runtime.CompilerServices;
using CourierSolution.Factory;
using NUnit.Framework;

namespace CourierUnitTest
{
    public class ParcelFactoryHelperTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1,2,4, typeof(SmallParcel))]
        [TestCase(1,2,8, typeof(MediumParcel))]
        [TestCase(5,5,5,typeof(XLParcel))]
        public void CheckFactoryReturnsCorrectParcelTypes(double length, double width, double height, Type type)
        {
            var parcel = ParcelFactoryHelper.CreateParcel(length, width, height,10);
            
            Assert.AreEqual(parcel.GetType(),type);
        }
        
        
        [TestCase(1,2,4, 3)]
        [TestCase(1,2,8, 8)]
        [TestCase(5,5,5,25)]
        public void CheckFactoryReturnsCorrectCost(double length, double width, double height, double cost)
        {
            var parcel = ParcelFactoryHelper.CreateParcel(length, width, height,10);
            
            Assert.AreEqual(parcel.Cost,cost);
        }
        
        
        [TestCase(1,2,4, 2)]
        [TestCase(1,2,8, 6)]
        [TestCase(5,5,5,11)]
        public void CheckFactoryReturnsAdditionalWeightCharge(double length, double width, double height, double weight)
        {
            var parcel = ParcelFactoryHelper.CreateParcel(length, width, height,weight);
            
            Assert.NotZero(parcel.AdditionalWeightCharge);
        }
        
        
    }
}