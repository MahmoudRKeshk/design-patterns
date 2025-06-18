using Interview.Structural.Composite.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Testing.Structural
{
    public static class CompositePatternTesting
    {
        public static void Run()
        {
            // Create files 
            var file1 = new FileItem("FileItem 1", 10);
            var file2 = new FileItem("FileItem 2", 20);
            var file3 = new FileItem("FileItem 3", 30);


            // Create a composite component
            var composite = new Folder("Root");
            composite.AddFile(file1);
            composite.AddFile(file2);
            composite.AddFile(file3);

            // Create a sub-folder and add it to the composite
            var subFolder = new Folder("SubFolder 1");
            subFolder.AddFile(new FileItem("SubFileItem 1", 5));
            subFolder.AddFile(new FileItem("SubFileItem 2", 15));
            composite.AddFile(subFolder);


            // Display the structure
            composite.Display(0);
        }
    }
}
