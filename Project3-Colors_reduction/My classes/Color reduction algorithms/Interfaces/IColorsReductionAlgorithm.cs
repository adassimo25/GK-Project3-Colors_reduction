
namespace Project3_Colors_reduction.Color_reduction_algorithms
{
    public interface IColorsReductionAlgorithm
    {
        string AlgorithmName { get; }
        void AssignBasicParameters(params int[] parameters);
        DirectBitmap ReduceColors(DirectBitmap image);
    }
}
