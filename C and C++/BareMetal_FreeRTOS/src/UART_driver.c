
#include "UART_driver.h"
UART_HandleTypeDef UartHandle;
volatile uint8_t flag = 0;
void UART_Init(){
    UartHandle.Instance          = USARTx;
    UartHandle.Init.BaudRate     = 9600;
    UartHandle.Init.WordLength   = UART_WORDLENGTH_8B;
    UartHandle.Init.StopBits     = UART_STOPBITS_1;
    UartHandle.Init.Parity       = UART_PARITY_NONE;
    UartHandle.Init.HwFlowCtl    = UART_HWCONTROL_NONE;
    UartHandle.Init.Mode         = UART_MODE_TX_RX;
    UartHandle.Init.OverSampling = UART_OVERSAMPLING_16;
    HAL_UART_Init(&UartHandle);
}
void UART_Return(uint8_t data1[]){
    HAL_UART_Transmit_IT(&UartHandle, (uint8_t *)data1, 3);
}
void UART_HandleComand(uint8_t data[]){
    HAL_UART_Receive_IT(&UartHandle, data, 2);
    while(flag != 1){}
    flag = 0;
}
void HAL_UART_RxCpltCallback(UART_HandleTypeDef *huart)
{
    flag = 1;
}
void USART6_IRQHandler(void)
{
    HAL_UART_IRQHandler(&UartHandle);

}
void HAL_UART_MspInit(UART_HandleTypeDef *huart)
{
  GPIO_InitTypeDef  GPIO_InitStruct;
  USARTx_TX_GPIO_CLK_ENABLE();
  USARTx_RX_GPIO_CLK_ENABLE();
  USARTx_CLK_ENABLE();
  GPIO_InitStruct.Pin       = USARTx_TX_PIN;
  GPIO_InitStruct.Mode      = GPIO_MODE_AF_PP;
  GPIO_InitStruct.Pull      = GPIO_PULLUP;
  GPIO_InitStruct.Speed     = GPIO_SPEED_FAST;
  GPIO_InitStruct.Alternate = USARTx_TX_AF;
  HAL_GPIO_Init(USARTx_TX_GPIO_PORT, &GPIO_InitStruct);
  GPIO_InitStruct.Pin = USARTx_RX_PIN;
  GPIO_InitStruct.Alternate = USARTx_RX_AF;
  HAL_GPIO_Init(USARTx_RX_GPIO_PORT, &GPIO_InitStruct);
  HAL_NVIC_SetPriority(USART6_IRQn, 0, 0);
  HAL_NVIC_EnableIRQ(USART6_IRQn);
}
void HAL_UART_MspDeInit(UART_HandleTypeDef *huart)
{
  USARTx_FORCE_RESET();
  USARTx_RELEASE_RESET();
  HAL_GPIO_DeInit(USARTx_TX_GPIO_PORT, USARTx_TX_PIN);
  HAL_GPIO_DeInit(USARTx_RX_GPIO_PORT, USARTx_RX_PIN);
}
