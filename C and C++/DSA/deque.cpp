#include <iostream>

using namespace std;

struct node
{
	int data;
	node * previous;
	node * next;
};

class myDeque
{
	public:
		Deq();
		int popFront();
		int popBack();
		void pushFront(int val);
		void pushBack(int val);
		bool isEmpty();
	private:
		node * head;
		node * tail;
		int size;
};

myDeque::myDeque()
{
	size = 0;
	head = NULL;
	tail = NULL;
}

void myDeque::pushFront(int value)
{
	node * temp = new node;
	temp->data = value;
	if (isEmpty())
	{
		this->head = temp;
		this->tail = temp;
		temp->previous = NULL;
		temp->next = NULL;
	}
	else
	{
		temp->previous = NULL;
		temp->next = head;
		head->previous = temp;
		head = temp;
	}

	size++;
}

void myDeque::pushBack(int value)
{
	node * temp = new node;
	temp->data = value;

	if(isEmpty())
	{
		this->head = temp;
		this->tail = temp;
		temp->previous = NULL;
		temp->next = NULL;
	}
	else
	{
		temp->next = NULL;
		tail->next = temp;
		temp->previous = tail;
		tail = temp;
	}

	size++;
}

bool myDeque::isEmpty()
{
	if(size == 0)
	{
		return true;
	}

	return false;
}

int myDeque::popFront()
{
	if(!isEmpty())
	{
		int result;

		result = head->data;
		node * temp = this->head;

		if(head->next != NULL)
		{
			head = head->next;
			head->previous = NULL;
		}
		else
		{
			head = NULL;
		}

		size--;
		delete temp;

		return result;
	}
}

int myDeque::popBack()
{
	if(!isEmpty())
	{
		int result;

		result = tail->data;
		node * temp = this->tail;

		if(tail->previous != NULL){
			tail = tail->previous;
			tail->next = NULL;
		}
		else
		{
			tail = NULL;
		}

		size--;
		delete temp;

		return result;
	}
}

int main()
{
	myDeque myDataStructure;

	myDataStructure.pushFront(53);
	myDataStructure.pushFront(7);
	myDataStructure.pushBack(16);

	return 0;
}