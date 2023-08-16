using System.Collections.Generic;
namespace CodeChallenges
{
  public class CodeChallenge8
  {
    public static LinkedListKth ZipLists(LinkedListKth list1, LinkedListKth list2)
    {
      //the new list we want to return
      LinkedListKth result = new LinkedListKth();
      //Setting the current nodes to each to our linked list
      Node node1 = list1.Head;
      Node node2 = list2.Head;
      //While they are null, we will keep adding them to the list, null is the end
      while(node1 != null || node2 != null)
      {
        //We want to make sure it isn't null
        if (node1 != null)
        {
          //We add it to the list
          result.Append(node1.Value);
          //And then we go next
          node1 = node1.Next;
        }
        if (node2 != null)
        {
          //We add it to the list
          result.Append(node2.Value);
          //And then we go next
          node2 = node2.Next;
        }
      }
      return result;
    }
  }
}