using System;

namespace School
{
    class MainProgram
    {
        public void CreatAndShowObjects()
        {
            Queue<Student> a = new Queue<Student>();
            Node<Student> t1 = new Node<Student>(new Student(40, "shay swisa", "054-7996239", new Parent(59545983, "Tamar Swisa", "054-8310931")));
            for (int i = 500; i > 0; i--)
                t1 = new Node<Student>(new Student(i, "shay swisa"+(char)(i+'a'), "054-7996239", new Parent(59545983, "Tamar Swisa", "054-8310931")), t1);
            for (int i = 0; i < 500; i++)
            {
                a.Insert(t1.Info);
                t1 = t1.Next;
            }
            Console.WriteLine(a.Remove());
            Console.WriteLine("____________________");
            Console.WriteLine(a);
        }
        public static void Main(string[] args)
        {
           new MainProgram().CreatAndShowObjects();
        }
    }

    /* _____________________________________________________________________________________________________________
     *                                                                 יצירה והדפסת תור של סטודנטים
     *   Queue<Student> a = new Queue<Student>();     
            Node<Student> t1 = new Node<Student>(new Student(40, "shay swisa", "054-7996239", new Parent(59545983, "Tamar Swisa", "054-8310931")));
            for (int i = 5; i > 0; i--)
                t1 = new Node<Student>(new Student(i, "shay swisa", "054-7996239", new Parent(59545983, "Tamar Swisa", "054-8310931")), t1);
            for (int i = 0; i < 5; i++)
            {
                a.Insert(t1.Info);
                t1 = t1.Next;
            }
            Console.WriteLine(a.Head());
            Console.WriteLine("____________________");
            Console.WriteLine(a);
            Stack<int> stak = new Stack<int>(new Node<int>(1));                           יצירה והדפסת מחסנית של מספרים שלמים
            for (int i = 1; i < 7; i++)
            {
                stak.Push(i+1); 
            }
            stak.Pop();
            stak.Pop();
            Console.WriteLine(stak);
     * _____________________________________________________________________________________________________________
     * 
            //   אופציות לייצירת חוליות גנריות לשימוש בפונקציות 

     Student t = new Student(302859913, "shay swisa", "054-7996239", new Parent(59545983, "dad of student", "054-8558931"));
     Node<Student> asd = new Node<Student>(t);
     StudentList t1 = new StudentList();
     for (int i = 0; i < t1.GetAllStudent().Length; i++)
         t1.AddStu(new Student(i + 1, "shay swisa", "054-7996239", new Parent(59545983, "Tamar Swisa", "054-8310931")));
     StudentList t3 = new StudentList(t1);
     t1.DelStu(3);
     t1.DelStu(7);
     Console.WriteLine(t1);
     Console.WriteLine(t3);

    Node<int> a = new Node<int>(7);
    Node<int> a1 = new Node<int>(6,a);
    Node<int> a2 = new Node<int>(5, a1);
    Node<int> a3 = new Node<int>(4, a2);
    Node<int> a4 = new Node<int>(3, a3);   //       חוליות גנריות 
    Node<int> a5 = new Node<int>(2, a4);
    Node<int> a6 = new Node<int>(1, a5);


    Node<int> b = new Node<int>(7, a3);
    Node<int> b1 = new Node<int>(8, b);     //       זוג חוליות המצביעות על אמצע החולייה הקודמת

    Node<char> c = new Node<char>('a');
    Node<char> c1 = new Node<char>('p', c);
    Node<char> c2 = new Node<char>('f', c1);
    Node<char> c3 = new Node<char>('a', c2);  //    חוליה גנרית לתווים 
    Node<char> c4 = new Node<char>('a', c3);
    Node<char> c5 = new Node<char>('c', c4);
    Disconnect(a6,b1);
    a2.Info *= 100;
    b.Next.Next.Next.Next.Info *= 7000%22;
    Console.WriteLine(b1);
    Console.WriteLine(a6);             
     _____________________________________________________________________________________________________________
                                                                  יצירת חולייה של 40 סטודנטים
    
             Node<Student> a = new Node<Student>(new Student(302859913, "shay swisa", "054-7996239", new Parent(59545983, "dad of student", "054-8558931")));
            Console.WriteLine(a);
            //   אופציות לייצירת חוליות גנריות לשימוש בפונקציות 


             Node<Student> t1 = new Node<Student>(new Student(40, "shay swisa", "054-7996239", new Parent(59545983, "Tamar Swisa", "054-8310931")));

             for (int i = 39; i > 0; i--)
                 t1 = new Node<Student>(new Student(i, "shay swisa", "054-7996239", new Parent(59545983, "Tamar Swisa", "054-8310931")),t1);
             List<Student> t3 = new List<Student>(t1);
             Node<Student> t4 = t1.Next.Next.Next.Next.Next.Next.Next;
             t3=new List<Student>(t3.Remove(t4));
             Console.WriteLine(t3.Insert(t3.GetNode(),t4.Info));
             t3= new List<Student>(t3.Insert(t3.GetNode(), t4.Info));
             Console.WriteLine(t3);
            Stack<Student> pos = new Stack<Student>(new Node<Student>(new Student(1, "shay swisa", "054-7996239", new Parent(59545983, "Tamar Swisa", "054-8310931"))));
            Stack<Student> pos2 = new Stack<Student>(new Node<Student>(new Student(2, "shay swisa", "054-7996239", new Parent(59545983, "Tamar Swisa", "054-8310931")), pos.GetNode()));
            Console.WriteLine(pos2.IsEmpty());

            Stack<Student> pos3 = new Stack<Student>();
            Console.WriteLine(pos3.IsEmpty());
            
    */

}
