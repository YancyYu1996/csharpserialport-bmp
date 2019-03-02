/*
  ******************************************************************************
  * @file    LCD
  * @author  LCD
  * @version V1.0
  * @date    20170101
  * @brief   LCD
  ******************************************************************************
*/
#include "stm32f10x.h"
#include <stdio.h>
#include "main.h"
#include "ShowBPM.h"
unsigned char Packet[30]={0};
static char ID_flag = 0; 
int main(void)
{
	u16 i=0,j=0,t=0;  
	u16 len;
	u8 tmp1=0,tmp2=0;

	RCC_Configuration();
	delay_init();
	NVIC_PriorityGroupConfig(NVIC_PriorityGroup_2);
	uart_init(115200);
	GPIO_Configuration();
	MCU_DIR_Write;
	RGB_DIR_Write;
	RCC_AHBPeriphClockCmd(RCC_AHBPeriph_FSMC, ENABLE);
	FSMC_LCD_Init();
	SD_Init();
	
	LCD_RST();
	LCD_Init();
	BlockWrite(0,LCD_WIDTH-1,0,LCD_HEIGHT-1);

	 	while(1)
	{
		
		if(USART_RX_STA&0x8000)
		{					   
			len=USART_RX_STA&0x3fff;//得到此次接收到的数据长度
			
			/****************************send_bmp****************************/
			if(USART_RX_BUF[0] == 0x95 && USART_RX_BUF[1] == 0x03)  //说明读到ID。2,3返回宽  4,5高
			{
				ID_flag = 1;	
				USART_RX_BUF[2] = LCD_WIDTH/100;
				USART_RX_BUF[3] = LCD_WIDTH%100;
				USART_RX_BUF[4] = LCD_HEIGHT/100;
				USART_RX_BUF[5] = LCD_HEIGHT%100;
				
				if(USART_RX_BUF[8]==1)
				{
						BlockWrite(0,LCD_WIDTH-1,0,LCD_HEIGHT-1);
				}					
	
				for(t=0;t<len;t++)
			{
				
				USART_SendData(USART1, USART_RX_BUF[t]);//向串口1发送数据
				while(USART_GetFlagStatus(USART1,USART_FLAG_TC)!=SET);//等待发送结束
			}
			
			}
			else if(USART_RX_BUF[0] == 0x02) //一行一行发
			{
			
				DrawOneWidth(USART_RX_BUF);	
			
			}
		//	else if(USART_RX_BUF[0] == 0x01)  //一点发
		//	{
				
		//		DrawOneDot(USART_RX_BUF);	
		//	}									
			USART_RX_STA=0;
		    
			
			
			/****************************send_bmp****************************/
		
			for(i=0,t=0;t<len;)
			{
				
				if((0x2F<USART_RX_BUF[t])&&(USART_RX_BUF[t]<0x3A))//判断0~9
				{
					tmp1=USART_RX_BUF[t]-0x30;
					USART_RX_BUF[t] = tmp1;
				}
				
		     if((0x40<USART_RX_BUF[t])&&(USART_RX_BUF[t]<0x47))//判断A~F
				{
					tmp1=USART_RX_BUF[t]-0x37;
					USART_RX_BUF[t] = tmp1;
				}
				
				t++;
				
				 if((0x2F<USART_RX_BUF[t])&&(USART_RX_BUF[t]<0x3A))//判断0~9
				{
					tmp2=USART_RX_BUF[t]-0x30;
					USART_RX_BUF[t] = tmp2;
				}
				
		     if((0x40<USART_RX_BUF[t])&&(USART_RX_BUF[t]<0x47))//判断A~F
				{
					tmp2=USART_RX_BUF[t]-0x37;
					USART_RX_BUF[t] = tmp2;
				}
				
				Packet[i]=(tmp1<<4)+(tmp2);
				
				t++;
				i++;
				

			}
		
			
			switch(Packet[1])
		{
		   case 0:		                    
			   for(j=0;j<Packet[2];j++) 
			    {
						LCD_DataWrite(Packet[3+j]);
					} 
			   break;
	
		   case 1:			                  //?á??′???E
				 switch(Packet[3])
				 {
				  case 1:LCD_CtrlWrite(Packet[2]);MCU_DIR_Read;Packet[2]=LCD_DataRead();MCU_DIR_Write;break;
				  case 2:LCD_CtrlWrite(Packet[2]);MCU_DIR_Read;Packet[2]=LCD_DataRead();Packet[2]=LCD_DataRead();Packet[3]=LCD_DataRead();MCU_DIR_Write;break;
				  case 3:LCD_CtrlWrite(Packet[2]);MCU_DIR_Read;Packet[2]=LCD_DataRead();Packet[2]=LCD_DataRead();Packet[3]=LCD_DataRead();Packet[4]=LCD_DataRead();MCU_DIR_Write;break;
				  case 4:LCD_CtrlWrite(Packet[2]);MCU_DIR_Read;Packet[2]=LCD_DataRead();Packet[2]=LCD_DataRead();Packet[3]=LCD_DataRead();Packet[4]=LCD_DataRead();Packet[5]=LCD_DataRead();MCU_DIR_Write;break;
				  default:break;
				 }
		       break;
			   								
		   case 2: 							   //?èD′μ??·￡??ùD′êy?Y	,just for Gamma
					LCD_CtrlWrite(Packet[2]);	
				 for(j=0;j<Packet[3];j++) 
				 {
				   LCD_DataWrite(Packet[4+j]);
				 } 
			   break;
	
		   case 3: 							   //?￠?ò?×
				 if(Packet[2]==0x40)		   //64
					{	 
						DispColor(Packet[3]);
				  }
				 if(Packet[2]==0x20)			//32
					{	 
					  DispColor(Packet[3]*2);
					}

				 break;
	
		 case 4: 	
			 	  if( Packet[2]==0x40)
				  {
				   	 DispFlick(Packet[3]);
				   }
				  if( Packet[2]==0x20)
				  {
				     DispFlick(Packet[3]*2);
				   }
			  
			 break;

		case 5: 							   //for others but not Gamma
				LCD_CtrlWrite(Packet[2]);	
				 for(j=0;j<Packet[3];j++) 
				 {
				   LCD_DataWrite(Packet[4+j]);
				 } 
			   break;
	
	  default: break;
		}
	}
		
			


}


}









void RCC_Configuration(void)
{   
  /* Setup the microcontroller system. Initialize the Embedded Flash Interface,  
     initialize the PLL and update the SystemFrequency variable. */
  SystemInit();

  /* Enable Key Button GPIO Port, GPIO_LED and AFIO clock */
  RCC_APB2PeriphClockCmd(RCC_APB2Periph_AFIO, ENABLE);

  RCC_APB1PeriphClockCmd(RCC_APB1Periph_TIM3,ENABLE);


  /* 使能USART1&使能GPIO port clock */
  RCC_APB2PeriphClockCmd( RCC_APB2Periph_USART1 |RCC_APB2Periph_GPIOA | RCC_APB2Periph_GPIOB |
                         RCC_APB2Periph_GPIOC | RCC_APB2Periph_GPIOD |
                         RCC_APB2Periph_GPIOE, ENABLE);
}


