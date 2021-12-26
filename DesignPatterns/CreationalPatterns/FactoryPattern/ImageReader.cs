using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.FactoryPattern
{
    public interface ImageReader
    {
        public DecodedImage GetDecodedImage(string image);
    }
}
