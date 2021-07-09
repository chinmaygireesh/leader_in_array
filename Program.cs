using System;

namespace leader_in_an_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arr = new int[]  { 3,3,3};
            int i,j;
            bool flag;
            for(i=0;i<arr.Length;i++)
            {
                
                flag = true;//assuming as a leader
                for(j=i+1;j<arr.Length;j++)
                {
                    if(arr[j]>arr[i])
                    {
                        flag = false; //not a leader
                        break;
                    }
                    }
                if(flag)//still if it is leader
                {
                    
                    Console.Write($"{arr[i]} ");
                }    
                
            }
        }
    }
}
