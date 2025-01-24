using System.Text;

namespace leetcode_questions
{
    public static class Leetcode {

    public static string MergeAlternately (string word1, string word2) {
        var fullString = new StringBuilder();
        int i = 0, j = 0;
        while(i<word1.Length || j<word2.Length){
            if(i<word1.Length){
                fullString.Append(word1[i++]);
            }
            if(j<word2.Length){
                fullString.Append(word2[j++]);
            }
        }
        return fullString.ToString();
    }

    public static string GcdOfStrings(string str1, string str2) {
        var gcd = new StringBuilder();
        int i = 0;
        int lengthOfTheSmallerString = str1.Length > str2.Length ? str2.Length : str1.Length;
        while (i<lengthOfTheSmallerString){
            if(str1.Contains(gcd.ToString()) && str2.Contains(gcd.ToString())) {
                Console.WriteLine($"gcd:{gcd}, index:{i}");
                gcd.Append(str1[i++]);
            } else {
                break;
            }
        }
        return gcd.ToString();
    }
}
    
}