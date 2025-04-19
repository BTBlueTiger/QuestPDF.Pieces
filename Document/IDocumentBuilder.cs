namespace QuestPDF.Pieces.Document
{
    using QuestPDF.Fluent;
    using QuestPDF.Infrastructure;
    using QuestPDF.Pieces.Sections;
    public abstract class IDocumentBuilder<T>
    {
        protected List<ISection> _sections = [];
        protected PageDescriptor _content = new();
        public delegate void BuildDelegate(PageDescriptor x);

        // Should be in the Contructor or a method
        protected DocumentMetadata _documentMetadata =
            new()
            {
                Title = "Pieces Document",
                Author = "Pieces",
                Subject = "Dokument",
                Keywords = "QuestPDF, PDF, Document, Pieces",
            };

        public IDocumentBuilder<T> AddComponent(ISection section)
        {
            Console.WriteLine($"Adding section: {section.ElementName}");
            _sections.Add(section);
            return this;
        }

        public IDocumentBuilder<T> AddTitle(string title)
        {
            _documentMetadata.Title = title;
            return this;
        }

        public IDocumentBuilder<T> AddAuthor(string author)
        {
            _documentMetadata.Author = author;
            return this;
        }

        public IDocumentBuilder<T> AddSubject(string subject)
        {
            _documentMetadata.Subject = subject;
            return this;
        }

        public IDocumentBuilder<T> AddKeywords(string keywords)
        {
            _documentMetadata.Keywords = keywords;
            return this;
        }

        public abstract T Build();
    }
}