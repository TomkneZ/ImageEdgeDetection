namespace Lab3
{
    internal static class Matrices
    {
        // Identity.
        internal static double[,] Identity = new double[,]
                             {{0.0, 0.0, 0.0},
                             {0.0, 1.0, 0.0},
                             {0.0, 0.0, 0.0}};

        // Gaussian blur 3x3.
        internal static double[,] GaussianBlur = new double[,]
                             {{1.0 / 16, 2.0 / 16.0, 1.0 / 16.0},
                             {2.0 / 16.0, 4.0 / 16.0, 2.0 / 16.0},
                             {1.0 / 16.0, 2.0 / 16.0, 1.0 / 16.0}};

        // Edge detection Laplacian 3x3.
        internal static double[,] EdgeDetection3x3 = new double[,]
                             {{-1.0, -1.0, -1.0},
                             {-1.0, 8.0, -1.0},
                             {-1.0, -1.0, -1.0}};

        // Edge detection Laplacian 5x5.
        internal static double[,] EdgeDetection5x5 = new double[,]
                             {{-1.0, -1.0, -1.0, -1.0, -1.0},
                             {-1.0, -1.0, -1.0, -1.0, -1.0},
                             {-1.0, -1.0, 24.0, -1.0, -1.0},
                             {-1.0, -1.0, -1.0, -1.0, -1.0},
                             {-1.0, -1.0, -1.0, -1.0, -1.0}};

        // Sharpen.
        internal static double[,] Sharpen = new double[,]
                             {{0.0, -1.0, 0.0},
                             {-1.0, 5.0, -1.0},
                             {0.0, -1.0, 0.0}};

        // Box blur.
        internal static double[,] BoxBlur = new double[,]
                             {{1.0 / 9.0, 1.0 / 9.0, 1.0 / 9.0},
                             {1.0 / 9.0, 1.0 / 9.0, 1.0 / 9.0},
                             {1.0 / 9.0, 1.0 / 9.0, 1.0 / 9.0}};

        internal static double[,] Sobel3x3Horizontal = new double[,]
                             {{-1.0, 0.0, 1.0},
                             {-2.0, 0.0, 2.0},
                             {-1.0, 0.0, 1.0}};

        internal static double[,] Sobel3x3Vertical = new double[,]
                             {{1.0, 2.0, 1.0},
                             {0.0, 0.0, 0.0},
                             {-1.0, -2.0, -1.0}};
    }
}
