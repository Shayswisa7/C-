using System;
using System.Collections.Generic;
using System.Text;


namespace School
{
    class List<T>
    {
        private Node<T> first;

        public List(Node<T> first)
        {
            this.first = first;
        }
        //public Node<T> First { get => first; set => first=value; }
        public List(List<T> first)
        {
            this.first =new Node<T>(first.GetNode());
        }
        public  Node<T> GetNode()
        {
            return this.first;
        }
        public Node<T> Insert(Node<T> pos,T x)
        {
            
           return pos = new Node<T>(x, pos);
        }
        public Node<T> Remove(Node<T> pos)
        {
            if (this.first.Next == null)
            {
                if (this.first != pos)
                    return this.first;
                return null;
            }
            if (this.first == pos)
            {
                this.first = this.first.Next;
                return Remove(pos);
            }
            T a = this.first.Info;
            this.first = this.first.Next;
             return new Node<T>(a,Remove(pos));
           
        }
        public override string ToString()
        {
            string st = "";
            return st+=this.first;
        }
    }
}
