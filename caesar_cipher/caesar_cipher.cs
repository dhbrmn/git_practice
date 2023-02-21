using System;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;

namespace ExquisiteCorpse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Encrypt or decrypt choice method
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
        }

        static void Encrypt() /*Encrypts the input*/

        {
           /*alphabet array*/
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            /*not allowed characters array*/
            char[] symbols = new char[] { '!', '?', '.', ',', ';', ':', '"', '#', '$', '%', '&', '/', '(', ')', '=', '*' };

            /*Message input*/
            Console.WriteLine("Input the message you want to encrypt: "); 
            string msgString = Console.ReadLine().ToLower();

            /*convert string to char array*/
            char[] msgArray = msgString.ToCharArray();
            /*create a new array the same size as the input message array*/
            char[] encryptedMsg = new char[msgString.Length];
            /*for loop*/
            for (int i = 0; i < msgString.Length; i++)
            {
                /*defines a new variable for a character in the new input message char array*/
                char a = msgArray[i];

                /*checks if the input char is a symbol or a letter*/
                bool isSymbol = Array.Exists(symbols, element => element == a);

                /*switch conditional to skip encryption of symbols*/
                switch (isSymbol)
                {
                    case true:
                    encryptedMsg[i] = a;
                        break;
                    case false:
                        int alphaIndex = Array.IndexOf(alphabet, a);
                        int encIndex = (alphaIndex + 3) % 26;
                        char encChar = alphabet[encIndex];
                        encryptedMsg[i] = encChar;
                        break;
                }
            }
            /*joins the encrypted array to a string and prints it out*/
            string encString = String.Join("", encryptedMsg);
            Console.WriteLine(encString);
        }

        static void Decrypt() /*Decrypts the input*/
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] symbols = new char[] { '!', '?', '.', ',', ';', ':', '"', '#', '$', '%', '&', '/', '(', ')', '=', '*' };

        }
    }
}
