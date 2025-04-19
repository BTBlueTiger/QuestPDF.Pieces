// filepath: ExampleUsage.cs
using QuestPDF.Companion;
using QuestPDF.Infrastructure;
using QuestPDF.Pieces;
using QuestPDF.Pieces.Components;
using QuestPDF.Pieces.Document;
using QuestPDF.Pieces.Sections;

QuestPDF.Settings.License = LicenseType.Community;

var documentComposer = new DocumentComposer();

// Add a header section
var header = new HeaderSection();
header.AddComponent(new TextLine("Header Title", size: 16));
documentComposer.AddComponent(header);

// Add a body section
var body = new BodySection();
body.AddComponent(new TextLine("This is the body content."));
body.AddComponent(new Seperator());
body.AddComponent(new TextLine("More content here."));
documentComposer.AddComponent(body);

// Add a footer section
var footer = new FooterSection();
footer.AddComponent(new TextLine("Footer Content ", size: 10));
documentComposer.AddComponent(footer);

// Generate the PDF document
var document = documentComposer.Compose();
document.ShowInCompanion();