using QuestPDF.Pieces.Components;
using QuestPDF.Fluent;
using Xunit;
using Moq;

namespace QuestPDF.Pieces.Tests.Components
{
    public class TextLineTests
    {
        [Fact]
        public void TextLine_Compose_ShouldSetTextAndFontSize()
        {
            // Arrange
            var textLine = new TextLine("Test Text", 12);
            var columnDescriptorMock = new Mock<ColumnDescriptor>();

            // Act
            textLine.Compose(columnDescriptorMock.Object);

            // Assert
            columnDescriptorMock.Verify(x => x.Text("Test Text"), Times.Once);
            columnDescriptorMock.Verify(x => x.FontSize(12), Times.Once);
        }
    }
}
