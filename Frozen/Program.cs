using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {
        public static object StringSplitOptions { get; private set; }

        class SecretSanta 
        {
            string name;
            string gift;

            public SecretSanta(string _name, string _gift)
            {
                name = _name;
                gift = _gift;
            }
            public string Name 
            { 
                get { return name; }
            }
            public string Gift
            {
                get { return gift; }
            }
        }
        static void Main(string[] args)
        {
            List<SecretSanta> mySecretsanta = new List<SecretSanta>();
            string[] secretsantaFromFile = GetDataFromFile();

            foreach (string line in secretsantaFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' });
                SecretSanta newSecretSanta = new SecretSanta(tempArray[0], tempArray[1]);
                mySecretsanta.Add(newSecretSanta);
            }
            foreach(SecretSanta secretsantaFromList in mySecretsanta) 
            {
                Console.WriteLine($"{secretsantaFromList.Name} wants {secretsantaFromList.Gift} for Christmas!");
            }
        }
        public static void DisplayElementsFromArray(string[] someArray) 
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"tring from array: {element}");
            }
        }
        public static string[] GetDataFromFile() 
        {
            string filePath = @"C:\Users\...\samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);
            return dataFromFile;
        }
    }
}
