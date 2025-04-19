namespace QuestPDF.Pieces.Sections
{
    using QuestPDF.Fluent;
    using QuestPDF.Pieces;

    public class BodySection : ISection
    {
        public override string ElementName { get; } = "BodySection";
        public override Section_t SectionType { get; } = Section_t.Body;

        private readonly List<Pieces> _components = [];

        public BodySection AddComponent(Pieces component)
        {
            _components.Add(component);
            return this;
        }

        /// <summary>
        /// Composes the body section using the provided <see cref="PageDescriptor"/>.
        /// </summary>
        public override void Compose(PageDescriptor x)
        {
            base.Compose(x);

            x.Content()
                .Column(column =>
                {
                    foreach (var component in _components)
                    {
                        component.Compose(column);
                    }
                });
        }

        public override void Compose(ColumnDescriptor x)
        {
            LogNotImplementedForThisDescriptor(x);
        }
    }
}