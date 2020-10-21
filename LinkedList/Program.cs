using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList1 linkedList = new LinkedList1();
            linkedList.Append(56);
            linkedList.Append(70);
            linkedList.InsertAtGivenPosition(2, 30);
            linkedList.Display();
        }
    }
}
