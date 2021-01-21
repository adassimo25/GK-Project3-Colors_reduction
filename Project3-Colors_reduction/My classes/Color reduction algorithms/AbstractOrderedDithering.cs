
using System;
using System.Collections.Generic;

namespace Project3_Colors_reduction.Color_reduction_algorithms
{
    public abstract class AbstractOrderedDithering : AbstractDithering
    {
        protected Dictionary<int, int[,]> orderDitheringMatrices;

        public AbstractOrderedDithering((int, int, int) parameters, Dictionary<int, int[,]> orderDitheringMatrices) : base(parameters)
        {
            this.orderDitheringMatrices = orderDitheringMatrices;
        }

        protected (int[,], int[,], int[,]) GetOrderedDitheringPatterns()
        {
            (int R, int G, int B) sizes = (RoundToExistingPattern(kR), RoundToExistingPattern(kG), RoundToExistingPattern(kB));
            return (orderDitheringMatrices[sizes.R], orderDitheringMatrices[sizes.G], orderDitheringMatrices[sizes.B]);
        }

        private int RoundToExistingPattern(double k)
        {
            int n = (int)Math.Ceiling(Math.Sqrt(256.0 / (k - 1)));
            for (int i = 0; i < Constants.patterns.Length; i++)
            {
                if (Constants.patterns[i] >= n)
                {
                    n = Constants.patterns[i];
                    break;
                }
            }
            return n;
        }
    }
}
