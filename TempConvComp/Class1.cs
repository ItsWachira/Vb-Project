using System;
namespace TempConv
{
    public class TempConvComp
    {
        public TempConvComp()
        {

        }
        public double cToF(double c)
        {
            return (int)((c * 9 / 5.0 + 32) * 100) / 100.0;
        }
        public double fToC(double f)
        {
            return (int)((f - 32) * 5 / 9.0 * 100) / 100.0;
        }

    }
}