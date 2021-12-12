using Xunit;
using Notas.Modelos;

namespace Notas
{
    public class GestorDeNotasTests
    {
        GestorDeNotas _gn;

        public GestorDeNotasTests()
        {
            this._gn = new GestorDeNotas();
        }

        public void Dispose()
        {
            //_bar?.Dispose();
        }
        
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 3 }, "3/4")]
        [InlineData(new int[] { 2, 2, 3 }, "1/3")]
        public void Ejemplo1(int[] data, string expected)
        {
            // Arrange
            // Act
            string result = _gn.Ejemplo1(data);
            // Assert
            Assert.Equal(expected, result);
        }

    }
}
