namespace FilesAndFoldersTree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Folder
    {
        public string Name { get; set; }
        public File[] Files { get; set; }
        public Folder[] ChildFolders { get; set; }

        public Folder(string name)
        {
            this.Name = name;
            this.Files = new File[1000];
            this.ChildFolders = new Folder[1000];
        }

        public Folder(string name, params File[] files)
            : this(name)
        {
            this.Files = files;
        }

        public Folder(string name, File[] files, Folder[] folders)
            : this(name)
        {
            this.Files = files;
            this.ChildFolders = folders;
        }


    }
}
