using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NesterenkoVV.Sprint6.Task2.V23.Lib
{
    public class DataService : ISprint6Task2V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            
            double[] doubles = new double[stopValue - startValue + 1];
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (2 * i - 2 == 0)
                {
                    doubles[count] = 0;
                }
                else
                {

                    doubles[count] = Math.Round(4 - 2 * i + (2+Math.Cos(i))/(2*i-2), 2);
                }
                count++;
            }

            return doubles;
        }
    }
}
