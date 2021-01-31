using System;

namespace School
{
    class Stack<T>
    {
        
        private Node<T> first;
        public Stack(Node<T> node)
        {
            this.first = node;
        }
        public Stack()
        {
            this.first = null;
        }
        public Stack(T info,Node<T> next)
        {
            this.first = new Node<T>(info, next);
        }
        public Stack(Stack<T> pos)
        {
            this.first = new Node<T>(pos.first);
        }
        public Node<T> GetNode()
        {
            return this.first;
        }
        public bool IsEmpty()
        {
            return this.first == null;
        }
        public void Push(T x)
        {
            this.first = new Node<T>(x, this.first);
        }
        public T Pop()
        {
            T x = this.first.Info;
            this.first = this.first.Next;
            return x;
        }
        public T Top()
        {
            return this.first.Info;
        }
        public override string ToString()
        {
            return "Stack: "+this.GetNode();
        }
    }
}
