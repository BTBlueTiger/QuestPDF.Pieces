namespace QuestPDF.Pieces.Theme
{
    using System;
    using System.IO;
    using System.Reflection;
    using QuestPDF.Helpers;
    using QuestPDF.Infrastructure;

    /// <summary>
    /// Constants class for PDF generation
    /// </summary>
    public static class ThemeController
    {
        public class Configurator
        {
            public Configurator SetVariable<T>(string name, T value)
            {
                var property = typeof(ThemeController).GetProperty(
                    name,
                    BindingFlags.Public | BindingFlags.Static
                );

                if (property == null || !property.CanWrite)
                    throw new ArgumentException(
                        $"Property '{name}' does not exist or is not writable."
                    );

                var propertyType = property.PropertyType;
                object convertedValue;

                try
                {
                    if (propertyType.IsEnum)
                    {
                        convertedValue = Enum.Parse(propertyType, value!.ToString()!);
                    }
                    else
                    {
                        convertedValue = Convert.ChangeType(value, propertyType);
                    }
                }
                catch (Exception ex)
                {
                    throw new ArgumentException(
                        $"Value '{value}' is not valid for property '{name}': {ex.Message}"
                    );
                }

                property.SetValue(null, convertedValue);
                return this;
            }
        }

        private static int _defaultFontSize = 10;
        private static int _defaultFontSizeHeadline = 12;
        private static int _defaultSizeSmall = 8;
        private static int _defaultPaddingSize = 5;

        private static string _primaryFontFamily = "DM Sans Variable";
        private static string _primaryFontColor = "#1A535C";
        private static string _primaryFontContrastColor = "#FF6B6B";

        private static string _secondaryFontFamily = "Barlow";
        private static string _secondaryFontColor = "#4ECDC4";
        private static string _secondaryContrastColor = "#FFE66D";

        private static string _descriptionFontColor = "#FF6B6B";
        private static string _backgroundColor = "#F7FFF7";

        private static PageSize _pageSize = PageSizes.A4;
        private static Color _pageColor = Colors.White;

        public static int DefaultFontSize
        {
            get => _defaultFontSize;
            set => _defaultFontSize = value;
        }

        public static int DefaultFontSizeHeadline
        {
            get => _defaultFontSizeHeadline;
            set => _defaultFontSizeHeadline = value;
        }

        public static int DefaultSizeSmall
        {
            get => _defaultSizeSmall;
            set => _defaultSizeSmall = value;
        }

        public static int DefaultPaddingSize
        {
            get => _defaultPaddingSize;
            set => _defaultPaddingSize = value;
        }

        public static string PrimaryFontFamily
        {
            get => _primaryFontFamily;
            set => _primaryFontFamily = value;
        }

        public static string PrimaryFontColor
        {
            get => _primaryFontColor;
            set => _primaryFontColor = value;
        }

        public static string PrimaryFontContrastColor
        {
            get => _primaryFontContrastColor;
            set => _primaryFontContrastColor = value;
        }

        public static string SecondaryFontFamily
        {
            get => _secondaryFontFamily;
            set => _secondaryFontFamily = value;
        }

        public static string SecondaryFontColor
        {
            get => _secondaryFontColor;
            set => _secondaryFontColor = value;
        }

        public static string SecondaryContrastColor
        {
            get => _secondaryContrastColor;
            set => _secondaryContrastColor = value;
        }

        public static string DescriptionFontColor
        {
            get => _descriptionFontColor;
            set => _descriptionFontColor = value;
        }

        public static string BackgroundColor
        {
            get => _backgroundColor;
            set => _backgroundColor = value;
        }

        public static PageSize PageSize
        {
            get => _pageSize;
            set => _pageSize = value;
        }

        public static Color PageColor
        {
            get => _pageColor;
            set => _pageColor = value;
        }

        public static string GetDefaultIconSrc() => "res/material-symbols/info-i.png";

        public static void ResetToDefaults()
        {
            _defaultFontSize = 10;
            _defaultFontSizeHeadline = 12;
            _defaultSizeSmall = 8;
            _defaultPaddingSize = 5;

            _primaryFontFamily = "DM Sans Variable";
            _primaryFontColor = "#1A535C";
            _primaryFontContrastColor = "#FF6B6B";

            _secondaryFontFamily = "Barlow";
            _secondaryFontColor = "#4ECDC4";
            _secondaryContrastColor = "#FFE66D";

            _descriptionFontColor = "#FF6B6B";
            _backgroundColor = "#F7FFF7";

            _pageSize = PageSizes.A4;
            _pageColor = Colors.White;
        }
    }
}
