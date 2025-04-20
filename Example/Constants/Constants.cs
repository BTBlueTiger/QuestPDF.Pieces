namespace QuestPDF.Pieces.Constants
{
    using QuestPDF.Helpers;
    using QuestPDF.Infrastructure;

    /// <summary>
    /// Constants class for PDF generation
    /// </summary>
    public static class Constants
    {
        public static int DefaultSize => 10;
        public static int DefaultSizeLarge => 12;
        public static int DefaultSizeSmall => 8;

        public static int DefaultPaddingSize => 5;

        // Fonts and colors
        public static string PrimaryFont => "DM Sans Variable";
        public static string PrimaryFontColor => "#000000";
        public static string PrimaryFontContrastColor => "#f5f5f5";

        public static string SecondaryFont => "Barlow";
        public static string SecondaryFontColor => "#1C2833";
        public static string SecondaryContrastColor => "#f5f5f5";

        public static string DescriptionFontColor => "#935116";

        public static string BackgroundColor => "F9F3E5";

        // Page settings
        public static PageSize PageSize => PageSizes.A4;
        public static Color PageColor => Colors.White;
    }
}
