
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Project3_Colors_reduction.Color_reduction_algorithms;

namespace Project3_Colors_reduction
{
    public partial class Main : Form
    {
        DirectBitmap originalImage, originalGreyImage;
        double pBWidth, pBHeight;
        Graphics graphicsOriginal;
        IColorsReductionAlgorithm colorsReductionAlgorithm = null;
        readonly Dictionary<int, int[,]> orderedDitheringMatrices = new Dictionary<int, int[,]>();

        public Main()
        {
            InitializeComponent();

            pBWidth = pictureBoxOriginal.Width;
            pBHeight = pictureBoxOriginal.Height;

            FitImageToPictureBox(Properties.Resources.LenaForsenPhoto);
            originalGreyImage = ConvertImageToGreyscale(originalImage);
            pictureBoxOriginal.Image = originalImage.Bitmap;
            pictureBoxOriginal.Refresh();

            CalculateOrderedDitheringMatrices();

            labelFocus.Focus();
        }

        #region Menu

        private void greyscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            greyscaleToolStripMenuItem.Checked = !greyscaleToolStripMenuItem.Checked;
            UpdateImages();
        }

        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = ImagesFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap newImage = new Bitmap(new Bitmap(openFileDialog.FileName));
                FitImageToPictureBox(newImage);
                originalGreyImage = ConvertImageToGreyscale(originalImage);
                UpdateImages();
            }
        }

        private void modifyImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFullFrame();
            originalGreyImage = ConvertImageToGreyscale(originalImage);
            UpdateImages();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Select algorithm

        private void radioButtonAverageDithering_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAverageDithering.Checked)
            {
                colorsReductionAlgorithm = new AverageDithering(GetDitheringParams());
                UpdateModifiedImage();
            }
        }

        private void radioButtonErrorDiffusionDithering_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonErrorDiffusionDithering.Checked)
            {
                colorsReductionAlgorithm = new ErrorDiffusionDithering(GetDitheringParams());
                UpdateModifiedImage();
            }
        }

        private void radioButtonOrderedDitheringRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOrderedDitheringRandom.Checked)
            {
                colorsReductionAlgorithm = new OrderedDitheringRandom(GetDitheringParams(), orderedDitheringMatrices);
                UpdateModifiedImage();
            }
        }

        private void radioButtonOrderedDitheringRelative_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOrderedDitheringRelative.Checked)
            {
                colorsReductionAlgorithm = new OrderedDitheringRelative(GetDitheringParams(), orderedDitheringMatrices);
                UpdateModifiedImage();
            }
        }

        private void radioButtonPopularityAlgorithm_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPopularityAlgorithm.Checked)
            {
                colorsReductionAlgorithm = new PopularityAlgorithm((int)numericUpDownK.Value);
                UpdateModifiedImage();
            }
        }

        #endregion

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            if (colorsReductionAlgorithm == null)
                return;
            if (colorsReductionAlgorithm.AlgorithmName == "popularity algorithm")
                colorsReductionAlgorithm.AssignBasicParameters((int)numericUpDownK.Value);
            else
            {
                (int kR, int kG, int kB) = GetDitheringParams();
                colorsReductionAlgorithm.AssignBasicParameters(kR, kG, kB);
            }
            UpdateModifiedImage();
        }
    }
}
