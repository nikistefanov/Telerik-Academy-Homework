#ifndef LED_DRIVER_H_INCLUDED
#define LED_DRIVER_H_INCLUDED
#include "stm32f4xx_hal.h"

void LEDS_Init();
void LED_On(uint8_t number);
void LED_Off(uint8_t number);
void LEDS_DeInit();



#endif /* LED_DRIVER_H_INCLUDED */
