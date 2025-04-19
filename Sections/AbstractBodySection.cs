namespace QuestPDF.Pieces.Sections
{
    public class AbstractBodySection : AbstractSection
    {
        public override string ElementName { get; } = "BodySection";
        public override Section_t SectionType { get; } = Section_t.Body;
    }
}