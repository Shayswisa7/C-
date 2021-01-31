using System;

namespace School
{
    class Student
    {
        private int stuID;
        private string stuName;
        private string stuPhoneNum;
        private Parent parentOfStu;
        public Student(int id, string name, string phone)
        {
            this.stuID = id;
            this.stuName = name;
            this.stuPhoneNum = phone;
            this.parentOfStu = new Parent();
        }
        public Student(int id, string name, string phone, Parent par)
        {
            this.stuID = id;
            this.stuName = name;
            this.stuPhoneNum = phone;
            this.parentOfStu = par;
        }
        public Student(Student a)
        {
            this.stuID = a.GetStuID();
            this.stuName = a.GetStuName();
            this.stuPhoneNum = a.GetStuPhoneN();
            this.parentOfStu = new Parent(a.GetParentOfStu());
        }
        public int GetStuID()
        {
            return this.stuID;
        }
        public string GetStuName()
        {
            return this.stuName;
        }
        public string GetStuPhoneN()
        {
            return this.stuPhoneNum;
        }
        public Parent GetParentOfStu()
        {
            return this.parentOfStu;
        }
        public void SetStuID(int id)
        {
            this.stuID = id;
        }
        public void SetStuName(string name)
        {
            this.stuName = name;
        }
        public void SetStuPhoneN(string phoneN)
        {
            this.stuPhoneNum = phoneN;
        }
        public void SetParentOfStu(Parent par)
        {
            this.parentOfStu = par;
        }
        public override string ToString()
        {
            string st = "";
            return st += "Student:\tStudent ID: " + this.stuID + "  |  Student Name: " + this.stuName + "  |  Phone Number: " + this.stuPhoneNum + "  Parent Of Student: " + this.parentOfStu;
        }
    }    
}