#include "ShowBPM.h"

#include "lcd.h"

 void DrawOneDot(unsigned char* pack2)
 {
		  LCD_DataWrite((pack2[1])&0xFF);
			LCD_DataWrite((pack2[2])&0xFF);
			LCD_DataWrite((pack2[3])&0xFF);

 }
 
  void DrawOneWidth(unsigned char* pack2)
 {
	 int i;
		   for(i =0;i<LCD_WIDTH;i++)
	{
			LCD_DataWrite((pack2[3*i+1])&0xFF);
			LCD_DataWrite((pack2[3*i+2])&0xFF);
			LCD_DataWrite((pack2[3*i+3])&0xFF);
	
	}
	
 }