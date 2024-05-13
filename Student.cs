
namespace Student_Staff
{
    class Student : Person
    {
        private string program;
        private int year;
        private double fee;
        public Student(string name, string address, string program, int year, double fee) : base(name, address)
        {
            this.setName(name);
            this.setAddress(address);
            this.program = program;
            this.year = year;
            this.fee = fee;
        }
        public string getProgram()
        {
            return this.program;
        }
        public int getYear()
        {
            return this.year;
        }
        public double getFee()
        {
            return this.fee;
        }
        public override string ToString()
        {
            return "Student[Person[name=" + this.getName() + ",address=" + this.getAdress() + "],program=" + this.getProgram() + ",year=" + this.getYear() + ",fee=" + this.getFee() + "]";
        }
    }
}
