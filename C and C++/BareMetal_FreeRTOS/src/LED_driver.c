#include "LED_driver.h"

void LEDS_Init(){
    static GPIO_InitTypeDef  GPIO_InitStruct;
    __HAL_RCC_GPIOA_CLK_ENABLE();
    __HAL_RCC_GPIOB_CLK_ENABLE();
    GPIO_InitStruct.Pin = GPIO_PIN_3;
    GPIO_InitStruct.Mode = GPIO_MODE_OUTPUT_PP;
    GPIO_InitStruct.Pull = GPIO_PULLUP;
    GPIO_InitStruct.Speed = GPIO_SPEED_FAST;
    HAL_GPIO_Init(GPIOA, &GPIO_InitStruct);
    GPIO_InitStruct.Pin = GPIO_PIN_2;
    HAL_GPIO_Init(GPIOA, &GPIO_InitStruct);
    GPIO_InitStruct.Pin = GPIO_PIN_10;
    HAL_GPIO_Init(GPIOA, &GPIO_InitStruct);
    GPIO_InitStruct.Pin = GPIO_PIN_8;
    HAL_GPIO_Init(GPIOA, &GPIO_InitStruct);
    GPIO_InitStruct.Pin = GPIO_PIN_10;
    HAL_GPIO_Init(GPIOB, &GPIO_InitStruct);
    GPIO_InitStruct.Pin = GPIO_PIN_3;
    HAL_GPIO_Init(GPIOB, &GPIO_InitStruct);
    HAL_GPIO_WritePin(GPIOA, GPIO_PIN_3,GPIO_PIN_SET);
    HAL_GPIO_WritePin(GPIOA, GPIO_PIN_2,GPIO_PIN_SET);
    HAL_GPIO_WritePin(GPIOA, GPIO_PIN_10,GPIO_PIN_SET);
    HAL_GPIO_WritePin(GPIOB, GPIO_PIN_3,GPIO_PIN_SET);
    HAL_GPIO_WritePin(GPIOB, GPIO_PIN_10,GPIO_PIN_SET);
    HAL_GPIO_WritePin(GPIOA, GPIO_PIN_8,GPIO_PIN_SET);
}

void LED_On(uint8_t number){
switch (number) {
    case 0:
        HAL_GPIO_WritePin(GPIOA, GPIO_PIN_3,GPIO_PIN_RESET);
        break;
    case 1:
        HAL_GPIO_WritePin(GPIOA, GPIO_PIN_2,GPIO_PIN_RESET);
        break;
    case 2:
        HAL_GPIO_WritePin(GPIOA, GPIO_PIN_10,GPIO_PIN_RESET);
        break;
    case 3:
        HAL_GPIO_WritePin(GPIOB, GPIO_PIN_3,GPIO_PIN_RESET);
        break;
    case 4:
        HAL_GPIO_WritePin(GPIOB, GPIO_PIN_10,GPIO_PIN_RESET);
        break;
    case 5:
        HAL_GPIO_WritePin(GPIOA, GPIO_PIN_8,GPIO_PIN_RESET);
        break;
    }
}
void LED_Off(uint8_t number){
switch (number) {
    case 0:
        HAL_GPIO_WritePin(GPIOA, GPIO_PIN_3,GPIO_PIN_SET);
        break;
    case 1:
        HAL_GPIO_WritePin(GPIOA, GPIO_PIN_2,GPIO_PIN_SET);
        break;
    case 2:
        HAL_GPIO_WritePin(GPIOA, GPIO_PIN_10,GPIO_PIN_SET);
        break;
    case 3:
        HAL_GPIO_WritePin(GPIOB, GPIO_PIN_3,GPIO_PIN_SET);
        break;
    case 4:
        HAL_GPIO_WritePin(GPIOB, GPIO_PIN_10,GPIO_PIN_SET);
        break;
    case 5:
        HAL_GPIO_WritePin(GPIOA, GPIO_PIN_8,GPIO_PIN_SET);
        break;
    }
}

