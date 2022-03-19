namespace Codewars_Challenge_Tests;

public class HammingNumberTest
{
    [Test]
    public void Should_ReturnFirst_When_InputIsOne()
    {
        Assert.AreEqual("1", HammingNumber.Hamming(1).ToString());
    }
    
    [Test]
    public void Should_ReturnSecond_When_InputIsTwo()
    {
        Assert.AreEqual("2", HammingNumber.Hamming(2).ToString());
    }
    
    [Test]
    public void Should_ReturnThird_When_InputIsThree()
    {
        Assert.AreEqual("3", HammingNumber.Hamming(3).ToString());
    }
    
    [Test]
    public void Should_ReturnTenth_When_InputIsTen()
    {
        Assert.AreEqual("12", HammingNumber.Hamming(10).ToString());
    }
    
    [Test]
    public void Should_ReturnNineteenth_When_InputIsNineteen()
    {
        Assert.AreEqual("32", HammingNumber.Hamming(19).ToString());
    }
    
    [Test]
    public void Should_ReturnTwentyFifth_When_InputIsTwentyFive()
    {
        Assert.AreEqual("54", HammingNumber.Hamming(25).ToString());
    }
}