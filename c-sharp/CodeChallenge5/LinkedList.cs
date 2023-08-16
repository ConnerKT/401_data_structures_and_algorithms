namespace CodeChallenges
{
  public class LinkedList
  {
    public Node Head { get; set; }
    public Node Tail { get; set; }
    public Node CurrentNode { get; set; }

    public void Insert(int value)

    {
      //Adds a new node with that value to the head of the
      Node Node = new Node(value);
        
      if (Head == null)
      {
        Head = Node;
      }
      else
      {
        Node.Next = Head;
        Head = Node;
      }

    }
    public bool Includes(int value)
    {
      //returns true if that value exists as a node's value somewhere within the list
      //We have to check every element in the list
      bool result = false;

      Node currentNode = Head;

      while (currentNode != null)
      {
        if (currentNode.Value == value)
        {
          result = true;
          break;
        }
        currentNode = currentNode.Next;
      }

      return result;
    }
    public string ToString()
    {
      string liststring = "";
      Node currentNode = Head;

      while (currentNode != null)
      {
        liststring += String.Format("{0} -> ", currentNode.Value);
        currentNode = currentNode.Next;
      }

      return liststring + "NULL";
    }
  }

  public class Node
  {
    public int Value { get; set; }
    public Node Next { get; set; }
    public Node Last { get; set; }

    public Node(int value)
    {
      Value = value;
      Next = null;
    }
  }
}
