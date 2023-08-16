namespace CodeChallenges
{
  public class InsertableLinkedList : LinkedList
  {

    //adds a new node with the given value to the end of the list
    public void Append(int value)
    {
      Node newNode = new Node(value);

      if (Head == null)
      {
      
        Tail = newNode;
        Head = newNode;
       
        return;
      }

      Node currentNode = Head;

      while (currentNode.Next != null)
      {
        currentNode = currentNode.Next;

      }

      currentNode.Next = newNode;
      newNode.Last = currentNode;
      Tail = newNode;

    }
    //adds a new node with the given new value immediately before the first node that has the value specified
    public void InsertBefore(int value, int valueToInsert)
    {
      Node newNode = new Node(valueToInsert);

      if (Head.Next == null && Head != null)
      {
        // List is empty, so assign newNode as the Head
        newNode.Next = Head;
        Head = newNode;
      }

      Node currentNode = Head;

      while (currentNode != null && currentNode.Next != null)
      {

        if (currentNode.Next.Value == value)
        {
          newNode.Next = currentNode.Next;
          currentNode.Next = newNode;
          break;


        }
        currentNode = currentNode.Next;
      }

    }
    public void InsertAfter(int value, int valueToInsert)
    {
      Node testnewNode = new Node(valueToInsert);
      if (Head == null)
      {
        Head = testnewNode;
        Tail = testnewNode;
        return;
      }

      Node currentNode = Head;

      while (currentNode != null)
      {
        if (currentNode.Value == value)
        {
          testnewNode.Last = currentNode;
          testnewNode.Next = currentNode.Next;

          if (currentNode.Next != null)
          {
            currentNode.Next.Last = testnewNode;
          }
          else
          {
            Tail = testnewNode;
          }

          currentNode.Next = testnewNode;
          return;
        }

        currentNode = currentNode.Next;
      }
    }

  }
}

