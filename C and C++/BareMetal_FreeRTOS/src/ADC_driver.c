#include "main.h"
#include "ADC_driver.h"

ADC_HandleTypeDef    AdcHandle[2];
ADC_ChannelConfTypeDef sConfig[2];
uint8_t ADC_IT_Flag[2] = {0};
volatile uint32_t ADC_Value[2] = {0};

void ADC_Temp_Init(){
}
void ADC_Light_Init(){
    AdcHandle[1].Instance = ADCx;
    AdcHandle[1].Init.ClockPrescaler = ADC_CLOCKPRESCALER_PCLK_DIV2;
    AdcHandle[1].Init.Resolution = ADC_RESOLUTION_12B;
    AdcHandle[1].Init.ScanConvMode = DISABLE;
    AdcHandle[1].Init.ContinuousConvMode = DISABLE;//Disable continuous conversion
    AdcHandle[1].Init.DiscontinuousConvMode = DISABLE;
    AdcHandle[1].Init.NbrOfDiscConversion = 1;
    AdcHandle[1].Init.ExternalTrigConvEdge = ADC_EXTERNALTRIGCONVEDGE_NONE;
    AdcHandle[1].Init.ExternalTrigConv = ADC_SOFTWARE_START;//Configure SW trigger
    AdcHandle[1].Init.DataAlign = ADC_DATAALIGN_RIGHT;
    AdcHandle[1].Init.NbrOfConversion = 1;
    AdcHandle[1].Init.DMAContinuousRequests = ENABLE;
    AdcHandle[1].Init.EOCSelection = DISABLE;
    HAL_ADC_Init(&AdcHandle[1]);
    sConfig[1].Channel = ADCx_CHANNEL;
    sConfig[1].Rank = 1;
    sConfig[1].SamplingTime = ADC_SAMPLETIME_3CYCLES;
    sConfig[1].Offset = 0;
    HAL_ADC_ConfigChannel(&AdcHandle[1], &sConfig[1]);
}
uint32_t ADC_GetValueTemp(){
    return 0b1 << 24;
}
uint32_t ADC_GetValueLight(){
    HAL_ADC_Start_DMA(&AdcHandle[1], (uint32_t*)&ADC_Value[1], 1);
    while(ADC_IT_Flag[1] != 1){};
    return ADC_Value[1];
    ADC_IT_Flag[1] = 0;
    HAL_ADC_Stop_DMA(&AdcHandle[1]);
}
void ADC_Temp_DeInint(){
}
void ADC_Light_DeInit(){
}
void ADCx_DMA_IRQHandler(void){
    HAL_DMA_IRQHandler(AdcHandle[1].DMA_Handle);
}
void HAL_ADC_ConvCpltCallback(ADC_HandleTypeDef* AdcHandle){
    if(AdcHandle->Instance == ADC1){
        ADC_IT_Flag[1] = 1;
    }
    else {
        ADC_IT_Flag[0] = 1;
    }
}
void HAL_ADC_MspInit(ADC_HandleTypeDef* hadc) {
  GPIO_InitTypeDef          GPIO_InitStruct;
  static DMA_HandleTypeDef  hdma_adc;

  /*##-1- Enable peripherals and GPIO Clocks #################################*/
  /* Enable GPIO clock */
  ADCx_CHANNEL_GPIO_CLK_ENABLE();
  /* ADC3 Periph clock enable */
  ADCx_CLK_ENABLE();
  /* Enable DMA2 clock */
  DMAx_CLK_ENABLE();

  /*##-2- Configure peripheral GPIO ##########################################*/
  /* ADC3 Channel8 GPIO pin configuration */
  GPIO_InitStruct.Pin = ADCx_CHANNEL_PIN;
  GPIO_InitStruct.Mode = GPIO_MODE_ANALOG;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  HAL_GPIO_Init(ADCx_CHANNEL_GPIO_PORT, &GPIO_InitStruct);

  /*##-3- Configure the DMA streams ##########################################*/
  /* Set the parameters to be configured */
  hdma_adc.Instance = ADCx_DMA_STREAM;

  hdma_adc.Init.Channel  = ADCx_DMA_CHANNEL;
  hdma_adc.Init.Direction = DMA_PERIPH_TO_MEMORY;
  hdma_adc.Init.PeriphInc = DMA_PINC_DISABLE;
  hdma_adc.Init.MemInc = DMA_MINC_ENABLE;
  hdma_adc.Init.PeriphDataAlignment = DMA_PDATAALIGN_WORD;
  hdma_adc.Init.MemDataAlignment = DMA_MDATAALIGN_WORD;
  hdma_adc.Init.Mode = DMA_CIRCULAR;
  hdma_adc.Init.Priority = DMA_PRIORITY_HIGH;
  hdma_adc.Init.FIFOMode = DMA_FIFOMODE_DISABLE;
  hdma_adc.Init.FIFOThreshold = DMA_FIFO_THRESHOLD_HALFFULL;
  hdma_adc.Init.MemBurst = DMA_MBURST_SINGLE;
  hdma_adc.Init.PeriphBurst = DMA_PBURST_SINGLE;

  HAL_DMA_Init(&hdma_adc);

  /* Associate the initialized DMA handle to the the ADC handle */
  __HAL_LINKDMA(hadc, DMA_Handle, hdma_adc);

  /*##-4- Configure the NVIC for DMA #########################################*/
  /* NVIC configuration for DMA transfer complete interrupt */
  HAL_NVIC_SetPriority(ADCx_DMA_IRQn, 0, 0);
  HAL_NVIC_EnableIRQ(ADCx_DMA_IRQn);
}
void HAL_ADC_MspDeInit(ADC_HandleTypeDef *hadc){
  static DMA_HandleTypeDef  hdma_adc;

  /*##-1- Reset peripherals ##################################################*/
  ADCx_FORCE_RESET();
  ADCx_RELEASE_RESET();

  /*##-2- Disable peripherals and GPIO Clocks ################################*/
  /* De-initialize the ADC3 Channel8 GPIO pin */
  HAL_GPIO_DeInit(ADCx_CHANNEL_GPIO_PORT, ADCx_CHANNEL_PIN);

  /*##-3- Disable the DMA Streams ############################################*/
  /* De-Initialize the DMA Stream associate to transmission process */
  HAL_DMA_DeInit(&hdma_adc);

  /*##-4- Disable the NVIC for DMA ###########################################*/
  HAL_NVIC_DisableIRQ(ADCx_DMA_IRQn);
}
