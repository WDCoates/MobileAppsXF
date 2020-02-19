using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Forms;

namespace Ch13_Bitmaps
{
    public class BmpMaker
    {
        private const int HeaderSize = 54;
        private readonly byte[] buffer;
        public int Height { get; private set; }
        public int Width { get; private set; }

        public BmpMaker(int width, int height)
        {
            Width = width;
            Height = height;

            var numPixels = Width * Height;
            var numPixelBytes = 4 * numPixels;
            var fileSize = HeaderSize + numPixelBytes;
            buffer = new byte[fileSize];

            //Write headers in MemoryStream i.e. buffer.
            using (MemoryStream memStream = new MemoryStream(buffer))
            {
                using (BinaryWriter bWriter = new BinaryWriter(memStream, Encoding.UTF8))
                {
                    //Construct BMP header (14 bytes).
                    bWriter.Write(new char[] {'B', 'M'});   //Signature
                    bWriter.Write(fileSize);
                    bWriter.Write((short)0);                    // Reserved
                    bWriter.Write((short)0);                    // Reserved
                    bWriter.Write(HeaderSize);

                    // Construct BitmapInfoHeader
                    bWriter.Write(40);
                    bWriter.Write(Width);
                    bWriter.Write(Height);
                    bWriter.Write((short)1);                    // Planes
                    bWriter.Write((short)32);                   // Bits per pixel
                    bWriter.Write(0);                           // Compression
                    bWriter.Write(numPixelBytes);               // Image Size
                    bWriter.Write(0);                           // X pixels per meter
                    bWriter.Write(0);                           // Y pixels per meter
                    bWriter.Write(0);                           // Number of colours in colour table!
                    bWriter.Write(0);                           // Important colour count!
                }
            }
        }

        public void SetPixel(int row, int col, Color colour)
        {
            SetPixel(row, col, (int)(255 * colour.R),
                                    (int)(255 * colour.G),
                                    (int)(255 * colour.B),
                                    (int)(255 * colour.A)
            );
        }

        public void SetPixel(int row, int col, int r, int g, int b, int a)
        {
            var index = (row * Width + col) * 4 + HeaderSize;
            buffer[index + 0] = (byte)b;
            buffer[index + 1] = (byte)g;
            buffer[index + 2] = (byte)r;
            buffer[index + 3] = (byte)a;

        }

        public ImageSource Generate()
        {
            // Create MemoryStream from buffer with bitmap.
            var memoryStream = new MemoryStream(buffer);

            // Convert to StreamImageSource
            return ImageSource.FromStream(() => memoryStream);
        }
    }
}
