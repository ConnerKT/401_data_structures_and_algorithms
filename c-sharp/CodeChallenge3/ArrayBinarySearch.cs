namespace CodeChallenges
{
  public class CodeChallenge3
  {
    public static int BinarySearch(int[] array, int key)
    {
      int low = 0;
      int high = array.Length - 1;

      while (low <= high)
      {
        int mid = (low + high) / 2;

        if (key == array[mid])
        {
          return mid;
        }
        else if (key < array[mid])
        {
          high = mid - 1;
        }
        else if (key > array[mid])
        {
          low = mid + 1;
        }
      }
      return -1;
    }
  }
}
