using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {
        //StackNonGeneric();
        //Queue q = new Queue(4, 5);
        //q.Enqueue(34);
        //q.Enqueue(78.33f);//float
        //q.Enqueue(8788787.33d);//double
        //q.Enqueue(32332.444m);//decimal

        //int[] arr = new int[] { 11, 12, 13, 14, 15 };
        //ArrayListDemo();//100.988f,"Hello",'A',200
        SortedList sortedList = new SortedList();
        sortedList.Add(1, 100);
        sortedList.Add(13, 800);
        sortedList.Add(2, 200);
        sortedList.Add(3, 300);
        sortedList.Add(10, 700);
        sortedList.Add(4, 400);
        

        IDictionaryEnumerator ie=sortedList.GetEnumerator();
        while (ie.MoveNext()) 
        {
            Console.WriteLine(ie.Key  + " " + ie.Value);
        
        }


        Console.WriteLine("Hashtable......");
        Hashtable h=new Hashtable();
        h.Add(1, 100);//
        h.Add(13, 800);
        h.Add(2, 200);
        h.Add(3, 300);
        h.Add(10, 700);
        h.Add(4, 400);

         ie = h.GetEnumerator();
        while (ie.MoveNext())
        {
            Console.WriteLine(ie.Key + " " + ie.Value);

        }

        









        Console.ReadLine();
            }

    private static void ArrayListDemo()
    {
        Stack s = new Stack();
        s.Push(11);
        s.Push(100.988f);
        s.Push("Hello");
        s.Push('A');


        ArrayList a = new ArrayList(s);
        a.Add(100);
        a.Add(200);
        int[] array = new int[] { 6, 7, 89, 90, 91 };
        a.AddRange(array);//added end of the arraylist
        a.Insert(0, "First value");//single value
        a.InsertRange(1, array);//at the particular index insert multiple values

        a.RemoveRange(1, 6);//starting from particular index number of elements to remove


        Console.WriteLine("Original Arraylsit");
        foreach (var item in a)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
        int[] a1 = new int[] { 1000, 2000, 3000, 4000 };
        a.SetRange(0, a1);
        Console.WriteLine("After set range the arraylist is");
        foreach (var item in a)
        {
            Console.WriteLine(item);
        }

        ArrayList newlist = a.GetRange(0, 4);
        Console.WriteLine("Get range ");
        foreach (var item in newlist)
        {
            Console.WriteLine(item);
        }



        //Console.WriteLine("Ater rremoving 100");
        //a.Remove(100);
        //foreach (var item in a)
        //{
        //    Console.WriteLine(item);
        //}




        //Console.WriteLine("0 remove at");
        //a.RemoveAt(0);
        //foreach (var item in a)
        //{
        //    Console.WriteLine(item);
        //}
    }

    private static void StackNonGeneric()
    {
        Stack s = new Stack();
        s.Push(1);
        s.Push(2.33f);
        s.Push(new DateOnly(2024, 1, 17));
        s.Push(new TimeOnly(10, 10, 30));
        s.Push(new DateTime(2024, 2, 20, 4, 40, 10));

        //object o=s.Pop();

        object o1 = s.Peek();
        bool containsValue = s.Contains(10);//false
        containsValue = s.Contains(1);//true

        //  s.Clear();//remove all values from stack
        object[] obj = new object[10];
        obj[0] = 101;
        obj[1] = 102;
        s.CopyTo(obj, 2);
        Console.WriteLine("Using Copy to");
        foreach (var item in obj)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("================");

        object[] obj1ToArray = s.ToArray();
        Console.WriteLine("Using ToArray");
        foreach (var item in obj1ToArray)
        {
            Console.WriteLine(item);
        }
    }
}