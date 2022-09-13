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

    public void Return_2_Given_0_1_2_3_4_7_and_3_as_x_g2()
    {
        // Arrange
        int[] items2 = new int[] {0,1,2,3,4,7};

        // Act
        int result2 = Generic.GreaterCount2<int,int>(items2, 3);

        // Assert
        result2.Equals(2);
    }
}