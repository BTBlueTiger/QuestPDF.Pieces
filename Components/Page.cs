namespace QuestPDF.Pieces.Components
{
    using System.Collections.ObjectModel;
    using QuestPDF.Fluent;
    public class Page(Collection<PieceComponent> pieces) : IPDFComponentontainer(pieces)
    {
        public override string ElementName { get; } = "Page";

        public override void Compose(ColumnDescriptor x)
        {
            base.Compose(x);
            foreach (var piece in _pieces)
            {
                piece.Compose(x); // Use 'piece' instead of 'component'
            }
            x.Item().PageBreak();
        }

        public override void Compose(PageDescriptor x)
        {
            LogNotImplementedForThisDescriptor(x);
        }
    }
}
