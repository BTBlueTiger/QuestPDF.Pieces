using Moq;
using QuestPDF.Fluent;
using QuestPDF.Pieces.Document;
using QuestPDF.Pieces.Sections;
using Xunit;

namespace QuestPDF.Pieces.Tests.Document
{
    public class DocumentComposerTests
    {
        [Fact]
        public void DocumentComposer_AddComponent_ShouldAddSection()
        {
            // Arrange
            var documentComposer = new DocumentComposer();
            var sectionMock = new Mock<AbstractSection>();

            // Act
            documentComposer.AddComponent(sectionMock.Object);

        }

        [Fact]
        public void DocumentComposer_Compose_ShouldComposeAllSections()
        {
            // Arrange
            var documentComposer = new DocumentComposer();
            var sectionMock = new Mock<AbstractSection>();
            documentComposer.AddComponent(sectionMock.Object);

        }
    }
}
