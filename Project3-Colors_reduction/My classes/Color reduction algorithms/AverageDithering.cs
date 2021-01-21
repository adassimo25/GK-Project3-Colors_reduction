
using System;
using System.Drawing;

namespace Project3_Colors_reduction.Color_reduction_algorithms
{
    public class AverageDithering : AbstractDithering
    {
        override public string AlgorithmName { get { return "average dithering"; } }

        public AverageDithering((int, int, int) parameters) : base(parameters) { }

        override public DirectBitmap ReduceColors(DirectBitmap image)
        {
            DirectBitmap newImage = new DirectBitmap(image.Width, image.Height);

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color color = image.GetPixel(x, y);

                    int newColorR = (int)CalculateNewColorComponent(color.R, kR);
                    int newColorG = (int)CalculateNewColorComponent(color.G, kG);
                    int newColorB = (int)CalculateNewColorComponent(color.B, kB);

                    Color newColor = Color.FromArgb(newColorR, newColorG, newColorB);
                    newImage.SetPixel(x, y, newColor);
                }
            }
            return newImage;
        }

        private double CalculateNewColorComponent(double colorComponent, double huesNumber)
        {
            return Math.Round((huesNumber - 1) / 255.0 * colorComponent) * 255.0 / (huesNumber - 1);
        }
    }
}
