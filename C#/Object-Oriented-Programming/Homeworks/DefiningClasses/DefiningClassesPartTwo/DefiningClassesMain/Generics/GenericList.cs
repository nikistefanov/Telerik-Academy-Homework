namespace GenericSpace
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    //Problem 5. Generic class
    //Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
    //Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
    //Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, clearing the list, finding element by its value and ToString().
    //Check all input parameters to avoid accessing elements at invalid positions.
    public class GenericList<T> 
        where T : IComparable
    {
        private const int FIRST_CAPACITY = 16;

        private T[] elements;
        private int index;
        private int capacity;


        public GenericList(int capacity)
        {
            this.capacity = capacity;
            this.elements = new T[capacity];
            this.index = 0;
        }

        public GenericList()
        {
            this.Capacity = capacity;
            this.elements = new T[FIRST_CAPACITY];
            this.index = 0;
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            private set
            {
                this.capacity = value;
            }
        }

        public void Add(T element)
        {
            if (this.index == this.elements.Length)
            {
                AutoGrow();
            }
            this.elements[this.index] = element;
            this.index++;
        }

        public int IndexOf(T element)
        {
            if (this.index == 0)
            {
                throw new ArgumentException("This list is empty!");
            }

            int index = 0;
            for (int i = 0; i < this.index; i++)
            {
                if (elements[i].Equals(element))
                {
                    index = i;
                }
            }
            return index;
        }

        public void RemoveAt(int index)
        {
            CheckInputedIndex(index);

            T[] newElements = new T[this.index - 1];

            for (int i = 0; i < index; i++)
            {
                newElements[i] = elements[i];
            }
            for (int i = index + 1; i < this.index; i++)
            {
                newElements[i - 1] = elements[i];
            }

            elements = new T[this.index];
            this.index--;

            for (int i = 0; i < this.index; i++)
            {
                elements[i] = newElements[i];
            }
        }

        public void InsertAt(int index, T element)
        {
            CheckInputedIndex(index);

            if (this.index >= this.capacity)
            {
                AutoGrow();
            }
            this.index++;

            T[] newElements = new T[this.index + 1];

            for (int i = 0; i < this.index + 1; i++)
            {
                if (i == index)
                {
                    newElements[i] = element;
                }
                else if (i < index)
                {
                    newElements[i] = elements[i];
                }
                else if (i > index)
                {
                    newElements[i] = elements[i - 1];
                }
            }
            elements = new T[this.index + 1];
            for (int i = 0; i < this.index; i++)
            {
                elements[i] = newElements[i];
            }
        }

        public void Clear()
        {
            this.elements = new T[FIRST_CAPACITY];
            this.index = 0;
        }


        //Problem 6. Auto-grow
        //Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.
        private void AutoGrow()
        {
            int newCapacity = this.elements.Length * 2;
            T[] newElements = new T[newCapacity];

            for (int i = 0; i < index; i++)
            {
                newElements[i] = this.elements[i];
            }

            this.elements = newElements;
            this.Capacity = Capacity * 2;
        }

        //Problem 7. Min and Max
        //Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the GenericList<T>.
        //You may need to add a generic constraints for the type T.
        public T Min()
        {
            T min = this.elements[0];
            for (int i = 0; i < this.index; i++)
            {
                if (min.CompareTo(elements[i]) >= 0)
                {
                    min = elements[i];
                }
            }
            return min;
        }

        public T Max()
        {
            T max = this.elements[0];
            for (int i = 0; i < this.index; i++)
            {
                if (max.CompareTo(elements[i]) <= 0)
                {
                    max = elements[i];
                }
            }
            return max;
        }
        private void CheckInputedIndex(int index)
        {
            if (this.index == 0)
            {
                throw new ArgumentException("This list is empty!");
            }

            if (index >= this.index || index < 0)
            {
                throw new IndexOutOfRangeException("Index was out of range");
            }
        }

        public override string ToString()
        {

            StringBuilder listToString = new StringBuilder();
            for (int i = 0; i < this.index; i++)
            {
                listToString.Append(elements[i]);
                if (i < this.index - 1)
                {
                    listToString.Append(", ");
                }
            }
            return listToString.ToString();
        }
    }
}
