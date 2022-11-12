using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Proj3_Calculator
{
  internal class MyStack<T>
  {
    private T[] data;
    private int top = -1;

    public MyStack() : this(1000)
    {
    }
    public MyStack(int capacity)
    {
      data = new T[capacity];
    }

    public int getSize()
    {
      return top + 1;
    }
    public bool isEmpty()
    {
      return top == -1;
    }
    public void Push(T d)
    {
      if (getSize() == data.Length) throw new Exception("stack is full");
      data[++top] = d;
    }
    public T Peek()
    {
            if (!this.isEmpty())
                return data[top];
            else
                throw new Exception("Stack is Empty");
    }
    public T Pop()
    {
            if (this.isEmpty()) throw new Exception("Null");
      T answer;
      answer = data[top];
      //data[top] = null ;
      top--;
      return answer;

    }


  }
}
