namespace Assignment01.Tests;
using Assignment01;
using System.Collections;
public class UnitTest1
{
    [Fact]
    public void SplitLine_splity_split()
    { 
        //Arrage
        IEnumerable<string> lines = new List<string>() {"One two", "three four seven"};
        //Act
        var a = RegularExpression.SplitLine(lines);
        //Assert
        Assert.Equal(new[] {"One", "two", "three", "four", "seven"}, a);
    }

    [Fact]
    public void Resolutions_given_sample_input(){
        //Arrange 
        var resolutions = new List<string>() {"1920x1080", "1024x768, 800x600, 640x480", "320x200, 320x240, 800x600", "1280x960"};
        //Act
        var a = RegularExpression.Resolutions(resolutions);
        //Assert
        Assert.Equal(1920, a.ElementAt(0).width);
        Assert.Equal(1080, a.ElementAt(0).height);

        Assert.Equal(1024, a.ElementAt(1).width);
        Assert.Equal(768, a.ElementAt(1).height);

        Assert.Equal(800, a.ElementAt(2).width);
        Assert.Equal(600, a.ElementAt(2).height);

        Assert.Equal(640, a.ElementAt(3).width);
        Assert.Equal(480, a.ElementAt(3).height);

        Assert.Equal(320, a.ElementAt(4).width);
        Assert.Equal(200, a.ElementAt(4).height);

        Assert.Equal(320, a.ElementAt(5).width);
        Assert.Equal(240, a.ElementAt(5).height);

        Assert.Equal(800, a.ElementAt(6).width);
        Assert.Equal(600, a.ElementAt(6).height);

        Assert.Equal(1280, a.ElementAt(7).width);
        Assert.Equal(960, a.ElementAt(7).height);
    }


    [Fact]
    public void get_InnerText_From_Example_Text_Given_Tag_p(){
        //Arrange
        string input = "<div><p>The phrase <i>regular expressions</i> (and consequently, regexes) is often used to mean the specific, standard textual syntax for representing <u>patterns</u> that matching <em>text</em> need to conform to.</p> </div>";
        IEnumerable<string> output = new List<string>();

        List<string> expected = new List<string>();
        expected.Add("The phrase regular expressions (and consequently, regexes) is often used to mean the specific, standard textual syntax for representing patterns that matching text need to conform to.");
        
        //Act
        output = RegularExpression.InnerText(input, "p");
        
        //Assert
        output.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void get_InnerText_From_Second_Example_Text_Given_Tag_p(){
        //Arrange
        string input = @"<div>
                            <p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href=""https://en.wikipedia.org/wiki/Theoretical_computer_science"" title=""Theoretical computer science"">theoretical computer science</a> and <a href=""https://en.wikipedia.org/wiki/Formal_language"" title=""Formal language"">formal language</a> theory, a sequence of <a href=""https://en.wikipedia.org/wiki/Character_(computing)"" title=""Character (computing)"">characters</a> that define a <i>search <a href=""https://en.wikipedia.org/wiki/Pattern_matching"" title=""Pattern matching"">pattern</a></i>. Usually this pattern is then used by <a href=""https://en.wikipedia.org/wiki/String_searching_algorithm"" title=""String searching algorithm"">string searching algorithms</a> for ""find"" or ""find and replace"" operations on <a href=""https://en.wikipedia.org/wiki/String_(computer_science)"">strings</a>.</p>
                        </div>";
        IEnumerable<string> output = new List<string>();

        List<string> expected = new List<string>();
        expected.Add("theoretical computer science");
        expected.Add("formal language");
        expected.Add("characters");
        expected.Add("pattern");
        expected.Add("string searching algorithms");
        expected.Add("strings");
        
        //Act
        output = RegularExpression.InnerText(input, "a");
        
        //Assert
        output.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void get_InnerText_From_Altered_Example_Text_Given_Tag_p(){
        //Arrange
        string input = "<div><p>The phrase <i>regular expressions</i> (and consequently, regexesesesese) is often used to mean the specific, standard textual syntax for representing <u>patterns</u> that matching <em>text</em> need to conform to.</p> </div>";
        IEnumerable<string> output = new List<string>();

        List<string> expected = new List<string>();
        expected.Add("The phrase regular expressions (and consequently, regexes) is often used to mean the specific, standard textual syntax for representing patterns that matching text need to conform to.");
        
        //Act
        output = RegularExpression.InnerText(input, "p");
        
        //Assert
        output.Should().NotBeEquivalentTo(expected);
    }

    /*[Fact]
    public void testNow(){
        string expected = "test";
        string output = "Test now";
        output.Should().BeEquivalentTo(expected);
    }*/

    //[Fact]
    //public void Urls_something(){
        //Arrange

        //Act
        //var a = RegularExpression.Urls();

        //Assert
    //}

}