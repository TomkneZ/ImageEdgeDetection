namespace Lab3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            filtersComboBox.SelectedIndex = 0;
        }

        private void openImageButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Png Image|*.png";
            openFileDialog1.Title = "Choose a file to upload";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                originalPictureBox.Image = Image.FromFile(@openFileDialog1.FileName);
            }
        }

        private void applyFilterButton_Click(object sender, EventArgs e)
        {       
            if (originalPictureBox.Image == null)
            {
                return;
            }

            var image = (Bitmap)originalPictureBox.Image.Clone();

            filteredPictureBox.Image = filtersComboBox.SelectedIndex switch
            {
                1 => image.ConvolutionFilter(Matrices.EdgeDetection3x3),
                2 => image.ConvolutionFilter(Matrices.EdgeDetection5x5),
                3 => image.ConvolutionFilter(Matrices.BoxBlur),
                4 => image.ConvolutionFilter(Matrices.GaussianBlur),
                5 => image.MedianFilter(5),
                6 => image.ConvolutionFilter(Matrices.Sobel3x3Horizontal, Matrices.Sobel3x3Vertical),
                _ => image.ConvolutionFilter(Matrices.Identity)
            };
        }        

        private void filtersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filtersComboBox.SelectedIndex == 5)
            {
                matrixSizeLabel.Visible = true;
                matrixSizeTextBox.Visible = true;
                return;
            }

            matrixSizeLabel.Visible = false;
            matrixSizeTextBox.Visible = false;
        }
    }
}