namespace CourierSolution.Factory
{
    public interface IParcel
    {
        double Cost { get; set; }

        bool IsSpeedy { get; set; }
        double WeightLimitCharge { get; set; }
        double MaxWeight { get; set; }
        double Weight { get; set; }

        double AdditionalWeightCharge { get; set; }
    }
}