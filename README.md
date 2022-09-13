# svg2icons
SVG转多分辨率ICO图标

## 项目原理

该项目非常简单，引用了SVG的库函数，将svg文件转成多尺寸的png图片，最终生成一个ico文件。

由于SVG库非常庞大，DLL文件非常多，于是引用 `Costura.Fody` 库将DLL文件集成到EXE内部，所以文件体积超过1Mb。

## 软件图片

![](https://image.xiaoxin.pro/2022/09/13/51a33c9a38888.png)

