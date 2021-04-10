/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2020-2021 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: OOP Project 1.2
**				ÖĞRENCİ ADI............: Caner Kaymakçı
**				ÖĞRENCİ NUMARASI.......: B191210095
**                         DERSİN ALINDIĞI GRUP...: Group D
****************************************************************************/

using System;
using System.Collections.Generic;
using System.Threading;

namespace OOP_Work_2
{
    class Program
    {
        //Method without Substring method.
        static void indexWithoutSubstr()
        {
            Console.WriteLine("Please enter a sentence..: ");
            string entry = Console.ReadLine().ToLower();    //We takes an entry variable.

            Console.WriteLine("\nPlease enter a word to find (must enter whole word. Can't find just part of a word including punctuations)..: ");
            string find = Console.ReadLine().ToLower() + ' ';   //We takes a variable to find.

            int index = 0 - find.Length, count = 0; //Index and counter variables.

            //Finds a string in a sentence from the first index.
            do
            {
                index = entry.IndexOf(find, index + find.Length);

                //If there isn't any string to find, program will be stopped.
                if (index == -1) break;

                count++;

                Console.WriteLine("Word " + find + " is in index " + index + ".");

            } while (index != -1);

            Console.WriteLine("\nWord "+find+" had been used "+count+" times.");
        }

        //Method with Substring method.
        static void indexWithSubstr()
        {
            Console.WriteLine("Please enter a sentence..: ");
            string entry=Console.ReadLine().ToLower();      //We takes an entry variable.

            Console.WriteLine("\nPlease enter a word to find..: ");
            string find = Console.ReadLine().ToLower();     //We takes a variable to find.

            string tempString;      //Used temporary string variable
            int count = 0;

            //Finds a string in a sentence from the first index.
            for (int index = 0; index < entry.Length; index++)
            {
                //If there is any word that starts with the same letter with find variable, program will check if word is correct. 
                if (entry[index] == find[0])
                {
                    tempString = entry.Substring(index, find.Length);
                    //If word is correct, we will get index of the word.
                    if (tempString == find)
                    {
                        count++;
                        Console.WriteLine("Word " + find + " is in index " + index + ".");
                    }
                    else continue;
                }
                else continue;
            }
            Console.WriteLine("\nWord " + find + " had been used " + count + " times.");
        }

        //Method to find all letters.
        static void findHowMany()
        {
            Console.WriteLine("Enter the sentence..: ");

            string entry = Console.ReadLine().ToLower();    //We takes an entry variable.

            //Used Lists to avoid keeping useless letters.
            var Letters = new List<char>();
            var Count = new List<int>();

            int index;
            string alphabet = "abcçdefgğhıijklmnoöpqrsştuüvwxyz";

            //Checks letters of the whole sentence.
            foreach (var character in entry)
            {
                //If program find a letter for the first time, Letter will be added to list.
                //If not, Program will increase count of that letter.
                if (Letters.Contains(character) == false)
                {
                    Letters.Add(character);
                    Count.Add(1);
                }
                else
                {
                    index = Letters.IndexOf(character);
                    Count[index]++;
                }
            }

            //A loop for write usages in an order.
            foreach (var character in alphabet)
            {
                //If a letter is used, Program will write it with symbols.
                //If not, Program will write that letter had been used 0 times.
                if (Letters.Contains(character))
                {
                    index = Letters.IndexOf(character);
                    Console.Write("The letter " + Letters[index] + " had been used " + Count[index] + " times. ");
                    for (int j = 0; j < Count[index]; j++) Console.Write("*");
                    Console.WriteLine();
                    continue;
                }
                else
                {
                    Console.WriteLine("The letter " + character + " had been used 0 times.");
                    continue;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to program. Pick a choice...\n");
            string pick;    //Pick variable.

            //We let user pick his/her choice.
            do
            {
                Console.WriteLine("1-) In a string variable, find a string without Substring method.");
                Console.WriteLine("2-) In a string variable, find a string with Substring method.");
                Console.WriteLine("3-) In a string variable, find all letters and find how many times be used.");
                pick = Console.ReadLine();

                //If the pick is incorrect, an error message will be shown.
                if (pick != "1" && pick != "2" && pick != "3")
                {
                    Console.WriteLine("Error. Try again.");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            } while (pick!="1"&&pick!="2"&&pick!="3");
            
            Console.Clear();

            //Picking a method here.
            switch (pick)
            {
                case "1":
                    indexWithoutSubstr();
                    break;
                case "2":
                    indexWithSubstr();
                    break;
                case "3":
                    findHowMany();
                    break;
            }
        }
    }
}
