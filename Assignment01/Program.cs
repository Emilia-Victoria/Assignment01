// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string input = @"<div>
                            <p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href=""https://en.wikipedia.org/wiki/Theoretical_computer_science"">theoretical computer science</a> and <a href=""https://en.wikipedia.org/wiki/Formal_language"" title=""Formal language"">formal language</a> theory, a sequence of <a href=""https://en.wikipedia.org/wiki/Character_(computing)"" title=""Character (computing)"">characters</a> that define a <i>search <a href=""https://en.wikipedia.org/wiki/Pattern_matching"" title=""Pattern matching"">pattern</a></i>. Usually this pattern is then used by <a href=""https://en.wikipedia.org/wiki/String_searching_algorithm"" title=""String searching algorithm"">string searching algorithms</a> for ""find"" or ""find and replace"" operations on <a href=""https://en.wikipedia.org/wiki/String_(computer_science)"">strings</a>.</p>
                        </div>";

IEnumerable<(Uri, string)> testus = Assignment01.RegularExpression.Urls(input);

foreach (var item in testus){
    Console.WriteLine(item.Item1 + " " + item.Item2);
}

