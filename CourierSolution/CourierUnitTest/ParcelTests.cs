using CourierSolution.Factory;
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
        public void SpeedyDeliveryStatusChanges()
        {
            Mock<SmallParcel> smallParcel = new Mock<SmallParcel>();
            
            Assert.IsFalse(smallParcel.Object.IsSpeedy);
            
            smallParcel.Object.AddSpeedyDelivery();
            
            Assert.IsTrue(smallParcel.Object.IsSpeedy);
        }
        
    }
}