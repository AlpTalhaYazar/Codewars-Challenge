namespace Codewars_Challenge_Tests;

public class ParseIntReloadedTest
{
    [Test]
    public void Should_ConvertBasicDigit_When_InputIsOne()
    {
        Assert.AreEqual("1", ParseIntReloaded.ParseInt("one").ToString());
    }

    [Test]
    public void Should_ConvertBasicDigit_When_InputIsTwo()
    {
        Assert.AreEqual("2", ParseIntReloaded.ParseInt("two").ToString());
    }

    [Test]
    public void Should_ConvertBasic_When_InputIsTen()
    {
        Assert.AreEqual("10", ParseIntReloaded.ParseInt("ten").ToString());
    }
    
    [Test]
    public void Should_ConvertBasic_When_InputIsTwenty()
    {
        Assert.AreEqual("20", ParseIntReloaded.ParseInt("twenty").ToString());
    }
    
    [Test]
    public void Should_ConvertMoreComplexUnified_When_InputIsTwentyOne()
    {
        Assert.AreEqual("21", ParseIntReloaded.ParseInt("twenty one").ToString());
    }
    
    [Test]
    public void Should_ConvertMoreComplexUnified_When_InputIsFortyTwo()
    {
        Assert.AreEqual("42", ParseIntReloaded.ParseInt("forty two").ToString());
    }
    
    [Test]
    public void Should_ConvertMoreComplexBiggerThanHundred_When_InputIsTwoHundredTwentyOne()
    {
        Assert.AreEqual("221", ParseIntReloaded.ParseInt("two hundred twenty one").ToString());
    }
    
    [Test]
    public void Should_ConvertMoreComplexBiggerThanHundred_When_InputIsOneHundredFortyTwo()
    {
        Assert.AreEqual("142", ParseIntReloaded.ParseInt("one hundred forty two").ToString());
    }

    [Test]
    public void Should_ConvertMoreComplexBiggerThanThousand_When_InputIsOneThousandTwoHundredTwentyOne()
    {
        Assert.AreEqual("1221", ParseIntReloaded.ParseInt("one thousand two hundred twenty one").ToString());
    }

    [Test]
    public void Should_ConvertMoreComplexBiggerThanThousand_When_InputIsOneThousandOneHundredFortyTwo()
    {
        Assert.AreEqual("1142", ParseIntReloaded.ParseInt("one thousand one hundred forty two").ToString());
    }
    
    [Test]
    public void Should_ConvertMoreComplexBiggerThanMillion_When_InputIsOneMillionTwoHundredTwentyOneThousandTwoHundredTwentyOne()
    {
        Assert.AreEqual("1221221", ParseIntReloaded.ParseInt("one million two hundred twenty one thousand two hundred twenty one").ToString());
    }
}