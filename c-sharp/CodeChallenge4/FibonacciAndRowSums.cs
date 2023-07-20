namespace CodeChallenges 
{
    public class CodeChallenge4
    {
        public static int GetNthNumberInFibonacciSequence(int nthNumberInSequence)
        {
            int result = 0;

            return result;
        }

        public static int[] RowSums(int[][] matrix)
        {
            int[] rowSums = new int[matrix.Length];

        for (int i =0; i < matrix.Length;i++)
      {
        int sum = 0;
          for (int k = 0; k < matrix[i].Length;k++)
          {
            sum += matrix[i][k];
          }
          rowSums[i] = sum;
        }
            
            return rowSums;
        }

    }
}