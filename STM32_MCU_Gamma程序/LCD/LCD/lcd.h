#include "stm32f10x.h"
#include <stdio.h>
#include "stdlib.h"
#include <delay.h>
#include "ff.h"	 


#define LCD_WIDTH 240
#define LCD_HEIGHT 320




#define LCD_BASE0        ((u32)0x60000000)
#define LCD_BASE1        ((u32)0x60020000)

#define LCD_CtrlWrite(cmd)	  *(vu16*) (LCD_BASE0)= (cmd)
#define LCD_DataWrite(data)   *(vu16*) (LCD_BASE1)= (data)
#define	LCD_StatusRead()	 *(vu16*) (LCD_BASE0)
#define	LCD_DataRead()   	 *(vu16*) (LCD_BASE1)



#define MCU_DIR_Write GPIOA->BSRR = GPIO_Pin_0
#define MCU_DIR_Read  GPIOA->BRR = GPIO_Pin_0

#define RGB_DIR_Write GPIOC->BRR = GPIO_Pin_0
#define RGB_DIR_Read GPIOC->BSRR = GPIO_Pin_0

#define H_MCUReset GPIOD->BSRR = GPIO_Pin_12
#define L_MCUReset GPIOD->BRR = GPIO_Pin_12

#define H_SPIReset GPIOD->BSRR = GPIO_Pin_13
#define L_SPIReset GPIOD->BRR = GPIO_Pin_13

void GPIO_Configuration(void);
void FSMC_LCD_Init(void);
void LCD_RST(void);
void LCD_Init(void);
void BlockWrite(unsigned int Xstart,unsigned int Xend,unsigned int Ystart,unsigned int Yend);
void DispColor(unsigned int color);
void DispFlick(unsigned int color);
void sd_showbmp(char * fname);
void DispColorR(unsigned int color);









