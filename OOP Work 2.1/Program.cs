using System;

namespace OOP_Work_2._1
{
    public class MyString
    {
        private string testString;

        public MyString(string entry)
        {
            testString = entry;
        }

        public int NumberOfElements(string x)
        {
            int Count = 0;
            foreach (var chars in x)Count++;
            return Count;
        }

        public int NumberOfElements()
        {
            int Count = 0;
            foreach (var chars in testString) Count++;
            return Count;
        }

        public string Merge(MyString string2)
        {
            string LastString = testString + string2.testString;
            return LastString;
        }

        public string Join(int index,MyString string2)
        {
            int LengthString = NumberOfElements(string2.testString);

            char[] TempArray = new char[LengthString+NumberOfElements()];

            for (int i = 0; i < index; i++)
            {
                TempArray[i] = testString[i];
            }

            for (int i = index; i < index + NumberOfElements(string2.testString); i++)
            {
                TempArray[i] = string2.testString[i-index];
            }

            for (int i = index + NumberOfElements(string2.testString); i < NumberOfElements(string2.testString)+NumberOfElements(); i++)
            {
                TempArray[i] = testString[i - NumberOfElements(string2.testString)];
            }

            string LastString = new string(TempArray);

            return LastString;
        }

        public string SubStr(int index, int length)
        {
            char[] TempArray = new char[length];
            int counter = 0;

            for (int i = index; i < index + length; i++)
            {
                if (counter == length) break;
                TempArray[counter] = testString[i];
                counter++;
            }
            string LastString = new string(TempArray);

            return LastString;
        }

        public string[] Splitter(char splitter)
        {
            int j = 0;
            int words = 1;
            foreach (var chars in testString)
            {
                if (chars == ' ') words++;
            }

            string[] LastArray=new string[words];

            for (int i = 0; i < words; i++)
            {
                for (; j < NumberOfElements(); j++)
                {
                    if (testString[j] == splitter)
                    {
                        j++;
                        break;
                    }
                    LastArray[i] += testString[j];
                }
            }
            return LastArray;
        }

        public char[] ConvertChar()
        {
            char[] LastArray = new char[NumberOfElements()];
            for (int i = 0; i < NumberOfElements(); i++)
            {
                LastArray[i] = testString[i];
            }
            return LastArray;
        }

        public int FindIndex(MyString string2, int start = 0)
        {
            int LastIndex=-1;
            bool IndexCheck = false;

            for (int i = start; i < NumberOfElements(); i++)
            {
                if (testString[i] == string2.testString[0])
                {
                    for (int j = 0; j < NumberOfElements(string2.testString); j++)
                    {
                        if (testString[i + j] == string2.testString[j])
                        {
                            IndexCheck = true;
                            continue;
                        }
                        else
                        {
                            IndexCheck = false;
                            break;
                        }
                    }
                }

                if (IndexCheck == true)
                {
                    LastIndex = i;
                    break;
                }
                else if (IndexCheck==false)
                {
                    LastIndex = -1;
                    continue;
                }
            }
            return LastIndex;
        }

        public string SortAZ()
        {
            string alphabet = "abcçdefgğhıijklmnoöpqrsştuüvwxyz";
            char[] TempArray=new char[NumberOfElements()];
            int counter = 0;

            for (int i = 0; i < NumberOfElements(alphabet); i++)
            {
                foreach (var chars in testString)
                {
                    if (chars == alphabet[i])
                    {
                        TempArray[counter] = chars;
                        counter++;
                    }
                }
                if (counter == NumberOfElements() - 1) break;
            }
            string LastString = new string(TempArray);

            return LastString;
        }

        public string SortZA()
        {
            string alphabet = "zyxwvüutşsrqpöonmlkjiıhğgfedçcba";
            char[] TempArray = new char[NumberOfElements()];
            int counter = 0;

            for (int i = 0; i < NumberOfElements(alphabet); i++)
            {
                foreach (var chars in testString)
                {
                    if (chars == alphabet[i])
                    {
                        TempArray[counter] = chars;
                        counter++;
                    }
                }
                if (counter == NumberOfElements() - 1) break;
            }
            string LastString = new string(TempArray);

            return LastString;
        }

        public string Backward()
        {
            char[] TempArray=new char[NumberOfElements()];

            for (int i = NumberOfElements() - 1; -1 < i; i--)
            {
                TempArray[NumberOfElements() - 1 - i] = testString[i];
            }
            string LastString = new string(TempArray);

            return LastString;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("=== Welcome to my String Program! ===");
                Console.WriteLine("Please enter a string value");
                MyString string1 = new MyString(Console.ReadLine());

                string pick;
                do
                {
                    Console.WriteLine("Please pick an option:\n");
                    Console.WriteLine("1. Number of Elements");
                    Console.WriteLine("2. Merge Two Strings");
                    Console.WriteLine("3. Insert a String");
                    Console.WriteLine("4. Pick Somewhere From the String");
                    Console.WriteLine("5. Split the String");
                    Console.WriteLine("6. Convert String to the Char Array");
                    Console.WriteLine("7. Find an Index From the String");
                    Console.WriteLine("8. Sort the String A to Z");
                    Console.WriteLine("9. Sort the String Z to A");
                    Console.WriteLine("10. Reverse the String");
                    Console.WriteLine("0. Exit");

                    pick = Console.ReadLine();

                } while (pick != "0" && pick != "1" && pick != "2" && pick != "3" && pick != "4" && pick != "5" && pick != "6" && pick != "7" && pick != "8" && pick != "9" && pick != "10");

                int index,length;
                char splitter;
                bool exit = false;

                switch (pick)
                {
                    case "1":
                        Console.WriteLine(string1.NumberOfElements());
                        break;
                    case "2":
                        Console.WriteLine("Please Enter 2nd String Value:");
                        MyString string2=new MyString(Console.ReadLine());
                        Console.WriteLine(string1.Merge(string2));
                        break;
                    case "3":
                        Console.WriteLine("Please Enter 2nd String Value:");
                        MyString string3 = new MyString(Console.ReadLine());
                        Console.WriteLine("Please Enter an Index Value:");
                        index = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(string1.Join(index, string3));
                        break;
                    case "4":
                        Console.WriteLine("Please Enter an Index Value:");
                        index = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please Enter a Length Value");
                        length = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(string1.SubStr(index,length));
                        break;
                    case "5":
                        Console.WriteLine("Please Enter a CHAR Value:");
                        splitter = Convert.ToChar(Console.ReadLine());
                        string[] stringArray = new string[string1.NumberOfElements()];
                        stringArray = string1.Splitter(splitter);
                        foreach (var words in stringArray)
                        {
                            Console.WriteLine(words);
                        }
                        break;
                    case "6":
                        char[] charArray=new char[string1.NumberOfElements()];
                        charArray = string1.ConvertChar();
                        Console.WriteLine("String was Converted to Char Array.");
                        break;
                    case "7":
                        Console.WriteLine("Please Enter 2nd String Value:");
                        MyString string4 = new MyString(Console.ReadLine());
                        Console.WriteLine("Please Enter an Index Value to Start:");
                        index = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(string1.FindIndex(string4, index));
                        break;
                    case "8":
                        Console.WriteLine(string1.SortAZ());
                        break;
                    case "9":
                        Console.WriteLine(string1.SortZA());
                        break;
                    case "10":
                        Console.WriteLine(string1.Backward());
                        break;
                    case "0":
                        exit = true;
                        break;
                }

                Console.WriteLine("Press a Key to Continue");
                Console.ReadKey();

                Console.Clear();
                if (exit) break;

            }
        }
    }
}
