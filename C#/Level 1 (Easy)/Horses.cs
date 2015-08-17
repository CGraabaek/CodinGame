using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;


class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        List<int> horses = new List<int>();
        
        
        for (int i = 0; i < N; i++)
        {
        horses.Add(int.Parse(Console.ReadLine())); 
        }
        
        horses.Sort(); 
        var smallestDiff = horses[1] - horses[0];
        
      for(int i = 1; i < N; i++ )
      {
          var bigDiff = horses[i] - horses[i-1]; 
          if(bigDiff < smallestDiff)
          {
          smallestDiff = bigDiff;  
          }
      }
        
    Console.WriteLine(smallestDiff); 
    }
}

   