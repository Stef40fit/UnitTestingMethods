using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    // TODO: finish test
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        string input = "";

        // Act
        
        string result = StringReverse.Reverse(input);
        // Assert
        Assert.AreEqual("", result);
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        string input = "a";

        // Act

        string result = StringReverse.Reverse(input);
        // Assert
        Assert.AreEqual("a", result);
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        string input = "abc";

        // Act

        string result = StringReverse.Reverse(input);
        // Assert
        Assert.AreEqual("cba", result);
    }
}
