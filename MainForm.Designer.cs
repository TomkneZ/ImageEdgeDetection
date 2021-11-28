namespace Lab3
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.originalPictureBox = new System.Windows.Forms.PictureBox();
            this.filteredPictureBox = new System.Windows.Forms.PictureBox();
            this.filtersComboBox = new System.Windows.Forms.ComboBox();
            this.openImageButton = new System.Windows.Forms.Button();
            this.applyFilterButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.matrixSizeTextBox = new System.Windows.Forms.TextBox();
            this.matrixSizeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filteredPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // originalPictureBox
            // 
            this.originalPictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.originalPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.originalPictureBox.Location = new System.Drawing.Point(27, 55);
            this.originalPictureBox.Name = "originalPictureBox";
            this.originalPictureBox.Size = new System.Drawing.Size(341, 368);
            this.originalPictureBox.TabIndex = 0;
            this.originalPictureBox.TabStop = false;
            // 
            // filteredPictureBox
            // 
            this.filteredPictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.filteredPictureBox.Location = new System.Drawing.Point(409, 55);
            this.filteredPictureBox.Name = "filteredPictureBox";
            this.filteredPictureBox.Size = new System.Drawing.Size(341, 368);
            this.filteredPictureBox.TabIndex = 1;
            this.filteredPictureBox.TabStop = false;
            // 
            // filtersComboBox
            // 
            this.filtersComboBox.FormattingEnabled = true;
            this.filtersComboBox.Items.AddRange(new object[] {
            "Identity",
            "Edge detection Laplacian 3x3",
            "Edge detection Laplacian 5x5",
            "Box blur",
            "Gaussian blur",
            "Median filter",
            "Sobel filter"});
            this.filtersComboBox.Location = new System.Drawing.Point(294, 12);
            this.filtersComboBox.Name = "filtersComboBox";
            this.filtersComboBox.Size = new System.Drawing.Size(206, 28);
            this.filtersComboBox.TabIndex = 2;
            this.filtersComboBox.SelectedIndexChanged += new System.EventHandler(this.filtersComboBox_SelectedIndexChanged);
            // 
            // openImageButton
            // 
            this.openImageButton.Location = new System.Drawing.Point(27, 13);
            this.openImageButton.Name = "openImageButton";
            this.openImageButton.Size = new System.Drawing.Size(94, 29);
            this.openImageButton.TabIndex = 3;
            this.openImageButton.Text = "Upload";
            this.openImageButton.UseVisualStyleBackColor = true;
            this.openImageButton.Click += new System.EventHandler(this.openImageButton_Click);
            // 
            // applyFilterButton
            // 
            this.applyFilterButton.Location = new System.Drawing.Point(649, 11);
            this.applyFilterButton.Name = "applyFilterButton";
            this.applyFilterButton.Size = new System.Drawing.Size(101, 29);
            this.applyFilterButton.TabIndex = 4;
            this.applyFilterButton.Text = "Filter";
            this.applyFilterButton.UseVisualStyleBackColor = true;
            this.applyFilterButton.Click += new System.EventHandler(this.applyFilterButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            // 
            // matrixSizeTextBox
            // 
            this.matrixSizeTextBox.Location = new System.Drawing.Point(592, 14);
            this.matrixSizeTextBox.Name = "matrixSizeTextBox";
            this.matrixSizeTextBox.Size = new System.Drawing.Size(51, 27);
            this.matrixSizeTextBox.TabIndex = 5;
            this.matrixSizeTextBox.Text = "3";
            this.matrixSizeTextBox.Visible = false;
            // 
            // matrixSizeLabel
            // 
            this.matrixSizeLabel.AutoSize = true;
            this.matrixSizeLabel.Location = new System.Drawing.Point(506, 17);
            this.matrixSizeLabel.Name = "matrixSizeLabel";
            this.matrixSizeLabel.Size = new System.Drawing.Size(80, 20);
            this.matrixSizeLabel.TabIndex = 6;
            this.matrixSizeLabel.Text = "Matrix size";
            this.matrixSizeLabel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.matrixSizeLabel);
            this.Controls.Add(this.matrixSizeTextBox);
            this.Controls.Add(this.applyFilterButton);
            this.Controls.Add(this.openImageButton);
            this.Controls.Add(this.filtersComboBox);
            this.Controls.Add(this.filteredPictureBox);
            this.Controls.Add(this.originalPictureBox);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filteredPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox originalPictureBox;
        private PictureBox filteredPictureBox;
        private ComboBox filtersComboBox;
        private Button openImageButton;
        private Button applyFilterButton;
        private OpenFileDialog openFileDialog1;
        private TextBox matrixSizeTextBox;
        private Label matrixSizeLabel;
    }
}