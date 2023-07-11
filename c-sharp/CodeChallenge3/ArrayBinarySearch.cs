namespace CodeChallenges 
{
    public class CodeChallenge3
    {
        public static int BinarySearch(int[] array, int key)
        {
      int low = 0;
      int mid = array.Length / 2;
      int high = array.Length - 1;
      if (key == array[mid])
      {
        return mid;
      }
      else if (key < array[mid])
      {
        high = mid - 1;
        mid = (low + high) / 2;
      }
      else if (key > array[mid])
      {
        low = mid + 1;
        mid = (low + high) / 2;
      }
        }

    }
}