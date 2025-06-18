using Interview.Structural.Proxy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Structural.Proxy.Implementations
{
    public class ProxyImage : IImage
    {
        private RealImage _realImage;
        private string _fileName;
        public ProxyImage(string fileName)
        {
            _fileName = fileName;
        }

        public void DisplayImage()
        {
            if (_realImage == null)
            {
                _realImage = new RealImage(_fileName);
                _realImage.DisplayImage();
            } else
            {
                _realImage.DisplayImage();   
            }
        }
    }
}
