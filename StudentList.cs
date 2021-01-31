using System;

namespace School
{
    class StudentList
    {
        private int pos;
        public const int Max = 40;
        private Student[] allStudent;
         public StudentList()
         {
             this.pos = 0;
             this.allStudent = new Student[Max];
         }
        public StudentList(StudentList a)
        {
            this.pos = 0;
            this.allStudent = new Student[Max];
            for (int i = 0; i < a.GetPos(); i++)
            {
                this.allStudent[i] = new Student(a.GetAllStudent()[i]);
            }
        }
         public void SetPos(int p)
         {
             this.pos = p;
         }
         public int GetPos()
         {
             return this.pos;
         }

         public Student[] GetAllStudent()
         {
            return this.allStudent;
         }
         public int GetStudentsByID(int id)
         {
             for (int i = 0; i < this.allStudent.Length; i++)

                 if (id == allStudent[i].GetStuID())
                     return i + 1;
             return -1;
         }
         public void AddStu(Student a)//הוספת סטודנט לרשימה וקליטת הורה הסטודנט
         {
             if (this.pos == 0)
                 this.allStudent[this.pos++] = new Student(a.GetStuID(), a.GetStuName(), a.GetStuPhoneN(), a.GetParentOfStu());
             else
             {

                 if (a.GetStuName().CompareTo(this.allStudent[this.pos - 1].GetStuName()) == 1)
                     this.allStudent[this.pos++] = new Student(a.GetStuID(), a.GetStuName(), a.GetStuPhoneN(), a.GetParentOfStu());
                 else if (a.GetStuName().CompareTo(this.allStudent[this.pos - 1].GetStuName()) == -1)
                 {
                     this.allStudent[this.pos++] = new Student(a.GetStuID(), a.GetStuName(), a.GetStuPhoneN(), a.GetParentOfStu());
                     for (int i = this.pos - 1; i >= 0; i--)
                     {
                         if (a.GetStuName().CompareTo(this.allStudent[i].GetStuName()) == -1)
                         {
                             this.allStudent[i + 1] = this.allStudent[i];
                             this.allStudent[i] = new Student(a.GetStuID(), a.GetStuName(), a.GetStuPhoneN(), a.GetParentOfStu());
                         }
                     }
                 }
                 else
                     this.allStudent[this.pos++] = new Student(a.GetStuID(), a.GetStuName(), a.GetStuPhoneN(), a.GetParentOfStu());
             }
         }
         public void DelStu(int id)// claer a student from the list by id
         {
             bool flag = false;
             for (int i = 0; i < this.allStudent.Length; i++)
             {
                if (this.allStudent[i].GetStuID() == id || flag && i<this.allStudent.Length-1)
                {
                    if (this.allStudent[i + 1] == null)
                    {
                        this.allStudent[i] = null;
                        i = this.allStudent.Length;
                    }
                    else 
                    {
                        flag = true;
                        this.allStudent[i] = this.allStudent[i + 1];
                    }
                }
                 else
                    if( i == this.allStudent.Length - 1)
                        this.allStudent[i] = null;
             }
         }

         public override string ToString()
         {
             string st = "____________StudentList____________\n\n";
             for (int i = 0; i < Max; i++)
             {
                 if (this.allStudent[i] != null)
                     st += "Student number : " + (i + 1) + "\n" + this.allStudent[i] + "\n";
             }
             return st;
         }
    }
}
