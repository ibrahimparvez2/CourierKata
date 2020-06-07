using System;
using CourierSolution.Factory;
using CourierSolution.Repository;

namespace CourierSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Courier Solution");

            var mediumParcel = ParcelFactoryHelper.CreateParcel(4, 2, 2,20);
            var smallParcel =  ParcelFactoryHelper.CreateParcel(1, 1, 1, 3);
            
            OrderRepository orderRepository = new OrderRepository();
            
            orderRepository.AddParcelToOrder(mediumParcel);
            orderRepository.AddParcelToOrder(smallParcel);
            
            Console.WriteLine((orderRepository.PrintSummary()));

            Console.ReadLine();

        }
    }
}