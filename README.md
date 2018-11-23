# HandWithIntelSense | 手势智能识别控制器
---
## 概览
该识别控制器借助[Inter Sense](https://github.com/IntelRealSense)技术，基于HandsViewer (C++,C#)开发。在使用时请确保至少有一个Inter Sense的3D实感摄像头（型号不低于SR300）。该控制器由C#编写，使用Visual Studio 2017 编写编译。该控制器基于Intel(R) RealSense(TM) SDK 2016 R3版本开发，在Intel(R) RealSense(TM) SDK  2.0中部分功能可能不适用。如只想试用可直接下载编译好的文件。

识别控制器演示出了手和光标跟踪功能的GUI应用程序。 展示了跟踪的手骨架（关节点、骨骼和手轮廓），分割背景（将手与背景分开）和手势识别机制等。事实检测反馈出当前手势信息。从菜单中，用户可以选择输入设备，手部跟踪模块和操作模式（实时流模式，播放模式和录制模式）

![![图示](https://raw.githubusercontent.com/BYFOR/HandWithIntelSense/master/markdown/HandWithIntelSense%20(1).png)


![![图示](https://raw.githubusercontent.com/BYFOR/HandWithIntelSense/master/markdown/HandWithIntelSense%20(2).png)


## V1.0
---
V1.0版本基本实现了手势的基本识别输出与控制，这只是开始，以后将慢慢更新一些根据使用的操作功能，比如控制PPT的演示，播放器的播放控制等等。

### V1.0手势列表

实现了Intel Sense提供的基本手势

| 手势代码 | 详解 |
| :-------  | :------- | 
|click        | 张开手心朝向相机，快速将食指移向手掌中心。 |  
|fist            |所有的手指都握成了拳头。 手掌处于相机的大致方向，拳头可以处于不同的方向。|
|full_pinch|所有手指伸展并触摸拇指。 收缩的手指可以指向直接指向屏幕或在轮廓中的任何位置。|
|spreadfingers|张开手，面向相机。|
|swipe_down|手掌朝向相机，向下移动然后回到起始位置。|
|swipe_left| 手掌朝向相机，向左移动然后回到起始位置。|
|swipe_right| 手掌朝向相机，向右移动然后回到起始位置。|
|swipe_up|手掌朝向相机，向上移动然后回到起始位置。|
|tap|一个自然放松姿势的手向前移动，就像按下按钮一样。|
|thumb_down|用拇指向下指关闭的手。下面那个反过来|
|thumb_up| 手用拇指向上关闭。棒那个|
|two_fingers_pinch_open|用拇指和食指互相接触的手打开。|
|v_sign|手用食指和中指向上关闭，即V字胜利手势|
|wave|面朝屏幕的张开的手。波可包括任意数量的重复，即左右招手|

## V2.0
增加了一些编译好的示例，包括背景移除，手势轨迹的显示，面部识别等。近期整理后会上传工程文件。



