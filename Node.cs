using System;


namespace School
{
    class Node<T>
    {
       
        private T info;
        private Node<T> next;
        public Node(T info)
        {
            this.Info = info;
            this.Next = null;
        }
        public Node(T info,Node<T> a)
        {
            this.Info = info;
            this.Next = a;
        }
        public Node(Node<T> a)
        {
            if (a.Next.Next == null)
            {
                this.info = a.Info;
                this.next = new Node<T>(a.Next.Info);
            }
            else
            {
                this.info = a.Info;
                this.next = new Node<T>(a.Next);
            }
        }
        public T Info { get => info; set => info = value; }
        public Node<T> Next { get => next; set => next = value; }
        public int LenNode()// פונקצייה לחישוב אורך של חוליה
        {
            if (this.Next == null)
            {
                return 1;
            }
            return this.Next.LenNode() + 1;
        }
        public Node<Student> Full(Node<Student> a)
        {
            return null;
        }
        public string Mystery(Node<T> a)
        {
            if (a.Next == null)
            {
                return a.Info.ToString();
            }
            return Mystery(a.Next) + "," + a.Info;
        }
        public static Student Find(StudentList stuList,int id,int i)
        {
            if(stuList==null)
               return null;
            if (stuList.GetAllStudent()[i].GetStuID() == id)
                return stuList.GetAllStudent()[i];
            return Find(stuList, id,i);
        }

        public static void What_i_ame_doing(Node<int> p, int n)
        {// הפונקצייה מזיזה את האיבר השני מ פעמים קדימה 
            
            Node<int> pos;
            while (n != 0 && p.Next.Next != null)
            {
                pos = p.Next;
                p.Next=pos.Next;
                pos.Next=p.Next.Next;
                p.Next.Next=pos;
                n--;
                p = p.Next;
            }
        }
        public override string ToString()
        {
            string st = "\n|Info :\n";
            if (this.next != null)
            {
                st +=  this.info +"  "+(char)4+"---->\n" + this.next;
            }
            else
                st += this.info+"  "+(char) 4+"----> Null|\n";
            return st ;
        }
       
    }
}
