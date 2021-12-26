using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.FactoryPattern
{
    public class FactoryExecutor : IExecute
    {
        public void Execute()
        {
            var imageReader = ImageReaderFactory.GetImageReader(ImageReaderType.JpegReader);
            var decodedImage = imageReader.GetDecodedImage("some image");
            Console.WriteLine(decodedImage);
        }
    }
}
