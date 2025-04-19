
namespace QuestPDF.Pieces.Sections
{
    using System.Collections.Generic;
    using Fluent;

    public abstract class AbstractSection : AbstractPiece
    {
        protected readonly List<AbstractPiece> _pieces = [];

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

        public AbstractSection AddComponent(AbstractPiece component)
        {
            _pieces.Add(component);
            return this;
        }
    }
}