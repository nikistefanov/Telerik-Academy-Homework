#include <iostream>
#include <cmath>
#define MAX 150000
#define MIN -150000
using namespace std;

int arrMax(int * arr, int sz,int upperbound){
	int currmax = MIN ;
	if(sz == 1){
		return currmax;
	}
	else{
		for(int i = 1; i < sz;i++){
			if ((arr[i] > currmax) && (arr[i] < upperbound)){
				currmax = arr[i];
			}
		}
	}
	return currmax;
}
int arrMin(int * arr, int sz,int lowerbound){
	int currmin = MAX;
	if(sz == 1){
		return currmin;
	}
	else{
		for(int i = 1; i < sz;i++){
			if ((arr[i] < currmin) && (arr[i] > lowerbound)){
				currmin = arr[i];
			}
		}
	}
	return currmin;
}
int arrMid(int * arr, int sz){
	int min = arrMin(arr,sz,MIN);
	int max = arrMax(arr,sz,MAX);
	double med = ((min+(max-min+1))/2.0);
	int ret = abs(med-min)>abs(med-max) ? min : max;
	for(int i = 0 ; i < sz; i++){
		if(abs(med-(double)arr[i])<abs((double)ret-(double)arr[i])){
			ret = arr[i];
		}
	}
	return ret;
}
int main(){
	int a[] = {1,2,3,1,1,5,5,1,7,8};//123578
	// cout << arrMax(a,10,MAX);
	// cout << arrMax(a,10,arrMax(a,10,MAX));
	// cout << arrMax(a,10,arrMax(a,10,arrMax(a,10,MAX)));
	// cout << arrMin(a,10,MIN);
	// cout << arrMin(a,10,arrMin(a,10,MIN));
	cout << arrMid(a,10);
	return 0;
}