using System;
using System.Collections.Generic;
using System.Linq;

namespace RechniciUpr2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> EmaiList = new Dictionary<string, string>();
            string[] input = Console.ReadLine().Split();

            while (true)
            
            if (input[0] == "Stop")
            {
                break;
            }

            if (input[0].ToLower() == "Add")
            {
                if (!EmaiList.ContainsKey(input[1]))
                {
                    EmaiList.Add(input[1], input[2]);
                }

                else
                {
                    EmaiList[input[1]] = input[2];
                }
            }
            if (input[1].ToLower() == "Sent")
            {
                if (EmaiList.ContainsKey(input[1]))
                {
                    Console.WriteLine($"{input[1]: (emailList[input[1])}");
                }
                else
                {
                    Console.WriteLine($"Contact {input[1]} does not exist");
                }
            }
            input = Console.ReadLine().Split();
        }        
    }
}

            
        
   


                

                
           

        
    

