namespace School
{
    class Parent
    {
        private int parID;
        private string parName;
        private string parPhoneNum;
        public Parent()
        {
            this.parID = 0;
            this.parName = "";
            this.parPhoneNum = "";
        }
        public Parent(int id,string name,string phoneN)
        {
            this.parID = id;
            this.parName = name;
            this.parPhoneNum = phoneN;
        }
        public Parent(Parent a)
        {
            this.parID = a.GetParID();
            this.parName = a.GetParName();
            this.parPhoneNum = a.GetParPhoneN();
        }
        public int GetParID()
        {
            return this.parID;
        }
        public string GetParName()
        {
            return this.parName;
        }
        public string GetParPhoneN()
        {
            return this.parPhoneNum;
        }
        public void SetParID(int id)
        {
            this.parID = id;
        }
        public void SetParName(string name)
        {
            this.parName = name;
        }
        public void SetParPhoneN(string phoneN)
        {
            this.parPhoneNum = phoneN;
        }
        public override string ToString()
        {
            string st = "";
            return st+="  Parent ID: "+this.parID+"  |  Parent Name: "+this.parName+"  |  Parent Phone Number: "+this.parPhoneNum+" ";
        }
      
    }
}
