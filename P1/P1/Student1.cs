namespace P1
{
    internal class Student1
    { 

        //Variable names
    private string firstName;
    private string lastName;
    private string streetAddress;
    private string state;
    private string zipCode;

    public Student1()
    {
        firstName = "";
        lastName = "";
        streetAddress = "";
        state = "";
        zipCode = "";
    }
    public Student1(string firstName, string lastName, string streetAddress, string state, string zipCode)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.streetAddress = streetAddress;
        this.state = state;
        this.zipCode = zipCode;
    }


    public string getInfo()
    {
        return firstName + lastName + streetAddress + state + zipCode;
    }
        public string Name { get; set; }

        public int MyProperty { get; set; }
        public int MyProperty { get; set; }
       
    }
}