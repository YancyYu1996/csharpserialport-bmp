/*
  ******************************************************************************
  * @file    LCD
  * @author  LCD
  * @version V1.0
  * @date    20170101
  * @brief   LCD
  ******************************************************************************
*/

#include "lcd.h"


void LCD_RST(void)
{
	H_MCUReset;
	delay_ms(20);
	L_MCUReset;
	delay_ms(20);
	H_MCUReset;
	delay_ms(120);
}

void BlockWrite(unsigned int Xstart,unsigned int Xend,unsigned int Ystart,unsigned int Yend)
{
	LCD_CtrlWrite(0x2a);   
	LCD_DataWrite(Xstart>>8);
	LCD_DataWrite(Xstart&0xff);
	LCD_DataWrite(Xend>>8);
	LCD_DataWrite(Xend&0xff);

	LCD_CtrlWrite(0x2b);   
	LCD_DataWrite(Ystart>>8);
	LCD_DataWrite(Ystart&0xff);
	LCD_DataWrite(Yend>>8);
	LCD_DataWrite(Yend&0xff);

	LCD_CtrlWrite(0x2c);
}


void DispFlick(unsigned int color)
{
	unsigned int i,j;

	BlockWrite(0,LCD_WIDTH-1,0,LCD_HEIGHT-1);

	for(i=0;i<LCD_HEIGHT/2;i++)
	{
	    for(j=0;j<LCD_WIDTH/2;j++)
		{
#ifdef SourcesFlick		
			LCD_DataWrite((color<<2)&0xFF);
			LCD_DataWrite(0x00);
			
			LCD_DataWrite((color<<2)&0xFF);
			LCD_DataWrite(0x00);
			
			LCD_DataWrite((color<<2)&0xFF);
			LCD_DataWrite(0x00);
			
			LCD_DataWrite((color<<2)&0xFF);
			LCD_DataWrite(0x00);
			
#else
			LCD_DataWrite((color<<2)&0xFF);
			LCD_DataWrite((color<<2)&0xFF);
			LCD_DataWrite((color<<2)&0xFF);


			LCD_DataWrite(0x00);
			LCD_DataWrite(0x00);
			LCD_DataWrite(0x00);	


#endif			
		}
		
		  for(j=0;j<LCD_WIDTH/2;j++)
		{
#ifdef SourcesFlick		
			
			LCD_DataWrite(0x00);
			LCD_DataWrite((color<<2)&0xFF);

			LCD_DataWrite(0x00);
			LCD_DataWrite((color<<2)&0xFF);

			LCD_DataWrite(0x00);
			LCD_DataWrite((color<<2)&0xFF);
			
#else
			
			LCD_DataWrite(0x00);
			LCD_DataWrite(0x00);
			LCD_DataWrite(0x00);	
			
			LCD_DataWrite((color<<2)&0xFF);
			LCD_DataWrite((color<<2)&0xFF);
			LCD_DataWrite((color<<2)&0xFF);
#endif			
		}
		
	}

}

#if 1
void DispColor(unsigned int color)
{
	unsigned int i,j;

	BlockWrite(0,LCD_WIDTH-1,0,LCD_HEIGHT-1);

	for(i=0;i<LCD_WIDTH;i++)
	{
	    for(j=0;j<LCD_HEIGHT*3;j++)
		{    
			LCD_DataWrite((color<<2)&0xFF);
		}
	}

}	
#else
void DispColor(unsigned int color)
{
	unsigned int i,j;

	BlockWrite(0,LCD_WIDTH-1,0,LCD_HEIGHT-1);

	for(i=0;i<LCD_WIDTH;i++)
	{
	    for(j=0;j<LCD_HEIGHT;j++)
		{    
			 LCD_DataWrite(color>>8);
	
			 LCD_DataWrite(color&0xFF);
		}
	}

}	
#endif

void LCD_Init(void)
{


	LCD_CtrlWrite(0xfe);// internal reg enable	
	LCD_CtrlWrite(0xef);//internal reg enable	
	
	LCD_CtrlWrite(0x36);
	LCD_DataWrite(0x48);
	
	LCD_CtrlWrite(0x3a);
	LCD_DataWrite(0x66);
	
	LCD_CtrlWrite(0xe8);
	LCD_DataWrite(0x12);
	LCD_DataWrite(0x22);
		//=============		

	LCD_CtrlWrite(0xe3);
	LCD_DataWrite(0x01);
	LCD_DataWrite(0x04);
	LCD_CtrlWrite(0xa5);
	LCD_DataWrite(0x40);
	LCD_DataWrite(0x40);
	LCD_CtrlWrite(0xa4);
	LCD_DataWrite(0x44);
	LCD_DataWrite(0x44);
	LCD_CtrlWrite(0xab);
	LCD_DataWrite(0x08);
	LCD_CtrlWrite(0xaa);
	LCD_DataWrite(0x88);
	LCD_DataWrite(0x88);
	LCD_CtrlWrite(0xae);
	LCD_DataWrite(0x0b);//0x1c  20151013 update
	LCD_CtrlWrite(0xac);
	LCD_DataWrite(0x00);
	LCD_CtrlWrite(0xaf);

	LCD_DataWrite(0x77);
	LCD_CtrlWrite(0xad);
	LCD_DataWrite(0x77);
	
	
	
	LCD_CtrlWrite(0x11);

	LCD_CtrlWrite(0x29);
	
}


	FATFS fs; 
	FIL fsrc, fdst;   
	UINT br, bw; 
	unsigned char buffer[LCD_WIDTH*3];

void sd_showbmp(char * fname)
{ 
  unsigned short i,j;
	unsigned short BmpWidth=0,BmpHeight=0;
	
	FRESULT res;
	
	
		f_mount(&fs,"0:",1); //挂载SD卡
	
    res = f_open(&fsrc, fname, FA_OPEN_EXISTING | FA_READ);	//打开文件
	   
	  res = f_read(&fsrc, buffer, 0x36,&br);	//跳过前面BMP信息部分
		BmpWidth=(buffer[19]<<8)|(buffer[18]);
	
		if(BmpWidth>LCD_WIDTH)
		{
			BmpWidth=LCD_WIDTH;
		}
			if((buffer[23]&0xF0)==0xF0)
		{
			buffer[23]=0xFF-buffer[23];
			buffer[22]=0x100-buffer[22];
		}
		BmpHeight=(buffer[23]<<8)|(buffer[22]);
		
	if(BmpHeight>LCD_HEIGHT)
	{
		BmpHeight=LCD_HEIGHT;
	}
		
		BlockWrite(0,BmpWidth-1,0,BmpHeight-1);
	
		 for(j=0;j<BmpHeight;j++)
	  {
	     res = f_read(&fsrc, buffer, BmpWidth*3,&br);	//每次读完一行
			// fsrc.fptr=fsrc.fptr+(BmpWidth-LCD_WIDTH+1)*3;
		 
		 for(i=0;i<BmpWidth*3;i+=3) 	//每次写一行
		 {
			 
			 LCD_DataWrite(buffer[i+2]);
			 LCD_DataWrite(buffer[i+1]);
			 LCD_DataWrite(buffer[i]);
			
		 }

		 if (res || br == 0) break;   // error or eof	   	  
         }

	    f_close(&fsrc);
}

void GPIO_Configuration(void)
{
	GPIO_InitTypeDef GPIO_InitStructure;
	
	GPIO_InitStructure.GPIO_Pin = GPIO_Pin_0 | GPIO_Pin_8;// 0 MCU Dir 8 LED
	GPIO_InitStructure.GPIO_Mode = GPIO_Mode_Out_PP;
	GPIO_InitStructure.GPIO_Speed = GPIO_Speed_50MHz;
	GPIO_Init(GPIOA, &GPIO_InitStructure);	


	GPIO_InitStructure.GPIO_Pin = GPIO_Pin_12 | GPIO_Pin_13 | GPIO_Pin_14 | GPIO_Pin_15; // 12 SPI CS 13 SPI CLK 14 SPI RS 15 SPI SDA
	//	GPIO_InitStructure.GPIO_Mode = GPIO_Mode_AF_PP; 
	GPIO_InitStructure.GPIO_Mode = GPIO_Mode_Out_PP; 
	GPIO_InitStructure.GPIO_Speed = GPIO_Speed_50MHz;
	GPIO_Init(GPIOB, &GPIO_InitStructure);
	
	GPIO_InitStructure.GPIO_Pin = GPIO_Pin_0;//RGB DIR
	GPIO_InitStructure.GPIO_Mode = GPIO_Mode_Out_PP;
	GPIO_InitStructure.GPIO_Speed = GPIO_Speed_50MHz;
	GPIO_Init(GPIOC, &GPIO_InitStructure);	

	GPIO_InitStructure.GPIO_Pin = GPIO_Pin_12 | GPIO_Pin_13;// 12 MCU RST 13 RGB RST
	GPIO_InitStructure.GPIO_Mode = GPIO_Mode_Out_PP;
	GPIO_InitStructure.GPIO_Speed = GPIO_Speed_50MHz;
	GPIO_Init(GPIOD, &GPIO_InitStructure);	
	
	GPIO_InitStructure.GPIO_Pin = GPIO_Pin_1;// 1 RA8876 RST
	GPIO_InitStructure.GPIO_Mode = GPIO_Mode_Out_PP;
	GPIO_InitStructure.GPIO_Speed = GPIO_Speed_50MHz;
	GPIO_Init(GPIOE, &GPIO_InitStructure);	

	
	

	

//FSMC

	
	
	
	GPIO_InitStructure.GPIO_Pin = GPIO_Pin_6; //PD6 MCU_WAIT
	GPIO_InitStructure.GPIO_Speed = GPIO_Speed_50MHz;
	GPIO_InitStructure.GPIO_Mode = GPIO_Mode_IN_FLOATING;	//输入悬空
	GPIO_Init(GPIOD, &GPIO_InitStructure);
	

	GPIO_InitStructure.GPIO_Pin = GPIO_Pin_0 | GPIO_Pin_1 | GPIO_Pin_4 | GPIO_Pin_5 |
	                           GPIO_Pin_7 | GPIO_Pin_8 | GPIO_Pin_9 | GPIO_Pin_10 | GPIO_Pin_11 | GPIO_Pin_14 | 
	                            GPIO_Pin_15;
	GPIO_InitStructure.GPIO_Speed = GPIO_Speed_50MHz;
	GPIO_InitStructure.GPIO_Mode = GPIO_Mode_AF_PP; 
	GPIO_Init(GPIOD, &GPIO_InitStructure);


	GPIO_InitStructure.GPIO_Pin = GPIO_Pin_7 | GPIO_Pin_8 | GPIO_Pin_9 | GPIO_Pin_10 | 
	                            GPIO_Pin_11 | GPIO_Pin_12 | GPIO_Pin_13 | GPIO_Pin_14 | 
	                            GPIO_Pin_15;
  GPIO_InitStructure.GPIO_Speed = GPIO_Speed_50MHz;
	GPIO_InitStructure.GPIO_Mode = GPIO_Mode_AF_PP;
	GPIO_Init(GPIOE, &GPIO_InitStructure); 
	
}

void FSMC_LCD_Init(void)
{
	FSMC_NORSRAMInitTypeDef  FSMC_NORSRAMInitStructure;
	FSMC_NORSRAMTimingInitTypeDef  p;

	/* FSMC_Bank1_NORSRAM1 timing configuration */
	p.FSMC_AddressSetupTime = 0x00;/*地址建立时间期限*/											
	p.FSMC_AddressHoldTime = 0x00;/*地址的持续时间*/
	p.FSMC_DataSetupTime = 0x01;/*设定数据时间期限*/
	p.FSMC_BusTurnAroundDuration = 0x00;/*总线转向时间*/
	p.FSMC_CLKDivision = 0x00;/*CLK时钟输出信号的HCLK周期数表示时间???*/
	p.FSMC_DataLatency = 0x00;/*指定在获得第一个数据前的时钟周期*/
	p.FSMC_AccessMode = FSMC_AccessMode_A;

	FSMC_NORSRAMInitStructure.FSMC_Bank = FSMC_Bank1_NORSRAM1;/*指定的FSMC块*/
	FSMC_NORSRAMInitStructure.FSMC_DataAddressMux = FSMC_DataAddressMux_Disable; /*地址和数据值不复用的数据总线*/ 									   
	FSMC_NORSRAMInitStructure.FSMC_MemoryType = FSMC_MemoryType_NOR;/*外部存储器的类型*/
	FSMC_NORSRAMInitStructure.FSMC_MemoryDataWidth = FSMC_MemoryDataWidth_16b;/*数据宽度*/
	FSMC_NORSRAMInitStructure.FSMC_BurstAccessMode = FSMC_BurstAccessMode_Disable;/* 禁用突发访问模式*/
	FSMC_NORSRAMInitStructure.FSMC_WaitSignalPolarity = FSMC_WaitSignalPolarity_Low;/*指定等待信号的极性*/
	FSMC_NORSRAMInitStructure.FSMC_WrapMode = FSMC_WrapMode_Disable;/*Enables or disables the Wrapped burst access mode for Flash*/
	FSMC_NORSRAMInitStructure.FSMC_WaitSignalActive = FSMC_WaitSignalActive_BeforeWaitState;
	FSMC_NORSRAMInitStructure.FSMC_WriteOperation = FSMC_WriteOperation_Enable;/*启用指定的FSMC块的写操作*/
	FSMC_NORSRAMInitStructure.FSMC_WaitSignal = FSMC_WaitSignal_Disable;
	FSMC_NORSRAMInitStructure.FSMC_ExtendedMode = FSMC_ExtendedMode_Disable;/*扩展模式*/
	FSMC_NORSRAMInitStructure.FSMC_WriteBurst = FSMC_WriteBurst_Disable;/*禁用写突发操作*/
	FSMC_NORSRAMInitStructure.FSMC_ReadWriteTimingStruct = &p;
	FSMC_NORSRAMInitStructure.FSMC_WriteTimingStruct = &p;	 


	FSMC_NORSRAMInit(&FSMC_NORSRAMInitStructure);

	/* Enable FSMC Bank1_SRAM Bank */
	FSMC_NORSRAMCmd(FSMC_Bank1_NORSRAM1, ENABLE);  

}



