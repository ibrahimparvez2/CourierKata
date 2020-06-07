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
                return new SmallParcel();
            }
            else if (dimensions <= 50)
            {
                return new MediumParcel();
            }
            else if ( dimensions <= 100)
            {
                return new LargeParcel();
            }
            
            else if (dimensions >= 100)
            {
                return new XLParcel();
            }

            else
            {
                throw new ArgumentException();
            }

        }
    }
}