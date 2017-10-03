using System;
using System.Drawing;
using System.IO;

namespace YazLab1
{
    public static class Histogram
    {
        public static void ImportImage()
        {
            int[] red = new int[256];
            int[] green = new int[256];
            int[] blue = new int[256];
            int[] histogram = new int[256];

            Image image = Image.FromFile(@"C:/image5.jpg");
            Bitmap bitmap = new Bitmap(image);

            Color[] colors = new Color[image.Width * image.Height];

            for (int row = 0; row < bitmap.Size.Width; row++)
            {
                for (int column = 0; column < bitmap.Size.Height; column++)
                {
                    var pixel = bitmap.GetPixel(row, column);
                    
                    colors[column] = Color.FromArgb(pixel.R, pixel.G, pixel.B);
                }
            }

            for (int i = 0; i < colors.Length; i++)
            {
                red[colors[i].R]++;
                green[colors[i].G]++;
                blue[colors[i].B]++;
            }
        }
    }
}
