namespace QuestPDF.Pieces.Components
{
    using System;
    using System.Collections.ObjectModel;
    using QuestPDF.Fluent;
    using QuestPDF.Pieces;

    /// <summary>
    /// Interface for PDF components.
    /// </summary>
    public abstract class PieceComponent : Pieces
    {
        /// <summary>
        /// Components are not implementing this by default
        /// </summary>
        /// <param name="x"></param>
        public override void Compose(PageDescriptor x)
        {
            LogNotImplementedForThisDescriptor(x);
        }
    }

    public abstract class IPDFComponentontainer(Collection<PieceComponent> pieces) : Pieces
    {
        public readonly Collection<PieceComponent> _pieces = pieces;

        /// <summary>
        /// ComponentContainer are not implementing this by default
        /// </summary>
        /// <param name="x"></param>
        public override void Compose(PageDescriptor x)
        {
            LogNotImplementedForThisDescriptor(x);
        }

        /// <summary>
        /// Builds the PDF document using the specified column descriptor.
        /// </summary>
        public override void Compose(ColumnDescriptor x)
        {
            Console.WriteLine($"Generating PDF Creatable: {ElementName} with ColumnDescriptor");
            Console.WriteLine(
                $"Generating PDF Component: {ElementName} with {_pieces.Count} components"
            );
            // Default implementation for building a PDF document
            // This method can be overridden by derived classes to provide custom behavior
        }
    }
}
