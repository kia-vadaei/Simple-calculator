using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Proj3_Calculator
{
  internal class Stack<T>
  {
    private T[] data;
    private int top = -1;

    public Stack() : this(1000)
    {
    }
    public Stack(int capacity)
    {
      data = new T[capacity];
    }

    public int size()
    {
      return top + 1;
    }
    public bool isEmpty()
    {
      return top == -1;
    }
    public void push(T d)
    {
      if (size() == data.Length) throw new Exception("stack is full");
      data[++top] = d;
    }
    public T peek()
    {
      if (!this.isEmpty())
        return data[top];
      else
        throw new Exception("Null");
    }
    public T pop()
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
