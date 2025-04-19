namespace QuestPDF.Pieces.Components
{
    using QuestPDF.Fluent;
    public class TextLine(string text, int size = 10) : BasePiece
    {
        public override string ElementName { get; } = "TextLine";
        public string Text { get; } = text;
        public int Size { get; } = size;

        public override void Compose(ColumnDescriptor x)
        {
            base.Compose(x);
            // Generate the standard text element for the PDF document
            x.Item().Text(Text).FontSize(Size).AlignCenter();
        }

        public override void Compose(PageDescriptor x)
        {
            LogNotImplementedForThisDescriptor(x);
        }
    }
}
