using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace YazLab1
{
    public static class Histogram
    {
        public static List<int[]> ImportImage()
        {
            int[] red = new int[256];
            int[] green = new int[256];
            int[] blue = new int[256];
            int[] histogram = new int[256];

            Image image = Image.FromFile(@"C:/image8.jpg");
            Bitmap bitmap = new Bitmap(image);

            Color[] colors = new Color[image.Width * image.Height];

            for (int x = 0; x < bitmap.Size.Width; x++)
            {
                for (int y = 0; y < bitmap.Size.Height; y++)
                {
                    var pixel = bitmap.GetPixel(x, y);

                    red[pixel.R]++;
                    green[pixel.G]++;
                    blue[pixel.B]++;
                }
            }

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    red[colors[i].R]++;
            //    green[colors[i].G]++;
            //    blue[colors[i].B]++;
            //}

            return new List<int[]> { red, green, blue };
        }
    }
}
