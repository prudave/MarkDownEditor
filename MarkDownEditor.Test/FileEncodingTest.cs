using MarkDownEditor.SimpleHelpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace MarkDownEditor.Test
{
    public class FileEncodingTest
    {
        private FileEncoding encoding;
        private const string resourcesPath = "..\\..\\..\\Resources\\";
        private const string asciiPath = resourcesPath + "ascii.md";
        private const string utf8Path = resourcesPath + "utf8.md";
        private const string win1258Path = resourcesPath + "win1258.md";
        private const string emptyPath = resourcesPath + "empty.md";
        private const string binaryPath = resourcesPath + "binary.data";


        public FileEncodingTest()
        {
            encoding = new FileEncoding();
        }

        [Fact]
        public void Test1()
        {
            encoding.Reset();

            using (var fileStream = new FileStream(@asciiPath, FileMode.Open, FileAccess.Read))
            {
                string name = encoding.Detect(fileStream);
                Assert.Equal("ASCII", name);
            }
        }
        [Fact]
        public void Test2()
        {
            encoding.Reset();

            using (var fileStream = new FileStream(emptyPath, FileMode.Open, FileAccess.Read))
            {
                string name = encoding.Detect(fileStream);
                Assert.Null(name);
            }
        }
        [Fact]
        public void Test3()
        {
            encoding.Reset();

            using (var fileStream = new FileStream(emptyPath, FileMode.Open, FileAccess.Read))
            {
                string name = encoding.Detect(fileStream);
                Assert.Null(name);
            }
        }
        [Fact]
        public void Test4()
        {
            encoding.Reset();
            using (var fileStream = new FileStream(emptyPath, FileMode.Open, FileAccess.Read))
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => encoding.Detect(fileStream, 1024, 0));
            }
        }
        [Fact]
        public void Test5()
        {
            encoding.Reset();
            using (var fileStream = new FileStream(asciiPath, FileMode.Open, FileAccess.Read))
            {
                string name = encoding.Detect(fileStream, 1024, 1024*64);
                Assert.Equal("ASCII", name);
            }
        }
        [Fact]
        public void Test6()
        {
            encoding.Reset();
            using (var fileStream = new FileStream(asciiPath, FileMode.Open, FileAccess.Read))
            {
                string name = encoding.Detect(fileStream, 0);
                Assert.Equal("ASCII", name);
            }
        }
        [Fact]
        public void Test7()
        {
            encoding.Reset();
            using (var fileStream = new FileStream(asciiPath, FileMode.Open, FileAccess.Read))
            {
                
                string name = encoding.Detect(fileStream, -1, 1024);
                Assert.Equal("ASCII", name);
                Assert.True(encoding.IsText);
            }
        }

       

        [Fact]
        public void Test10()
        {          
            encoding.Reset();
            
            byte[] file = File.ReadAllBytes(asciiPath);

            encoding.Done = true;

            string name = encoding.Detect(file, 0, file.Length);

            Assert.Null(name);
        }

        [Fact]
        public void Test11()
        {
            //encoding.Reset();
            //byte[] file = File.ReadAllBytes(binaryPath);
            //string name = encoding.Detect(file, 0, file.Length);
            //Assert.False(encoding.IsText);

            encoding.Reset();
            using (var fileStream = new FileStream(binaryPath, FileMode.Open, FileAccess.Read))
            {

                string name = encoding.Detect(fileStream, 0);
                Assert.False(encoding.IsText);
                Assert.True(encoding.Done);
            }


        }
        [Fact]
        public void Test12()
        {
            encoding.Reset();
            byte[] file = File.ReadAllBytes(utf8Path);
            string name = null;

            while (!encoding.Done)
            {
                name = encoding.Detect(file, 0, file.Length);
            }
            Assert.True(encoding.Done);
            
            Assert.Equal("UTF-8", name);
        }
        [Fact]
        public void Test13()
        {
            encoding.Reset();
            byte[] file = File.ReadAllBytes(asciiPath);
            
            
            string name = encoding.Detect(file, 0, 6*1024);
            
            Assert.Equal("ASCII", name);
        }
        [Fact]
        public void Test14()
        {
            encoding.Reset();
            byte[] file = File.ReadAllBytes(asciiPath);


            string name = encoding.Detect(file, 0, 1024);

            Assert.Equal("ASCII", name);
        }
        [Fact]
        public void Test15()
        {
            encoding.Reset();
            byte[] file1 = File.ReadAllBytes(asciiPath);
            byte[] file2 = File.ReadAllBytes(utf8Path);
            byte[] file3 = File.ReadAllBytes(win1258Path);

            byte[] rv = new byte[1024*3];
            System.Buffer.BlockCopy(file1, 0, rv, 0, 1024);
            System.Buffer.BlockCopy(file2, 0, rv, 1024, 1024);
            System.Buffer.BlockCopy(file3, 0, rv, 1024 + 1024, 1024);


            string name = encoding.Detect(rv, 0, 1024*3);

            Assert.Equal("ASCII", name);
        }
    }
}
