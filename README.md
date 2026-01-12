# Arduino_Uno_Project
Unity/Arduino Connection and Data Visualization

This project mainly focuses on the connection and visualization of Arduino Uno Sensor data.
To test this program, 2 steps are needed:
1. Set up Arduino Uno **Potentiometer**.
2. Run the Unity project.
Then you can test if the visualization is properly working while adjusting the potentiometer.

## Arduino Uno Setting
When setting up a potentiometer, you need to connect three wires, which are VCC(5V), SIG(A5), GND(GND). Then connect the USB port to your computer.
![KakaoTalk_20260112_162746161](https://github.com/user-attachments/assets/6a4b3e13-6488-466c-8955-9976269fe2f6)

## Unity Setting
First, check the port setting in your computer to see which port is connected to the Arduino Uno. Find the label such as USB-SERIAL CH340(COM6). Inside the Connect_Arduino.cs file, change the Port number according to your setting. Then you can run the Project and see how the 2D gauge is changing while adjusting the potentiometer.

## Result
https://github.com/user-attachments/assets/016abb02-405a-434a-8b9e-c9312a11d4c3

- reference
[1]Loading icons created by meaicon - Flaticon
[2]https://discussions.unity.com/t/sending-data-from-arduino-uno-to-unity/149028/2
