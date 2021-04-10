/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2020-2021 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: OOP Project 1.1
**				ÖĞRENCİ ADI............: Caner Kaymakçı
**				ÖĞRENCİ NUMARASI.......: B191210095
**                         DERSİN ALINDIĞI GRUP...: Group D
****************************************************************************/

using System;

namespace OOP_Work_1
{
    class Program
    {
        static Random random = new Random();  //Used Random class here.

        static void Main(string[] args)
        {
            bool[,] castle = new bool[8, 8];     //Created 2 dimensional bool array. Default value is False.

            int coordX, coordY;     //Coord variables.
            int castlecounter = 0;  //Number of castles
            int attempt = 0;        //Number of attempts

            //Loop for place all 8 castle. After 8 castle, Loop will be broken.
            while (true)
            {
                coordX = random.Next(0, 8);     //Creates random X coord.
                coordY = random.Next(0, 8);     //Creates random Y coord.
                bool tempbool = false;          //Temporary bool for if coords is available for place a castle

                //Checks X and Y coord if it is available for a castle. If yes, Temporary value will stay False.
                for (int i = 0; i < 8; i++)
                {
                    //Checks whole column of an X coord.
                    if (castle[coordX, i] == true)
                    {
                        tempbool = true;
                        break;
                    }
                    //Checks whole line of an Y coord.
                    if (castle[i, coordY] == true)
                    {
                        tempbool = true;
                        break;
                    }
                }

                attempt++;  //Increase attempt value in each loop.

                //If coords are available, program will draw the board at each place time.
                if (tempbool == false)
                {
                    castle[coordX, coordY] = true;    //Coords of castle will be True value.
                    castlecounter++;                //Number of castle will increase.

                    //Loop for draw a board with castles.
                    //Loop of each line.
                    for (int i = 0; i < 8; i++)
                    {
                        //Loop of each column.
                        for (int j = 0; j < 8; j++)
                        {
                            Console.Write("[");
                            //If there is a castle, program will write "C".
                            if (castle[j, i] == true)
                            {
                                Console.Write("C");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                            Console.Write("]");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("Castle No:" + castlecounter + " was placed in " + attempt + " attempt(s)\n");    //Program will say Castle number and their attempt number on each draw.
                }

                //If all castles are on board, Main loop will be broken.
                if (castlecounter == 8)
                {
                    break;
                }
            }
            Console.WriteLine("\nFinished with " + attempt + " attempts");  //Program will say how many attempts are there at the end of program.
        }
    }
}