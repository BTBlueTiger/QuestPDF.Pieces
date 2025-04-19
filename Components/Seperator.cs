namespace QuestPDF.Pieces.Components
{
    using QuestPDF.Fluent;

    public class Seperator(int? size = null) : PieceComponent
    {
        public override string ElementName { get; } = "Seperator";

        public int Size { get; } = size ?? 5;

        public override void Compose(ColumnDescriptor x)
        {
            base.Compose(x);
            // Generate the standard text element for the PDF document
            x.Item().Padding(5);
        }
    }
}
