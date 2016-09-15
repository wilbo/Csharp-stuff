public class Person
{
    private string _name;
    private int _age;

    public Person(name, age) {
        _name = name;
        _age = age;        
    }


    public static explicit operator Person(int n)
    {
        return new Person("No Name", n);
    }


}
