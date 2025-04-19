namespace QuestPDF.Pieces.Sections
{

    public abstract class AbstractHeaderSection : AbstractSection
    {
        public override string ElementName { get; } = "HeaderSection";
        public override Section_t SectionType { get; } = Section_t.Header;
    }
}
