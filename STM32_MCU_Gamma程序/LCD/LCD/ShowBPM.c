#include "ShowBPM.h"

#include "lcd.h"
static int i=0;
void Send_Bpm(unsigned char* pack)
{
	
	
	   
			LCD_DataWrite((pack[0]>>2)&0xFF);
      LCD_DataWrite((pack[1]>>2)&0xFF);
      LCD_DataWrite((pack[2]>>2)&0xFF);

}
