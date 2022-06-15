namespace Problems;

public class CaesarCipher
{
    private string alphabets = "abcdefghijklmnopqrstuvwxyz"; 
    public string caesarCipher(string s, int k)
    {

        var rotated = alphabets[k..] + alphabets[0..k];
        var toUpper = rotated.ToUpper();


        var cipher = "";

        for (int i = 0; i < s.Length; i++)
        {
            var charIdx = alphabets.IndexOf(s[i]);
            if (char.IsLetter(s[i]) && charIdx >= 0)
                cipher += rotated[charIdx];
            else if (char.IsLetter(s[i]) && charIdx < 0)
            {
                charIdx = alphabets.ToUpper().IndexOf(s[i]);
                cipher += toUpper[charIdx];
            }
            else
                cipher += s[i];
        }

        return cipher;
    }
}
