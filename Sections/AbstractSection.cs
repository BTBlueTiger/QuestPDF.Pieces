
namespace QuestPDF.Pieces.Sections
{
    using System.Collections.Generic;
    using Fluent;

    public abstract class AbstractSection : AbstractPiece
    {
        private readonly List<AbstractPiece> _components = [];

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

        public AbstractSection AddComponent(AbstractPiece component)
        {
            _components.Add(component);
            return this;
        }
    }
}