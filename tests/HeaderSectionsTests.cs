using QuestPDF.Pieces.Sections;
using QuestPDF.Fluent;
using Xunit;
using Moq;

namespace QuestPDF.Pieces.Tests.Sections
{
    public class HeaderSectionTests
    {
        [Fact]
        public void HeaderSection_Compose_ShouldComposeAllComponents()
        {
            // Arrange
            var headerSection = new HeaderSection();
            var mockComponent = new Mock<AbstractPiece>();
            headerSection.AddComponent(mockComponent.Object);
            var pageDescriptorMock = new Mock<PageDescriptor>();

            // Act
            headerSection.Compose(pageDescriptorMock.Object);

        }
    }
}
