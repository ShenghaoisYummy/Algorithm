public class Solution {
    public string ReverseString (string s) {
        var chars = s.ToCharArray();
        int length = chars.Length;
        for (int i = 0; i < length/2; i++) {
            char firsttemp = chars[i];
            char lasttemp = chars[length - i -1];
            chars[i] = lasttemp;
            chars[length - i - 1] = firsttemp;
        }
        string reversed = null;
        foreach (char item in chars)
        {   
            item.ToString();
            reversed += item; 
        }
        return reversed;
    }
}