using DrugiITreciZadatak;
using PrviZadatak;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Program : IntegerList
    {
        static void Main(string[] args)
        {
            //IntegerList listOfIntegers = new IntegerList();
            //listOfIntegers.ListExample(listOfIntegers);

            GenericList<string> stringList = new GenericList<string>();
            stringList.Add(" Hello ");
            stringList.Add(" World ");
            stringList.Add("!");
            foreach (string value in stringList)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();

            //try
            //{
            //    GenericList<double> genericList = new GenericList<double>();
            //    genericList.Add(1); // [1]
            //    genericList.Add(2); // [1 ,2]
            //    genericList.Add(3); // [1 ,2 ,3]
            //    genericList.Add(4); // [1 ,2 ,3 ,4]
            //    genericList.Add(5); // [1 ,2 ,3 ,4 ,5]
            //    genericList.RemoveAt(0); // [2 ,3 ,4 ,5]
            //    genericList.Remove(5); // [2 ,3 ,4]
            //    Console.WriteLine(genericList.Count); // 3
            //    Console.WriteLine(genericList.Remove(100)); // false
            //    Console.WriteLine(genericList.RemoveAt(5)); // false
            //    genericList.Clear(); // []
            //    Console.WriteLine(genericList.Count); // 0
            //    Console.ReadLine();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Greška: " + e.Message);
            //    Console.ReadLine();
            //}
        }

    }
}
