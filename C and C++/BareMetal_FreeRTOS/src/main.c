/**
  ******************************************************************************
  * @file    GPIO/GPIO_IOToggle/Src/main.c
  * @author  MCD Application Team
  * @version V1.2.1
  * @date    13-March-2015
  * @brief   This example describes how to configure and use GPIOs through
  *          the STM32F4xx HAL API.
  ******************************************************************************
  * @attention
  *
  * <h2><center>&copy; COPYRIGHT(c) 2015 STMicroelectronics</center></h2>
  *
  * Redistribution and use in source and binary forms, with or without modification,
  * are permitted provided that the following conditions are met:
  *   1. Redistributions of source code must retain the above copyright notice,
  *      this list of conditions and the following disclaimer.
  *   2. Redistributions in binary form must reproduce the above copyright notice,
  *      this list of conditions and the following disclaimer in the documentation
  *      and/or other materials provided with the distribution.
  *   3. Neither the name of STMicroelectronics nor the names of its contributors
  *      may be used to endorse or promote products derived from this software
  *      without specific prior written permission.
  *
  * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
  * AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
  * IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
  * DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE
  * FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
  * DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
  * SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
  * CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
  * OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
  * OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
  *
  ******************************************************************************
  */

/* Includes ------------------------------------------------------------------*/
#include "main.h"
#include "cmsis_os.h"

/** @addtogroup STM32F4xx_HAL_Examples
  * @{
  */

/** @addtogroup GPIO_IOToggle
  * @{
  */

/* Private typedef -----------------------------------------------------------*/
/* Private define ------------------------------------------------------------*/
/* Private macro -------------------------------------------------------------*/
/* Private variables ---------------------------------------------------------*/

/* Private function prototypes -----------------------------------------------*/
static void SystemClock_Config(void);
static void Error_Handler(void);

static TaskHandle_t MyTaskHandle[2] = {NULL,NULL};
static TimerHandle_t u32TimerHandler[4] ={NULL,NULL,NULL,NULL};
uint8_t LEDSelfDriveEnabled[2] = {0,0};
uint16_t SensorsValue[2] = {0,0};
static uint8_t Command[2];
static uint8_t Return[3];
/* Private functions ---------------------------------------------------------*/

#define Timer2Event 1
void ProcessTask( void * pvParameters )
 {

	 for( ;; )
	 {
        UART_HandleComand(Command);
            Return[0] = Command[0];
            Return[1] = Command[1];
            switch (Command[0]){
                case 0x01:
                    switch (Command[1]){
                        case 0x01:
                            LED_On(0);
                            break;
                        case 0x02:
                            LED_On(1);
                            break;
                        case 0x03:
                            LED_On(2);
                            break;
                        case 0x04:
                            LED_On(3);
                            break;
                        case 0x05:
                            LED_On(4);
                            break;
                        case 0x06:
                            PWM_SetPulse(2,0xffff);
                            break;
                        case 0x07:
                            PWM_SetPulse(1,0xffff);
                            break;
                        case 0x08:
                            LED_On(5);
                            break;
                        case 0x09:
                            LED_On(0);
                            LED_On(1);
                            LED_On(2);
                            LED_On(3);
                            LED_On(4);
                            LED_On(5);
                            PWM_SetPulse(0,0xffff);

                    }
                    Return[2] = 0x00;
                    break;
                case 0x02:
                    switch (Command[1]){
                        case 0x01:
                            LED_Off(0);
                            break;
                        case 0x02:
                            LED_Off(1);
                            break;
                        case 0x03:
                            LED_Off(2);
                            break;
                        case 0x04:
                            LED_Off(3);
                            break;
                        case 0x05:
                            LED_Off(4);
                            break;
                        case 0x06:
                            PWM_SetPulse(2,0x0000);
                            break;
                        case 0x07:
                            PWM_SetPulse(1,0x0000);
                            break;
                        case 0x08:
                            LED_Off(5);
                            break;
                        case 0x09:
                            LED_Off(0);
                            LED_Off(1);
                            LED_Off(2);
                            LED_Off(3);
                            LED_Off(4);
                            LED_Off(5);
                            PWM_SetPulse(0,0x0000);
                            break;
                    }
                    Return[2] = 0x00;
                    break;
                case 0x03:
                    if(Command[1] & 0x80) {
                        Command[1] -= 128;
                        PWM_SetPulse(1,Command[1] * 70);
                    }
                    else {
                        PWM_SetPulse(2,Command[1] * 70);
                    }
                    Return[2] = 0x00;
                    break;
                case 0x04:
                    switch(Command[1]){
                        case 0x01:
                            Return[1] = SensorsValue[0] & 0xff;
                            Return[2] = (SensorsValue[0] >> 8) & 0xff;
                            break;
                        case 0x02:
                            Return[1] = SensorsValue[1] & 0xff;
                            Return[2] = (SensorsValue[1] >> 8) & 0xff;
                            break;
                    }
                    break;
                case 0x05:
                    switch(Command[1]){
                    case 0x01:
                            xTimerStart( u32TimerHandler[0], 0 );
                            break;
                    case 0x02:
                            xTimerStart( u32TimerHandler[1], 0 );
                            break;
                    }
                    Return[2] = 0x00;
                    break;
            }
            UART_Return(Return);
            Command[0] = 0;
            Command[1] = 0;

	 }
}
void InitTask( void * pvParameters )
 {

	ADC_Light_Init();
	ADC_Temp_Init();
    PWM_Init();
    LEDS_Init();
    UART_Init();
    vTaskSuspend( NULL );
 }

 void Timer1_ExpireCallBack( TimerHandle_t pxTimer )
 {
    PWM_SetPulse(1,SensorsValue[0]);
}

 void Timer2_ExpireCallBack( TimerHandle_t pxTimer )
 {
    PWM_SetPulse(2,SensorsValue[0]);
}
void Timer3_ExpireCallBack( TimerHandle_t pxTimer )
 {
    SensorsValue[0] = ADC_GetValueLight();
}
void Timer4_ExpireCallBack( TimerHandle_t pxTimer )
 {
    SensorsValue[1] = ADC_GetValueTemp();
}
/**
  * @brief  Main program
  * @param  None
  * @retval None
  */
int main(void)
{
  static uint16_t u16MyTaskParameters;
  uint8_t u8TaskRet;
  HAL_Init();
  SystemClock_Config();

  u32TimerHandler[0] = xTimerCreate( "Timer1",       // Just a text name, not used by the kernel.
                                          ( 1 ),   // The timer period in ticks.
                                          pdTRUE,        // The timers will auto-reload themselves when they expire.
                                          ( void * ) 1,  // Assign each timer a unique id equal to its array index.
                                         Timer1_ExpireCallBack // Each timer calls the same callback when it expires.
                                     );
  u32TimerHandler[1] = xTimerCreate( "Timer2",       // Just a text name, not used by the kernel.
                                          ( 1 ),   // The timer period in ticks.
                                          pdTRUE,        // The timers will auto-reload themselves when they expire.
                                          ( void * ) 1,  // Assign each timer a unique id equal to its array index.
                                         Timer2_ExpireCallBack // Each timer calls the same callback when it expires.
                                     );
  u32TimerHandler[2] = xTimerCreate( "Timer3",       // Just a text name, not used by the kernel.
                                          ( 1 ),   // The timer period in ticks.
                                          pdTRUE,        // The timers will auto-reload themselves when they expire.
                                          ( void * ) 1,  // Assign each timer a unique id equal to its array index.
                                         Timer3_ExpireCallBack // Each timer calls the same callback when it expires.
                                     );
  u32TimerHandler[3] = xTimerCreate( "Timer4",       // Just a text name, not used by the kernel.
                                          ( 1 ),   // The timer period in ticks.
                                          pdTRUE,        // The timers will auto-reload themselves when they expire.
                                          ( void * ) 1,  // Assign each timer a unique id equal to its array index.
                                         Timer4_ExpireCallBack // Each timer calls the same callback when it expires.
                                     );

  if( u32TimerHandler[2] == NULL )
  {
  }
  else
  {
      if( xTimerStart( u32TimerHandler[2], 0 ) != pdPASS )
      {
     }

  }

  if( u32TimerHandler[3] == NULL )
  {
  }
  else
  {
     if( xTimerStart( u32TimerHandler[3], 0 ) != pdPASS )
      {
      }
  }


  u8TaskRet = xTaskCreate( InitTask, "InitTask", 500, &u16MyTaskParameters, 1, &MyTaskHandle[0] );
  u8TaskRet &= xTaskCreate( ProcessTask, "ProcessTask", 300, &u16MyTaskParameters, 0, &MyTaskHandle[1] );

  if (u8TaskRet == pdTRUE) {
    vTaskStartScheduler();  // should never return
  } else {
     // --TODO blink some LEDs to indicate fatal system error
  }

  while (1)
  {

  }
}

/**
  * @brief  System Clock Configuration
  *         The system Clock is configured as follow :
  *            System Clock source            = PLL (HSI)
  *            SYSCLK(Hz)                     = 84000000
  *            HCLK(Hz)                       = 84000000
  *            AHB Prescaler                  = 1
  *            APB1 Prescaler                 = 2
  *            APB2 Prescaler                 = 1
  *            HSI Frequency(Hz)              = 16000000
  *            PLL_M                          = 16
  *            PLL_N                          = 336
  *            PLL_P                          = 4
  *            PLL_Q                          = 7
  *            VDD(V)                         = 3.3
  *            Main regulator output voltage  = Scale2 mode
  *            Flash Latency(WS)              = 2
  * @param  None
  * @retval None
  */
static void SystemClock_Config(void)
{
  RCC_ClkInitTypeDef RCC_ClkInitStruct;
  RCC_OscInitTypeDef RCC_OscInitStruct;

  /* Enable Power Control clock */
  __HAL_RCC_PWR_CLK_ENABLE();

  /* The voltage scaling allows optimizing the power consumption when the device is
     clocked below the maximum system frequency, to update the voltage scaling value
     regarding system frequency refer to product datasheet.  */
  __HAL_PWR_VOLTAGESCALING_CONFIG(PWR_REGULATOR_VOLTAGE_SCALE2);

  /* Enable HSI Oscillator and activate PLL with HSI as source */
  RCC_OscInitStruct.OscillatorType = RCC_OSCILLATORTYPE_HSI;
  RCC_OscInitStruct.HSIState = RCC_HSI_ON;
  RCC_OscInitStruct.HSICalibrationValue = 0x10;
  RCC_OscInitStruct.PLL.PLLState = RCC_PLL_ON;
  RCC_OscInitStruct.PLL.PLLSource = RCC_PLLSOURCE_HSI;
  RCC_OscInitStruct.PLL.PLLM = 16;
  RCC_OscInitStruct.PLL.PLLN = 336;
  RCC_OscInitStruct.PLL.PLLP = RCC_PLLP_DIV4;
  RCC_OscInitStruct.PLL.PLLQ = 7;
  if(HAL_RCC_OscConfig(&RCC_OscInitStruct) != HAL_OK)
  {
    Error_Handler();
  }

  /* Select PLL as system clock source and configure the HCLK, PCLK1 and PCLK2
     clocks dividers */
  RCC_ClkInitStruct.ClockType = (RCC_CLOCKTYPE_SYSCLK | RCC_CLOCKTYPE_HCLK | RCC_CLOCKTYPE_PCLK1 | RCC_CLOCKTYPE_PCLK2);
  RCC_ClkInitStruct.SYSCLKSource = RCC_SYSCLKSOURCE_PLLCLK;
  RCC_ClkInitStruct.AHBCLKDivider = RCC_SYSCLK_DIV1;
  RCC_ClkInitStruct.APB1CLKDivider = RCC_HCLK_DIV2;
  RCC_ClkInitStruct.APB2CLKDivider = RCC_HCLK_DIV1;
  if(HAL_RCC_ClockConfig(&RCC_ClkInitStruct, FLASH_LATENCY_2) != HAL_OK)
  {
    Error_Handler();
  }
}

/**
  * @brief  This function is executed in case of error occurrence.
  * @param  None
  * @retval None
  */
static void Error_Handler(void)
{
  while(1)
  {
  }
}

#ifdef  USE_FULL_ASSERT
/**
  * @brief  Reports the name of the source file and the source line number
  *         where the assert_param error has occurred.
  * @param  file: pointer to the source file name
  * @param  line: assert_param error line source number
  * @retval None
  */
void assert_failed(uint8_t* file, uint32_t line)
{
  /* User can add his own implementation to report the file name and line number,
     ex: printf("Wrong parameters value: file %s on line %d\r\n", file, line) */

  /* Infinite loop */
  while (1)
  {
  }
}
#endif

/**
  * @}
  */

/**
  * @}
  */

/************************ (C) COPYRIGHT STMicroelectronics *****END OF FILE****/
