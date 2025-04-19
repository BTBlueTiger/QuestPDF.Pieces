namespace QuestPDF.Pieces.Sections
{
    public abstract class AbstractFooterSection : AbstractSection
    {
        public override string ElementName { get; } = "FooterSection";
        public override Section_t SectionType { get; } = Section_t.Footer;
    }
}
