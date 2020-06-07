using System;
using Microsoft.VisualBasic.CompilerServices;

namespace CourierSolution.Factory
{
    public static class ParcelFactoryHelper
    {
        public static IParcel CreateParcel(double length, double width, double height, double weight)
        {

            double dimensions = length * width * height;

            if (dimensions <= 10)
            {
                return new SmallParcel(3.00,weight,1,2);
            }
            else if (dimensions <= 50)
            {
                return new MediumParcel(8.00,weight,3,2);
            }
            else if ( dimensions <= 100)
            {
                return new LargeParcel(15.00, weight, 6,2);
            }
            
            else if (dimensions >= 100)
            {
                return new XLParcel(25.00, weight,10,2);
            }

            else
            {
                throw new ArgumentException();
            }

        }
    }
}