using Interview.Structural.Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Structural.Composite.Implementations
{
    public class FileItem : IFile
    {
        public string Name { get; private set; }
        public int Size { get; private set; }
        public FileItem(string name, int size)
        {
            Name = name;
            Size = size;
        }
        public void Display(int indent = 0)
        {
            Console.WriteLine($"{new string('.', indent + 2)}{Name.ToLower()}, {Size} bytes");
        }
    }
}
