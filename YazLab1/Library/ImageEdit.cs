using System;
using System.Collections.Generic;
using System.Drawing;

namespace YazLab1
{
    public static class ImageEdit
    {
        /// <summary>
        /// Bu metod parametre olarak aldığı resmin histogram değerlerini List<int[]> şeklinde ve histogram değerlerinin ortalamasını döndürür.
        /// </summary>
        public static (List<int[]> histogramValues, int histogramValueAverage) Histogram(Image image)
        {
            int[] red = new int[256];
            int[] green = new int[256];
            int[] blue = new int[256];
            int[] grayscale = new int[256];
            int[] histogram = new int[256];
            
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

                    var grayscalePixel = (pixel.R + pixel.G + pixel.B) / 3;
                    grayscale[grayscalePixel]++;

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

            return (new List<int[]> { red, green, blue, grayscale }, avgColors);
        }

        /// <summary>
        /// Bu metod parametre olarak aldığı resmin negatifini döndürür.
        /// </summary>
        public static Bitmap Negative(Image image)
        {
            Bitmap bitmap = new Bitmap(image);

            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color pixel = bitmap.GetPixel(x, y);
                    
                    int red = pixel.R;
                    int green = pixel.G;
                    int blue = pixel.B;

                    #region pixel renk değerleri 255'ten çıkarılarak negatif renk değerleri elde ediliyor
                    red = 255 - red;
                    green = 255 - green;
                    blue = 255 - blue; 
                    #endregion

                    bitmap.SetPixel(x, y, Color.FromArgb(red, green, blue));
                }
            }

            return bitmap;
        }

        public static Bitmap Mirror(Image image)
        {
            Bitmap oldBitmap = new Bitmap(image);

            for (int i = 0; i < oldBitmap.Height; i++)
            {
                for (int j = 0; j < oldBitmap.Width / 2; j++)
                {
                    Color p = oldBitmap.GetPixel(j, i); //TODO rename p to leftPixel
                    Color s = oldBitmap.GetPixel(oldBitmap.Width - 1 - j, i);
                    
                    int alpha = p.A;
                    int red = p.R;
                    int green = p.G;
                    int blue = p.B;
                    
                    int alpha2 = s.A;
                    int red2 = s.R;
                    int green2 = s.G;
                    int blue2 = s.B;

                    oldBitmap.SetPixel(j, i, Color.FromArgb(alpha2, red2, green2, blue2));
                    oldBitmap.SetPixel(oldBitmap.Width - 1 - j, i, Color.FromArgb(alpha, red, green, blue));
                }
            }

            return oldBitmap;
        }

        public static Bitmap Grayscale(Image image)
        {
            Bitmap bitmap = new Bitmap(image);

            int red, green, blue, average;

            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color pixel = bitmap.GetPixel(x, y);

                    red = pixel.R;
                    green = pixel.G;
                    blue = pixel.B;
                    average = (red + green + blue) / 3;
                    bitmap.SetPixel(x, y, Color.FromArgb(average, average, average));
                }
            }

            return bitmap;
        }

        /// <summary>
        /// Bu metod parametre olarak aldığı resmin renk kanallarının listesini döndürür.
        /// </summary>
        /// <returns></returns>
        public static List<Bitmap> ColorChannels(Image image)
        {
            List<Bitmap> channelsList = new List<Bitmap>();
            Bitmap bitmap = new Bitmap(image);

            var width = image.Width;
            var height = image.Height;
            
            Bitmap bitmap1 = new Bitmap(width, height);
            Bitmap bitmap2 = new Bitmap(width, height);
            Bitmap bitmap3 = new Bitmap(width, height);

            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color pixel = bitmap.GetPixel(x, y);
                    
                    bitmap1.SetPixel(x, y, Color.FromArgb(pixel.R, 0, 0));
                    bitmap2.SetPixel(x, y, Color.FromArgb(0, pixel.G, 0));
                    bitmap3.SetPixel(x, y, Color.FromArgb(0, 0, pixel.B));

                    channelsList.Add(bitmap1);
                    channelsList.Add(bitmap2);
                    channelsList.Add(bitmap3);
                }
            }

            return channelsList;
        }

        public static Bitmap Rotate(Image image)
        {
            var transposedImage = Transpose(image);
            var reversedImage = Mirror(transposedImage);

            return reversedImage;
        }

        public static Bitmap Transpose(Image image)
        {
            Bitmap bitmap = new Bitmap(image);
            Bitmap newBitmap = new Bitmap(image.Height, image.Width);

            var width = bitmap.Width;
            var height = bitmap.Height;
            
            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < width; column++)
                {
                    newBitmap.SetPixel(row, column, bitmap.GetPixel(column, row));
                }
            }
            return newBitmap;
        }

        public static string[,] Transpose(string[,] matrix)
        {
            var newMatrix = new string[2,9];

            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 2; column++)
                {
                    newMatrix[column, row] = matrix[row, column];
                }
            }

            return newMatrix;
        }

        public static string[,] ReverseRows(string[,] matrix)
        {
            var newMatrix = new string[2, 9];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j/2 <= 2 / 2; j++)
                {
                    newMatrix[2 - 1 - j, i] = matrix[i, j];
                }
            }

            return newMatrix;
        }

        public static Bitmap Scale(Image image, double rate)
        {
            Size oldSize = image.Size;
            Size newSize = Size.Empty;

            if (rate > 0)
            {
                var height = Convert.ToDouble(oldSize.Height) * (rate / 100.0);
                var width = Convert.ToDouble(oldSize.Width) * (rate / 100.0);

                newSize.Height = Convert.ToInt32(height);
                newSize.Width = Convert.ToInt32(width);
            }

            Bitmap bitmap = new Bitmap(image, newSize);

            return bitmap;
        }
    }
}
