using CourierSolution.Factory;

namespace CourierSolution
{
    public class BaseParcel : IParcel
    {
        public double Cost { get; set; }


        public BaseParcel(double cost)
        {

            this.Cost = cost;
        }

        public override string ToString()
        {
            return $"{this.GetType()} : ${this.Cost}";
        }
    }
}