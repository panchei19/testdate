namespace Library.Tests;
using TestDateFormat;
public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestCorrectFormatDate()
    {
        string actualDate = "10/11/1997";
        string expectedDate = "1997-11-10";
        string finalDate = DateFormatter.ChangeFormat(actualDate);
        Assert.AreEqual(finalDate, expectedDate);
    }
    [Test]
    public void TestIncorrectFormatDate()
    {
        string wDate = "0/1/19";
        string expectedDate = "1997-11-10";
        string convertedDate = DateFormatter.ChangeFormat(wDate);
        Assert.IsFalse(convertedDate.Equals(expectedDate));
    }

    [Test]
    public void TestcorrectFormatDate()
    {
        string actualDate = "";

        string convertedDate = DateFormatter.ChangeFormat(actualDate);
        Assert.IsNull(convertedDate);
    }

}
