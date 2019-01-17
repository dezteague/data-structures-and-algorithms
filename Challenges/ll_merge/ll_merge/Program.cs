using System;
using LinkedList.Classes;
using ll_kth_from_end;

namespace ll_merge
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LList listOne = new LList();
            listOne.Insert(1);
            listOne.Insert(2);
            listOne.Insert(3);
            LList listTwo = new LList();
            listTwo.Insert(4);
            listTwo.Insert(5);
            listTwo.Insert(6);
     
            Console.ReadLine();
        }

        public static LList LLMerge(LList llone, LList lltwo)
        {
            Node lloneCurrent = null;
            Node lltwoCurrent = null;

            if (llone.Head != null)
            {
                lloneCurrent = llone.Head;
            }
            else
            {
                return lltwo;
            }

            if (lltwo.Head != null)
            {
                lltwoCurrent = lltwo.Head;
            }
            else
            {
                return llone;
            }

           
            Node lloneNext = lloneCurrent.Next;
            Node lltwoNext = lltwoCurrent.Next;

            while(llone.Current != null && lltwo.Current != null)
            {
                lloneCurrent.Next = lltwoCurrent;
                lltwoCurrent.Next = lloneNext;

                lloneCurrent = lloneNext;
                lltwoCurrent = lltwoNext;

                lloneNext = lloneCurrent.Next;
                lltwoNext = lltwoCurrent.Next;
            }

            return llone; 
        }
    }
}
