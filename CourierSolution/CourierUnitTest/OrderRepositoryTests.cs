using CourierSolution.Factory;
using CourierSolution.Repository;
using Moq;
using NUnit.Framework;

namespace CourierUnitTest
{
    public class OrderRepositoryTests
    {
        private Mock<OrderRepository> OrderRepository;


        [SetUp]

        public void SetUp()
        {
            OrderRepository = new Mock<OrderRepository>();
        }

        [Test]
        public void AddToOrders()
        {
            
            this.OrderRepository.Object.Parcels.Add(ParcelFactoryHelper.CreateParcel(10,10,10,30));
            
            Assert.NotNull(this.OrderRepository.Object.Parcels);
        }
        
        
        [Test]
        public void GetOrderTotal()
        {
            
            this.OrderRepository.Object.Parcels.Add(ParcelFactoryHelper.CreateParcel(10,10,10,3));
            this.OrderRepository.Object.Parcels.Add(ParcelFactoryHelper.CreateParcel(10,10,10,3));
            this.OrderRepository.Object.Parcels.Add(ParcelFactoryHelper.CreateParcel(10,10,10,3));
            
            this.OrderRepository.Object.GetOrderTotal();
            Assert.AreEqual(75, this.OrderRepository.Object.OrderTotal);
        }
        
        [Test]
        public void PrintSummary()
        {
            
            this.OrderRepository.Object.Parcels.Add(ParcelFactoryHelper.CreateParcel(10,10,10,30));
            var  summary= this.OrderRepository.Object.PrintSummary();
            
            
            Assert.NotNull(summary);
        }

    }
}