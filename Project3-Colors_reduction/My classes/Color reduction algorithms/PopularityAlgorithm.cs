
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Drawing;

namespace Project3_Colors_reduction.Color_reduction_algorithms
{
    public class PopularityAlgorithm : IColorsReductionAlgorithm
    {
        public string AlgorithmName { get { return "popularity algorithm"; } }
        int k;

        public PopularityAlgorithm(int k)
        {
            this.k = k;
        }

        public void AssignBasicParameters(int[] parameters)
        {
            k = parameters[0];
        }

        public DirectBitmap ReduceColors(DirectBitmap image)
        {
            Dictionary<Color, int> imageColorsCount = GetImageColorsCount(image);
            if (imageColorsCount.Count <= k)
                return image;
            Color[] kMostPopularColors = imageColorsCount.OrderByDescending(iCC => iCC.Value).Take(k).Select(iCC => iCC.Key).ToArray();

            DirectBitmap newImage = new DirectBitmap(image.Width, image.Height);
            Parallel.For(0, image.Height * image.Width, i =>
              {
                  int x = i % image.Height, y = i / image.Height;
                  newImage.SetPixel(x, y, GetClosestColor(image.GetPixel(x, y), kMostPopularColors));
              });
            return newImage;
        }

        private Dictionary<Color, int> GetImageColorsCount(DirectBitmap image)
        {
            Dictionary<Color, int> colorsDictionary = new Dictionary<Color, int>();
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    if (!colorsDictionary.ContainsKey(pixelColor))
                        colorsDictionary.Add(pixelColor, 0);
                    colorsDictionary[pixelColor]++;
                }
            }
            return colorsDictionary;
        }

        public Color GetClosestColor(Color color, Color[] palette)
        {
            Color closestColor = default(Color);
            double distToClosestColor = double.MaxValue;
            for (int i = 0; i < palette.Length; i++)
            {
                double currDist = GetColorsDistance(color, palette[i]);
                if (currDist < distToClosestColor)
                {
                    distToClosestColor = currDist;
                    closestColor = palette[i];
                }
                if (distToClosestColor == 0)
                    return closestColor;
            }
            return closestColor;
        }

        private double GetColorsDistance(Color first, Color second)
        {
            double rDiff = first.R - second.R, gDiff = first.G - second.G, bDiff = first.B - second.B;
            return Math.Sqrt(rDiff * rDiff + gDiff * gDiff + bDiff * bDiff);
        }
    }
}
