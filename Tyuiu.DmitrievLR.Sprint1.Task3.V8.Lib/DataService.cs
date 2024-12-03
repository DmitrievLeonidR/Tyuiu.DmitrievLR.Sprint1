using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DmitrievLR.Sprint1.Task3.V8.Lib
{
    public class DataService : ISprint1Task3V8
    {
        public double IncomeAmount(double startAmount, double percent, double timeDays)
        {

            double dailyRate = percent / 100 / 365;
            double totalIncomeAmount = Math.Round((startAmount * dailyRate * timeDays), 3);
            
        
            return totalIncomeAmount;  
        }
    }
}
