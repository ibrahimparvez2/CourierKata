namespace CourierSolution.Models
{
    public class LargeParcel : BaseParcel
    {
        public LargeParcel(double cost, double weight, double maxWeight, double weightLimitCharge) : base(cost, weight, maxWeight, weightLimitCharge)
        {
        }
    }
}