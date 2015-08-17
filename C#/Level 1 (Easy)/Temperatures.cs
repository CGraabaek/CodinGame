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
        int N = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        string TEMPS = Console.ReadLine(); // the N temperatures expressed as integers ranging from -273 to 5526
        string[] values = TEMPS.Split(' '); // Seperates the values from each other
        int closestTemp = int.Parse(values[0]);

       if(N == 0)
        {
          Console.WriteLine("0");
          return;
        }
      
      foreach (string v in values)
      {
          int temporaryValue = int.Parse(v);
          
          if (temporaryValue > 0){
              closestTemp = (temporaryValue > closestTemp) && (temporaryValue > (closestTemp * -1)) ? closestTemp : temporaryValue;
          }
          else if(temporaryValue < 0){
              closestTemp = temporaryValue < closestTemp ? closestTemp : temporaryValue;
          }
          else{
              Console.WriteLine(0);
          }
      }
       Console.WriteLine(closestTemp);
    }
}