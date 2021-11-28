# Image Edge Detection + Blur + Median Filter
## Description
This repo contains my university task for digital signal processing. The task is to implement Laplacian edge detection 3x3 and 5x5, Sobel edge detection, box blur, Gaussian blur and median filter. Everything is implemented by means of image convolution.
## Working Results
| Operation      |    Kernel        | Image Result  |
| :---  | :---:     | :---:  |
| Identity       | {{0, 0, 0},<br>{0, 1, 0},<br>{0, 0, 0}}|![image](https://user-images.githubusercontent.com/61329729/143782033-f261cab2-4613-4885-a68e-624c39f63c47.png)|
| Laplacian 3x3  | {{-1, -1, -1},<br>{-1, 8, -1},<br>{-1, -1, -1}}|![image](https://user-images.githubusercontent.com/61329729/143782049-f12b6b99-4be9-436f-8c36-b239fa4ad72e.png)|
| Laplacian 5x5  | {{-1, -1, -1, -1, -1},<br>{-1, -1, -1, -1, -1},<br>{-1, -1, 24, -1, -1},<br>{-1, -1, -1, -1, -1},<br>{-1, -1, -1, -1, -1}}| ![image](https://user-images.githubusercontent.com/61329729/143782224-252334a8-1086-438b-a8f7-c213279ea8c8.png) |
| Sobel          | Horizontal<br>{{-1, 0, 1},<br>{-2, 0, 2},<br>{-1, 0, 1}}<br>Vertical<br>{{1, 2, 1},<br>{0, 0, 0},<br>{-1, -2, -1}}|![image](https://user-images.githubusercontent.com/61329729/143782275-b234e5f1-c93d-4a25-abda-ba0d0f708c9c.png)|
| Box blur       | {{1 , 1, 1}<br>{1, 1, 1}<br> {1, 1, 1}}<br>Normalized by 9 | ![image](https://user-images.githubusercontent.com/61329729/143782290-5cffb856-7251-43cb-b04a-43da5ec48f52.png)  |
| Gaussian blur  | {{1, 2, 1},<br>{2, 4, 2},<br>{1, 2, 1}}<br>Normalized by 16| ![image](https://user-images.githubusercontent.com/61329729/143782311-38b05a0c-6870-42b7-b789-6837e154222f.png) |
| Median filter  | Content Cell  | Content Cell  |
