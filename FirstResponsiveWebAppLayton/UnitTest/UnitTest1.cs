using Responsive.Models;

namespace UnitTest
{
    [Fact]
    public void ValidAge()
    {
        // Arrange
        string name = "Taylor";
        int birth = 1;

        string expected = "Taylor is 32 this year.";
        string actual;

        // Act
        actual = ResponsiveModel.CalculateAge(name, birth);

        // Assert
        Assert.Equal(expected, actual);
    }
}