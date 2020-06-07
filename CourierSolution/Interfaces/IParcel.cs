namespace CourierSolution.Interfaces
{
    public interface IParcel
    {
        double Cost { get; set; }
        double WeightLimitCharge { get; set; }
        double MaxWeight { get; set; }
        double Weight { get; set; }

        double AdditionalWeightCharge { get; set; }

        bool IsParcelLimit { get; set; }
    }
}