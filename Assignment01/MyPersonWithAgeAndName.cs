public class MyPersonWithAgeAndName : MyPersonWithAge{

    private String name;
    public MyPersonWithAgeAndName(int age, String name) : base(age){

            this.name = name;
        
    }

    public String Name{
        get {return name;}
        set {name = value;}
    }
}