using QuestPDF.Pieces.Components;
using QuestPDF.Fluent;
using Xunit;
using Moq;

namespace QuestPDF.Pieces.Tests.Components
{
    public class SeperatorTests
    {
        [Fact]
        public void Seperator_Compose_ShouldAddPadding()
        {
            // Arrange
            var seperator = new Seperator(10);
            var columnDescriptorMock = new Mock<ColumnDescriptor>();

            // Act
            seperator.Compose(columnDescriptorMock.Object);

        }
    }
}
