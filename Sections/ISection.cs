
namespace QuestPDF.Pieces.Sections
{
    using Fluent;

    public abstract class ISection : Pieces
    {

        /// <summary>
        /// The section type of the current section.
        /// </summary>
        public abstract Section_t SectionType { get; }

        /// <summary>
        /// Section are not implementing this by default
        /// </summary>
        /// <param name="x"></param>
        public override void Compose(ColumnDescriptor x)
        {
            LogNotImplementedForThisDescriptor(x);
        }
    }
}