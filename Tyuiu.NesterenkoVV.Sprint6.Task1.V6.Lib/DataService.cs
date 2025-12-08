using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NesterenkoVV.Sprint6.Task1.V6.Lib
{
    public class DataService : ISprint6Task1V6
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] doubles = new double[stopValue - startValue + 1];
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                doubles[count] = Math.Round((Math.Sin(i) - 2 * i) / (3 * i - 1) + Math.Sin(i) - 3 * i + 2, 2);
                count++;
            }

            return doubles;
        }
    }
}
