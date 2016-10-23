using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviZadatak
{
    public class IntegerList : IIntegerList
    {
        private int[] _internalStorage;
        private int _currentSize = 4;
        private int _itemsCounter = 0;

        // ... Constructors ...
        public IntegerList()
        {
            this._internalStorage = new int[_currentSize];
        }

        public IntegerList(int initialSize)
        {
            try { 
                this._internalStorage = new int[initialSize];
            }
            catch
            {
                throw;
            }
            this._currentSize = initialSize;
        }

        // ... IIntegerList implementation ...
        public int Count
        {
            get
            {
                return this._itemsCounter;
            }
        }

        public void Add(int item)
        {
            if (this._itemsCounter == this._currentSize)
            {
                this._currentSize *= 2;
                int[] tempList = this._internalStorage;
                this._internalStorage = new int[this._currentSize];
                Array.Copy(tempList, 0, this._internalStorage, 0, tempList.Length);
            }
            this._internalStorage[this._itemsCounter] = item;
            this._itemsCounter++;
        }

        public void Clear()
        {
            this._currentSize = 0;
            this._internalStorage = new int[_currentSize];
            this._itemsCounter = 0;
        }

        public bool Contains(int item)
        {
            return this._internalStorage.Any(i => i == item);
        }

        public int GetElement(int index)
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

        public int IndexOf(int item)
        {
            var index = 0;
            foreach (int i in this._internalStorage)
            {
                if (i == item)
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        public bool Remove(int item)
        {
            var index = this.IndexOf(item);
            return this.RemoveAt(index);
        }

        public bool RemoveAt(int index)
        {
            if (index >= _currentSize - 1 || index == -1)
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


        public void ListExample(IIntegerList listOfIntegers)
        {
            try
            {
                //IntegerList listOfIntegers = new IntegerList();
                listOfIntegers.Add(1); // [1]
                listOfIntegers.Add(2); // [1 ,2]
                listOfIntegers.Add(3); // [1 ,2 ,3]
                listOfIntegers.Add(4); // [1 ,2 ,3 ,4]
                listOfIntegers.Add(5); // [1 ,2 ,3 ,4 ,5]
                listOfIntegers.RemoveAt(0); // [2 ,3 ,4 ,5]
                listOfIntegers.Remove(5); // [2 ,3 ,4]
                Console.WriteLine(listOfIntegers.Count); // 3
                Console.WriteLine(listOfIntegers.Remove(100)); // false
                Console.WriteLine(listOfIntegers.RemoveAt(5)); // false
                listOfIntegers.Clear(); // []
                Console.WriteLine(listOfIntegers.Count); // 0
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greška: " + e.Message);
                Console.ReadLine();
            }
        }
    }
}
