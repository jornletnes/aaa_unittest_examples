using Produksjon;
using Xunit;

namespace Tester
{
    public class PersonTest
    {
        // Nomenklatur:
        // TestAt_PublicFunction_Returns_Expectation
        // 
        // Her kan du godt utelate "TestAt_"-biten - men
        // det er nyttig å mentalt fylle den ut slikt at
        // nomenklaturen blir lettfattelig.
        
        [Fact]
        public void TestAt_Navn_Returns_ForventetNavn()
        {
            // Arrange
            var underTest = new Person();
            var expected = "Kong Salomo";

            // Act
            var actual = underTest.Navn();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}