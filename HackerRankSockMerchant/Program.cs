using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSockMerchant
{
    class Program
    {
        static void Main(string[] args)
        {
            string socksInput;
            string arrayInput;
            int numberOfSocks=0; //length of array
         

            // user inputs length of array
            Console.WriteLine("Number of socks");
            socksInput = Console.ReadLine();
            numberOfSocks = Convert.ToInt32(socksInput);//covert to integer

            int[] socks = new int[numberOfSocks];//new array

            //user fills the array
            for (int i = 0; i < socks.Length; i++)
            {
                Console.WriteLine("input for sock number " + (i+1));
                arrayInput=Console.ReadLine();
                socks[i] = Convert.ToInt32(arrayInput);
            }


        }
    }
}
