using System;

namespace Bead
{
    class Bead
    {
        private char size;
        private string color;
        private Bead next;
        public Bead(char size, string color)
        {
            this.size = size;
            this.color = color;
            this.next = null;
        }
        public Bead(char size, string color, Bead bead)
        {
            this.size = size;
            this.color = color;
            this.next = bead;
        }
        public Bead(char size)
        {
            this.size = size;
            this.next = null;
        }
        public Bead(char size, Bead bead)
        {
            this.size = size;
            this.next = bead;
        }
        public Bead(Bead bead)
        {
            this.size = bead.GetSize();
            this.color = bead.GetColor();
            this.next = bead.GetNextBead();
        }
        public char GetSize()
        {
            return this.size;
        }
        public string GetColor()
        {
            return this.color;
        }
        public Bead GetNextBead()
        {
            return this.next;
        }
        public void SetSize(char ch)
        {
            this.size = ch;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
        public void SetNextBead(Bead bead)
        {
            this.next = bead;
        }
        public override string ToString()
        {
            string st = "";
            return st = "Size: " + this.size +"\n"+this.next /*" Color: " + this.color*/;
        }
        class IntNode
        {
            private int info;
            private IntNode next;

            public IntNode(int info)
            {
                this.info = info;
                this.next = null;
            }
            public IntNode(int info, IntNode a)
            {
                this.info = info;
                this.next = a;
            }
            public int GetInfo()
            {
                return this.info;
            }
            public IntNode GetNext()
            {
                return this.next;
            }
            public void SetInfo(int info)
            {
                this.info = info;
            }
            public void SetNext(IntNode a)
            {
                this.next = a;
            }
            public static IntNode AddNode(IntNode pos, int a)//function for add a organ in to the list
            {
                IntNode c = new IntNode(a, pos.GetNext());
                pos.SetNext(c);
                return pos;
            }
            public static IntNode DelNode(IntNode pos)// function for delete a organ in the list
            {
                IntNode a = pos.GetNext();
                pos.SetNext(pos.GetNext().GetNext());
                a.SetNext(null);
                return a;
            }

            public static int LenNode(IntNode allList)// this function return the length node
            {
                int count = 0;
                while (allList.GetNext() != null)
                {
                    allList = allList.GetNext();
                    count++;
                }
                return count;
            }
            public static int LenNodeR(IntNode allList)// this Recursive function return the length node
            {
                if (allList.GetNext() == null)
                    return 0;
                else
                {
                    allList = allList.GetNext();
                    return 1+LenNodeR(allList);
                }
                
            }
            public static void AddNodeA(IntNode a, int x)
            {
                bool flag = true;
                while (a.GetNext() != null)
                {
                    if (x > a.GetInfo() && x <= a.GetNext().GetInfo())
                    {
                        IntNode c = new IntNode(x, a.GetNext());
                        a.SetNext(c);
                        a = c;
                        flag = false;
                    }
                    else if (x <= a.GetInfo() && flag)
                    {
                        IntNode c = new IntNode(a.GetInfo(), a.GetNext());
                        a.SetInfo(x);
                        a.SetNext(c);
                        flag = false;
                    }
                    a = a.GetNext();
                }
                if (x > a.GetInfo() && flag)
                {
                    IntNode p = new IntNode(x);
                    a.SetNext(p);
                }
            }
            public override string ToString()
            {
                string st = "";
                return st = "Info :" + this.info + "\n" + this.next;
            }
           
            static void Main(string[] args)
            {
                Bead a1 = new Bead('L');//create list
                Bead b = new Bead('M', a1);
                Bead c = new Bead('S', b);
                Bead d = new Bead('M',  c);
                Bead e = new Bead('M', d);
                Bead e2 = new Bead('M',e);
                Console.WriteLine(e2);
                
                /*Bead add = new Bead(new Bead('S', "blue", new Bead('M', "green", new Bead('L', "yellow"))));
                IntNode a = new IntNode(2, new IntNode(3, new IntNode(5)));
                AddNodeA(a,5);
                Console.WriteLine(a);
                a= AddNode(a, 4);
                Console.WriteLine(LenNodeR(a));
              Console.WriteLine(a);
                IntNode p = DelNode(a);
                Console.WriteLine(p);
                Console.WriteLine(a);
                Console.WriteLine(LenNode(p));*/
                
            
            }
          
        }

    }
}
