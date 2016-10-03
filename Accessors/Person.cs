namespace ConsoleApplication
{
    public class Person
    {
        private string _name;
        private int _age;

        public string name
        {
            set { _name = value; }
            get { return _name; }
        }

        public int age
        {
            set { _age = value; }
            get { return _age; }
        }

        public override string ToString()
        {
            return _name + ", " + _age + " jaar.";
        }
        
    }
    
}
