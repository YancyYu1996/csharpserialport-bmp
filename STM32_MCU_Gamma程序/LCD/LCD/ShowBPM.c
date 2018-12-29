#include "ShowBPM.h"
#include "usart.h"

void Send_Bpm(u8* USART_RX_BUF,int len)
{
	  int i;
		for(i = 0;i<len;i++)
		{
			printf("%X",USART_RX_BUF[i]);
		}

}
