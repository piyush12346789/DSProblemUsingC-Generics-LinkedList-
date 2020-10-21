using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList1 linkedList = new LinkedList1();
            linkedList.Append(70);
            linkedList.Append(30);
            linkedList.Append(56);
            linkedList.Display();
        }
    }
}
