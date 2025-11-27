using System.Linq;
using System.Runtime.InteropServices;

namespace Lab5
{
    public class White
    {
        public double Task1(int[,] matrix)
        {
            double average = 0;

            // code here
            double srz = 0;
            double pe = 0;
            double count = 0;
            for (int i = 0;i < matrix.GetLenght(0); i++)
            {
                for (int j = 0; j < matrix.GetLenght(1); j++)
                {
                    if matrix[i, j] > 0{
                        pe += matrix[i, j];
                        count += 1;
                    }
                }
            }
            if (count > 0) 
            {
                srz = pe / count;
            }
            average = srz;
            // end

            return average;
        }
        public (int row, int col) Task2(int[,] matrix)
        {
            int row = 0, col = 0;

            // code here

            // end

            return (row, col);
        }
        public void Task3(int[,] matrix, int k)
        {

            // code here

            // end

        }
        public int[,] Task4(int[,] matrix)
        {
            int[,] answer = null;

            // code here

            // end

            return answer;
        }
        public int Task5(int[,] matrix)
        {
            int sum = 0;

            // code here

            // end

            return sum;
        }
        public void Task6(int[,] matrix)
        {

            // code here

            // end

        }
        public int[] Task7(int[,] matrix)
        {
            int[] negatives = null;

            // code here

            // end

            return negatives;
        }
        public void Task8(int[,] matrix)
        {

            // code here

            // end

        }
        public void Task9(int[,] matrix)
        {

            // code here

            // end

        }
        public void Task10(int[,] matrix)
        {

            // code here

            // end

        }
        public int[,] Task11(int[,] matrix)
        {
            int[,] answer = null;

            // code here

            // end

            return answer;
        }
        public void Task12(int[][] array)
        {

            // code here

            // end

        }
    }
}