using MarkDownEditor.Model;
using MarkDownEditor.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Xunit;
using static MarkDownEditor.ViewModel.MainViewModel;

namespace MarkDownEditor.Test
{
    public class DocumentExporterTest : IDisposable
    {
        private const string resourcesPath = "..\\..\\..\\Resources\\";

        //SettingsViewModel Settings = new SettingsViewModel();
        public DocumentExporterTest()
        {
            

        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }


        [Fact]
        public void CanExportTest1()
        {
            Assert.True(DocumentExporter.CanExport("Plain Html"));
            Assert.False(DocumentExporter.CanExport("Bad type"));
        }
        [Fact]
        public void CanExportTest2()
        {
            Assert.False(DocumentExporter.CanExport(null));
        }



        [Fact]
        public void HTMLPlainExporterTest()
        {
            string exportType = "Plain Html";

            string inputPath = resourcesPath + "input.md";
            string outputPath = resourcesPath + "output\\plan.html";
            string refOutputPath = resourcesPath + "reference\\plain.html";

            Assert.True(DocumentExporter.CanExport(exportType));

            DocumentExporter.Export(exportType, 
                MarkDownType["Markdown"], 
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
            string outputPath = resourcesPath + "output\\css_math.html";
            string refOutputPath = resourcesPath + "reference\\css_math.html";

            string cssPath = resourcesPath + "Default.css";

            //Settings.ShowMathJax = true;

            Assert.True(DocumentExporter.CanExport(exportType));

            DocumentExporter.Export(exportType,
                MarkDownType["Markdown"],
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
            string outputPath = resourcesPath + "output\\math.html";
            string refOutputPath = resourcesPath + "reference\\math.html";

            string cssPath = null;

            Assert.True(DocumentExporter.CanExport(exportType));

            DocumentExporter.Export(exportType,
                MarkDownType["Markdown"],
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
            string outputPath = resourcesPath + "output\\css_math.pdf";
            string refOutputPath = resourcesPath + "reference\\css_math.pdf";

            string cssPath = resourcesPath + "Default.css";

            Assert.True(DocumentExporter.CanExport(exportType));

            DocumentExporter.Export(exportType,
                MarkDownType["Markdown"],
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
            string outputPath = resourcesPath + "output\\css.pdf";
            string refOutputPath = resourcesPath + "reference\\css.pdf";

            string cssPath = resourcesPath + "Default.css";

            Assert.True(DocumentExporter.CanExport(exportType));

            DocumentExporter.Export(exportType,
                MarkDownType["Markdown"],
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
            string outputPath = resourcesPath + "output\\plain.pdf";
            string refOutputPath = resourcesPath + "reference\\plain.pdf";

            string cssPath = null;

            Assert.True(DocumentExporter.CanExport(exportType));

            DocumentExporter.Export(exportType,
                MarkDownType["Markdown"],
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
            string outputPath = resourcesPath + "output\\math.jpg";
            string refOutputPath = resourcesPath + "reference\\math.jpg";

            string cssPath = null;

            Assert.True(DocumentExporter.CanExport(exportType));

            DocumentExporter.Export(exportType,
                MarkDownType["Markdown"],
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
            string outputPath = resourcesPath + "output\\plain.jpg";
            string refOutputPath = resourcesPath + "reference\\plain.jpg";

            string cssPath = null;

            Assert.True(DocumentExporter.CanExport(exportType));

            DocumentExporter.Export(exportType,
                MarkDownType["Markdown"],
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
            string outputPath = resourcesPath + "output\\css_math.jpg";
            string refOutputPath = resourcesPath + "reference\\css_math.jpg";

            string cssPath = resourcesPath + "Default.css";

            Assert.True(DocumentExporter.CanExport(exportType));

            DocumentExporter.Export(exportType,
                MarkDownType["Markdown"],
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
            string outputPath = resourcesPath + "output\\output.rtf";
            string refOutputPath = resourcesPath + "reference\\output.rtf";

            Assert.True(DocumentExporter.CanExport(exportType));

            DocumentExporter.Export(exportType,
                MarkDownType["Markdown"],
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
            string outputPath = resourcesPath + "output\\output.docx";
            string refOutputPath = resourcesPath + "reference\\output.docx";

            Assert.True(DocumentExporter.CanExport(exportType));

            DocumentExporter.Export(exportType,
                MarkDownType["Markdown"],
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
            string outputPath = resourcesPath + "output\\output.tex";
            string refOutputPath = resourcesPath + "reference\\output.tex";

            Assert.True(DocumentExporter.CanExport(exportType));

            DocumentExporter.Export(exportType,
                MarkDownType["Markdown"],
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
            string outputPath = resourcesPath + "output\\output.epub";
            string refOutputPath = resourcesPath + "reference\\output.epub";

            Assert.True(DocumentExporter.CanExport(exportType));

            DocumentExporter.Export(exportType,
                MarkDownType["Markdown"],
                null,
                inputPath,
                outputPath);

            Assert.True(TestUtils.FileEquals(outputPath, refOutputPath));
        }
    }
}
