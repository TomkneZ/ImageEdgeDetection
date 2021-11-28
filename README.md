# Image Edge Detection + Blur + Median Filter
## Description
This repo contains my university task for digital signal processing. The task is to implement Laplacian edge detection 3x3 and 5x5, Sobel edge detection, box blur, Gaussian blur and median filter. Everything is implemented by means of image convolution.
## Working Results
| Operation      |    Kernel        | Image Result  |
| :---  | :---:     | :---:  |
| Identity       | {{0, 0, 0},<br>{0, 1, 0},<br>{0, 0, 0}}|![image](https://user-images.githubusercontent.com/61329729/143782033-f261cab2-4613-4885-a68e-624c39f63c47.png)|
| Laplacian 3x3  | {{-1, -1, -1},<br>{-1, 8, -1},<br>{-1, -1, -1}}|![image](https://user-images.githubusercontent.com/61329729/143782049-f12b6b99-4be9-436f-8c36-b239fa4ad72e.png)|
| Laplacian 5x5  | {{-1, -1, -1, -1, -1},<br>{-1, -1, -1, -1, -1},<br>{-1, -1, 24, -1, -1},<br>{-1, -1, -1, -1, -1},<br>{-1, -1, -1, -1, -1}}| ![image](https://user-images.githubusercontent.com/61329729/143782067-ec247231-0d2c-40d6-a629-e3873e3f68cd.png)  |
| Sobel          | Horizontal<br>{{-1, 0, 1},<br>{-2, 0, 2},<br>{-1, 0, 1}}<br>Vertical<br>{{1, 2, 1},<br>{0, 0, 0},<br>{-1, -2, -1}}|![image](https://user-images.githubusercontent.com/61329729/143782091-d09131a6-40ac-4335-b4f0-de0d81cac414.png)   |
| Box blur       | {{1 , 1, 1}<br>{1, 1, 1}<br> {1, 1, 1}}<br>Normalized by 9 | ![image](https://user-images.githubusercontent.com/61329729/143782098-3f161f3c-b403-4852-9754-f44bff364f87.png)  |
| Gaussian blur  | {{1, 2, 1},<br>{2, 4, 2},<br>{1, 2, 1}}<br>Normalized by 16| ![image](https://user-images.githubusercontent.com/61329729/143782119-4c02ed4e-ad7a-4b5a-b771-7f254708cba0.png)  |
| Median filter  | Content Cell  | Content Cell  |
