using System;
using System.Collections;
using System.Collections.Generic;

class HandGenerator
{
    static IEnumerable<int> DoubleValues(IEnumerable<int> enumerable)
    {
        // For each value in enumerable, return a value that is twice that amount
        return new DoubleEnumerable(enumerable);
    }

    class DoubleEnumerable: IEnumerable<int>
    {
        IEnumerable<int> enumerable;
        internal DoubleEnumerable(IEnumerable<int> enumerable)
        {
            this.enumerable = enumerable;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new DoubleEnumerator(enumerable.GetEnumerator());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class DoubleEnumerator: IEnumerator<int>
    {
        IEnumerator<int> enumerator;
        int current;

        internal DoubleEnumerator(IEnumerator<int> enumerator)
        {
            this.enumerator = enumerator;
        }

        public int Current
        {
            get { return current; }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            if (enumerator.MoveNext())
            {
                current = enumerator.Current * 2;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

    }
}
