using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugiITreciZadatak
{
    public class GenericList<X> : IGenericList<X>
    {
        private X[] _internalStorage;
        private int _currentSize = 4;
        private int _itemsCounter = 0;

        // ... Constructors ...
        public GenericList()
        {
            this._internalStorage = new X[this._currentSize];
        }

        public GenericList(int initialSize)
        {
            try
            {
                this._internalStorage = new X[initialSize];
            }
            catch
            {
                throw;
            }
            this._currentSize = initialSize;
        }

        // ... IGenericList implementation ...
        public int Count
        {
            get
            {
                return this._itemsCounter;
            }
        }

        public void Add(X item)
        {

            if (this._itemsCounter == this._currentSize)
            {
                this._currentSize *= 2;
                X[] tempList = this._internalStorage;
                this._internalStorage = new X[this._currentSize];
                Array.Copy(tempList, 0, this._internalStorage, 0, tempList.Length);
            }
            this._internalStorage[this._itemsCounter] = item;
            this._itemsCounter++;
        }

        public void Clear()
        {
            this._currentSize = 0;
            this._internalStorage = new X[this._currentSize];
            this._itemsCounter = 0;
        }

        public bool Contains(X item)
        {
            return this._internalStorage.Any(i => i.Equals(item));
        }

        public X GetElement(int index)
        {
            if (index < this._currentSize)
            {
                return this._internalStorage[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public int IndexOf(X item)
        {
            var index = 0;
            foreach (X i in this._internalStorage)
            {
                if (i.Equals(item))
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        public bool Remove(X item)
        {
            var index = this.IndexOf(item);
            return this.RemoveAt(index);
        }

        public bool RemoveAt(int index)
        {
            if (index >= this._currentSize - 1 || index == -1)
            {
                return false;
            }
            var tempList = this._internalStorage.ToList();
            tempList.RemoveAt(index);
            this._currentSize--;
            this._itemsCounter--;
            this._internalStorage = tempList.ToArray();
            return true;
        }

        public IEnumerator<X> GetEnumerator()
        {
            return new GenericListEnumerator<X>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
