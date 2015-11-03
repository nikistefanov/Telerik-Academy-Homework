#include "PWM_driver.h"
static TIM_HandleTypeDef    TimHandle;
static TIM_OC_InitTypeDef sConfig;

void PWM_Init(void){
    TimHandle.Instance = TIMx;
    TimHandle.Init.Prescaler     = 4;
    TimHandle.Init.Period        = PERIOD_VALUE;
    TimHandle.Init.ClockDivision = 0;
    TimHandle.Init.CounterMode   = TIM_COUNTERMODE_UP;
    HAL_TIM_PWM_Init(&TimHandle);

  /*##-2- Configure the PWM channels #########################################*/
  /* Common configuration for all channels */
    sConfig.OCMode     = TIM_OCMODE_PWM1;
    sConfig.OCPolarity = TIM_OCPOLARITY_LOW;
    sConfig.OCFastMode = TIM_OCFAST_DISABLE;

  /* Set the pulse value for channel 1 */
    sConfig.Pulse = 0x0000;
    HAL_TIM_PWM_ConfigChannel(&TimHandle, &sConfig, TIM_CHANNEL_1);

  /* Set the pulse value for channel 2 */
    sConfig.Pulse = 0x0000;
    HAL_TIM_PWM_ConfigChannel(&TimHandle, &sConfig, TIM_CHANNEL_2);

  /*##-3- Start PWM signals generation #######################################*/
  /* Start channel 1 */
    HAL_TIM_PWM_Start(&TimHandle, TIM_CHANNEL_1);
  /* Start channel 2 */
    HAL_TIM_PWM_Start(&TimHandle, TIM_CHANNEL_2);

}

void PWM_SetPulse(uint8_t Led, uint32_t Value){
    sConfig.Pulse = Value;
    if(Led == 1){
         HAL_TIM_PWM_ChangePulseWeith(&TimHandle, &sConfig, TIM_CHANNEL_1);
    }
    else if(Led == 2){
        HAL_TIM_PWM_ChangePulseWeith(&TimHandle, &sConfig, TIM_CHANNEL_2);
    }
    else{
        HAL_TIM_PWM_ChangePulseWeith(&TimHandle, &sConfig, TIM_CHANNEL_1);
        HAL_TIM_PWM_ChangePulseWeith(&TimHandle, &sConfig, TIM_CHANNEL_2);
    }

}

void PWM_DeInit(void){
}


void HAL_TIM_PWM_MspInit(TIM_HandleTypeDef *htim)
{
  GPIO_InitTypeDef   GPIO_InitStruct;

  /*##-1- Enable peripherals and GPIO Clocks #################################*/
  /* TIMx Peripheral clock enable */
  TIMx_CLK_ENABLE();

  /* Enable GPIO Channels Clock */
  TIMx_CHANNEL_GPIO_PORT();

  /*##-2- Configure I/Os #####################################################*/
  /* Configure PB.4 (TIM3_Channel1), PB.5 (TIM3_Channel2),
   in output, push-pull, alternate function mode
  */
  /* Common configuration for all channels */
  GPIO_InitStruct.Mode = GPIO_MODE_AF_PP;
  GPIO_InitStruct.Pull = GPIO_PULLUP;
  GPIO_InitStruct.Speed = GPIO_SPEED_HIGH;
  GPIO_InitStruct.Alternate = GPIO_AF2_TIM3;

  GPIO_InitStruct.Pin = GPIO_PIN_CHANNEL1;
  HAL_GPIO_Init(GPIOB, &GPIO_InitStruct);

  GPIO_InitStruct.Pin = GPIO_PIN_CHANNEL2;
  HAL_GPIO_Init(GPIOB, &GPIO_InitStruct);
}
