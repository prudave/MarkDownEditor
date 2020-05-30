using MarkDownEditor.Model;
using MarkDownEditor.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Xunit;
using static MarkDownEditor.ViewModel.MainViewModel;

namespace MarkDownEditor.Test.ExportTests
{
    public class GithubMarkdownExportTest
    {
        private const string resourcesPath = "..\\..\\..\\Resources\\";
        protected string mdType = "GitHub Flavored Markdown";
        protected string pathChange = "markdown_github";


        [Fact]
        public void HTMLPlainExporterTest()
        {
            string exportType = "Plain Html";

            string inputPath = resourcesPath + "input.md";
            string outputPath = resourcesPath + pathChange + "\\output\\plain.html";
            string refOutputPath = resourcesPath + pathChange + "\\reference\\plain.html";

            Assert.True(DocumentExporter.CanExport(exportType));

            DocumentExporter.Export(exportType,
                MarkDownType[mdType],
                null,
                inputPath,
                outputPath);

            Assert.True(TestUtils.FileEquals(outputPath, refOutputPath));
        }

        [Fact]
        public void HTMLFullExporterTest()
        {
            string exportType = "Html";

            string inputPath = resourcesPath + "input.md";
            string outputPath = resourcesPath + pathChange + "\\output\\css_math.html";
            string refOutputPath = resourcesPath + pathChange + "\\reference\\css_math.html";

            string cssPath = resourcesPath + "Default.css";

            //Settings.ShowMathJax = true;

            Assert.True(DocumentExporter.CanExport(exportType));

            DocumentExporter.Export(exportType,
                MarkDownType[mdType],
                cssPath,
                inputPath,
                outputPath);

            Assert.True(TestUtils.FileEquals(outputPath, refOutputPath));
        }
        [Fact]
        public void HTMLMathExporterTest()
        {
            string exportType = "Html";

            string inputPath = resourcesPath + "input.md";
            string outputPath = resourcesPath + pathChange + "\\output\\math.html";
            string refOutputPath = resourcesPath + pathChange + "\\reference\\math.html";

            string cssPath = null;

            Assert.True(DocumentExporter.CanExport(exportType));

            DocumentExporter.Export(exportType,
                MarkDownType[mdType],
                cssPath,
                inputPath,
                outputPath);

            Assert.True(TestUtils.FileEquals(outputPath, refOutputPath));
        }

        [Fact]
        public void PDFFullExporterTest()
        {
            string exportType = "PDF";

            string inputPath = resourcesPath + "input.md";
            string outputPath = resourcesPath + pathChange + "\\output\\css_math.pdf";
            string refOutputPath = resourcesPath + pathChange + "\\reference\\css_math.pdf";

            string cssPath = resourcesPath + "Default.css";

            Assert.True(DocumentExporter.CanExport(exportType));

            DocumentExporter.Export(exportType,
                MarkDownType[mdType],
                cssPath,
                inputPath,
                outputPath);

            Assert.True(TestUtils.FileEquals(outputPath, refOutputPath));
        }
        [Fact]
        public void PDFCssExporterTest()
        {
            string exportType = "PDF";

            string inputPath = resourcesPath + "input.md";
            string outputPath = resourcesPath + pathChange + "\\output\\css.pdf";
            string refOutputPath = resourcesPath + pathChange + "\\reference\\css.pdf";

            string cssPath = resourcesPath + "Default.css";

            Assert.True(DocumentExporter.CanExport(exportType));

            DocumentExporter.Export(exportType,
                MarkDownType[mdType],
                cssPath,
                inputPath,
                outputPath);

            Assert.True(TestUtils.FileEquals(outputPath, refOutputPath));
        }

        [Fact]
        public void PDFPlainExporterTest()
        {
            string exportType = "PDF";

            string inputPath = resourcesPath + "input.md";
            string outputPath = resourcesPath + pathChange + "\\output\\plain.pdf";
            string refOutputPath = resourcesPath + pathChange + "\\reference\\plain.pdf";

            string cssPath = null;

            Assert.True(DocumentExporter.CanExport(exportType));

            DocumentExporter.Export(exportType,
                MarkDownType[mdType],
                cssPath,
                inputPath,
                outputPath);

            Assert.True(TestUtils.FileEquals(outputPath, refOutputPath));
        }

        [Fact]
        public void ImageMathExporterTest()
        {
            string exportType = "Image";

            string inputPath = resourcesPath + "input.md";
            string outputPath = resourcesPath + pathChange + "\\output\\math.jpg";
            string refOutputPath = resourcesPath + pathChange + "\\reference\\math.jpg";

            string cssPath = null;

            Assert.True(DocumentExporter.CanExport(exportType));

            DocumentExporter.Export(exportType,
                MarkDownType[mdType],
                cssPath,
                inputPath,
                outputPath);

            Assert.True(TestUtils.FileEquals(outputPath, refOutputPath));
        }


        [Fact]
        public void ImagePlainExporterTest()
        {
            string exportType = "Image";

            string inputPath = resourcesPath + "input.md";
            string outputPath = resourcesPath + pathChange + "\\output\\plain.jpg";
            string refOutputPath = resourcesPath + pathChange + "\\reference\\plain.jpg";

            string cssPath = null;

            Assert.True(DocumentExporter.CanExport(exportType));

            DocumentExporter.Export(exportType,
                MarkDownType[mdType],
                cssPath,
                inputPath,
                outputPath);

            Assert.True(TestUtils.FileEquals(outputPath, refOutputPath));
        }


        [Fact]
        public void ImageFullExporterTest()
        {
            string exportType = "Image";

            string inputPath = resourcesPath + "input.md";
            string outputPath = resourcesPath + pathChange + "\\output\\css_math.jpg";
            string refOutputPath = resourcesPath + pathChange + "\\reference\\css_math.jpg";

            string cssPath = resourcesPath + "Default.css";

            Assert.True(DocumentExporter.CanExport(exportType));

            DocumentExporter.Export(exportType,
                MarkDownType[mdType],
                cssPath,
                inputPath,
                outputPath);

            Assert.True(TestUtils.FileEquals(outputPath, refOutputPath));
        }




        [Fact]
        public void RTFExporterTest()
        {
            string exportType = "RTF";

            string inputPath = resourcesPath + "input.md";
            string outputPath = resourcesPath + pathChange + "\\output\\output.rtf";
            string refOutputPath = resourcesPath + pathChange + "\\reference\\output.rtf";

            Assert.True(DocumentExporter.CanExport(exportType));

            DocumentExporter.Export(exportType,
                MarkDownType[mdType],
                null,
                inputPath,
                outputPath);

            Assert.True(TestUtils.FileEquals(outputPath, refOutputPath));
        }
        [Fact]
        public void DocxExporterTest()
        {
            string exportType = "Docx";

            string inputPath = resourcesPath + "input.md";
            string outputPath = resourcesPath + pathChange + "\\output\\output.docx";
            string refOutputPath = resourcesPath + pathChange + "\\reference\\output.docx";

            Assert.True(DocumentExporter.CanExport(exportType));

            DocumentExporter.Export(exportType,
                MarkDownType[mdType],
                null,
                inputPath,
                outputPath);

            Assert.True(TestUtils.FileEquals(outputPath, refOutputPath));
        }

        [Fact]
        public void LatexExporterTest()
        {
            string exportType = "Latex";

            string inputPath = resourcesPath + "input.md";
            string outputPath = resourcesPath + pathChange + "\\output\\output.tex";
            string refOutputPath = resourcesPath + pathChange + "\\reference\\output.tex";

            Assert.True(DocumentExporter.CanExport(exportType));

            DocumentExporter.Export(exportType,
                MarkDownType[mdType],
                null,
                inputPath,
                outputPath);

            Assert.True(TestUtils.FileEquals(outputPath, refOutputPath));
        }
        [Fact]
        public void EpubExporterTest()
        {
            string exportType = "Epub";

            string inputPath = resourcesPath + "input.md";
            string outputPath = resourcesPath + pathChange + "\\output\\output.epub";
            string refOutputPath = resourcesPath + pathChange + "\\reference\\output.epub";

            Assert.True(DocumentExporter.CanExport(exportType));

            DocumentExporter.Export(exportType,
                MarkDownType[mdType],
                null,
                inputPath,
                outputPath);

            Assert.True(TestUtils.FileEquals(outputPath, refOutputPath));
        }
    }
}
