using System.Collections;
using System.Collections.Generic;
using CourierSolution.Interfaces;

namespace CourierSolution.Repository
{
    public interface IOrderRepository
    { 
        IList<IParcel> Parcels { get; set; }
        IList<IParcel> Promo { get; set; }
        double OrderTotal { get; set; }
        bool IsSpeedyDelivery { get; set; }
        void AddParcelToOrder(IParcel parcel);
        string PrintSummary();

    }
}