{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int lightX = int.Parse(inputs[0]); // the X position of the light of power
        int lightY = int.Parse(inputs[1]); // the Y position of the light of power
        int initialTX = int.Parse(inputs[2]); // Thor's starting X position
        int initialTY = int.Parse(inputs[3]); // Thor's starting Y position

        var thorX = initialTX; 
        var thorY = initialTY; 
        
        // game loop
        while (true)
        {
            int remainingTurns = int.Parse(Console.ReadLine());
        
            string directionX = ""; 
            string directionY=  ""; 
            
            if (thorY < lightY)
            {
            thorY++;
            directionY = "S";
            }
            
            else if( thorY > lightY)
             {
                thorY--;
                 directionY = "N"; 
             }
            
            
            if (thorX < lightX)
            {
                     thorX++;
                     directionX = "E"; 
                     
            }
            
            else if(thorX > lightX)
            {
                thorX--;
                directionX = "W";
               
            }
          
           Console.WriteLine(directionY+directionX);
           
        }
    }
}