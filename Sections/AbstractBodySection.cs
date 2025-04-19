namespace QuestPDF.Pieces.Sections
{
    using QuestPDF.Fluent;
    public class AbstractBodySection : AbstractSection
    {
        public override string ElementName { get; } = "BodySection";
        public override Section_t SectionType { get; } = Section_t.Body;

        public override void Compose(PageDescriptor x)
        {
            base.Compose(x);

            x.Content()
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