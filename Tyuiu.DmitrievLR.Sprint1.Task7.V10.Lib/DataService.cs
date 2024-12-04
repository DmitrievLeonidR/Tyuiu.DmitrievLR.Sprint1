using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DmitrievLR.Sprint1.Task7.V10.Lib
{
    public class DataService : ISprint1Task7V10
    {
        public double Calculate(double x)
        {

            double z = (2* (1/Math.Tan(3*x) ) - ( (Math.Log( Math.Cos(x) ) ) / (Math.Log(1+ Math.Pow(x,2) ) ) ) );

            double result = Math.Round(z, 3);
            return z;
        }
    }
}
