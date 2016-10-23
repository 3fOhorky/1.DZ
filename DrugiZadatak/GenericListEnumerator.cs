using System;
using System.Collections;
using System.Collections.Generic;

namespace DrugiITreciZadatak
{
    internal class GenericListEnumerator<X> : IEnumerator<X>
    {
        private GenericList<X> genericList;
        private int _current = -1;

        public GenericListEnumerator(GenericList<X> genericList)
        {
            this.genericList = genericList;
        }

        public X Current
        {
            get
            {
                try { 
                    return this.genericList.GetElement(this._current);
                }
                catch (IndexOutOfRangeException)
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose()
        {
            this.genericList.Clear();
        }

        public bool MoveNext()
        {
            this._current++;
            return (this._current < this.genericList.Count);
        }

        public void Reset()
        {
            this._current = -1;
        }
    }
}