namespace Codewars_Challenge_Tests;

public class WeirdStringCaseTest
{
    [Test]
    public void Should_ReturnWeIrDsTrInGcAsE_When_SingleWordWithNoSpaces()
    {
        var actual = WeirdStringCase.ToWeirdCase("WeirdStringCase");
        Assert.AreEqual("WeIrDsTrInGcAsE", actual);
    }

    [Test]
    public void Should_ReturnWeIrDStRiNgCaSe_When_MultipleWordsWithSpaces()
    {
        var actual = WeirdStringCase.ToWeirdCase("Weird string case");
        Assert.AreEqual("WeIrD StRiNg CaSe", actual);
    }

    [Test]
    public void Should_ReturnWeIrDStRiNgCaSe_When_MultipleWordsWithSpaces2()
    {
        var actual = WeirdStringCase.ToWeirdCase("This is a test");
        Assert.AreEqual("ThIs Is A TeSt", actual);
    }
}