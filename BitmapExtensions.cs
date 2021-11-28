using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Lab3
{
    internal static class BitmapExtensions
    {
        internal static Bitmap ConvolutionFilter(this Bitmap image, double[,] matrix)
        {
            (var stride, var pixelBuffer) = GetBytesArrayFromBitmap(image);

            var resultBuffer = new byte[pixelBuffer.Count()];

            var filterWidth = matrix.GetLength(1);

            var filterOffset = (filterWidth - 1) / 2;
            var calcOffset = 0;
            var byteOffset = 0;

            for (var offsetY = filterOffset; offsetY < image.Height - filterOffset; offsetY++)
            {
                for (var offsetX = filterOffset; offsetX < image.Width - filterOffset; offsetX++)
                {
                    var blue = 0d;
                    var green = 0d;
                    var red = 0d;

                    byteOffset = offsetY *
                                 stride +
                                 offsetX * 4;

                    for (var filterY = -filterOffset; filterY <= filterOffset; filterY++)
                    {
                        for (var filterX = -filterOffset; filterX <= filterOffset; filterX++)
                        {
                            calcOffset = byteOffset +
                                         (filterX * 4) +
                                         (filterY * stride);

                            blue += (double)(pixelBuffer[calcOffset]) *
                                    matrix[filterY + filterOffset, filterX + filterOffset];

                            green += (double)(pixelBuffer[calcOffset + 1]) *
                                     matrix[filterY + filterOffset, filterX + filterOffset];

                            red += (double)(pixelBuffer[calcOffset + 2]) *
                                   matrix[filterY + filterOffset, filterX + filterOffset];
                        }
                    }

                    blue = NormalizeColorComponent(blue);
                    green = NormalizeColorComponent(green);
                    red = NormalizeColorComponent(red);                    

                    resultBuffer[byteOffset] = (byte)(blue);
                    resultBuffer[byteOffset + 1] = (byte)(green);
                    resultBuffer[byteOffset + 2] = (byte)(red);
                    resultBuffer[byteOffset + 3] = 255;
                }
            }

            return GetBitmapFromBytesArray(resultBuffer, image.Width, image.Height);
        }

        internal static Bitmap MedianFilter(this Bitmap image, int matrixSize)
        {
            (var stride, var pixelBuffer) = GetBytesArrayFromBitmap(image);

            var resultBuffer = new byte[pixelBuffer.Count()];

            var filterOffset = (matrixSize - 1) / 2;
            var calcOffset = 0;
            var byteOffset = 0;

            var neighbourPixels = new List<int>();
            byte[] middlePixel;

            for (var offsetY = filterOffset; offsetY < image.Height - filterOffset; offsetY++)
            {
                for (var offsetX = filterOffset; offsetX < image.Width - filterOffset; offsetX++)
                {
                    byteOffset = offsetY *
                                 stride +
                                 offsetX * 4;

                    neighbourPixels.Clear();

                    for (var filterY = -filterOffset;
                        filterY <= filterOffset; filterY++)
                    {
                        for (var filterX = -filterOffset;
                            filterX <= filterOffset; filterX++)
                        {
                            calcOffset = byteOffset +
                                         (filterX * 4) +
                                         (filterY * stride);

                            neighbourPixels.Add(BitConverter.ToInt32(
                                             pixelBuffer, calcOffset));
                        }
                    }

                    neighbourPixels.Sort();

                    middlePixel = BitConverter.GetBytes(
                                       neighbourPixels[filterOffset]);

                    resultBuffer[byteOffset] = middlePixel[0];
                    resultBuffer[byteOffset + 1] = middlePixel[1];
                    resultBuffer[byteOffset + 2] = middlePixel[2];
                    resultBuffer[byteOffset + 3] = middlePixel[3];
                }
            }

            return GetBitmapFromBytesArray(resultBuffer, image.Width, image.Height);
        }

        public static Bitmap ConvolutionFilter(this Bitmap image, double[,] xFilterMatrix, double[,] yFilterMatrix)
        {
            (var stride, var pixelBuffer) = GetBytesArrayFromBitmap(image);

            var resultBuffer = new byte[pixelBuffer.Count()];

            var filterOffset = 1;
            var calcOffset = 0;
            var byteOffset = 0;

            for (var offsetY = filterOffset; offsetY < image.Height - filterOffset; offsetY++)
            {
                for (var offsetX = filterOffset; offsetX < image.Width - filterOffset; offsetX++)
                {
                    var blueX = 0.0;
                    var greenX = 0.0;
                    var redX = 0.0;

                    var blueY = 0.0;
                    var greenY = 0.0;
                    var redY = 0.0;

                    var blueTotal = 0.0;
                    var greenTotal = 0.0;
                    var redTotal = 0.0;

                    byteOffset = offsetY *
                                 stride +
                                 offsetX * 4;

                    for (var filterY = -filterOffset; filterY <= filterOffset; filterY++)
                    {
                        for (var filterX = -filterOffset; filterX <= filterOffset; filterX++)
                        {
                            calcOffset = byteOffset +
                                         (filterX * 4) +
                                         (filterY * stride);

                            blueX += (double)
                                      (pixelBuffer[calcOffset]) *
                                      xFilterMatrix[filterY + filterOffset, filterX + filterOffset];

                            greenX += (double)
                                  (pixelBuffer[calcOffset + 1]) *
                                      xFilterMatrix[filterY + filterOffset, filterX + filterOffset];

                            redX += (double)
                                  (pixelBuffer[calcOffset + 2]) *
                                      xFilterMatrix[filterY + filterOffset, filterX + filterOffset];

                            blueY += (double)
                                      (pixelBuffer[calcOffset]) *
                                      yFilterMatrix[filterY + filterOffset, filterX + filterOffset];

                            greenY += (double)
                                  (pixelBuffer[calcOffset + 1]) *
                                      yFilterMatrix[filterY + filterOffset, filterX + filterOffset];

                            redY += (double)
                                  (pixelBuffer[calcOffset + 2]) *
                                      yFilterMatrix[filterY + filterOffset, filterX + filterOffset];
                        }
                    }

                    blueTotal = Math.Sqrt((blueX * blueX) + (blueY * blueY));

                    greenTotal = Math.Sqrt((greenX * greenX) + (greenY * greenY));

                    redTotal = Math.Sqrt((redX * redX) + (redY * redY));

                    blueTotal = NormalizeColorComponent(blueTotal);
                    greenTotal = NormalizeColorComponent(greenTotal);
                    redTotal = NormalizeColorComponent(redTotal);

                    resultBuffer[byteOffset] = (byte)(blueTotal);
                    resultBuffer[byteOffset + 1] = (byte)(greenTotal);
                    resultBuffer[byteOffset + 2] = (byte)(redTotal);
                    resultBuffer[byteOffset + 3] = 255;
                }
            }

            return GetBitmapFromBytesArray(resultBuffer, image.Width, image.Height);
        }

        private static Bitmap GetBitmapFromBytesArray(byte[] array, int width, int height)
        {
            var resultBitmap = new Bitmap(width, height);

            var resultData = resultBitmap.LockBits(new Rectangle(0, 0, resultBitmap.Width, resultBitmap.Height),
                ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            Marshal.Copy(array, 0, resultData.Scan0, array.Length);
            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }

        private static (int, byte[]) GetBytesArrayFromBitmap(Bitmap image)
        {
            var sourceData =
               image.LockBits(new Rectangle(0, 0,
               image.Width, image.Height),
               ImageLockMode.ReadOnly,
               PixelFormat.Format32bppArgb);

            var resultBuffer = new byte[sourceData.Stride *
                                   sourceData.Height];

            Marshal.Copy(sourceData.Scan0, resultBuffer, 0,
                              resultBuffer.Length);

            image.UnlockBits(sourceData);

            return (sourceData.Stride, resultBuffer);
        }

        private static double NormalizeColorComponent(double component)
        {
            if (component > 255)
            {
                return 255.0;
            }
            else if (component < 0)
            {
                return 0.0;
            }

            return component;
        }
    }
}
