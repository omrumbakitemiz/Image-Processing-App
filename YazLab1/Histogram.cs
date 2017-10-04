using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Diagnostics;

namespace YazLab1
{
    public static class Histogram
    {
        public static (List<int[]>, int) ImportImage()
        {
            int[] red = new int[256];
            int[] green = new int[256];
            int[] blue = new int[256];
            int[] histogram = new int[256];

            Image image = Image.FromFile(@"C:/image5.jpg");
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

            int sumRed = 0, sumGreen = 0, sumBlue = 0, avgRed, avgGreen, avgBlue, avgColors;

            for (int i = 0; i < 255; i++)
            {
                sumRed += red[i];
                sumGreen += green[i];
                sumBlue += blue[i];
            }

            avgRed = sumRed / 255;
            avgGreen = sumGreen / 255;
            avgBlue = sumBlue / 255;

            avgColors = (avgRed + avgGreen + avgBlue) / 3;

            return (new List<int[]> { red, green, blue }, avgColors);
        }
    }
}
