using CourierSolution.Factory;

namespace CourierSolution
{
    public class BaseParcel : IParcel
    {
        public double Cost { get; set; }
        
        public bool IsSpeedy { get; set; }
        public double WeightLimitCharge { get; set; }
        public double MaxWeight { get; set; }
        public double Weight { get; set; }
        public double AdditionalWeightCharge { get; set; }


        public BaseParcel(double cost, double weight, double maxWeight, double weightLimitCharge)
        {
            this.Cost = cost;
            this.Weight = weight;
            this.MaxWeight = maxWeight;
            this.WeightLimitCharge = weightLimitCharge;
            this.AdditionalWeightCharge = (this.Weight > this.MaxWeight)
                ? this.WeightLimitCharge * (this.Weight - this.MaxWeight)
                : 0.00;

        }

        public override string ToString()
        {
            return $"{this.GetType()} : ${this.Cost}";
        }

        public void AddSpeedyDelivery()
        {

            this.IsSpeedy = true;
        }
    }
}