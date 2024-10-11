using VowelCount;

namespace Test;

public class KataTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        // Act
        var vowelCount = Kata.GetVowelCount("abecidofugabecidofug");

        // Assert
        Assert.That(vowelCount, Is.EqualTo(10));
    }
}