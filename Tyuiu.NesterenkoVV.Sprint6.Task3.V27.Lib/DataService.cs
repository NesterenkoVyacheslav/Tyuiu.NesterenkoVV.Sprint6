using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NesterenkoVV.Sprint6.Task3.V27.Lib
{
    public class DataService : ISprint6Task3V27
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[] mat = new int[matrix.GetLength(0)];
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                mat[count] = matrix[i, 3];
                count++;
            }
            int temp;
            for (int i = 0; i < mat.Length - 1; i++)
            {
                for (int j = i + 1; j < mat.Length; j++)
                {
                    if (mat[i] > mat[j])
                    {
                        temp = mat[i];
                        mat[i] = mat[j];
                        mat[j] = temp;
                    }
                }
            }
            int k = 0;
            for (int i = 0;i < matrix.GetLength (0); i++) 
            {
                matrix[i, 3] = mat[k];
                k++;
            }
            return matrix;
        }
    }
}
