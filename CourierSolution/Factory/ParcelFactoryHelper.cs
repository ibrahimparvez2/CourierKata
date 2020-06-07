using System;
using Microsoft.VisualBasic.CompilerServices;

namespace CourierSolution.Factory
{
    public static class ParcelFactoryHelper
    {
        public static IParcel CreateParcel(double length, double width, double height)
        {

            double dimensions = length * width * height;

            if (dimensions <= 10)
            {
                return new SmallParcel(3.00);
            }
            else if (dimensions <= 50)
            {
                return new MediumParcel(8.00);
            }
            else if ( dimensions <= 100)
            {
                return new LargeParcel(15.00);
            }
            
            else if (dimensions >= 100)
            {
                return new XLParcel(25.00);
            }

            else
            {
                throw new ArgumentException();
            }

        }
    }
}