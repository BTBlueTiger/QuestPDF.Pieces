namespace QuestPDF.Pieces.Sections
{
    using QuestPDF.Fluent;

    public abstract class HeaderSection : AbstractSection
    {
        public override string ElementName { get; } = "HeaderSection";
        public override Section_t SectionType { get; } = Section_t.Header;
        public override void Compose(PageDescriptor x)
        {
            base.Compose(x);

            x.Header()
                .Column(column =>
                {
                    foreach (var component in _pieces)
                    {
                        // Use 'component' instead of 'column'
                        component.Compose(column);
                    }
                });
        }
    }
}
