///Being human is given, but keeping our humanity is a choice.
/*
 ----------------------------------------------------
Non-generic                             Generic
 ArrayList       ---------- >          List <T>
 HashTable    ----------->          Dictionary <T>
 SortedList    ----------->          SortedList <T> 
 Stack              ----------->         Stack <T>
 Queue            ----------->         Queue <T>
--------------------------------------------------
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Collection
    {
    class Da_GenericCollection
        {
        public static void  Main()
            {
            Console.WriteLine("Generic Collections");
            Console.WriteLine("-------------------------");


            /*
            ///1. List <T>
            -List is the generic version of the ArrayList
            -data type must be defined at List
            -baki shob ArrayList motoi
           */
            /*
            List<int> list = new List<int>(2); // arraylist with no elements size = 2 
            //List<int> list = new List<int>(4) {1,2,3,4}; // arraylist with initialized elements
            //Console.WriteLine("Capacity of list : {0} ", list.Capacity);
            //Console.WriteLine("Count : list {0}", list.Count);
            
            list.Add(1);
            Console.WriteLine(list[0]);
            list[0] = 0;
            Console.WriteLine(list[0]);
            list.Add(22);
            Console.WriteLine(list[1]);
            list[1] = 0;
            Console.WriteLine(list[1]);
            Console.WriteLine("Capacity of list : {0} ", list.Capacity);
            Console.WriteLine("Count : list {0}", list.Count);
            list.Add(33);
            Console.WriteLine("Capacity of list : {0} ", list.Capacity);
            Console.WriteLine("Count : list {0}", list.Count);
            
            
            list.Add(12); list.Add(13); list.Add(15); list.Add(11); list.Add(10);
            //Console.WriteLine("Capacity of list : {0} ", list.Capacity);
            //Console.WriteLine("Count : list {0}", list.Count);
             
            Console.WriteLine("Initial values of arrayList");
            for (int i = 0; i < list.Count; i++)
                {
                Console.Write(list[i]+" "); 
                }Console.WriteLine();

            ///Capacity : koto memory se nilo | Count : kotota element ache
            Console.WriteLine("Capacity of list : {0} ", list.Capacity);
            Console.WriteLine("Count : list {0}", list.Count);

            Console.WriteLine("Initial values of arrayList after sorting ascending order");
            list.Sort();
            for (int i = 0; i < list.Count; i++)
                {
                Console.Write(list[i] + " ");
                }Console.WriteLine();
            
            
            //Binary Search
            object s = list.BinarySearch(9);
            var s1 =  list.BinarySearch(10);
            if(s.Equals(-1))
            Console.WriteLine("9 is not found on the list");
            if(s1>0)
            Console.WriteLine("10 found on the list at index : "+s1);

            //Contains (find the value)
            var c = list.Contains(9);
            var c1 = list.Contains(10);
            if (c==false)
                Console.WriteLine("9 is not found on the list");
            if (c1==true)
                Console.WriteLine("10 found on the list");
            
            
            Console.WriteLine("Initial values of arrayList after reverse");
            list.Reverse();
            for (int i = 0; i < list.Count; i++)
                {
                Console.Write(list[i] + " ");
                }Console.WriteLine();

            
            list.Add(16); //adding 12 
            //list.Insert(14, 100); //an exception will be thrown "Index must be within the bounds"
            list.Insert(10, 100); //indics: [0,1,2,3,4,5,6,7,8,9,10,11,12]; inserting '100' at 10 index
            //why "list.Insert(10, 100)" exception throw kore na?? ans: je index e insert korbo oi index er ager index list e thakte hobe
            Console.WriteLine("Values of arrayList after adding '16' at the end and inserting '100' at index 10");
            for (int i = 0; i < list.Count; i++)
                {
                Console.Write(list[i]+" ");
                }Console.WriteLine();
            
            
            Console.WriteLine("After removing '100' and removing at index 3");
            list.Remove(100);//removing '100'
            list.RemoveAt(3); //removing index 3
            for (int i = 0; i < list.Count; i++)
                {
                Console.Write(list[i]+" ");
                }Console.WriteLine();
            

            
            ///akta list e onno akta list insert kora  
            List<int> list1 = new List<int>();//creating new arraylist
            list1.Add(103); list1.Add(101); list1.Add(102); list1.Add(104);
            Console.WriteLine("Initial values of list1");
            for (int i = 0; i < list1.Count; i++)
                {
                Console.Write(list1[i]+" ");
                }Console.WriteLine();

            list1.InsertRange(1, list);
            Console.WriteLine("Values of list1 after inserting list at index 1");
            for (int i = 0; i < list1.Count; i++)
                {
                Console.Write(list1[i]+" ");
                }Console.WriteLine(); 
            
            */

            /*
           ///2. Dictionary <TKey, TValue>
           -Dictionary <T> is the generic version of the HashTable
           -data type must be defined at Dictionary
           NOTE : 1. Dictionary <T> and List <T> er moddhe tofat holo user defined index other are same as List <T>
                         2. Add() charaw normal arrayr moto index create hoy
                         3. HashTable er moto ata akebare random data store kore na borong array te jevabe data store hoy onek ta sevabe
           */

            /*
            Dictionary<char, string> dictionary = new Dictionary<char, string>() { {'i', "1702028" },{ 'n', "Jitu" },{'e', "amkhan@gmail.com" } };
            //Dictionary <char,string> dictionary = new Dictionary <char,string>();
            dictionary['i'] = "1702028"; //Note:2
            dictionary['n'] = "Jitu";
            dictionary['e'] = "amkhan@gmail.com";
            dictionary.Add('j', "28");
            dictionary.Add('m', "Eshita");
            dictionary.Add('f', "eshitakhan@hotmail.com");
            
            if (dictionary.ContainsValue("Jit"))
                {
                Console.WriteLine("This student name is already in the list");
                }
            else
                {
                dictionary.Add('g', "joti@gmail.com"); //need both Tect 1 & Tech 2 
                //dictionary.Add(9, "joti@gmail.com"); //need Tect 2
                }
            
            // Get a collection of the keys.
            ICollection key = dictionary.Keys;
            ///Tect 1 : printing the value of hashtable  
            foreach (char k in key)
                {
                Console.WriteLine(k + ": " + dictionary[k]);
                }
           */
            /*
            ///Tect 2 : printing the value of hashtable
            foreach (object k1 in dictionary.Keys) // Getting object of the keys.
                {
                Console.WriteLine(k1 + ": " + dictionary[k1]);
                }Console.WriteLine();
           */


            /*
           ///3. SortedList <TKey, TValue>
           -SortedList <T> is the generic version of the SortedList
           -data type must be defined at SortedList <T>
           -baki shob SortedList er motoi
            NOTE :  1. SortedList ar "SortedList <T> & List<T>" er moddhe tofat holo key er value er opor base kore sorted way te store hoy
                           2. Add() charaw normal arrayr moto index create hoy as List<T>
                           3. value guli index onujayi access korte hole :  Console.WriteLine(sortedList1.GetByIndex(index)); index=0,1,2,...
                           4. value guli key onujayi access korte hole : Console.WriteLine(sortedList1[key]); key='a',"abc",1,2,... 
           */

            /*
            //SortedList<string, string> sortedList = new SortedList<string, string>(4) { { "id","1702028"}, { "name1", "Jitu" }, { "email1", "amkhan@gmail.com" } };
             SortedList<string,string> sortedList = new SortedList<string,string>(4);
             sortedList["id1"] = "1702028"; //Note:2
             sortedList["name1"] = "Jitu";
             sortedList["email1"] = "amkhan@gmail.com";
             sortedList.Add("id2", "28");
             sortedList.Add("name2", "Eshita");
             sortedList.Add("email2", "eshitakhan@hotmail.com");
             //Console.WriteLine(sortedList[0]);
             ICollection<string> key3 = sortedList.Keys;
             string vals = "Values of sortedList";
             Console.WriteLine("Keys{0,29}",vals);
             foreach (var k3 in key3)
             Console.WriteLine("{0,-13}{1}",k3, sortedList[k3]);
             //Console.WriteLine(String.Format("{0}{1,10}", k3, sortedList[k3])); 
            */


            /*
            SortedList <int,int> sortedList1 = new SortedList<int,int>(4) { { 0,102}, { 2, 105 }, { 5, 103 }, {1, 102 } };
            //Console.WriteLine(sortedList1.GetKey(103));// returns key index of the
            //Console.WriteLine(sortedList1.GetByIndex(0));// returns the value of the index
            //Console.WriteLine(sortedList1[3]);// returns the value of the key
            Console.WriteLine(sortedList1.IndexOfKey(5));// returns the index of the key
            Console.WriteLine(sortedList1.IndexOfValue(102));// returns the index of the first occurance of the value
            Console.WriteLine();
            */

            /*
            ///3. Stack <T>
            -Stack <T> is the generic version of the Stack
            -data type must be defined at Stack <T>
            -baki shob Stack er motoi:
            --ast-in, first out [LIFO] collection of object.Last er jon First e[Plate er stup]
            --adding is called in Stack <T> "Push" the element and only adding process
            --removing is called in Stack <T> "Pop" the element
            NOTE : 1. There is no SORT mechanism in Stack karon ata already sorted way te sojjito thake 
                          2. No value initialization ; //Stack <T> stack = new Stack<T>() { "1",2};
                          3. No access by index ; //Console.WriteLine(stack[0]);
            */

            /*
            //Stack <T> stack = new Stack <T> () { "1",2}; //not allowed; Note-2
            Stack <string> stack = new Stack <string> ();
            ///Pushing 4 elements in the stack
            stack.Push("Plate1");
            stack.Push("Plate2");
            stack.Push("Plate3");
            stack.Push("Plate4");
            //Console.WriteLine(stack[0]); //not allowed Note-3
            Console.WriteLine("Current stack: ");
            foreach (string s in stack)
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

            Console.WriteLine("Removing (Pop) 3 Elements from the stact");
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
           ///4. Queue <T>
           -Queue <T> is the generic version of the Queue
           -data type must be defined at Queue <T>
           -baki shob Queue er motoi:
           --first in, first out [FIFO] collection of object. First er jon First e [Bank e bill pay korar serial]
           --adding is called in Queue "Enqueue" the element only adding process
           --removing is called in Queue "Dequeue" the element
           NOTE : 1. There is no SORT mechanism in Queue karon ata already sorted way te sojjito thake 
                         2. No value initialization ; //Queue <T> queue = new Queue <T> (){1,"tt"};
                         3. No access by index ; //Console.WriteLine(queue[0]);
           */

            /*
            Queue <string> queue = new Queue <string> ();
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

            Console.Write("Removing 2 Elements from the queue ");
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
           /// 5. HashSet <T> 
            -HashSet <T> contains UNIQUE ELEMENT only other properties just List likewise
            -data type must be defined at HashSet <T>
            -some set operations are well defined here : Union,Intersect,Exceptwith(purokset),ProperSet etc.. 
            -baki shob List <T> er motoi:
            -- Add() charaw normal arrayr moto index create hoy as HashSet <T> ; //hashSet1[0] = 1.1; 
            --HashSet decalare korar somoy e initialize kora jay; HashSet<double> hashSet1  = new HashSet<double>() {1.1, 2.1, 3.1, 5.1, 3, 4.1};
           Note:  Lets, hashSet1 = {1,2,3}  hashSet2 = {1,2,4}
                        ///Union of hashSet1 and hashSet2
                        hashSet1.UnionWith(hashSet2);
                        Now,
                        hashSet1={1, 2, 3, 4}       |  dot wala ta merge hoye jabe 
                        hashSet2={1, 2, 4}            |  function er vitorer ta merge hoeb na
             */
            /*
            HashSet<double> hashSet1  = new HashSet<double>() {1.1, 2.1, 3.1, 5.1, 3, 4.1};
            HashSet<double> hashSet1duplicate1 = new HashSet<double>(hashSet1);
            HashSet<double> hashSet1duplicate2 = new HashSet<double>(hashSet1);
            hashSet1.Add(4.1);
            //hashSet1[0] = 1.1; 
            //duplicates are not added into collection.   
            Console.WriteLine("Unique Elements of HashSet1");
            foreach (var numbers in hashSet1)
                {
                Console.Write(numbers+", ");
                }Console.WriteLine();
         
            HashSet<double> hashSet2 = new HashSet<double>() { 1.1, 2.1, 6.2, 3, 9, 6.2, 7.2, 8.2 };
            Console.WriteLine("Unique Elements of HashSet2");
            foreach (var numbers in hashSet2)
                {
                Console.Write(numbers + ", ");
                }Console.WriteLine();

            ///Union of hashSet1 and hashSet2
            hashSet1.UnionWith(hashSet2);
            Console.WriteLine("Union of hashSet1 and hashSet2");
            foreach (var numbers in hashSet1)
                {
                Console.Write(numbers+", ");
                }Console.WriteLine();

            ///Intersection of hashSet1 and hashSet2
            hashSet1duplicate1.IntersectWith(hashSet2);
            Console.WriteLine("Intersection of hashSet1 and hashSet2");
            foreach (var numbers in hashSet1duplicate1)
                {
                Console.Write(numbers+", ");
                }Console.WriteLine();

            ///Intersection of hashSet1 and hashSet2
            hashSet1duplicate2.ExceptWith(hashSet2);
            Console.WriteLine("Except of hashSet1 to hashSet2");
            foreach (var numbers in hashSet1duplicate2)
                {
                Console.Write(numbers + ", ");
                }Console.WriteLine();
            
            ///hastSet1 er unique element guli sort korchi
            List<double> li = new List <double>(hashSet2);
            li.Sort();
            Console.WriteLine("Ascending order of hastSet2");
            for (int i =0; i < li.Count; i++)
                {
                Console.WriteLine("Index : "+i+" value : "+li[i]);
                }Console.WriteLine();
            */



            /*
            ///6. LinkedList
            The LinkedList<T> class allows insertion and deletion of elements from the list at a fast pace.
            C# LinkedList<T> class uses the concept of linked list. It allows us to insert and delete elements fastly.
            It can have duplicate elements.
           */
            /*
            LinkedList<string> linkedlist = new LinkedList<string>();
            linkedlist.AddLast("one"); // one
            linkedlist.AddLast("two"); // one two 
            var t = linkedlist.AddLast("three"); // one two three
            linkedlist.AddFirst("ten"); //ten one two three
            
            linkedlist.AddBefore(t, "five");
            linkedlist.AddAfter(t, "six");
            foreach (var v in linkedlist)
                Console.WriteLine(v);
            */
            }
        }
    }
