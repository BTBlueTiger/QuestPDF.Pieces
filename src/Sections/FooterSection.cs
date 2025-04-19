namespace QuestPDF.Pieces.Sections
{
    using QuestPDF.Fluent;

    public class FooterSection : AbstractSection
    {
        public override string ElementName { get; } = "FooterSection";
        public override Section_t SectionType { get; } = Section_t.Footer;

        public override void Compose(PageDescriptor x)
        {
            base.Compose(x);

            x.Footer()
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
