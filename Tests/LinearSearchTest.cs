namespace Tests
{
    public class LinearSearchTest
    {
        [Fact]
        public void LinearSearch_Exists()
        {
            // Arrange
            int[] array = { 1, 3, 5, 7, 9 };
            int needle = 5;

            // Act
            bool result = LinearSearch.Program.LinearSearch(array, needle);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void LinearSearch_NotExists()
        {
            // Arrange
            int[] array = { 1, 3, 5, 7, 9 };
            int needle = 2;

            // Act
            bool result = LinearSearch.Program.LinearSearch(array, needle);

            // Assert
            Assert.False(result);
        }
    }
}