using Responsive.Models;

namespace TestProject1
{
    [Fact]
    public void ValidAge()
    {
        string Name = "Taylor";
        string BirthYear = "1991";
        // Arrange
        string expected = "Taylor is 32 this year.";
        string actual;

        // Act
        actual = ResponsiveModel.CalculateAge();

        // Assert
        Assert.Equal(expected, actual);
    }
}