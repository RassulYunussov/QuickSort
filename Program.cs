using System;
using System.Linq;

namespace QuickSort
{
    class Program
    {
    	static void QuickSort(int [] src)
    	{
			qs(0,src.Length-1);

			void swap(ref int lv,ref int rv)
			{
				int temp = lv;
				lv = rv;
				rv = temp;
			}
			int partition(int ll, int rr)
			{

				int i = ll, j = rr;
				int pivot = src[(ll + rr) / 2];
				while (i <= j) 
				{
						while (src[i] < pivot)
							i++;
						while (src[j] > pivot)
							j--;
						if (i <= j) {
							swap(ref src[i++],ref src[j--]);
						}
				}
				return i;
			}	
			
    		void qs(int left,int right)
    		{
				int index = partition(left,right);
				if(index<right)
					qs(index,right);
				if(left<index-1)
					qs(left,index-1);
				
    		}
    	}
        static void Main(string[] args)
        {
		   Random r = new Random();
           int [] a = Enumerable.Range(1,100).Select(x=>r.Next(1,100)).ToArray();
		   QuickSort(a);
		   //quickSort(a,0,a.Length-1);
		   bool sorted = true;
		   for (int i = 0; i < a.Length-1; i++)
		   {
			   if(a[i]>a[i+1])
			   {
				   sorted = false;
				   break;
			   }
		   }
		   System.Console.WriteLine(sorted);
        }
    }
}
