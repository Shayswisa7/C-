using System;

namespace School
{
    class Queue<T>
    {
        private Node<T> first;
        private Node<T> last;
        public Queue()
        {
            this.first = this.last = null;
        }
        public bool IsEmpty()
        {
            return this.last != null;
        }
        public void Insert(T x)
        {
            if (!IsEmpty())
            {
                this.last = new Node<T>(x);
                this.first = this.last;
            }
            else if(x!=null)
            {
                this.last.Next = new Node<T>(x);
                this.last = this.last.Next;
            }
        }
        public T Remove()
        {
            T newT = this.first.Info;
            this.first = this.first.Next;
            return newT;
        }
        public T Head()
        {
            return this.first.Info;
        }
        public override string ToString()
        {
            return "obj: \n"+this.first;
        }
    }
}
