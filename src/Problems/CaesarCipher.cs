namespace Problems;

public class CaesarCipher
{
    private string alphabets = "abcdefghijklmnopqrstuvwxyz";

    /// <summary>
    /// Method used to create an encrypted text using Caesar's Cipher
    /// </summary>
    /// <param name="s">string to be encrypted</param>
    /// <param name="k">alphabet rotation factor</param>
    /// <returns>returns an encrypted string</returns>
    public string caesarCipher(string s, int k)
    {
        k = k % 26;
        var rotated = alphabets[k..] + alphabets[0..k];


        var toUpperAlphabets = alphabets.ToUpper();
        var toUpperAlphabetsRotated = toUpperAlphabets[k..] + toUpperAlphabets[0..k];

        var cipher = "";

        for (int i = 0; i < s.Length; i++)
        {
            var charIdx = alphabets.IndexOf(s[i]);
            if (char.IsLetter(s[i]) && charIdx >= 0)
                cipher += rotated[charIdx];
            else if (char.IsLetter(s[i]) && charIdx < 0)
            {
                charIdx = toUpperAlphabets.IndexOf(s[i]);
                cipher += toUpperAlphabetsRotated[charIdx];
            }
            else
                cipher += s[i];
        }

        return cipher;
    }
}
