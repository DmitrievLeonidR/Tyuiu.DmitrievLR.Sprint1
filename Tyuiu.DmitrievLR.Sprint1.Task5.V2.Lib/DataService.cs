using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DmitrievLR.Sprint1.Task5.V2.Lib
{
    public class DataService : ISprint1Task5V2
    {
        public int FahrenheitToСelsius(double temp)
        {
            double CelsiRes = ( (temp-32) *5) / 9 ;
            int result = Convert.ToInt32(CelsiRes);
            return result;
        }
    }
}
