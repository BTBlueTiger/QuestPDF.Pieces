namespace QuestPDF.Pieces.Sections
{
    using QuestPDF.Fluent;

    public abstract class FooterSection : ISection
    {
        public override string ElementName { get; } = "FooterSection";
        public override Section_t SectionType { get; } = Section_t.Footer;

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
