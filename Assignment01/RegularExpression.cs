using System.Text.RegularExpressions;
using System.Collections.Generic;
namespace Assignment01{

public class RegularExpression {
    public static IEnumerable<string> SplitLine(IEnumerable<string> lines){
        var regex = new Regex(" ");
        foreach (var line in lines) {
            string[] words = regex.Split(line);
            foreach (var word in words){
                yield return word;
            }
        }
    }

    public static IEnumerable<(int width, int height)> Resolutions(IEnumerable<string> resolutions){
        var tmpLines = RegularExpression.SplitLine(resolutions);
        var pattern = "(?<width>[0-9]+)x(?<height>[0-9]+)";
        foreach (var line in tmpLines) {
            var tmp = Regex.Matches(line, pattern);
            foreach (Match match in tmp){
                var width = Int32.Parse(match.Groups["width"].Value);
                var height = Int32.Parse(match.Groups["height"].Value);
                yield return (width, height);
            }
        }
    }

    //IEnumerable<string> InnerText(string html, string tag);

    //IEnumerable<(Uri url, string title)> Urls(string html);
    
}
}
