/*
 Collection classes are specialized classes for data storage and retrieval.
 Collection classes serve various purposes, such as allocating memory dynamically to elements and accessing a list of items 
 on the basis of an index etc. These classes create collections of objects of the Object class, which is the base class for all data types in C#.
 Bangla te ashi, Collections holo C# er kichu special Data Stuctures.
 Collections 2 or 3 vage vag kora jay :
 1. Non-generic collection: era dinamic sizing allow kore but type-safe na
     Example: 	ArrayList,   Hashtable,    SortedList,    Stack,    Queue,    *BitArray.
 2. Generic collection: era dinamic sizing allow kore and type-safe
     Example: List<T>,   Dictionary<TKey,TValue>,   SortedList<TKey,TValue>,   Stack<T>,   Queue<T>,   *HashSet<T>,   *LinkedList<T>
 3. Concurrent collection: era threads safe
     Example:
----------------------------------------------------
Non-generic                               Generic
 ArrayList        ----------->        List <T>
 HashTable      ----------->        Dictionary <T>
 SortedList      ----------->        SortedList <T>
 Stack               ----------->         Stack <T>
 Queue              ----------->        Queue <T>
Note: * has no vice versa
--------------------------------------------------
*/
using System;
using System.Collections;

namespace Collection
    {
    class Db_NonGenericCollection
        {
        static void Main(string[] args)
            {
            Console.WriteLine("Non Generic Collections");
            Console.WriteLine("-----------------------------");

            /*
            Array kichu drawback jetar jonno ashole bivinno collections (data structure) asheche
            -resize impossible
            -middle theke kono element delete/remove kora jay na
            -middle e kono element insert/add kora jay na
            */
            /*
            int[] array = new int[3]; // int a;
            array[0] = 1; array[1] = 2; array[2] = 3;
            //array[3] = 4;//runtime exception asbe
           
            ///[Manual Resizing] creating a new array with a bigger size and copying old array's value and giving new values then
            int[] array1 = new int[5];
            array1[0] = array[0]; array1[1] = array[1]; array1[2] = array[2]; array1[3] = 4; array1[4] = 5;
            ///[Using Resize Resizing]
            Array.Resize(ref array, 5);
            array[3] = 4; array[4] = 5;//runtime exception asbe na 
           // array[0] ; array[1] ; array[2];
            */


            /*
             ///1. ArrayList
             ArrayList stores objects of any type like an array. "type-safe na" meaning holo jekono dhononer type e contain kore
            -It uses index to access the elements
            -Need not specify the size, it resizes automatically
            -Add and remove items from a list at a specified position using an index and the array resizes itself automatically. 
            -Allows dynamic memory allocation, adding, searching and sorting items in the list.
            NOTE: 1. Add() chara index create hoy na
            */

            /*
            ArrayList arrayList = new ArrayList(2); // arraylist with no elements 
            //ArrayList arrayList = new ArrayList(4) {1,'A',"jitu",true}; // arraylist with initialized elements
            Console.WriteLine("Capacity of arrayList : {0} ", arrayList.Capacity);
            Console.WriteLine("Count : arrayList {0}", arrayList.Count);
            //arrayList[0] = 0; //Note:1 // Runtime exception ashbe "Index was out of range"
            arrayList.Add(1);
            Console.WriteLine(arrayList[0]);
            arrayList[0] = 0;
            Console.WriteLine(arrayList[0]);
            arrayList.Add("kutta");
            Console.WriteLine(arrayList[1]);
            arrayList[1] = 1;
            Console.WriteLine(arrayList[1]);
            */

           // arrayList[1] = 0;
            /*
            Console.WriteLine(arrayList[1]);
            Console.WriteLine("Capacity of arrayList : {0} ", arrayList.Capacity);
            Console.WriteLine("Count : arrayList {0}", arrayList.Count);
            arrayList.Add("hudai");
            Console.WriteLine("Capacity of arrayList : {0} ", arrayList.Capacity);
            Console.WriteLine("Count : arrayList {0}", arrayList.Count);
            arrayList.Add(1); arrayList.Add(2); arrayList.Add(3); arrayList.Add(4); arrayList.Add(4);
            Console.WriteLine("Capacity of arrayList : {0} ", arrayList.Capacity);
            //Console.WriteLine("Count : arrayList {0}", arrayList.Count);
            
            Console.WriteLine("Initial values of arrayList");
            for (int i = 0; i < arrayList.Count; i++)
                {
                Console.Write(arrayList[i]+" "); 
                }Console.WriteLine();
            ///Capacity : koto memory se nilo | Count : kotota element ache
            //Console.WriteLine("Capacity of arrayList : {0} ", arrayList.Capacity);
            //Console.WriteLine("Count : arrayList {0}", arrayList.Count);
            
            /*
            //arrayList.Sort();
            arrayList.Add(12); //adding 12 
            arrayList.Insert(4, 'Y'); //inserting 'Y' at 5 index
            Console.WriteLine("Values of arrayList after adding '12' at the end and inserting 'Y' at index 5");
            for (int i = 0; i < arrayList.Count; i++)
                {
                Console.Write(arrayList[i]+" ");
                }Console.WriteLine();
            
            Console.WriteLine("After removing 'A' and removing at index 3");
            arrayList.Remove('Y');//removing 'A'
            arrayList.RemoveAt(3); //removing index 3
            for (int i = 0; i < arrayList.Count; i++)
                {
                Console.Write(arrayList[i]+" ");
                }Console.WriteLine();

            ///akta array list e onno akta array list insert kora  
            ArrayList arrayList1 = new ArrayList();//{6,7,8};//creating new arraylist
            //arrayList1.Add(103); arrayList1.Add(101); arrayList1.Add(102); arrayList1.Add(104);
            Console.WriteLine("Initial values of arrayList1");
            for (int i = 0; i < arrayList1.Count; i++)
                {
                Console.Write(arrayList1[i]+" ");
                }Console.WriteLine();
            //ArrayList coOfArr = new ArrayList(arrayList);
            arrayList.InsertRange(1, arrayList1);
            Console.WriteLine("Values of arrayList after inserting arrayList1 at index 1");
            for (int i = 0; i < arrayList.Count; i++)
                {
                Console.Write(arrayList[i]+" ");
                }Console.WriteLine(); 

            ///arrayList.Sort(); //akta runtime exception asbe  
            Console.WriteLine("Values of arrayList after sorting ascending order");
            arrayList1.Sort(); //Sort() ata acending sort
            for (int i = 0; i < arrayList1.Count; i++)
                {
                Console.Write(arrayList1[i]+" ");
                }Console.WriteLine(); Console.WriteLine();
            */


            /*
            ///2. Hashtable
            -It uses a key(user defined index) to access the elements
            -Each item in the hash table has (key, value)
            -The order of the Hashtable is jumble hence it is uses hashcode
            NOTE : 1. ArrayList ar Hashtable er moddhe tofat holo user defined index other are same as ArrayList
                          2. Add() charaw normal arrayr moto index create hoy
            */

            /*
            //Hashtable hashtable = new Hashtable(){{"id",1702028},{"name1","Jitu"},{"email1","amkhan@gmail.com"}};
            Hashtable hashtable = new Hashtable();
            hashtable["id1"] = 1702028; //Note:2
            hashtable["name1"] = "Jitu";
            hashtable["email1"] = "amkhan@gmail.com";
            //Console.WriteLine(hashtable["id1"].GetHashCode());
            //Console.WriteLine(hashtable["name1"].GetHashCode());
            //Console.WriteLine(hashtable["email1"].GetHashCode());
            //Console.WriteLine(hashtable["email1"]); 
            //hashtable.Add("id2", 28);
            //hashtable.Add("name2", "Eshita");
            //hashtable.Add("email2", "eshitakhan@hotmail.com");

            if (hashtable.ContainsValue("Jit"))
                {
                Console.WriteLine("This student name is already in the list");
                }
            else
                {
                hashtable.Add("email3", "Jit@gmail.com"); //need both Tect 1 & Tech 2 
                //hashtable.Add(9, "joti@gmail.com"); //need Tect 2
                }
            
           // Get a collection of the keys.
           ICollection key = hashtable.Keys;
            //object key = hashtable.Keys;
           ///Tect 1 : printing the value of hashtable  
           foreach (string k in key)
               {
               Console.WriteLine(k + ": " + hashtable[k]);
               }
          
           /*
            ///Tect 2 : printing the value of hashtable
            foreach (object k1 in hashtable.Keys) // Getting object of the keys.
                {
                Console.WriteLine(k1 + ": " + hashtable[k1]);
                }Console.WriteLine();
           */



            /*
            ///3. SortedList
            -It uses a key as well as an index to access the elements
            -SortedList is a combination of an ArrayList and a HashTable. 
            -It contains a list of items that can be accessed using a key or an index. 
            -If you access items using an index, it is an ArrayList, and if you access items using a key , it is a Hashtable. 
            -Elements are always sorted by the key value. 
             NOTE :  1. SortedList ar "Hashtable & ArrayList" er moddhe tofat holo key er value er opor base kore sorted way te store hoy
                            2. Add() charaw normal arrayr moto index create hoy as HashTable
                            3. value guli index onujayi access korte hole :  Console.WriteLine(sortedList1.GetByIndex(index)); index=0,1,2,...
                            4. value guli key onujayi access korte hole : Console.WriteLine(sortedList1[key]); key='a',"abc",1,2,... 
            */

             /*
             SortedList sortedList = new SortedList(4);
             sortedList["28"] = 1702028; //Note:2
             sortedList["name1"] = "Jitu";
             sortedList["email1"] = "amkhan@gmail.com";
             sortedList.Add("45", 45);
             sortedList.Add("name2", "Eshita");
             sortedList.Add("email2", "eshitakhan@hotmail.com");
             //Console.WriteLine(sortedList[0]);
             ICollection key3 = sortedList.Keys;
             string vals = "Values of sortedList";
             Console.WriteLine("Keys{0,29}",vals);
            ///print("%10d %d %d",1,8,9)/// 1           8 9
             foreach (object k3 in key3)
             Console.WriteLine("{0,-13}{1}",k3, sortedList[k3]);
             //Console.WriteLine(String.Format("{0}{1,10}", k3, sortedList[k3])); 
            */

            /*
            SortedList sortedList1 = new SortedList(4) { { 'a',102}, { 'c', 105 }, { 'b', 103 }, { 'd', "100" } };
            //Console.WriteLine(sortedList1.GetKey(103));// returns key index of the
            Console.WriteLine(sortedList1.GetByIndex(0));// returns the value of the index
            //Console.WriteLine(sortedList1.IndexOfKey(0));// returns the index of the key
            Console.WriteLine(sortedList1.IndexOfValue(102));// returns the index of the first occurance of the value
            //Console.WriteLine(sortedList1[0]);//ata exception asbe coz index[0] name kicchu nai
            */

            /*
            ///3. Stack
            -last-in, first out [LIFO] collection of object. Last er jon First e [Plate er stup]
            -adding is called in Stack "Push" the element and only adding process
            -removing is called in Stack "Pop" the element
            NOTE : 1. There is no SORT mechanism in Stack karon ata already sorted way te sojjito thake 
                          2. No value initialization ; //Stack stack = new Stack() { "1",2};
                          3. No access by index ; //Console.WriteLine(stack[0]);
            */

            /*
            //Stack stack = new Stack() { "1",2};
            Stack stack = new Stack();
            ///Pushing 4 elements in the stack
            stack.Push("Plate1");
            stack.Push("Plate2");
            stack.Push("Plate3");
            stack.Push("Plate4");
            //string s = "plate12";
            //Console.WriteLine(stack[0]);
            Console.WriteLine("Current stack: ");
            foreach (string s in stack) /// 
                {
                Console.Write(s + " ");
                }Console.WriteLine();

            ///top most element of the current stack
            Console.WriteLine("The Current poppable Element in stack: {0}", stack.Peek());

            Console.WriteLine("Pushing HalfPlate1, HalfPlate2");
            ///Pushing(adding) more 2 elements in the stack
            stack.Push("HalfPlate1");
            stack.Push("HalfPlate2");
            
            ///top most element of the current stack
            Console.WriteLine("The Current poppable Element in stack: {0}", stack.Peek());
            
            Console.WriteLine("Current stack: ");
            foreach (string s in stack)
                {
                Console.Write(s + " ");
                } Console.WriteLine();

            Console.WriteLine("Removing 3 Elements from the stack");
            ///Poping(removing) 3 elements from the stack
            stack.Pop();
            stack.Pop();
            stack.Pop();

            Console.WriteLine("Current stack: ");
            foreach (string s in stack)
                {
                Console.Write(s + " ");
                }Console.WriteLine(); Console.WriteLine();
           */

            /*
           ///4. Queue
           -first in, first out [FIFO] collection of object. First er jon First e [Bank e bill pay korar serial]
           -adding is called in Queue "Enqueue" the element only adding process
           -removing is called in Queue "Dequeue" the element
           NOTE : 1. There is no SORT mechanism in Queue karon ata already sorted way te sojjito thake 
                         2. No value initialization ; //Queue queue = new Queue(){1,"tt"};
                         3. No access by index ; //Console.WriteLine(queue[0]);
           */
            /*
            Queue queue = new Queue();

            ///Enqueuing 4 elements in the Queue
            queue.Enqueue("Serial1");
            queue.Enqueue("Serial2");
            queue.Enqueue("Serial3");
            queue.Enqueue("Serial4");

            Console.WriteLine("Current queue: ");
            foreach (string s in queue)
                {
                Console.Write(s + " ");
                }Console.WriteLine();

            ///top most element of the current queue
            Console.WriteLine("The Current Enqueueable Element in queue: {0}", queue.Peek());

            Console.WriteLine("Enqueuing Serial5, Serial6");
            ///Enqueuing (adding) more 2 elements in the queue
            queue.Enqueue("Serial5");
            queue.Enqueue("Serial6");

            ///top most element of the current queue
            Console.WriteLine("The Current Enqueueable Element in queue: {0}", queue.Peek());
            
            Console.WriteLine("Current queue: ");
            foreach (string s in queue)
                {
                Console.Write(s + " ");
                } Console.WriteLine();

            Console.Write("Removing 2 Elements from the queue : ");
            ///Dequeuing(removing) 2 elements from the queue
            queue.Dequeue();
            //string dest = (string)queue.Dequeue();
            queue.Dequeue();
            //string destt = (string)queue.Dequeue();
            //Console.WriteLine(dest+" "+destt);

            Console.WriteLine("Current queue: ");
            foreach (string s in queue)
                {
                Console.Write(s + " ");
                }Console.WriteLine();Console.WriteLine();
            */


            /*
            ///4. BitArray
            -it can store the bit(in true/false) representation of any number
            -it can directly store bit(in true/false)
            -adding a bit value is "Set(int index, bool value)"
            -normal arrayr moto index e element initialize kora jay without Set() or SetAll() 
            NOTE : bitwise operation like AND,OR,NOT,XOR can be implemented in BitArray
            Personal Experiance:
            1. BitArray byte and int typer data k array hesebe accept kore
            2. arrayr element guli k BitArray wise store kore
            3. BitArray size = (bits that needs to represent data type)*number of elements
            4. BitArray data representation: 
                 suppose: byte 4                                             suppose int 4, 2
                 index : 7   6   5   4   3   2   1   0                     15  14  13  12  11  10   9   8   7   6   5   4   3   2   1   0
                     4 ->  0   0   0   0   0   1   0   0                       0    0    0     0    0    0    1    0   0   0   0   0   0   1   0   0
                              -----------4------------                       --------------2--------------    ------------4-----------  
            */

            /*
           /// declared a bitArray of size 8
           BitArray bitArray = new BitArray(8);
            
            //8 ta index e false diye set korlam
            bitArray.SetAll(false);
            bitArray[0] = true;
            //index and element print korchi
            for (int i=0;i<bitArray.Count;i++)
                {
                    Console.WriteLine("Index :"+i+" "+bitArray[i]);
                }
            //Set korchi 0,1,2,3 = true 
            bitArray.Set(0,true);
            bitArray.Set(1,true);
            bitArray.Set(2,true);
            bitArray.Set(3,true);
            //0,1,2,3 = true Set korar print korchi 
            int j = 0;
            foreach (object o in bitArray) 
                    {
                    Console.WriteLine("Index :"+j+" "+bitArray[j]);j++;
                    }
            */

            /*
          //creating two  bit arrays of size 8 and 32
          BitArray ba1 = new BitArray(8);
          BitArray ba2 = new BitArray(32);

          byte[] a = {255,2};
          int[] b = { 13 };

          //storing the values 255,2 into BitArray ba1 and 13 into the BitArray ba2
          ba1 = new BitArray(a);
          ba2 = new BitArray(b);

          //content of ba1
          Console.WriteLine("Bit array ba1: "+a[0]+" "+ a[1]);

          for (int i = 0; i < ba1.Count; i++)
              {
              Console.Write("{0, -4} ", ba1[i]);
              }///00001000 00000100
          Console.WriteLine();

          for (int i = ba1.Count-1; i>= 0; i--)
              {
              Console.Write("{0, -4} ", ba1[i]);
              }///00001000 00000100
          Console.WriteLine();

          foreach(object ba in ba1)
              {
              Console.Write(ba+" ");
              }Console.WriteLine();

          ba2.Set(0, true);
          //content of ba2
          Console.WriteLine("Bit array ba2: "+ba2[0]);

          for (int i = 0; i < ba2.Count; i++)
              {
              Console.Write("{0, -4} ", ba2[i]);
              }Console.WriteLine();
          */
            /*
            BitArray ba3 = new BitArray(8);
            ba3 = ba1.And(ba2);

            //content of ba3
            Console.WriteLine("Bit array ba3 after AND operation: 12");

            for (int i = 0; i < ba3.Count; i++)
                {
                Console.Write("{0, -6} ", ba3[i]);
                }
            Console.WriteLine();
            ba3 = ba1.Or(ba2);

            //content of ba3
            Console.WriteLine("Bit array ba3 after OR operation: 61");

            for (int i = 0; i < ba3.Count; i++)
                {
                Console.Write("{0, -6} ", ba3[i]);
                }
            Console.WriteLine();

                */
            }
        }
    }
