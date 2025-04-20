namespace QuestPDF.Pieces.Components
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using QuestPDF.Fluent;
    using QuestPDF.Pieces.Theme;

    namespace Headline
    {
        public class Standard(
            List<string> items,
            int? size = null,
            string backgroundColor = null,
            string fontColor = null,
            string fontFamily = null
        ) : Text.Standard(text: "", size, backgroundColor, fontColor, fontFamily)
        {
            public override string ElementName { get; } = "Headline.Standard";
            protected override int Size { get; } = ThemeController.DefaultFontSizeHeadline;

            protected readonly List<string> items = items;

            public override void Compose(ColumnDescriptor x)
            {
                base.Compose(x);
                // Generate the standard text element for the PDF document
                x.Item()
                    .Background(BackgroundColor)
                    .Padding(5)
                    .Row(row =>
                    {
                        foreach (var item in items)
                        {
                            row.RelativeItem()
                                .Text(item)
                                .FontSize(Size)
                                .FontColor(FontColor)
                                .FontFamily(FontFamily)
                                .AlignCenter();
                        }
                    });
            }
        }

        public class Light(
            List<string> items,
            int? size = null,
            string backgroundColor = null,
            string fontColor = null,
            string fontFamily = null
        ) : Text.Standard(text: "", size, backgroundColor, fontColor, fontFamily)
        {
            public override string ElementName { get; } = "Headline.Light";

            protected override string FontFamily => ThemeController.SecondaryFontFamily;

            public override void Compose(ColumnDescriptor x)
            {
                base.Compose(x);
                // Generate the standard text element for the PDF document
                x.Item()
                    .Background(BackgroundColor)
                    .Padding(5)
                    .Row(row =>
                    {
                        foreach (var item in items)
                        {
                            row.RelativeItem()
                                .Text(item)
                                .FontSize(Size)
                                .FontColor(FontColor)
                                .FontFamily(FontFamily)
                                .Light()
                                .AlignCenter();
                        }
                    });
            }
        }

        public class LeftRight(
            string left,
            string right,
            int? size = null,
            string backgroundColor = null,
            string fontColor = null,
            string fontFamily = null
        ) : Text.Standard(text: "", size, backgroundColor, fontColor, fontFamily)
        {
            public override string ElementName { get; } = "Headline.Light";

            protected string left = left;
            protected string right = right;

            protected override string FontFamily => ThemeController.SecondaryFontFamily;

            public override void Compose(ColumnDescriptor x)
            {
                base.Compose(x);
                // Generate the standard text element for the PDF document
                x.Item()
                    .Background(BackgroundColor)
                    .Padding(5)
                    .Row(row =>
                    {
                        row.RelativeItem()
                            .Text(left)
                            .FontSize(Size)
                            .FontColor(FontColor)
                            .AlignLeft();
                        row.RelativeItem()
                            .Text(right)
                            .FontSize(Size)
                            .FontColor(FontColor)
                            .AlignRight();
                    });
            }
        }

        public class LeftMiddleRight(
            string left,
            string middle,
            string right,
            int? size = null,
            string backgroundColor = null,
            string fontColor = null,
            string fontFamily = null
        ) : Text.Standard(text: "", size, backgroundColor, fontColor, fontFamily)
        {
            public override string ElementName { get; } = "Headline.Light";

            protected string left = left;
            protected string right = right;
            protected string middle = middle;

            protected override string FontFamily => ThemeController.SecondaryFontFamily;

            public override void Compose(ColumnDescriptor x)
            {
                base.Compose(x);
                // Generate the standard text element for the PDF document
                x.Item()
                    .Background(BackgroundColor)
                    .Padding(5)
                    .Row(row =>
                    {
                        row.RelativeItem()
                            .Text(left)
                            .FontSize(Size)
                            .FontColor(FontColor)
                            .AlignLeft();
                        row.RelativeItem()
                            .Text(middle)
                            .FontSize(Size)
                            .FontColor(FontColor)
                            .AlignCenter();
                        row.RelativeItem()
                            .Text(right)
                            .FontSize(Size)
                            .FontColor(FontColor)
                            .AlignRight();
                    });
            }
        }

        public class Centered(
            List<string> items,
            int? size = null,
            string backgroundColor = null,
            string fontColor = null,
            string fontFamily = null
        ) : Text.Standard(text: "", size, backgroundColor, fontColor, fontFamily)
        {
            public override string ElementName { get; } = "Headline.Centered";

            public override void Compose(ColumnDescriptor x)
            {
                base.Compose(x);
                x.Item()
                    .Background(BackgroundColor)
                    .Padding(5)
                    .Row(row =>
                    {
                        foreach (var item in items)
                        {
                            row.RelativeItem()
                                .Text(item)
                                .FontSize(Size)
                                .FontColor(FontColor)
                                .FontFamily(FontFamily)
                                .AlignCenter();
                        }
                    });
            }
        }
    }
}
