Arduino_T6963C
==============

Controlling SparkFun "Graphic LCD 160x128 Huge" from Arduino

Hardware:
  * Monochrome LCD 160x128 with T6963C controller: http://www.sparkfun.com/products/8799
  * Arduino Uno
  * 10K potentiometer
  * Misc wires
  
LCD connection

<table> 
<tr> <td>LCD pin #</td> <td>Symbol</td> <td>Function</td> <td>Arduino Uno pin</td> </tr> 
<tr> <td>1</td> <td>FG</td> <td>FRAME GROUND</td> <td>GND</td> </tr> 
<tr> <td>2</td> <td>VSS</td> <td>GND</td> <td>GND</td> </tr> 
<tr> <td>3</td> <td>VDD</td> <td>+5V</td> <td>+5V</td> </tr> 
<tr> <td>4</td> <td>VO</td> <td>Contrast Adjust</td> <td>Pot (middle pin)</td> </tr> 
<tr> <td>5</td> <td>VEE</td> <td>NEGATIVE VOLTAGE OUTPUT</td> <td>Pot</td> </tr>
<tr> <td>6</td> <td>/WR</td> <td>DATA WRITE&nbsp;</td> <td>A0</td> </tr> 
<tr> <td>7</td> <td>/RD</td> <td>DATA READ</td> <td>A1</td> </tr> 
<tr> <td>8</td> <td>/CE</td> <td>CHIP ENABLE</td> <td>A2</td> </tr> 
<tr> <td>9</td> <td>C/D</td> <td>COMMAND/DATA SELECTION</td> <td>A3</td> </tr>
<tr> <td>10</td> <td>/HALT</td> <td>CLOCK OPERATING STOP SIGNAL</td> <td>&nbsp;</td> </tr> 
<tr> <td>11</td> <td>/RST</td> <td>RESET</td> <td>&nbsp;</td> </tr> 
<tr> <td>12</td> <td>D0</td> <td>Data 0</td> <td>2</td> </tr> 
<tr> <td>13</td> <td>D1</td> <td>Data 1</td> <td>3</td> </tr> 
<tr> <td>14</td> <td>D2</td> <td>Data 2</td> <td>4</td> </tr> 
<tr> <td>15</td> <td>D3</td> <td>Data 3</td> <td>5</td> </tr> 
<tr> <td>16</td> <td>D4</td> <td>Data 4</td> <td>6</td> </tr> 
<tr> <td>17</td> <td>D5</td> <td>Data 5</td> <td>7</td> </tr> 
<tr> <td>18</td> <td>D6</td> <td>Data 6</td> <td>8</td> </tr> 
<tr> <td>19</td> <td>D7</td> <td>Data 7</td> <td>9</td> </tr> 
<tr> <td>20</td> <td>N/C</td> <td>NO CONNECTION</td> <td>&nbsp;</td> </tr> 
<tr> <td>21</td> <td>LEDA</td> <td>LED BACKLIGHT POWER SUPPLY (+5V)&nbsp;</td> <td>+5V</td> </tr> 
<tr> <td>22</td> <td>LEDK</td> <td>LED BACKLIGHT POWER SUPPLY (0V)</td> <td>GND</td> </tr> 
</table> 


Software:
  * Updated u8glib library (the original one did not support 160x128 reolution): http://code.google.com/p/u8glib/
  * BMP to C array converter (C# application)
  
Installation:
  * Copy libraries/U8glib to your Arduino library folder
  * Run an example Arduino_160x128

TODO: Merge my changes to u8glib project?

