namespace PrebitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class BitArray : IEnumerable
    {
        private ulong value;

        public BitArray(ulong value)
        {
            this.value = value;
        }

        public ulong this[int index]
        {
            get
            {
                return (this.value >> index) & 1;
            }
            set
            {
                if (index < 0 || index >= 64)
                {
                    throw new IndexOutOfRangeException("Invalid position.");
                }

                if (value < 0 || value > 1)
                {
                    throw new ArgumentException("Invalid bit value.");
                }

                if (((this.value >> index) & 1) != value)
                {
                    this.value ^= (1u << index);
                }
            }
        }

        public override bool Equals(object obj)
        {
            for (int i = 0; i < 64; i++)
            {
                if (((this.value >> i) & 1) !=
                     ((((obj as BitArray).value >> i)) & 1))
                {
                    return false;
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            return this.value.GetHashCode();
        }

        public static bool operator ==(BitArray first, BitArray second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(BitArray first, BitArray second)
        {
            return first.Equals(second);
        }

        public override string ToString()
        {
            StringBuilder printer = new StringBuilder();
            for (int i = 63; i >= 0; i--)
            {
                printer.Append((value >> i) & 1);
            }

            return printer.ToString();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int pos = 0; pos < 64; pos++)
            {
                yield return (int)this[pos];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
