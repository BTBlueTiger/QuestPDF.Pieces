namespace QuestPDF.Pieces
{
    using System;
    using QuestPDF.Fluent;

    public abstract class Pieces
    {
        public abstract string ElementName { get; }

        /// <summary>
        /// Composes a PDF piece using the specified container.
        /// </summary>
        public virtual void Compose(PageDescriptor descriptor)
        {
            Console.WriteLine($"Composing QuestPDFPiece: {ElementName} with PageDescriptor");
            // Default implementation for building a PDF document
        }

        /// <summary>
        /// Composes the PDF piece using the specified column descriptor.
        /// </summary>
        public virtual void Compose(ColumnDescriptor descriptor)
        {
            Console.WriteLine($"Composing QuestPDFPiece: {ElementName} with ColumnDescriptor");
        }

        /// <summary>
        /// Logs a message indicating that the method is not implemented for the given descriptor type.
        /// </summary>
        public void LogNotImplementedForThisDescriptor<T>(T descriptor)
        {
            Console.WriteLine(
                $"Not implemented for {ToString()} with this descriptor: {descriptor?.ToString()}"
            );
        }
    }
}
