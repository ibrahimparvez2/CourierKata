using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CourierSolution;
using CourierSolution.Interfaces;
using CourierSolution.Models;
using CourierSolution.Repository;
using Moq;
using NUnit.Framework;

namespace CourierUnitTest
{
    public   class PromotionHelperTests
    {
        private Mock<OrderRepository> OrderRepository;
        
        [SetUp]

        public void SetUp()
        {
            OrderRepository = new Mock<OrderRepository>();
        }

        [Test]
        public void SmallParcelMania()
        {

            OrderRepository.Object.Parcels.Add(new SmallParcel(1, 1, 1, 1));
            OrderRepository.Object.Parcels.Add(new SmallParcel(1, 1, 1, 1));
            OrderRepository.Object.Parcels.Add(new SmallParcel(1, 1, 1, 1));
            OrderRepository.Object.Parcels.Add(new SmallParcel(1, 1, 1, 1));
            OrderRepository.Object.Parcels.Add(new SmallParcel(1, 1, 1, 1));
            OrderRepository.Object.Parcels.Add(new SmallParcel(1, 1, 1, 1));
            

            var promo = PromotionHelper.GetPromotions(OrderRepository.Object.Parcels);
            
            Assert.AreEqual(promo.Count,2);

        }
        
        [Test]
        public void SmallMediumParcelMania()
        {

            OrderRepository.Object.Parcels.Add(new SmallParcel(1, 1, 1, 1));
            OrderRepository.Object.Parcels.Add(new SmallParcel(1, 1, 1, 1));
            OrderRepository.Object.Parcels.Add(new SmallParcel(1, 1, 1, 1));
            OrderRepository.Object.Parcels.Add(new MediumParcel(1, 1, 1, 1));
            OrderRepository.Object.Parcels.Add(new MediumParcel(1, 1, 1, 1));
            OrderRepository.Object.Parcels.Add(new MediumParcel(1, 1, 1, 1));
            OrderRepository.Object.Parcels.Add(new MediumParcel(1, 1, 1, 1));

            var promo = PromotionHelper.GetPromotions(OrderRepository.Object.Parcels);
            
            Assert.AreEqual(promo.Count,2);

        }

    }
}