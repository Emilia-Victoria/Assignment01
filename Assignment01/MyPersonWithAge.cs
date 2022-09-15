public class MyPersonWithAge : IComparable<MyPersonWithAge>{

    private int age;


    public MyPersonWithAge(int age){
        this.age = age;

    }

    public int Age {
        get {return age;}
        set {age = value;}
    }

    public int CompareTo(MyPersonWithAge person2){

        if (this.Age > person2.Age){
            return 1;

        }
        if (this.Age < person2.Age){
            return -1;

        }
        return 0;

    }

}