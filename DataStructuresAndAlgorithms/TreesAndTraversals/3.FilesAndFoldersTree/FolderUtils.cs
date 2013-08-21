namespace FilesAndFoldersTree
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class FolderUtils
    {
        static void Main()
        {
            string path = @"C:\Windows";
            string extension = "*.exe";

            var folderTree = TraverseFiles(path, extension);
            Console.WriteLine("Finished");
            Console.WriteLine(GetFileSizes(folderTree) + " bytes in exe files.");
        }

        public static long GetFileSizes(Folder folder)
        {
            long size = 0;

            foreach (var file in folder.Files)
            {
                size += file.Size;
            }

            foreach (var subFolder in folder.ChildFolders)
            {
                size += GetFileSizes(subFolder);
            }

            return size;
        }

        public static Folder TraverseFiles(string path, string extension)
        {
            File[] files = new File[0];
            Folder[] folders = new Folder[0];
            try
            {
                string[] exeFiles = Directory.GetFiles(path, extension);
                files = new File[exeFiles.Length];

                for (int i = 0; i < exeFiles.Length; i++)
                {
                    FileInfo fileInfo = new FileInfo(exeFiles[i]);
                    files[i] = new File(fileInfo.Name, fileInfo.Length);
                }

                string[] directories = Directory.GetDirectories(path);
                folders = new Folder[directories.Length];

                for (int i = 0; i < directories.Length; i++)
                {
                    folders[i] = new Folder(directories[i]);
                    folders[i] = TraverseFiles(directories[i], extension);
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Directory: {0}, can't be accessed!", path);

            }

            Folder tree = new Folder(path, files, folders);
            return tree;
        }
    }
}
