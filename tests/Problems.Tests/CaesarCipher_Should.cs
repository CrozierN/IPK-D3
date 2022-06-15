using Xunit;

namespace Problems.Tests;

public class CaesarCipher_Should
{
    private string Word1 = "There's-a-starman-waiting-in-the-sky";
    private string Word2 = "middle-Outz";


    [Fact]
    public void caesarCipher_OutputIsString()
    {
        // arrange 
        var caesarCipher = new CaesarCipher();
        // act 
        var cipher = caesarCipher.caesarCipher(Word1, 3);
        // assert
        Assert.IsType<string>(cipher);
    }

    [Fact]
    public void caesarCipher_OutputIsString_ReturnCipher1()
    {
        // arrange 
        var caesarCipher = new CaesarCipher();
        // act 
        var cipher = caesarCipher.caesarCipher(Word1, 3);
        // assert
        Assert.Equal("Wkhuh'v-d-vwdupdq-zdlwlqj-lq-wkh-vnb", cipher);
    }

    [Fact]
    public void caesarCipher_OutputIsString_ReturnCipher2()
    {
        // arrange 
        var caesarCipher = new CaesarCipher();
        // act 
        var cipher = caesarCipher.caesarCipher(Word2, 2);
        // assert
        Assert.Equal("okffng-Qwvb", cipher);
    }
}
