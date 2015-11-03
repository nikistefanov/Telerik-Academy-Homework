#ifndef PWM_DRIVER_H_INCLUDED
#define PWM_DRIVER_H_INCLUDED
#include "stm32f4xx_hal.h"
//#include "stm32f4xx_hal_tim.h"
#define TIMx                           TIM3
#define TIMx_CLK_ENABLE                __HAL_RCC_TIM3_CLK_ENABLE

/* Definition for USARTx Pins */
#define TIMx_CHANNEL_GPIO_PORT()       __HAL_RCC_GPIOB_CLK_ENABLE()
#define GPIO_PIN_CHANNEL1              GPIO_PIN_4
#define GPIO_PIN_CHANNEL2              GPIO_PIN_5
#define  PERIOD_VALUE       (1800 - 1)  /* Period Value  */
#define  PULSE1_VALUE       1350        /* Capture Compare 1 Value  */ //max
#define  PULSE2_VALUE       900         /* Capture Compare 2 Value  */
#define  PULSE3_VALUE       600         /* Capture Compare 3 Value  */
#define  PULSE4_VALUE       5           /* Capture Compare 4 Value  */ //min


void PWM_Init(void);
void PWM_SetPulse(uint8_t Led, uint32_t Value);
// Led0 = Both
void PWM_DeInit(void);


#endif /* PWM_DRIVER_H_INCLUDED */
