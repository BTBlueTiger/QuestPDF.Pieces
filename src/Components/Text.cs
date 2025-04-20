#nullable enable

namespace QuestPDF.Pieces.Components
{
    using QuestPDF.Fluent;
    using QuestPDF.Pieces.Theme;

    namespace Text
    {
        public class Standard(
            string? text = null,
            int? size = null,
            string? backgroundColor = null,
            string? fontColor = null,
            string? fontFamily = null
        ) : BasePiece
        {
            public override string ElementName { get; } = "TextLine.Standard";
            protected virtual string Text { get; } = text ?? "";
            protected virtual string BackgroundColor { get; } =
                backgroundColor ?? ThemeController.BackgroundColor;
            protected virtual int Size { get; } = size ?? ThemeController.DefaultFontSize;
            protected virtual string FontColor { get; } =
                fontColor ?? ThemeController.PrimaryFontColor;
            protected virtual string FontFamily { get; } =
                fontFamily ?? ThemeController.PrimaryFontFamily;

            public override void Compose(ColumnDescriptor x)
            {
                base.Compose(x);
                x.Item()
                    .Background(BackgroundColor)
                    .Padding(5)
                    .Text(Text)
                    .FontSize(Size)
                    .FontColor(FontColor)
                    .FontFamily(FontFamily);
            }

            public override void Compose(PageDescriptor x)
            {
                LogNotImplementedForThisDescriptor(x);
            }
        }

        public class Light(
            string? text = null,
            int? size = null,
            string? backgroundColor = null,
            string? fontColor = null,
            string? fontFamily = null
        ) : Standard(text, size, backgroundColor, fontColor, fontFamily)
        {
            public override string ElementName { get; } = "TextLine.Light";

            protected override string FontFamily => ThemeController.SecondaryFontFamily;
            protected override string FontColor => ThemeController.SecondaryFontColor;

            public override void Compose(ColumnDescriptor x)
            {
                base.Compose(x);
                x.Item()
                    .Background(BackgroundColor)
                    .Padding(5)
                    .Text(Text)
                    .FontSize(Size)
                    .FontColor(FontColor)
                    .FontFamily(FontFamily)
                    .Light();
            }
        }

        public class DescriptionBlock(
            string? text = null,
            string? iconSrc = null,
            int? size = null,
            string? backgroundColor = null,
            string? fontColor = null,
            string? fontFamily = null
        ) : Standard("", size, backgroundColor, fontColor, fontFamily)
        {
            public override string ElementName { get; } = "TextLine.DescriptionBlock";
            protected string IconSrc { get; } = iconSrc ?? ThemeController.GetDefaultIconSrc();

            protected override string FontFamily => ThemeController.SecondaryFontFamily;
            protected override string FontColor => ThemeController.SecondaryFontColor;

            public override void Compose(ColumnDescriptor x)
            {
                base.Compose(x);
                x.Item()
                    .Row(row =>
                    {
                        row.ConstantItem(20);
                        row.ConstantItem(20).AlignMiddle().Image(IconSrc).FitWidth();
                        row.ConstantItem(10);
                        row.RelativeItem()
                            .Text(text)
                            .FontSize(Size)
                            .Italic()
                            .FontColor(FontColor)
                            .FontFamily(FontFamily);
                    });
            }
        }

        public class Bold(
            string? text = null,
            int? size = null,
            string? backgroundColor = null,
            string? fontColor = null,
            string? fontFamily = null
        ) : Standard(text, size, backgroundColor, fontColor, fontFamily)
        {
            public override string ElementName { get; } = "TextLine.Bold";

            public override void Compose(ColumnDescriptor x)
            {
                base.Compose(x);
                x.Item()
                    .Text(Text)
                    .FontSize(Size)
                    .FontColor(FontColor)
                    .FontFamily(FontFamily)
                    .Bold();
            }
        }

        public class Italic(
            string? text = null,
            int? size = null,
            string? backgroundColor = null,
            string? fontColor = null,
            string? fontFamily = null
        ) : Standard(text, size, backgroundColor, fontColor, fontFamily)
        {
            public override string ElementName { get; } = "TextLine.Italic";

            public override void Compose(ColumnDescriptor x)
            {
                base.Compose(x);
                x.Item()
                    .Text(Text)
                    .FontSize(Size)
                    .FontColor(FontColor)
                    .FontFamily(FontFamily)
                    .Italic();
            }
        }

        public class Underline(
            string? text = null,
            int? size = null,
            string? backgroundColor = null,
            string? fontColor = null,
            string? fontFamily = null
        ) : Standard(text, size, backgroundColor, fontColor, fontFamily)
        {
            public override string ElementName { get; } = "TextLine.Underline";

            public override void Compose(ColumnDescriptor x)
            {
                base.Compose(x);
                x.Item()
                    .Text(Text)
                    .FontSize(Size)
                    .FontColor(FontColor)
                    .FontFamily(FontFamily)
                    .Underline();
            }
        }
    }
}
