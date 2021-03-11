using System;

namespace CastroInterpolation
{
    public static class CastroInterpolation
    {
        public static decimal? CalculateInterpolation(decimal x1, decimal y1, decimal x2, decimal y2, decimal x3, int precision = 4){
            try
            {
                decimal param;

                if(x2 == x1)
                    param = 0;
                else 
                    param = (x3 - x1) / (x2 - x1);

                    return Math.Round(y1 + param * (y2 - y1), precision);
            }
            catch (System.Exception)
            {
                return null;
            }
        }
    }
}
