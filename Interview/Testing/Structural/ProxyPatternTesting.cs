using Interview.Structural.Proxy.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Testing.Structural
{
    public class ProxyPatternTesting
    {
        public static void Run()
        {

            var proxyImage = new ProxyImage("test_image.jpg");
            proxyImage.DisplayImage();

            // Display the image again to demonstrate that it does not reload. it is cached!
            proxyImage.DisplayImage();
        }
    }
}
