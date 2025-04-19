namespace QuestPDF.Pieces.Document
{   using QuestPDF;
    using System;
    using QuestPDF.Fluent;

    public class DocumentBuilder : IDocumentBuilder<Document>
    {
        public override Document Build()
        {
            Console.WriteLine("Building Document...");
            Console.WriteLine($"Document Metadata: {_documentMetadata}");
            Console.WriteLine($"Document Sections: {_sections.Count}");
            // Set the document metadata
            // Create a new Document object
            return Document.Create(container =>
            {
                container.Page(x =>
                {
                    _sections.ForEach(section =>
                    {
                        Console.WriteLine($"Building section: {section.ElementName}");
                        // Call the Build method of each section
                        section.Compose(x);
                    });
                });
            });
        }
    }
}
