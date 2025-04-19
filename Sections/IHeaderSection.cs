namespace QuestPDF.Pieces.Sections
{
    using QuestPDF.Fluent;

    public abstract class HeaderSection : ISection
    {
        public override string ElementName { get; } = "HeaderSection";
        public override Section_t SectionType { get; } = Section_t.Header;

        public override void Compose(PageDescriptor x)
        {
            base.Compose(x);
        }

        public override void Compose(ColumnDescriptor x)
        {
            LogNotImplementedForThisDescriptor(x);
        }
    }
}
