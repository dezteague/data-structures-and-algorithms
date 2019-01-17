using System;
using LinkedList.Classes;
using ll_kth_from_end;

namespace ll_merge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LList listOne = new LList();
            LList listTwo = new LList();
        }

        public static LList LLMerge(LList llone, LList lltwo)
        {
            llone.Current = lltwo.Head;
            int counterOne = 0;

            //go through the length of llone, incrementing to add to total merge length
            while (llone.Current.Next != null)
            {
                llone.Current = llone.Current.Next;
                counterOne++;
            }

            lltwo.Current = lltwo.Head;
            int countertwo = 0;

            //repeat for second list, the length will be added to total for merge list
            while (lltwo.Current.Next != null)
            {
                lltwo.Current = lltwo.Current.Next;
                countertwo++;
            }

            //add two counters together to get the length of the merged list
            int mergedlistcounter = counterOne + countertwo;

            //go back to list one
            //start at the head
            llone.Current = llone.Head;
            //if the new merged counter is at least one
            while(mergedlistcounter > 1)
            {
                if (llone.Current.Next != null)
                {
                    //insert the value of list two after the list one head
                    llone.InsertAfter(llone.Head.Value, lltwo.Current.Value);
                    llone.Current = llone.Current.Next;
                }
                else
                {
                    llone.Current = lltwo.Current.Next;
                }
                //decrement the merged list counter
                mergedlistcounter--;
            }
            return llone;
        }
    }
}
