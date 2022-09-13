using Svg;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svg2icons
{
    public class IconFile
    {
        const uint HEADER_SIZE = 6;
        const uint ENTRY_SIZE = 16;

        public void AddImage(IconImage image)
        {
            _images.Add(image);
        }

        public void AddImage(SvgDocument svg, int width)
            => AddImage(new IconImage(width, GetPngFromSvg(svg, width)));

        static byte[] GetPngFromSvg(SvgDocument svg, int width)
        {
            using (var png = svg.Draw(width, width))
            {
                using (var stream = new MemoryStream())
                {
                    png.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    return stream.ToArray();
                }
            }
        }

        public void Save(string fileName)
        {
            if (_images.Count == 0)
                return;

            using (var writer = new BinaryWriter(File.Create(fileName)))
            {
                var offset = HEADER_SIZE + ((uint)_images.Count * ENTRY_SIZE);
                WriteHeader(writer);
                foreach (var img in _images)
                {
                    WriteImage(writer, img, offset);
                    offset += (uint)img.Data.Length;
                }
                foreach (var img in _images)
                    writer.Write(img.Data, 0, img.Data.Length);
            }
        }

        void WriteHeader(BinaryWriter writer)
        {
            writer.Write((UInt16)0);                    // Reserved. Always 0
            writer.Write((UInt16)1);                    // Image type: 1 - icon (.ico), 2 = cursor (.cur)
            writer.Write((UInt16)_images.Count);        // Number of images
        }

        void WriteImage(BinaryWriter writer, IconImage image, UInt32 offset)
        {
            writer.Write((byte)image.Width);            // Width in pixels
            writer.Write((byte)image.Height);           // Height in pixels
            writer.Write((byte)0);                      // Number of colours in palette (0 for no palette)
            writer.Write((byte)0);                      // Reserved. Always 0
            writer.Write((UInt16)1);                    // Number of colour planes
            writer.Write((UInt16)image.BitsPerPixel);   // Bits per pixel
            writer.Write((UInt32)image.Data.Length);    // Size of image data
            writer.Write((UInt32)offset);               // Start of image data
        }

        List<IconImage> _images = new List<IconImage>();
    }

    public struct IconImage
    {
        public IconImage(int width, byte[] data)
        {
            Width = width;
            Height = width;
            BitsPerPixel = 4;
            Data = data;
        }

        public IconImage(int width, int bitsPerPixel, byte[] data)
        {
            Width = width;
            Height = width;
            BitsPerPixel = bitsPerPixel;
            Data = data;
        }

        public IconImage(int width, int height, int bitsPerPixel, byte[] data)
        {
            Width = width;
            Height = height;
            BitsPerPixel = bitsPerPixel;
            Data = data;
        }

        public int Width { get; }
        public int Height { get; }
        public int BitsPerPixel { get; }
        public byte[] Data { get; }
    }
}
