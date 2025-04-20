// filepath: ExampleUsage.cs
using System.Drawing;
using QuestPDF.Companion;
using QuestPDF.Infrastructure;
using QuestPDF.Pieces;
using QuestPDF.Pieces.Components;
using QuestPDF.Pieces.Document;
using QuestPDF.Pieces.Sections;
using Headline = QuestPDF.Pieces.Components.Headline;
using Text = QuestPDF.Pieces.Components.Text;

QuestPDF.Settings.License = LicenseType.Community;

var documentComposer = new DocumentComposer();

var configurator = new QuestPDF.Pieces.Theme.ThemeController.Configurator();
configurator
    .SetVariable("DefaultFontSize", 12)
    .SetVariable("DefaultFontSizeHeadline", 16)
    .SetVariable("PrimaryFontColor", "#000000")
    .SetVariable("SecondaryFontColor", "#1E3F66")
    .SetVariable("BackgroundColor", "#BCD2E8")
    .SetVariable("PrimaryFontFamily", "Arial")
    .SetVariable("SecondaryFontFamily", "Arial");

// Add a header section
var header = new HeaderSection();
header.AddComponent(new Text.Standard("Header Title", size: 16));
documentComposer.AddComponent(header);

// Add a body section
var body = new BodySection();
body.AddComponent(
    new Page(
        [
            new Headline.Standard(["Headline 1", "Headline 2", "Headline 3"]),
            new Headline.Light(["Subheadline 1", "Subheadline 3"]),
            new Text.DescriptionBlock(
                "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.."
            ),
            new Headline.LeftMiddleRight("Left", "Middle", "Right"),
            new Headline.LeftRight("Left", "Right"),
        ]
    )
);
body.AddComponent(new Text.Standard("This is the body content."));
body.AddComponent(new Seperator());
body.AddComponent(new Text.Light("More content here."));
documentComposer.AddComponent(body);

// Add a footer section
var footer = new FooterSection();
footer.AddComponent(new Text.Standard("Footer Content ", size: 10));
documentComposer.AddComponent(footer);

// Generate the PDF document
var document = documentComposer.Compose();
document.ShowInCompanion();
