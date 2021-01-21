
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Project3_Colors_reduction.Color_reduction_algorithms
{
    public class OrderedDitheringRelative : AbstractOrderedDithering
    {
        override public string AlgorithmName { get { return "ordered dithering relative"; } }

        public OrderedDitheringRelative((int, int, int) parameters, Dictionary<int, int[,]> orderDitheringMatrices) : base(parameters, orderDitheringMatrices) { }

        override public DirectBitmap ReduceColors(DirectBitmap image)
        {
            DirectBitmap newImage = new DirectBitmap(image.Width, image.Height);

            (int[,] R, int[,] G, int[,] B) patterns = GetOrderedDitheringPatterns(); 

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color color = image.GetPixel(x, y);

                    int newColorR = CalculateNewColorComponent(patterns.R, kR, color.R, x, y);
                    int newColorG = CalculateNewColorComponent(patterns.G, kG, color.G, x, y);
                    int newColorB = CalculateNewColorComponent(patterns.B, kB, color.B, x, y);

                    Color newColor = Color.FromArgb(newColorR, newColorG, newColorB);
                    newImage.SetPixel(x, y, newColor);
                }
            }
            return newImage;
        }

        private int CalculateNewColorComponent(int[,] matrix, int k, double intensity, int x, int y)
        {
            double n = matrix.GetLength(0);
            int i = y % (int)n;
            int j = x % (int)n;
            if (k != 2)
            {
                double col = intensity / (n * n);
                double re = intensity % (n * n);
                if (re >= matrix[i, j])
                    col++;
                return (int)Math.Min(col * n * n, 255);
            }
            return intensity > matrix[i, j] ? (int)intensity : 255;
        }
    }
}
