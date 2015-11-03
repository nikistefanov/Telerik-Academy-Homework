#include <iostream>

using namespace std;

struct 
{
	int data;
	node * next;
};

class IntADT
{
public:
	IntADT();
	virtual void push(int data);
	virtual int pop();

private:
	int size;
	node * first;
};

IntADT::IntADT()
{
	first = NULL;
	size = 0;
}

void IntADT::push(int data)
{
	node * temp = new node;
	temp->next = first;
	temp->data = data;
	size++;
	first = temp;
}

int IntADT::pop()
{
	node * temp = first;
	int result = temp->data;
	first = temp->next;
	delete temp;
	size--;
	return result;
}

int main()
{
	IntADT linkedList;

	for (int i = 0; i < 10; i++)
	{
		linkedList.push(i);
	}

	cout << linkedList.pop();

	return 0;
}