Windows 10 IoT Core sample code
===============

Hello World to test my LCD in my Raspberry Pi3 using Microsoft Windows Core.
The ideia is using c# and raspberry Pi3 by my own.

In order to use the Character LCD with c# we need to set up a library that comunicate with the LCD.

I discovered the CharacterLCD library, see in references, and that is possible to wiring the Arduino Libraries and use it in C# (see links below).

https://blogs.windows.com/buildingapps/2016/09/07/introducing-arduino-wiring-on-windows-10-iot-core/#Phj5lIe5UgqkqhxC.97
https://developer.microsoft.com/en-us/windows/iot/samples/arduino-wiring/LCDTextDisplay
https://developer.microsoft.com/en-us/windows/iot/samples/arduino-wiring/lcdtextdisplay

.:: Hardware components ::.

Raspberry Pi3
Character LCD 16x2
Resistor
BreadBoard
Potentiometer
Jumpers


.:: Software ::.
Visual Studio
Microsoft Windows IoT Core
Library CharacterLCD
IoT Dashboard


.:: GPIOs used ::.

RS => 25
E  => 24
data0 => 27
data1 => 22
data2 => 5
data3 => 6
data4 => 13
data5 => 26
data6 => 18
data7 => 16



Reference:
https://github.com/bartcallant/CharacterLCD
https://www.hackster.io/bartcallant/characterlcd-b4b405

