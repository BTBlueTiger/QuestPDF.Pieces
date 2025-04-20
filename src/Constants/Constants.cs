namespace QuestPDF.Pieces.Constants
{
    using System;
    using System.IO;
    using System.Reflection;
    using QuestPDF.Helpers;
    using QuestPDF.Infrastructure;

    /// <summary>
    /// Constants class for PDF generation
    /// </summary>
    public static class Constants
    {
        public static int DefaultFontSize => 10;
        public static int DefaultFontSizeHeadline => 12;
        public static int DefaultSizeSmall => 8;

        public static int DefaultPaddingSize => 5;

        // Fonts and colors
        public static string PrimaryFontFamily => "DM Sans Variable";
        public static string PrimaryFontColor => "#1A535C";
        public static string PrimaryFontContrastColor => "#FF6B6B";

        public static string SecondaryFontFamily => "Barlow";
        public static string SecondaryFontColor => "#4ECDC4";
        public static string SecondaryContrastColor => "#FFE66D";

        public static string DescriptionFontColor => "#FF6B6B";

        public static string BackgroundColor => "#F7FFF7";

        // Page settings
        public static PageSize PageSize => PageSizes.A4;
        public static Color PageColor => Colors.White;

        public static string GetDefaultIconSrc() => "res/material-symbols/info-i.png";
    }
}
