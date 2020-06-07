using System;
using System.Collections.Generic;
using CourierSolution.Interfaces;

namespace CourierSolution.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public IList<IParcel> Parcels { get; set; }
        public IList<IParcel> Promo { get; set; }


        public void AddParcelToOrder()
        {
            throw new System.NotImplementedException();
        }

        public double OrderTotal { get; set; }
        public bool IsSpeedyDelivery { get; set; }
        
        
        public string PrintSummary()
        {
            string summary = "";
            foreach (var parcel in this.Parcels)
            {
                summary+= "\n"  + parcel.ToString() ;
            }

            return summary;
        }

        public OrderRepository()
        {
            Parcels = new List<IParcel>();    
        }

        public void AddParcelToOrder(IParcel parcel)
        {
            this.Parcels.Add(parcel);
        }

        public void GetOrderTotal()
        {
            foreach (var parcel in this.Parcels)
            {
              this.OrderTotal += parcel.Cost + parcel.AdditionalWeightCharge;
            }
            
        }
    }
}