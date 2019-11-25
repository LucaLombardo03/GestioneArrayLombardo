using System;
using LibreriaArray;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int [3];
            GestioneArray.FillArray(array);
            GestioneArray.StampaArray(array);
            Console.ReadLine();
        }
    }
}