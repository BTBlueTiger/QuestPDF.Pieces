namespace QuestPDF.Pieces.Document
{
    using QuestPDF.Fluent;
    using System;
    using QuestPDF.Pieces.Sections;
    using System.Collections.Generic;
    using QuestPDF.Infrastructure;

    public abstract class AbstractDocumentComposer<T>
    {
        protected List<AbstractSection> _sections = [];
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

        public AbstractDocumentComposer<T> AddComponent(AbstractSection section)
        {
            Console.WriteLine($"Adding section: {section.ElementName}");
            _sections.Add(section);
            return this;
        }

        public AbstractDocumentComposer<T> AddTitle(string title)
        {
            _documentMetadata.Title = title;
            return this;
        }

        public AbstractDocumentComposer<T> AddAuthor(string author)
        {
            _documentMetadata.Author = author;
            return this;
        }

        public AbstractDocumentComposer<T> AddSubject(string subject)
        {
            _documentMetadata.Subject = subject;
            return this;
        }

        public AbstractDocumentComposer<T> AddKeywords(string keywords)
        {
            _documentMetadata.Keywords = keywords;
            return this;
        }

        public abstract T Compose();
    }
}