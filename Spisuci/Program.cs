using System;
using System.Collections.Generic;
using System.Linq;

namespace Spisuci
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "print")
                {
                    Console.WriteLine(string.Join(" ", nums));
                    break;
                }
                if (int.TryParse(input, out int n) == true)
                {
                    nums.Sort();
                    Console.WriteLine(string.Join(" ", nums));
                }

                string[] commands = input.Split();
                switch (commands[0])
                {
                    case "insert":
                        {
                            int index = int.Parse(commands[1]);
                            int element = int.Parse(commands[2]);

                            if (!nums.Contains(element))
                            {
                                nums.Insert(index, element);
                            }
                            break;
                        }
                    case "delete":
                        {
                            int indexToDelete = int.Parse(commands[1]);
                            if (indexToDelete < 0 || indexToDelete >= nums.Count)
                            {
                                Console.WriteLine("Element is in the list!");
                            }
                            else
                            {
                                nums.DeleteAt(indexToDelete);
                            }
                            break;
                        }
                    case "swap":
                        {
                            int firstElement = int.Parse(commands[1]);
                            int indexOfFirstElement = nums.IndexOf(firstElement);

                            int secondElement = int.Parse(commands[2]);
                            int indexOfSecondElement = nums.IndexOf(secondElement);

                            int temp = firstElement;
                            nums[indexOfFirstElement] = secondElement;
                            nums[indexOfSecondElement] = temp;
                            break;
                        }
                    case "statistic":
                        {
                            Console.WriteLine(nums.Average());
                            Console.WriteLine(nums.Count);
                            break;
                        }
                }
            }
        }
    }
}
                
            
        
   

