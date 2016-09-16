public class Person
{
    private string name;
    private int age;

    public Person(string name, int age) 
    {
        this.name = name;
        this.age = age;        
    }

    public string Name
    {
        set { name = value; }
        get { return name; }
    }

    public int Age
    {
        set { age = value; }
        get { return age; }
    }

    // user defined casting
    public static explicit operator Person(int n)
    {
        return new Person("No Name", n);
    }


}
