using System;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;

namespace ExquisiteCorpse
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] symbols = new char[] { '!', '?', '.', ',', ';', ':', '"', '#', '$', '%', '&', '/', '(', ')', '=', '*' }


            Console.WriteLine("Do you wish to encrypt or decrypt a message?");
            string optionChoose = Console.ReadLine().ToLower();

            if (optionChoose == "encrypt")
            {
                Encrypt();
            }
            else if (optionChoose == "decrypt")
            {
                Decrypt();
            }
            /* --- Moved into a method --- will delete later
            Console.WriteLine("Input the secret message: ");, 
            string msgString = Console.ReadLine().ToLower();

            char[] msgArray = msgString.ToCharArray();

            char[] ecnryptedMsg = new char[msgString.Length];

            for (int i = 0; i < msgString.Length; i++)
            {
                char a = msgArray[i];
                int alphaInx = Array.IndexOf(alphabet, a);
                alphaInx = (alphaInx + 3) % 26;
                char encChar = alphabet[alphaInx];
                ecnryptedMsg[i] = encChar;
            }

            string encString = String.Join("", ecnryptedMsg);
            Console.WriteLine(encString);
            */
        }

        static void Encrypt(string a)
        {
            Console.WriteLine("Input the secret message: ");, 
            string msgString = Console.ReadLine().ToLower();

            char[] msgArray = msgString.ToCharArray();

            char[] ecnryptedMsg = new char[msgString.Length];

            for (int i = 0; i < msgString.Length; i++)
            {
                char a = msgArray[i];
                int alphaInx = Array.IndexOf(alphabet, a);
                alphaInx = (alphaInx + 3) % 26;
                char encChar = alphabet[alphaInx];
                ecnryptedMsg[i] = encChar;
            }

            string encString = String.Join("", ecnryptedMsg);
            Console.WriteLine(encString);
        }

        static void Decrypt(string a)
        {

        }
    }
}
