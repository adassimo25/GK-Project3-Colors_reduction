
using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace Project3_Colors_reduction
{
    public partial class Main : Form
    {
        private DirectBitmap ConvertImageToGreyscale(DirectBitmap image)
        {
            DirectBitmap grayImage = new DirectBitmap(image.Width, image.Height, image);
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color color = grayImage.GetPixel(x, y);
                    double gray = 0.299 * color.R + 0.587 * color.G + 0.114 * color.B;
                    grayImage.SetPixel(x, y, Color.FromArgb((int)gray, (int)gray, (int)gray));
                }
            }
            return grayImage;
        }

        #region Ordered dithering matrices

        private void CalculateOrderedDitheringMatrices()
        {
            int[,] matrix2 = new int[2, 2] { { 0, 2 }, { 3, 1 } };
            orderedDitheringMatrices.Add(2, matrix2);
            int[,] matrix3 = new int[3, 3] { { 6, 8, 4 }, { 1, 0, 3 }, { 5, 2, 7 } };
            orderedDitheringMatrices.Add(3, matrix3);

            AddOrderDitheringMatrix(4);
            AddOrderDitheringMatrix(6);
            AddOrderDitheringMatrix(8);
            AddOrderDitheringMatrix(12);
            AddOrderDitheringMatrix(16);
        }

        private void AddOrderDitheringMatrix(int n)
        {
            int halfN = n / 2;
            int[,] submatrix = orderedDitheringMatrices[halfN];
            int[,] matrix = new int[n, n];
            for (int i = 0; i < halfN; i++)
            {
                for (int j = 0; j < halfN; j++)
                {
                    matrix[i, j] = 4 * submatrix[i, j];
                    matrix[i + halfN, j] = 4 * submatrix[i, j] + 2;
                    matrix[i, j + halfN] = 4 * submatrix[i, j] + 3;
                    matrix[i + halfN, j + halfN] = 4 * submatrix[i, j] + 1;
                }
            }
            orderedDitheringMatrices.Add(n, matrix);
        }

        #endregion

        #region Visible images

        private void FitImageToPictureBox(Bitmap bitmap)
        {
            double k = Math.Min(pBWidth / ((double)bitmap.Width), pBHeight / ((double)bitmap.Height));
            int width = (int)(k * bitmap.Width), height = (int)(k * bitmap.Height);
            originalImage = new DirectBitmap(width, height);
            graphicsOriginal = Graphics.FromImage(originalImage.Bitmap);
            graphicsOriginal.DrawImage(bitmap, 0, 0, width, height);
        }

        private void UpdateImages()
        {
            pictureBoxOriginal.Image = GetProperOriginal().Bitmap;
            UpdateModifiedImage();
            pictureBoxOriginal.Refresh();
        }

        private DirectBitmap GetProperOriginal()
        {
            return (greyscaleToolStripMenuItem.Checked ? originalGreyImage : originalImage);
        }

        private void UpdateModifiedImage()
        {
            if (colorsReductionAlgorithm != null)
            {
                pictureBoxModified.Image = colorsReductionAlgorithm.ReduceColors(GetProperOriginal()).Bitmap;
                labelModified.Text = Constants.labelModifiedText + colorsReductionAlgorithm.AlgorithmName + ":";
                pictureBoxModified.Refresh();
            }
        }

        private void AddFullFrame()
        {
            int thickness = Constants.basicFrameThickness;
            int width = originalImage.Width, height = originalImage.Height;

            //black and white
            AddColorFrame(new SolidBrush(Color.FromArgb(0, 0, 0)), 0, thickness);
            AddColorFrame(new SolidBrush(Color.FromArgb(255, 255, 255)), 1, thickness);

            //rgb
            int pos = 2 * thickness;
            graphicsOriginal.FillRectangle(new SolidBrush(Color.FromArgb(255, 0, 0)), pos, pos, width - 2 * pos, thickness);
            graphicsOriginal.FillRectangle(new SolidBrush(Color.FromArgb(0, 255, 0)), width - pos - thickness, pos, thickness, height - 2 * pos);
            graphicsOriginal.FillRectangle(new SolidBrush(Color.FromArgb(0, 0, 255)), pos, height - pos - thickness, width - 2 * pos, thickness);

            //grays
            double wsp = 255.0 / (height - 2 * pos - thickness);
            for (int i = pos + thickness; i < height - pos; i++)
            {
                int intensity = (int)((i - pos - thickness) * wsp);
                Pen pen = new Pen(Color.FromArgb(intensity, intensity, intensity));
                graphicsOriginal.DrawLine(pen, pos, i, pos + thickness, i);
            }
        }

        private void AddColorFrame(SolidBrush solidBrush, int factor, int thickness)
        {
            int width = originalImage.Width, height = originalImage.Height;
            int facthic = factor * thickness;
            graphicsOriginal.FillRectangle(solidBrush, facthic, facthic, width - 2 * facthic, thickness);
            graphicsOriginal.FillRectangle(solidBrush, facthic, height - facthic - thickness, width - 2 * facthic, thickness);
            graphicsOriginal.FillRectangle(solidBrush, facthic, facthic, thickness, height - 2 * facthic);
            graphicsOriginal.FillRectangle(solidBrush, width - facthic - thickness, facthic, thickness, height - 2 * facthic);
        }

        #endregion

        private OpenFileDialog ImagesFileDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString(), "Images");
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Title = "Select image";
            openFileDialog.Multiselect = false;
            return openFileDialog;
        }

        private (int, int, int) GetDitheringParams()
        {
            int kR = (int)numericUpDownKR.Value;
            int kG = (int)numericUpDownKG.Value;
            int kB = (int)numericUpDownKB.Value;
            return (kR, kG, kB);
        }
    }
}
