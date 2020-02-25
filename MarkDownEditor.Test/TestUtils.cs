using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MarkDownEditor.Test
{
    public class TestUtils
    {
        public static bool FileEquals(string filePath1, string filePath2)
        {
            byte[] file1 = File.ReadAllBytes(filePath1);
            byte[] file2 = File.ReadAllBytes(filePath2);

            if (file1.Length == file2.Length)
            {
                for (int i = 0; i < file1.Length; i++)
                {
                    if (file1[i] != file2[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
