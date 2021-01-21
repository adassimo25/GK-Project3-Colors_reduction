
using System;
using System.Drawing;

namespace Project3_Colors_reduction.Color_reduction_algorithms
{
    public class ErrorDiffusionDithering : AbstractDithering
    {
        override public string AlgorithmName { get { return "error diffusion dithering"; } }

        public ErrorDiffusionDithering((int, int, int) parameters) : base(parameters) { }

        override public DirectBitmap ReduceColors(DirectBitmap image)
        {
            DirectBitmap newImage = new DirectBitmap(image.Width, image.Height, image);

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color oldColor = newImage.GetPixel(x, y);
                    Color newColor = CalculateNewColor(oldColor);
                    newImage.SetPixel(x, y, newColor);
                    (float, float, float) quantError = CalculateQuantError(oldColor, newColor);
                    FloydSteinbergCorrection(newImage, x, y, quantError);
                }
            }

            return newImage;
        }

        private Color CalculateNewColor(Color oldColor)
        {
            double oldColorR = oldColor.R;
            double colorR = Math.Round(((double)kR - 1) / 255.0 * oldColorR) * (255.0 / ((double)kR - 1));
            double oldColorG = oldColor.G;
            double colorG = Math.Round(((double)kG - 1) / 255.0 * oldColorG) * (255.0 / ((double)kG - 1));
            double oldColorB = oldColor.B;
            double colorB = Math.Round(((double)kB - 1) / 255.0 * oldColorB) * (255.0 / ((double)kB - 1));
            return Color.FromArgb((int)colorR, (int)colorG, (int)colorB);
        }

        private (float, float, float) CalculateQuantError(Color oldColor, Color newColor)
        {
            return (oldColor.R - newColor.R, oldColor.G - newColor.G, oldColor.B - newColor.B);
        }

        private void FloydSteinbergCorrection(DirectBitmap image, int x, int y, (float, float, float) quantError)
        {
            if (x < image.Width - 1)
                FloydSteinbergPixelCorrection(image, x + 1, y, quantError, (float)(7.0 / 16.0));
            if (x > 0 && y < image.Height - 1)
                FloydSteinbergPixelCorrection(image, x - 1, y + 1, quantError, (float)(3.0 / 16.0));
            if (y < image.Height - 1)
                FloydSteinbergPixelCorrection(image, x, y + 1, quantError, (float)(5.0 / 16.0));
            if (x < image.Width - 1 && y < image.Height - 1)
                FloydSteinbergPixelCorrection(image, x + 1, y + 1, quantError, (float)(1.0 / 16.0));
        }

        private void FloydSteinbergPixelCorrection(DirectBitmap image, int x, int y, (float R, float G, float B) quantError, float factor)
        {
            Color pixelColor = image.GetPixel(x, y);

            float newPixelColorR = pixelColor.R + quantError.R * factor;
            newPixelColorR = Math.Max(newPixelColorR, 0);
            newPixelColorR = Math.Min(newPixelColorR, 255);
            float newPixelColorG = pixelColor.G + quantError.G * factor;
            newPixelColorG = Math.Max(newPixelColorG, 0);
            newPixelColorG = Math.Min(newPixelColorG, 255);
            float newPixelColorB = pixelColor.B + quantError.B * factor;
            newPixelColorB = Math.Max(newPixelColorB, 0);
            newPixelColorB = Math.Min(newPixelColorB, 255);

            image.SetPixel(x, y, Color.FromArgb((int)newPixelColorR, (int)newPixelColorG, (int)newPixelColorB));
        }
    }
}
