## NuGet

[![NuGet](https://img.shields.io/nuget/v/QuestPDF.Pieces.svg)](https://www.nuget.org/packages/QuestPDF.Pieces)
[![NuGet Downloads](https://img.shields.io/nuget/dt/QuestPDF.Pieces.svg)](https://www.nuget.org/packages/QuestPDF.Pieces)


# 📄 QuestPDF.Pieces

**Composable, reusable building blocks for creating professional PDF documents using [QuestPDF](https://www.questpdf.com/).**

> Build dynamic, high-quality PDFs with a modular and component-based approach.

---

## 🚀 Overview

**QuestPDF.Pieces** is a robust and flexible framework built on top of [QuestPDF](https://www.questpdf.com/). It simplifies PDF generation by introducing reusable "pieces" (components) that encapsulate layout logic, enabling developers to create clean, maintainable, and modular code.

Whether you're generating invoices, reports, proposals, forms, or other documents, this library provides a structured and intuitive way to design your documents.

---

## ✨ Key Features

- **Abstract Base Classes**: Simplify the creation of structured PDF sections and components.
- **Reusable Components**: Build headers, footers, tables, and other elements with ease.
- **Seamless Integration**: Works effortlessly with QuestPDF’s fluent API.
- **Clean Architecture**: Promotes modular and maintainable code for PDF generation.
- **Developer-Friendly**: Extensible, easy to test, and designed for productivity.

---

## 📖 Basic Usage

Here’s an example of how to use **QuestPDF.Pieces** to create a simple PDF document:

```csharp
// filepath: ExampleUsage.cs
using QuestPDF.Pieces;
using QuestPDF.Pieces.Components;
using QuestPDF.Pieces.Document;
using QuestPDF.Pieces.Sections;

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
footer.AddComponent(new TextLine("Footer Content", size: 10));
documentComposer.AddComponent(footer);

// Generate the PDF document
var document = documentComposer.Compose();
document.GeneratePdf("output.pdf");
```

This example demonstrates how to create a document with a header, body, and footer using reusable components like `TextLine` and `Seperator`.

---

## 🛠️ Extensibility

### Creating Custom Components

You can easily create new components by extending the `BasePiece` class within the `QuestPDF.Pieces.Components` namespace. For example:

```csharp
using QuestPDF.Pieces.Components;
using QuestPDF.Fluent;

public class CustomTextLine(string text, int size = 12) : BasePiece
{
    public override string ElementName { get; } = "CustomTextLine";

    public override void Compose(ColumnDescriptor x)
    {
        x.Item().Text(text).FontSize(size).Bold();
    }
}
```

This allows you to define custom behavior and styling for your components.

### Overriding Sections

You can override existing sections like `HeaderSection`, `BodySection`, or `FooterSection` to provide default behavior or styling. For example:

```csharp
using QuestPDF.Pieces.Sections;
using QuestPDF.Pieces.Components;

public class DefaultHeaderSection : HeaderSection
{
    public DefaultHeaderSection()
    {
        AddComponent(new TextLine("Default Header", size: 18));
    }
}
```

This enables you to standardize headers, footers, or other sections across your documents.

---

## 📜 License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT). See the `LICENSE` file for more details.

---

## 🤝 Contributing

Contributions are welcome! If you have ideas for improvements or new features, feel free to open an issue or submit a pull request. Please ensure your contributions align with the project's goals and coding standards.

---

## 📧 Contact

For questions, feedback, or support, please reach out via the [GitHub repository](https://github.com/BTBlueTiger/QuestPDF.Pieces).

---
