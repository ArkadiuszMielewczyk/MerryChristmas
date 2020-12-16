using System;
using System.Threading;

namespace MerryChristmas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Merry Christmas";
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            new ChristmasTree(3, 4, ConsoleColor.DarkGreen).DrawChristmasTree();
            Thread.Sleep(500);
            new ChristmasTree(63, 1, ConsoleColor.DarkYellow).DrawChristmasTree();
            Thread.Sleep(500);
            new ChristmasTree(23, 2, ConsoleColor.Red).DrawChristmasTree();
            Thread.Sleep(500);
            new ChristmasTree(43, 6, ConsoleColor.Blue).DrawChristmasTree();
            Thread.Sleep(500);
            new ChristmasTree(83, 5, ConsoleColor.DarkMagenta).DrawChristmasTree();
            Thread.Sleep(600);

            for (; ;)
            {
                WriteMerryChristmas.DrawMerryChristmasInscription();
            }
        }
    }

    public class WriteMerryChristmas
    {
        public static void MerryChristmasInscription()
        {
            string[,] merryChristmasInscription = new string[,]
            {
                        {"   #   #                       ##                  #              ##             #            #      "},
                        {"   #   #                        #                  #             #  #                        ###     "},
                        {"   # # #   ##    ####    ##     #    #  #    ###   # #            #     #   #   ##     ###    #      "},
                        {"   # # #  # ##   ##     #  #    #    #  #   #      ## #            #    # # #    #    #  #    # #    "},
                        {"   ## ##  ##       ##   #  #    #    ## #   #      #  #          #  #   # # #    #    #  #    # #    "},
                        {"   #   #   ###   ####    ##    ###     ##    ###   #  #           ##     # #    ###    ####    #     "},
                        {"                                     #  #                                                            "},
                        {"                                       ##                                                            "},
            };
           
            foreach (var item in merryChristmasInscription)
            {
                Console.SetCursorPosition(5, Console.CursorTop);
                Console.WriteLine(item);
            }
        }

        public static void DrawMerryChristmasInscription()
        {
            int randomNumberForColor = new Random().Next(0, 6);
            if (randomNumberForColor == 0)
            {
                Console.SetCursorPosition(5, Console.CursorTop + 2);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                MerryChristmasInscription();
                Thread.Sleep(200);
                Console.SetCursorPosition(5, Console.CursorTop - 10);
            }
            else if (randomNumberForColor == 1)
            {
                Console.SetCursorPosition(5, Console.CursorTop + 2);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                MerryChristmasInscription();
                Thread.Sleep(200);
                Console.SetCursorPosition(5, Console.CursorTop - 10);
            }
            else if (randomNumberForColor == 2)
            {
                Console.SetCursorPosition(5, Console.CursorTop + 2);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                MerryChristmasInscription();
                Thread.Sleep(200);
                Console.SetCursorPosition(5, Console.CursorTop - 10);
            }
            else if (randomNumberForColor == 3)
            {
                Console.SetCursorPosition(5, Console.CursorTop + 2);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                MerryChristmasInscription();
                Thread.Sleep(200);
                Console.SetCursorPosition(5, Console.CursorTop - 10);
            }
            else if (randomNumberForColor == 4)
            {
                Console.SetCursorPosition(5, Console.CursorTop + 2);
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                MerryChristmasInscription();
                Thread.Sleep(200);
                Console.SetCursorPosition(5, Console.CursorTop - 10);
            }
            else if (randomNumberForColor == 5)
            {
                Console.SetCursorPosition(5, Console.CursorTop + 2);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                MerryChristmasInscription();
                Thread.Sleep(200);
                Console.SetCursorPosition(5, Console.CursorTop - 10);
            }
            else if (randomNumberForColor == 6)
            {
                Console.SetCursorPosition(5, Console.CursorTop + 2);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                MerryChristmasInscription();
                Thread.Sleep(200);
                Console.SetCursorPosition(5, Console.CursorTop - 10);
            }
        }
    }

    struct ChristmasTree
    {
        int left;
        int top;
        ConsoleColor treeColor;

        public ChristmasTree(int l, int t, ConsoleColor tColor)
        {
            left = l;
            top = t;
            treeColor = tColor;
        }

        public void DrawChristmasTree()
        {
            string[,] christmasTree = new string[,]
                {
                    {"        ▲        "},
                    {"       ▲▼▲       "},
                    {"      ▲▼▲▼▲      "},
                    {"     ▲▼▲▼▲▼▲     "},
                    {"      ▲▼▲▼▲      "},
                    {"     ▲▼▲▼▲▼▲     "},
                    {"    ▲▼▲▼▲▼▲▼▲    "},
                    {"   ▲▼▲▼▲▼▲▼▲▼▲   "},
                    {"     ▲▼▲▼▲▼▲     "},
                    {"    ▲▼▲▼▲▼▲▼▲    "},
                    {"   ▲▼▲▼▲▼▲▼▲▼▲   "},
                    {"  ▲▼▲▼▲▼▲▼▲▼▲▼▲  "},
                    {" ▲▼▲▼▲▼▲▼▲▼▲▼▲▼▲ "},
                    {"      @@@@       "},
                    {"      @@@@       "},
                };

            Console.SetCursorPosition(left, top);
            Console.ForegroundColor = treeColor;
            foreach (var item in christmasTree)
            {
                Console.SetCursorPosition(left, Console.CursorTop);
                Console.WriteLine(item);
            }
        }
    }
}

