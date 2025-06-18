using Interview.Structural.Proxy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Structural.Proxy.Implementations
{
    public class RealImage : IImage
    {
        private string _fileName;
        public RealImage(string fileName)
        {
            _fileName = fileName;
            LoadImageFromDisk();
        }
        private void LoadImageFromDisk()
        {
            Console.WriteLine($"Loading image: {_fileName}");
        }
        public void DisplayImage()
        {
            Console.WriteLine($"Displaying image: {_fileName}");
        }
    }
}