
namespace Project3_Colors_reduction.Color_reduction_algorithms
{
    public abstract class AbstractDithering : IColorsReductionAlgorithm
    {
        abstract public string AlgorithmName { get; }
        protected int kR, kG, kB;

        public AbstractDithering((int kR, int kG, int kB) parameters)
        {
            kR = parameters.kR;
            kG = parameters.kG;
            kB = parameters.kB;
        }

        public void AssignBasicParameters(int[] parameters)
        {
            kR = parameters[0];
            kG = parameters[1];
            kB = parameters[2];
        }

        abstract public DirectBitmap ReduceColors(DirectBitmap image);
    }
}
