
namespace Student_Staff
{
    class Staff : Person
    {
        private string school;
        private double pay;
        public Staff(string name, string address, string school, double pay) : base(name, address)
        {
            this.setName(name);
            this.setAddress(address);
            this.school = school;
            this.pay = pay;
        }
        public string getSchool()
        {
            return this.school;
        }
        public void setSchool(string school)
        {
            this.school = school;
        }
        public double getPay()
        {
            return this.pay;
        }
        public void setPay(double pay)
        {
            this.pay = pay;
        }
        public override string ToString()
        {
            return "Student[Person[name=" + this.getName() + ",address=" + this.getAdress() + "],school="+this.getSchool()+",pay="+this.getPay()+"]";
        }
    }
}
