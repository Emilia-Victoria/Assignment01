namespace Assignment1.Tests;
using iterators;
using System.Collections;
public class IteratorsTests
{
    [Fact]
    public void FlattenThreeArraysInAList()
    {
        //Arrange
        int[] innerItem1 = {1, 3, 5};
        int[] innerItem2 = {2, 4, 6};
        int[] innerItem3 = {7, 8, 9};

        List<int[]> item = new List<int[]>();
        item.Add(innerItem1);
        item.Add(innerItem2);
        item.Add(innerItem3);

        IList<int> expectedList = new List<int>();
        foreach(var number in innerItem1){expectedList.Add(number);}
        foreach(var number in innerItem2){expectedList.Add(number);}
        foreach(var number in innerItem3){expectedList.Add(number);}

        //Act
        IEnumerable<int> toReturn = Iterators.Flatten(item);

        //Assert
        toReturn.Should().BeEquivalentTo(expectedList);
    }

    [Fact]
    public void FilterReturningListContaining_2_4_6()
    {
        //Act
        Predicate<int> even = Even;

        static bool Even(int i) => i % 2 == 0;

        int[] toBeFiltered = {1,2,3,4,5,6,7};

        int[] expectedInput = {2,4,6};
        List<int> expected = new List<int>(expectedInput);

        //Act
        IEnumerable<int> toReturn = Iterators.Filter(toBeFiltered, even);

        //Assert
        toReturn.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void FilterReturningListContainingDifferenceFromExpected()
    {
        //Act
        Predicate<int> even = Even;

        static bool Even(int i) => i % 2 == 0;

        int[] toBeFiltered = {1,2,3,4,5,6,7};

        int[] expectedInput = {1,2,4,6};
        List<int> expected = new List<int>(expectedInput);

        //Act
        IEnumerable<int> toReturn = Iterators.Filter(toBeFiltered, even);

        //Assert
        toReturn.Should().NotBeEquivalentTo(expected);
    }



}