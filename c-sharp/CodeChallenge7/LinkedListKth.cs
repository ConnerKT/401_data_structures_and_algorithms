namespace CodeChallenges 
{
    public class LinkedListKth: InsertableLinkedList
    {
    public int KthFromEnd(int kthFromEnd)
    {
      //Using a two pointer approach
      if (kthFromEnd < 0 || Head == null)
      {
        throw new Exception("K is negative or invalid");
      }
      Node first = Head;
      Node second = Head;
      for (int i = 0; i < kthFromEnd - 1; i++)
      {
        if (first.Next == null)
        {
          throw new Exception("K is too large");
        }
        first = first.Next;
      }
      while (first.Next != null)
      {
        first = first.Next;
        second = second.Next;
      }

      return second.Value;
    }
    }
}