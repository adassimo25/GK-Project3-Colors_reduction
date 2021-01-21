
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Project3_Colors_reduction.Color_reduction_algorithms
{
    public class OrderedDitheringRandom : AbstractOrderedDithering
    {
        override public string AlgorithmName { get { return "ordered dithering random"; } }

        public OrderedDitheringRandom((int, int, int) parameters, Dictionary<int, int[,]> orderDitheringMatrices) : base(parameters, orderDitheringMatrices) { }

        override public DirectBitmap ReduceColors(DirectBitmap image)
        {
            DirectBitmap newImage = new DirectBitmap(image.Width, image.Height);

            (int[,] R, int[,] G, int[,] B) patterns = GetOrderedDitheringPatterns();
            Random random = new Random();

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color color = image.GetPixel(x, y);

                    int newColorR = CalculateNewColorComponent(patterns.R, kR, color.R, random);
                    int newColorG = CalculateNewColorComponent(patterns.G, kG, color.G, random);
                    int newColorB = CalculateNewColorComponent(patterns.B, kB, color.B, random);

                    Color newColor = Color.FromArgb(newColorR, newColorG, newColorB);
                    newImage.SetPixel(x, y, newColor);
                }
            }
            return newImage;
        }

        private int CalculateNewColorComponent(int[,] matrix, int k, double intensity, Random random)
        {
            double n = matrix.GetLength(0);
            int i = random.Next() % (int)n;
            int j = random.Next() % (int)n;
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
