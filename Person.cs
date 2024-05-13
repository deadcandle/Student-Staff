
namespace Student_Staff
{
    class Person
    {
        private string name;
        private string address;
        public Person(string name, string adress)
        {
            this.name = name;
            this.address = adress;
        }
        public string getName()
        {
            return this.name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getAdress()
        {
            return this.address;
        }
        public void setAddress(string adress)
        {
            this.address = adress;
        }
        public override string ToString()
        {
            return "Person[name="+this.getName()+",address="+this.getAdress()+"]";
        }
    }
}
