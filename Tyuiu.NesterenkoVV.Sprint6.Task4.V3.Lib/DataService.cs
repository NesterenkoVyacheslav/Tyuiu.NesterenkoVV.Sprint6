using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NesterenkoVV.Sprint6.Task4.V3.Lib
{
    public class DataService : ISprint6Task4V3
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int count = 0;
            double[] doubles = new double[stopValue - startValue + 1];
            for (int i = startValue; i <= stopValue; i++)
            {
                if (Math.Sin(i) - 3 + i == 0)
                {
                    doubles[count] = 0;
                }
                else
                {
                    doubles[count] = Math.Round((3*i-1.5)/(Math.Sin(i)-3+i)+2, 2);
                }

                count++;
            }
            return doubles;
        }
    }
}
