namespace Project3_Colors_reduction
{
    partial class Main
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greyscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelOriginal = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.labelOriginal = new System.Windows.Forms.Label();
            this.tableLayoutPanelModified = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxModified = new System.Windows.Forms.PictureBox();
            this.labelModified = new System.Windows.Forms.Label();
            this.tableLayoutPanelMenu = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxAlgorithms = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelAlgorithms = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonAverageDithering = new System.Windows.Forms.RadioButton();
            this.radioButtonPopularityAlgorithm = new System.Windows.Forms.RadioButton();
            this.radioButtonErrorDiffusionDithering = new System.Windows.Forms.RadioButton();
            this.radioButtonOrderedDitheringRelative = new System.Windows.Forms.RadioButton();
            this.radioButtonOrderedDitheringRandom = new System.Windows.Forms.RadioButton();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.groupBoxPopAlgParams = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelPopAlgParams = new System.Windows.Forms.TableLayoutPanel();
            this.labelK = new System.Windows.Forms.Label();
            this.numericUpDownK = new System.Windows.Forms.NumericUpDown();
            this.labelFocus = new System.Windows.Forms.Label();
            this.groupBoxDitheringParams = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelDitheringParams = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDownKG = new System.Windows.Forms.NumericUpDown();
            this.labelKR = new System.Windows.Forms.Label();
            this.labelKG = new System.Windows.Forms.Label();
            this.labelKB = new System.Windows.Forms.Label();
            this.numericUpDownKR = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownKB = new System.Windows.Forms.NumericUpDown();
            this.menuStrip.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanelOriginal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            this.tableLayoutPanelModified.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxModified)).BeginInit();
            this.tableLayoutPanelMenu.SuspendLayout();
            this.groupBoxAlgorithms.SuspendLayout();
            this.tableLayoutPanelAlgorithms.SuspendLayout();
            this.groupBoxPopAlgParams.SuspendLayout();
            this.tableLayoutPanelPopAlgParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownK)).BeginInit();
            this.groupBoxDitheringParams.SuspendLayout();
            this.tableLayoutPanelDitheringParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKB)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1182, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.greyscaleToolStripMenuItem,
            this.loadImageToolStripMenuItem,
            this.modifyImageToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // greyscaleToolStripMenuItem
            // 
            this.greyscaleToolStripMenuItem.Name = "greyscaleToolStripMenuItem";
            this.greyscaleToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.greyscaleToolStripMenuItem.Text = "Greyscale";
            this.greyscaleToolStripMenuItem.Click += new System.EventHandler(this.greyscaleToolStripMenuItem_Click);
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.loadImageToolStripMenuItem.Text = "Load image";
            this.loadImageToolStripMenuItem.Click += new System.EventHandler(this.loadImageToolStripMenuItem_Click);
            // 
            // modifyImageToolStripMenuItem
            // 
            this.modifyImageToolStripMenuItem.Name = "modifyImageToolStripMenuItem";
            this.modifyImageToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.modifyImageToolStripMenuItem.Text = "Modify image (frame)";
            this.modifyImageToolStripMenuItem.Click += new System.EventHandler(this.modifyImageToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanelOriginal, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanelModified, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanelMenu, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1182, 525);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // tableLayoutPanelOriginal
            // 
            this.tableLayoutPanelOriginal.ColumnCount = 1;
            this.tableLayoutPanelOriginal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelOriginal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelOriginal.Controls.Add(this.pictureBoxOriginal, 0, 1);
            this.tableLayoutPanelOriginal.Controls.Add(this.labelOriginal, 0, 0);
            this.tableLayoutPanelOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelOriginal.Location = new System.Drawing.Point(239, 3);
            this.tableLayoutPanelOriginal.Name = "tableLayoutPanelOriginal";
            this.tableLayoutPanelOriginal.RowCount = 2;
            this.tableLayoutPanelOriginal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelOriginal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanelOriginal.Size = new System.Drawing.Size(466, 519);
            this.tableLayoutPanelOriginal.TabIndex = 2;
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.BackColor = System.Drawing.Color.White;
            this.pictureBoxOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxOriginal.Location = new System.Drawing.Point(3, 54);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(460, 462);
            this.pictureBoxOriginal.TabIndex = 0;
            this.pictureBoxOriginal.TabStop = false;
            // 
            // labelOriginal
            // 
            this.labelOriginal.AutoSize = true;
            this.labelOriginal.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOriginal.Location = new System.Drawing.Point(3, 0);
            this.labelOriginal.Name = "labelOriginal";
            this.labelOriginal.Size = new System.Drawing.Size(158, 51);
            this.labelOriginal.TabIndex = 1;
            this.labelOriginal.Text = "Original image:";
            this.labelOriginal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelModified
            // 
            this.tableLayoutPanelModified.ColumnCount = 1;
            this.tableLayoutPanelModified.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelModified.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelModified.Controls.Add(this.pictureBoxModified, 0, 1);
            this.tableLayoutPanelModified.Controls.Add(this.labelModified, 0, 0);
            this.tableLayoutPanelModified.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelModified.Location = new System.Drawing.Point(711, 3);
            this.tableLayoutPanelModified.Name = "tableLayoutPanelModified";
            this.tableLayoutPanelModified.RowCount = 2;
            this.tableLayoutPanelModified.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelModified.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanelModified.Size = new System.Drawing.Size(468, 519);
            this.tableLayoutPanelModified.TabIndex = 3;
            // 
            // pictureBoxModified
            // 
            this.pictureBoxModified.BackColor = System.Drawing.Color.White;
            this.pictureBoxModified.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxModified.Location = new System.Drawing.Point(3, 54);
            this.pictureBoxModified.Name = "pictureBoxModified";
            this.pictureBoxModified.Size = new System.Drawing.Size(462, 462);
            this.pictureBoxModified.TabIndex = 1;
            this.pictureBoxModified.TabStop = false;
            // 
            // labelModified
            // 
            this.labelModified.AutoSize = true;
            this.labelModified.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelModified.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelModified.Location = new System.Drawing.Point(3, 0);
            this.labelModified.Name = "labelModified";
            this.labelModified.Size = new System.Drawing.Size(358, 51);
            this.labelModified.TabIndex = 2;
            this.labelModified.Text = "Image after deployment of <selected algorithm>:";
            this.labelModified.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelMenu
            // 
            this.tableLayoutPanelMenu.ColumnCount = 1;
            this.tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMenu.Controls.Add(this.groupBoxAlgorithms, 0, 0);
            this.tableLayoutPanelMenu.Controls.Add(this.groupBoxPopAlgParams, 0, 2);
            this.tableLayoutPanelMenu.Controls.Add(this.labelFocus, 0, 3);
            this.tableLayoutPanelMenu.Controls.Add(this.groupBoxDitheringParams, 0, 1);
            this.tableLayoutPanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMenu.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelMenu.Name = "tableLayoutPanelMenu";
            this.tableLayoutPanelMenu.RowCount = 4;
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMenu.Size = new System.Drawing.Size(230, 519);
            this.tableLayoutPanelMenu.TabIndex = 4;
            // 
            // groupBoxAlgorithms
            // 
            this.groupBoxAlgorithms.Controls.Add(this.tableLayoutPanelAlgorithms);
            this.groupBoxAlgorithms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAlgorithms.Location = new System.Drawing.Point(3, 3);
            this.groupBoxAlgorithms.Name = "groupBoxAlgorithms";
            this.groupBoxAlgorithms.Size = new System.Drawing.Size(224, 191);
            this.groupBoxAlgorithms.TabIndex = 0;
            this.groupBoxAlgorithms.TabStop = false;
            this.groupBoxAlgorithms.Text = "Algorithms";
            // 
            // tableLayoutPanelAlgorithms
            // 
            this.tableLayoutPanelAlgorithms.ColumnCount = 1;
            this.tableLayoutPanelAlgorithms.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelAlgorithms.Controls.Add(this.radioButtonAverageDithering, 0, 0);
            this.tableLayoutPanelAlgorithms.Controls.Add(this.radioButtonPopularityAlgorithm, 0, 4);
            this.tableLayoutPanelAlgorithms.Controls.Add(this.radioButtonErrorDiffusionDithering, 0, 1);
            this.tableLayoutPanelAlgorithms.Controls.Add(this.radioButtonOrderedDitheringRelative, 0, 3);
            this.tableLayoutPanelAlgorithms.Controls.Add(this.radioButtonOrderedDitheringRandom, 0, 2);
            this.tableLayoutPanelAlgorithms.Controls.Add(this.buttonRefresh, 0, 5);
            this.tableLayoutPanelAlgorithms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelAlgorithms.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanelAlgorithms.Name = "tableLayoutPanelAlgorithms";
            this.tableLayoutPanelAlgorithms.RowCount = 6;
            this.tableLayoutPanelAlgorithms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelAlgorithms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelAlgorithms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelAlgorithms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelAlgorithms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelAlgorithms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelAlgorithms.Size = new System.Drawing.Size(218, 170);
            this.tableLayoutPanelAlgorithms.TabIndex = 0;
            // 
            // radioButtonAverageDithering
            // 
            this.radioButtonAverageDithering.AutoSize = true;
            this.radioButtonAverageDithering.Location = new System.Drawing.Point(3, 3);
            this.radioButtonAverageDithering.Name = "radioButtonAverageDithering";
            this.radioButtonAverageDithering.Size = new System.Drawing.Size(140, 21);
            this.radioButtonAverageDithering.TabIndex = 0;
            this.radioButtonAverageDithering.Text = "average dithering";
            this.radioButtonAverageDithering.UseVisualStyleBackColor = true;
            this.radioButtonAverageDithering.CheckedChanged += new System.EventHandler(this.radioButtonAverageDithering_CheckedChanged);
            // 
            // radioButtonPopularityAlgorithm
            // 
            this.radioButtonPopularityAlgorithm.AutoSize = true;
            this.radioButtonPopularityAlgorithm.Location = new System.Drawing.Point(3, 115);
            this.radioButtonPopularityAlgorithm.Name = "radioButtonPopularityAlgorithm";
            this.radioButtonPopularityAlgorithm.Size = new System.Drawing.Size(153, 21);
            this.radioButtonPopularityAlgorithm.TabIndex = 4;
            this.radioButtonPopularityAlgorithm.Text = "popularity algorithm";
            this.radioButtonPopularityAlgorithm.UseVisualStyleBackColor = true;
            this.radioButtonPopularityAlgorithm.CheckedChanged += new System.EventHandler(this.radioButtonPopularityAlgorithm_CheckedChanged);
            // 
            // radioButtonErrorDiffusionDithering
            // 
            this.radioButtonErrorDiffusionDithering.AutoSize = true;
            this.radioButtonErrorDiffusionDithering.Location = new System.Drawing.Point(3, 31);
            this.radioButtonErrorDiffusionDithering.Name = "radioButtonErrorDiffusionDithering";
            this.radioButtonErrorDiffusionDithering.Size = new System.Drawing.Size(176, 21);
            this.radioButtonErrorDiffusionDithering.TabIndex = 3;
            this.radioButtonErrorDiffusionDithering.Text = "error diffusion dithering";
            this.radioButtonErrorDiffusionDithering.UseVisualStyleBackColor = true;
            this.radioButtonErrorDiffusionDithering.CheckedChanged += new System.EventHandler(this.radioButtonErrorDiffusionDithering_CheckedChanged);
            // 
            // radioButtonOrderedDitheringRelative
            // 
            this.radioButtonOrderedDitheringRelative.AutoSize = true;
            this.radioButtonOrderedDitheringRelative.Location = new System.Drawing.Point(3, 87);
            this.radioButtonOrderedDitheringRelative.Name = "radioButtonOrderedDitheringRelative";
            this.radioButtonOrderedDitheringRelative.Size = new System.Drawing.Size(188, 21);
            this.radioButtonOrderedDitheringRelative.TabIndex = 2;
            this.radioButtonOrderedDitheringRelative.Text = "ordered dithering relative";
            this.radioButtonOrderedDitheringRelative.UseVisualStyleBackColor = true;
            this.radioButtonOrderedDitheringRelative.CheckedChanged += new System.EventHandler(this.radioButtonOrderedDitheringRelative_CheckedChanged);
            // 
            // radioButtonOrderedDitheringRandom
            // 
            this.radioButtonOrderedDitheringRandom.AutoSize = true;
            this.radioButtonOrderedDitheringRandom.Location = new System.Drawing.Point(3, 59);
            this.radioButtonOrderedDitheringRandom.Name = "radioButtonOrderedDitheringRandom";
            this.radioButtonOrderedDitheringRandom.Size = new System.Drawing.Size(190, 21);
            this.radioButtonOrderedDitheringRandom.TabIndex = 1;
            this.radioButtonOrderedDitheringRandom.Text = "ordered dithering random";
            this.radioButtonOrderedDitheringRandom.UseVisualStyleBackColor = true;
            this.radioButtonOrderedDitheringRandom.CheckedChanged += new System.EventHandler(this.radioButtonOrderedDitheringRandom_CheckedChanged);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonRefresh.Location = new System.Drawing.Point(124, 143);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(91, 24);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.TabStop = false;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // groupBoxPopAlgParams
            // 
            this.groupBoxPopAlgParams.Controls.Add(this.tableLayoutPanelPopAlgParams);
            this.groupBoxPopAlgParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPopAlgParams.Location = new System.Drawing.Point(3, 329);
            this.groupBoxPopAlgParams.Name = "groupBoxPopAlgParams";
            this.groupBoxPopAlgParams.Size = new System.Drawing.Size(224, 56);
            this.groupBoxPopAlgParams.TabIndex = 1;
            this.groupBoxPopAlgParams.TabStop = false;
            this.groupBoxPopAlgParams.Text = "Params for popularity algorithm";
            // 
            // tableLayoutPanelPopAlgParams
            // 
            this.tableLayoutPanelPopAlgParams.ColumnCount = 2;
            this.tableLayoutPanelPopAlgParams.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelPopAlgParams.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanelPopAlgParams.Controls.Add(this.labelK, 0, 0);
            this.tableLayoutPanelPopAlgParams.Controls.Add(this.numericUpDownK, 1, 0);
            this.tableLayoutPanelPopAlgParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPopAlgParams.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanelPopAlgParams.Name = "tableLayoutPanelPopAlgParams";
            this.tableLayoutPanelPopAlgParams.RowCount = 1;
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPopAlgParams.Size = new System.Drawing.Size(218, 35);
            this.tableLayoutPanelPopAlgParams.TabIndex = 0;
            // 
            // labelK
            // 
            this.labelK.AutoSize = true;
            this.labelK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelK.Location = new System.Drawing.Point(3, 0);
            this.labelK.Name = "labelK";
            this.labelK.Size = new System.Drawing.Size(26, 35);
            this.labelK.TabIndex = 0;
            this.labelK.Text = "K";
            this.labelK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownK
            // 
            this.numericUpDownK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownK.Location = new System.Drawing.Point(35, 6);
            this.numericUpDownK.Maximum = new decimal(new int[] {
            262144,
            0,
            0,
            0});
            this.numericUpDownK.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownK.Name = "numericUpDownK";
            this.numericUpDownK.Size = new System.Drawing.Size(180, 22);
            this.numericUpDownK.TabIndex = 1;
            this.numericUpDownK.TabStop = false;
            this.numericUpDownK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownK.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // labelFocus
            // 
            this.labelFocus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFocus.AutoSize = true;
            this.labelFocus.Location = new System.Drawing.Point(3, 502);
            this.labelFocus.Name = "labelFocus";
            this.labelFocus.Size = new System.Drawing.Size(0, 17);
            this.labelFocus.TabIndex = 3;
            // 
            // groupBoxDitheringParams
            // 
            this.groupBoxDitheringParams.Controls.Add(this.tableLayoutPanelDitheringParams);
            this.groupBoxDitheringParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDitheringParams.Location = new System.Drawing.Point(3, 200);
            this.groupBoxDitheringParams.Name = "groupBoxDitheringParams";
            this.groupBoxDitheringParams.Size = new System.Drawing.Size(224, 123);
            this.groupBoxDitheringParams.TabIndex = 2;
            this.groupBoxDitheringParams.TabStop = false;
            this.groupBoxDitheringParams.Text = "Params for dithering";
            // 
            // tableLayoutPanelDitheringParams
            // 
            this.tableLayoutPanelDitheringParams.ColumnCount = 2;
            this.tableLayoutPanelDitheringParams.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelDitheringParams.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanelDitheringParams.Controls.Add(this.numericUpDownKG, 1, 1);
            this.tableLayoutPanelDitheringParams.Controls.Add(this.labelKR, 0, 0);
            this.tableLayoutPanelDitheringParams.Controls.Add(this.labelKG, 0, 1);
            this.tableLayoutPanelDitheringParams.Controls.Add(this.labelKB, 0, 2);
            this.tableLayoutPanelDitheringParams.Controls.Add(this.numericUpDownKR, 1, 0);
            this.tableLayoutPanelDitheringParams.Controls.Add(this.numericUpDownKB, 1, 2);
            this.tableLayoutPanelDitheringParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDitheringParams.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanelDitheringParams.Name = "tableLayoutPanelDitheringParams";
            this.tableLayoutPanelDitheringParams.RowCount = 3;
            this.tableLayoutPanelDitheringParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelDitheringParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelDitheringParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelDitheringParams.Size = new System.Drawing.Size(218, 102);
            this.tableLayoutPanelDitheringParams.TabIndex = 0;
            // 
            // numericUpDownKG
            // 
            this.numericUpDownKG.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDownKG.Location = new System.Drawing.Point(35, 40);
            this.numericUpDownKG.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numericUpDownKG.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownKG.Name = "numericUpDownKG";
            this.numericUpDownKG.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownKG.TabIndex = 6;
            this.numericUpDownKG.TabStop = false;
            this.numericUpDownKG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownKG.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // labelKR
            // 
            this.labelKR.AutoSize = true;
            this.labelKR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelKR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.labelKR.Location = new System.Drawing.Point(3, 0);
            this.labelKR.Name = "labelKR";
            this.labelKR.Size = new System.Drawing.Size(26, 34);
            this.labelKR.TabIndex = 0;
            this.labelKR.Text = "Kr";
            this.labelKR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelKG
            // 
            this.labelKG.AutoSize = true;
            this.labelKG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelKG.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.labelKG.Location = new System.Drawing.Point(3, 34);
            this.labelKG.Name = "labelKG";
            this.labelKG.Size = new System.Drawing.Size(26, 34);
            this.labelKG.TabIndex = 1;
            this.labelKG.Text = "Kg";
            this.labelKG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelKB
            // 
            this.labelKB.AutoSize = true;
            this.labelKB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.labelKB.Location = new System.Drawing.Point(3, 68);
            this.labelKB.Name = "labelKB";
            this.labelKB.Size = new System.Drawing.Size(26, 34);
            this.labelKB.TabIndex = 2;
            this.labelKB.Text = "Kb";
            this.labelKB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownKR
            // 
            this.numericUpDownKR.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDownKR.Location = new System.Drawing.Point(35, 6);
            this.numericUpDownKR.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numericUpDownKR.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownKR.Name = "numericUpDownKR";
            this.numericUpDownKR.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownKR.TabIndex = 3;
            this.numericUpDownKR.TabStop = false;
            this.numericUpDownKR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownKR.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // numericUpDownKB
            // 
            this.numericUpDownKB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDownKB.Location = new System.Drawing.Point(35, 74);
            this.numericUpDownKB.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numericUpDownKB.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownKB.Name = "numericUpDownKB";
            this.numericUpDownKB.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownKB.TabIndex = 5;
            this.numericUpDownKB.TabStop = false;
            this.numericUpDownKB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownKB.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colors reduction";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanelOriginal.ResumeLayout(false);
            this.tableLayoutPanelOriginal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            this.tableLayoutPanelModified.ResumeLayout(false);
            this.tableLayoutPanelModified.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxModified)).EndInit();
            this.tableLayoutPanelMenu.ResumeLayout(false);
            this.tableLayoutPanelMenu.PerformLayout();
            this.groupBoxAlgorithms.ResumeLayout(false);
            this.tableLayoutPanelAlgorithms.ResumeLayout(false);
            this.tableLayoutPanelAlgorithms.PerformLayout();
            this.groupBoxPopAlgParams.ResumeLayout(false);
            this.tableLayoutPanelPopAlgParams.ResumeLayout(false);
            this.tableLayoutPanelPopAlgParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownK)).EndInit();
            this.groupBoxDitheringParams.ResumeLayout(false);
            this.tableLayoutPanelDitheringParams.ResumeLayout(false);
            this.tableLayoutPanelDitheringParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.PictureBox pictureBoxModified;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOriginal;
        private System.Windows.Forms.Label labelOriginal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelModified;
        private System.Windows.Forms.Label labelModified;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMenu;
        private System.Windows.Forms.GroupBox groupBoxAlgorithms;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAlgorithms;
        private System.Windows.Forms.RadioButton radioButtonAverageDithering;
        private System.Windows.Forms.RadioButton radioButtonOrderedDitheringRandom;
        private System.Windows.Forms.RadioButton radioButtonOrderedDitheringRelative;
        private System.Windows.Forms.RadioButton radioButtonErrorDiffusionDithering;
        private System.Windows.Forms.RadioButton radioButtonPopularityAlgorithm;
        private System.Windows.Forms.Label labelFocus;
        private System.Windows.Forms.GroupBox groupBoxPopAlgParams;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPopAlgParams;
        private System.Windows.Forms.Label labelK;
        private System.Windows.Forms.NumericUpDown numericUpDownK;
        private System.Windows.Forms.GroupBox groupBoxDitheringParams;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDitheringParams;
        private System.Windows.Forms.Label labelKR;
        private System.Windows.Forms.Label labelKG;
        private System.Windows.Forms.Label labelKB;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.NumericUpDown numericUpDownKG;
        private System.Windows.Forms.NumericUpDown numericUpDownKR;
        private System.Windows.Forms.NumericUpDown numericUpDownKB;
        private System.Windows.Forms.ToolStripMenuItem greyscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyImageToolStripMenuItem;
    }
}

