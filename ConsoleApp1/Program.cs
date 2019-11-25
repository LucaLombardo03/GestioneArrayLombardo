using LibreriaArray;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3];
            GestioneArray.FillArray(array);
            GestioneArray.StampaArray(array);
            Console.ReadLine();
        } 
    }
}

