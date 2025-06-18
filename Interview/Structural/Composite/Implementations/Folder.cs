using Interview.Structural.Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Structural.Composite.Implementations
{
    public class Folder : IFile
    {
        public string Name { get; set; }
        public List<IFile> Files { get; set; }


        public Folder(string name)
        {
            Name = name;
            Files = new List<IFile>();
        }

        public bool AddFile(IFile file)
        {
            Files.Add(file);
            return true;
        }

        public void Display(int indent = 0)
        {
            Console.WriteLine($"{new string('.', indent == 0 ? 0 : indent + 2)}{Name.ToLower()}/ ");
            foreach (var file in Files)
            {
                file.Display(indent + 2);
            }
        }
    }
}
