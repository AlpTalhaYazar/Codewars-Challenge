namespace Codewars_Challenge_Tests;

public class WhoLikesItTests
{
    [Test]
    public void Should_ReturnNoOne_When_EmptyArrayInput()
    {
        var actual = WhoLikesIt.Likes(new string[] { });
        Assert.AreEqual("no one likes this", actual);
    }
    
    [Test]
    public void Should_Return1Person_When_1PersonInput()
    {
        var actual = WhoLikesIt.Likes(new string[] { "Peter" });
        Assert.AreEqual("Peter likes this", actual);
    }
    
    [Test]
    public void Should_Return2People_When_2PeopleInput()
    {
        var actual = WhoLikesIt.Likes(new string[] { "Jacob", "Alex" });
        Assert.AreEqual("Jacob and Alex like this", actual);
    }
    
    [Test]
    public void Should_Return3People_When_3PeopleInput()
    {
        var actual = WhoLikesIt.Likes(new string[] { "Max", "John", "Mark" });
        Assert.AreEqual("Max, John and Mark like this", actual);
    }
    
    [Test]
    public void Should_ReturnOthersWord_When_4OrMorePeopleInput()
    {
        var actual = WhoLikesIt.Likes(new string[] { "Alex", "Jacob", "Mark", "Max" });
        Assert.AreEqual("Alex, Jacob and 2 others like this", actual);
    }
    
    [Test]
    public void Should_ReturnOthersWord_When_4OrMorePeopleInput2()
    {
        var actual = WhoLikesIt.Likes(new string[] { "Alex", "Jacob", "Mark", "Max", "John" });
        Assert.AreEqual("Alex, Jacob and 3 others like this", actual);
    }
}