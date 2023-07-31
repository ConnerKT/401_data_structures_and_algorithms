using System;

namespace CodeChallenges
{
  public class Node
  {
    public int Value { get; set; }
    public Node Next { get; set; }

    public Node(int value)
    {
      Value = value;
      Next = null;
    }

  }

  public class Stack
  {
    private Node Top { get; set; }
    //Defining stack class
    public Stack(Node node)
    {
      Top = node;
    }
    //push method
    public void Push(int value)
    {
      Node newNode = new Node(value);
      newNode.Next = Top;
      Top = newNode;
      
    }
    //Pop Method
    public int Pop()
    {
     
      if (Top == null)
      {
        throw new Exception("Your stack is Empty...");
      }else
      {
        int currentValue;
        currentValue = Top.Value;
        Top = Top.Next;
        return currentValue;

      }
    }
    //Peek  (returns the value of the top node)
    public int Peek()
    {
      return Top.Value;
    }


  }

  public class Queue
  {
    //node(s)? front? back?
    public Node Front { get; set; }

    public Node Back { get; set; }
    //constructor . take in a value for the first node
    public Queue()
    {
      Front = null;
      Back = null;
    }

    public Queue(Node node)
    {
      Front = node;
      Back = node;
    }
    //enqueue ( value ) . add value to the queue
    public void Enqueue(int value)
    {
      Node newNode = new Node(value);

      if (Front == null) // empty queue -> 1
      {
        Front = newNode;
        //Back = newNode;
        return;
      }
      else if (Back == null) // 1 -> 2
      {
        Back = newNode;
        Front.Next = Back;
        return;
      }

      //2+ -> 
      Back.Next = newNode; //Add new value to back of the line
      Back = newNode; //set newValue as the Back
    }

    //dequeue . returns the first value in the queue and removes it
    //peek . returns the first value in the queue
    public int Peek()
    {
      if (Front == null)
      {
        throw new InvalidOperationException("Empty~~~ D:");
      }
      return Front.Value;
    }
    //dequeue . returns the first value in the queue and removes it
   
    //isempty . return true or false if the queue is empty get shmoney
  }
}
