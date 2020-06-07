using System.Collections;
using System.Collections.Generic;
using CourierSolution.Interfaces;

namespace CourierSolution.Repository
{
    public interface IOrderRepository
    {
        IList<IParcel> Parcels { get; set; }
        
        IList<IParcel> Promo { get; set; }
        void AddParcelToOrder();
        double OrderTotal { get; set; }
        bool IsSpeedyDelivery { get; set; }

        string PrintSummary();

    }
}