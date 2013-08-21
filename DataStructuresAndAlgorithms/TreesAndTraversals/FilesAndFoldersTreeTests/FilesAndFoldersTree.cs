using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FilesAndFoldersTree;
using System.IO;
using System.Linq;

namespace FilesAndFoldersTreeTests
{
    [TestClass]
    public class FilesAndFoldersTree
    {
        public static string extension = "*.exe";

        [TestMethod]
        public void TestRootFolderSize()
        {
            var folderTree = FolderUtils.TraverseFiles("..\\..\\TestDir\\", extension);
            long expected = GetDirectorySize("..\\..\\TestDir");
            long actual = FolderUtils.GetFileSizes(folderTree);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestFolderWithThreeSubfoldersAndFile()
        {
            var folderTree = FolderUtils.TraverseFiles("..\\..\\TestDir\\TestDir2_1", extension);
            long expected = GetDirectorySize("..\\..\\TestDir\\TestDir2_1");
            long actual = FolderUtils.GetFileSizes(folderTree);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestFolderWithOneFile()
        {
            var folderTree = FolderUtils.TraverseFiles("..\\..\\TestDir\\TestDir2_1\\TestDir2_2", extension);
            long expected = GetDirectorySize("..\\..\\TestDir\\TestDir2_1\\TestDir2_2");
            long actual = FolderUtils.GetFileSizes(folderTree);

            Assert.AreEqual(expected, actual);
        }

        private static long GetDirectorySize(string folderPath)
        {
            DirectoryInfo di = new DirectoryInfo(folderPath);
            return di.EnumerateFiles(extension, SearchOption.AllDirectories).Sum(fi => fi.Length);
        }
    }
}
