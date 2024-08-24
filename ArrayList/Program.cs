using System;
using System.Collections;

namespace Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring an array list undifined amount of objects
            ArrayList myArrayList = new ArrayList();
            //Declaring an array list with difined amount of objects
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(13.37);
            myArrayList.Add(13);
            myArrayList.Add(128);
            myArrayList.Add(25.3);
            myArrayList.Add(13);

            //This will remove specific entry in arraylist
            myArrayList.Remove(13);

            //Delete element at specific index(position)
            myArrayList.RemoveAt(0);

            Console.WriteLine(myArrayList.Count);

            double sum = 0;
            foreach (var item in myArrayList)
            {
                if(item is int)
                {
                    sum += Convert.ToDouble(item);
                }else if(item is double)
                {
                    sum += (double)item;
                }else if(item is string)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine(sum);

            
        }
    }
}