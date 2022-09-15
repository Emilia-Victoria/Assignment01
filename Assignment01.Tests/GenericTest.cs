namespace Assignment01.Tests;

public class GenericTest
{
    [Fact]
    public void Return_2_Given_0_1_2_3_4_7_and_3_as_x_g1()
    {
        // Arrange
        int[] items = new int[] {0,1,2,3,4,7};

        // Act
        int result = Generic.GreaterCount<int,Generic>(items, 3);

        // Assert
        result.Equals(2);
    }

    [Fact]
    public void Return_2_Given_PersonWithAge_0_1_2_3_4_7_max_3()
    {
        // Arrange
        MyPersonWithAgeAndName[] items2 = new MyPersonWithAgeAndName[] {new MyPersonWithAgeAndName(0,"Steve"),new MyPersonWithAgeAndName(1,"Steven"),new MyPersonWithAgeAndName(2,"Steels"),new MyPersonWithAgeAndName(3,"Stacy"),new MyPersonWithAgeAndName(4,"Bill"),new MyPersonWithAgeAndName(7,"Laura")};


        // Act
        int result2 = Generic.GreaterCount2<MyPersonWithAgeAndName,MyPersonWithAge>(items2, new MyPersonWithAgeAndName(3,"Isa"));

        // Assert
        result2.Equals(2);
    }
}