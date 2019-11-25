using System;

namespace LibreriaArray
{
    public class GestioneArray
    {
        public static void LeggiArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Inserisci l'elemento in posizione {i}:  ");
                int a = int.Parse(Console.ReadLine());
                array[i] = a;
            }
        }
        public static void StampaArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + " ");
            }
        }
        public static int[] CopiaArrayInt(int[] array)
        {
            int[] array2 = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i];
            }
            return array2;
        }
        public static bool RicercaArrayInt(int[] array, int elemento)
        {
            bool trovato = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == elemento)
                    trovato = true;
            }
            return trovato;
        }
        public static bool SonoUgualiInt(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length)
                return false;
            bool risposta = true;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                    risposta = false;
            }
            return risposta;
        }
        public static void LeggiArrayDouble(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Inserisci l'elemento in posizione {i}:  ");
                array[i] = double.Parse(Console.ReadLine());
            }
        }
        public static void StampaArrayDouble(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        public static double[] CopiaArrayDouble(double[] array)
        {
            double[] array2 = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i];
            }
            return array2;
        }
        public static bool RicercaArrayDouble(double[] array, double elemento)
        {
            bool trovato = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == elemento)
                    trovato = true;
            }
            return trovato;
        }
        public static bool SonoUgualiDouble(double[] array1, double[] array2)
        {
            if (array1.Length != array2.Length)
                return false;
            bool risposta = true;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                    risposta = false;
            }
            return risposta;
        }

        public static void LeggiArrayString(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Inserisci l'elemento in posizione {i}:  ");
                array[i] = Console.ReadLine();
            }
        }
        public static void StampaArrayString(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        public static string[] CopiaArrayString(string[] array)
        {
            string[] array2 = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i];
            }
            return array2;
        }
        public static bool RicercaArrayString(string[] array, string elemento)
        {
            bool trovato = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == elemento)
                    trovato = true;
            }
            return trovato;
        }
        public static bool SonoUgualiString(string[] array1, string[] array2)
        {
            if (array1.Length != array2.Length)
                return false;
            bool risposta = true;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                    risposta = false;
            }
            return risposta;
        }
        public static int CercaMax(int[] array)
        {
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }
        public static int CercaMin(int[] array)
        {
            int min = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }
            return min;
        }
        public static bool Crescente(int[] array)
        {
            bool risposta = true;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] <= array[i - 1])
                    risposta = false;
            }
            return risposta;
        }
        public static bool Decrescente(int[] array)
        {
            bool risposta = true;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] >= array[i - 1])
                    risposta = false;
            }
            return risposta;
        }
        public static int[] RandomNumberArray(int minValue, int maxValue, int size = 3)
        {
            if (minValue >= maxValue)
                return null;

            Random randomNumberGenerator = new Random();
            int[] numbers = new int[3];
            for (int i = 0; i < 3; i++)
                numbers[i] = randomNumberGenerator.Next(minValue, maxValue);
            return numbers;
        }
        public static void FillArray(int[] array)
        {
            Random randomNumberGenerator = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = randomNumberGenerator.Next();
        }
        public static int[] UnisciArray(int[] array, int[] array2, int[] array3)
        {
            
        }
    }
}
        