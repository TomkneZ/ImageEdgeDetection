# Image Edge Detection + Blur + Median Filter
## Description
This repo contains my university task for digital signal processing. The task is to implement Laplacian edge detection 3x3 and 5x5, Sobel edge detection, box blur, Gaussian blur and median filter. Everything is implemented by means of image convolution.
## Working Results
| Operation      |    Kernel        | Image Result  |
| -------------  | -------------    | ------------- |
| Identity       | {{0, 0, 0},<br> {0, 1, 0},<br> {0, 0, 0}}||
| Laplacian 3x3  | {{-1, -1, -1},<br> {-1, 8, -1},<br> {-1, -1, -1}}| Content Cell  |
| Laplacian 5x5  | {{-1, -1, -1, -1, -1},<br> {-1, -1, -1, -1, -1},<br> {-1, -1, 24, -1, -1},<br> {-1, -1, -1, -1, -1},<br> {-1, -1, -1, -1, -1}}| Content Cell  |
| Sobel          |  Horizontal <br>{{-1, 0, 1},<br> {-2, 0, 2},<br> {-1, 0, 1}}<br> Vertical <br>{{1, 2, 1},<br> {0, 0, 0},<br> {-1, -2, -1}}  | Content Cell  |
| Box blur       |      {{1 , 1, 1}<br>1/9 * {1, 1, 1}<br>      {1, 1, 1}} | Content Cell  |
| Gaussian blur  |      {{1, 2, 1},<br>1/16 * {2, 4, 2},<br>      {1, 2, 1}}  | Content Cell  |
| Median filter  | Content Cell  | Content Cell  |
