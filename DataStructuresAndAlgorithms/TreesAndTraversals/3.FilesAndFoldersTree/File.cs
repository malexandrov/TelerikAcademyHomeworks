namespace FilesAndFoldersTree
{
    using System;
    using System.Collections.Generic;

    public class File
    {
        public string Filename { get; set; }
        public long Size { get; set; }

        public File(string filename, long size)
        {
            this.Filename = filename;
            this.Size = size;
        }
    }
}
