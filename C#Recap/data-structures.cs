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
        if(str1 + str2 != str2 + str1 ){
            return "";
        }
        int gcdOfStringLengths = GCD(str1.Length, str2.Length);
        return str1.Substring(0, gcdOfStringLengths);
    }

    public static int GcdOfNumbers ( int a, int b ) {
        return GCD(a,b);
    }

    static int GCD(int a, int b){
        return b == 0 ? a : GCD(b, a%b );
    }

}
    
}