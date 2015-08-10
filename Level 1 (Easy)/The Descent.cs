using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;


class Player
{
    static void Main(string[] args)
    {

        // game loop
        while (true)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int spaceX = int.Parse(inputs[0]);
            
            var maxH = 0; 
            var heightpos = 0; 
                var count = 0; 
                List<int> heights = new List<int>();  
                
           
            int spaceY = int.Parse(inputs[1]);
            for (int i = 0; i < 8; i++)
            {
                int mountainH = int.Parse(Console.ReadLine()); // represents the height of one mountain, from 9 to 0. Mountain heights are provided from left to right
                
                heights.Add(mountainH); 
            }   
             
                foreach (int h in heights)
                {
                    if(h > maxH)
                    {
                        maxH = h; 
                        heightpos = count; 
                      
                    }
                      count += 1;
                }
                   
                //   if (maxH > 1)
               if(spaceX == heightpos)
                   {
                      Console.WriteLine("FIRE");
                   }
                   
                   else
                   Console.WriteLine("HOLD");
        }
    }
}