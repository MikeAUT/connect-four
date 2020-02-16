using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VierGewinnt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            bool xWinnner = false;
            bool oWinner = false;
            bool full1 = false; // Set when a column is full
            bool full2 = false;
            bool full3 = false;
            bool full4 = false;
            bool full5 = false;
            bool full6 = false;
            bool full7 = false;

            int row1 = 5; // Indices for the usable row of each column
            int row2 = 5;
            int row3 = 5;
            int row4 = 5;
            int row5 = 5;
            int row6 = 5;
            int row7 = 5;
            int player = 2; // Player index
            int input; // Entered column
            int xWon = 0; // Number of won games by player X
            int oWon = 0; // Number of won games by player O
            int timesWon = 0;

            char answer;
            char[,] board = new char[6, 7];
            char identfier = 'Q';

            string stringInput;

            ResetBoard(board);

            do
            {
                // Switch players
                if (player == 1)
                {
                    player = 2;
                    identfier = 'O';
                }
                else if (player == 2)
                {
                    player = 1;
                    identfier = 'X';
                }

                // Toss stones
                if ((xWinnner == false) && (oWinner == false))
                {
                    Console.Clear();
                    ShowBoard(board);
                    stonetoss:
                    Console.WriteLine("Player {0}, it's your turn. Choose a column:", identfier);
                    stringInput = Console.ReadLine();
                    if (int.TryParse(stringInput, out input))
                    {
                        if ((input >= 1) && (input <= 7))
                        {
                            switch (input)
                            {
                                case 1:
                                    if (board[0, input - 1] != ' ')
                                    {
                                        Console.Clear();
                                        ShowBoard(board);
                                        Console.WriteLine("This Column is full, choose another on!");
                                        full1 = true;
                                        goto stonetoss;
                                    }
                                    else
                                    {
                                        if (board[row1, input - 1] == ' ')
                                        {
                                            board[row1, input - 1] = identfier;
                                            row1--;
                                        }
                                        else
                                        {
                                            row1--;
                                        }
                                        full1 = false;
                                    }
                                    break;

                                case 2:
                                    if (board[0, input - 1] != ' ')
                                    {
                                        Console.Clear();
                                        ShowBoard(board);
                                        Console.WriteLine("This Column is full, choose another on!");
                                        full2 = true;
                                        goto stonetoss;
                                    }
                                    else
                                    {
                                        if (board[row2, input - 1] == ' ')
                                        {
                                            board[row2, input - 1] = identfier;
                                            row2--;
                                        }
                                        else
                                        {
                                            row2--;
                                        }
                                        full2 = false;
                                    }
                                    break;

                                case 3:
                                    if (board[0, input - 1] != ' ')
                                    {
                                        Console.Clear();
                                        ShowBoard(board);
                                        Console.WriteLine("This Column is full, choose another on!");
                                        full3 = true;
                                        goto stonetoss;
                                    }
                                    else
                                    {
                                        if (board[row3, input - 1] == ' ')
                                        {
                                            board[row3, input - 1] = identfier;
                                            row3--;
                                        }
                                        else
                                        {
                                            row3--;
                                        }
                                        full3 = false;
                                    }
                                    break;

                                case 4:
                                    if (board[0, input - 1] != ' ')
                                    {
                                        Console.Clear();
                                        ShowBoard(board);
                                        Console.WriteLine("This Column is full, choose another on!");
                                        full4 = true;
                                        goto stonetoss;
                                    }
                                    else
                                    {
                                        if (board[row4, input - 1] == ' ')
                                        {
                                            board[row4, input - 1] = identfier;
                                            row4--;
                                        }
                                        else
                                        {
                                            row4--;
                                        }
                                        full4 = false;
                                    }
                                    break;

                                case 5:
                                    if (board[0, input - 1] != ' ')
                                    {
                                        Console.Clear();
                                        ShowBoard(board);
                                        Console.WriteLine("This Column is full, choose another on!");
                                        full5 = true;
                                        goto stonetoss;
                                    }
                                    else
                                    {
                                        if (board[row5, input - 1] == ' ')
                                        {
                                            board[row5, input - 1] = identfier;
                                            row5--;
                                        }
                                        else
                                        {
                                            row5--;
                                        }
                                        full5 = false;
                                    }
                                    break;

                                case 6:
                                    if (board[0, input - 1] != ' ')
                                    {
                                        Console.Clear();
                                        ShowBoard(board);
                                        Console.WriteLine("This Column is full, choose another on!");
                                        full6 = true;
                                        goto stonetoss;
                                    }
                                    else
                                    {
                                        if (board[row6, input - 1] == ' ')
                                        {
                                            board[row6, input - 1] = identfier;
                                            row6--;
                                        }
                                        else
                                        {
                                            row6--;
                                        }
                                        full6 = false;
                                    }
                                    break;

                                case 7:
                                    if (board[0, input - 1] != ' ')
                                    {
                                        Console.Clear();
                                        ShowBoard(board);
                                        Console.WriteLine("This Column is full, choose another on!");
                                        full7 = true;
                                        goto stonetoss;
                                    }
                                    else
                                    {
                                        if (board[row7, input - 1] == ' ')
                                        {
                                            board[row7, input - 1] = identfier;
                                            row7--;
                                        }
                                        else
                                        {
                                            row7--;
                                        }
                                        full7 = false;
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            Console.Clear();
                            ShowBoard(board);
                            Console.WriteLine("Wrong input, please try again!");
                            goto stonetoss;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        ShowBoard(board);
                        Console.WriteLine("Wrong input, please try again!");
                        goto stonetoss;
                    }
                }

                if (
                    // Check if there are 4 fields of the same identifier in a row
                    // Check first row horizontal
                    ((board[0, 0] == identfier) && (board[0, 1] == identfier) && (board[0, 2] == identfier) && (board[0, 3] == identfier)) || ((board[0, 1] == identfier) && (board[0, 2] == identfier) && (board[0, 3] == identfier) && (board[0, 4] == identfier)) ||
                    ((board[0, 2] == identfier) && (board[0, 3] == identfier) && (board[0, 4] == identfier) && (board[0, 5] == identfier)) || ((board[0, 3] == identfier) && (board[0, 4] == identfier) && (board[0, 5] == identfier) && (board[0, 6] == identfier)) ||
                    // Check second row horizontal
                    ((board[1, 0] == identfier) && (board[1, 1] == identfier) && (board[1, 2] == identfier) && (board[1, 3] == identfier)) || ((board[1, 1] == identfier) && (board[1, 2] == identfier) && (board[1, 3] == identfier) && (board[1, 4] == identfier)) ||
                    ((board[1, 2] == identfier) && (board[1, 3] == identfier) && (board[1, 4] == identfier) && (board[1, 5] == identfier)) || ((board[1, 3] == identfier) && (board[1, 4] == identfier) && (board[1, 5] == identfier) && (board[1, 6] == identfier)) ||
                    // Check third row horizontal
                    ((board[2, 0] == identfier) && (board[2, 1] == identfier) && (board[2, 2] == identfier) && (board[2, 3] == identfier)) || ((board[2, 1] == identfier) && (board[2, 2] == identfier) && (board[2, 3] == identfier) && (board[2, 4] == identfier)) ||
                    ((board[2, 2] == identfier) && (board[2, 3] == identfier) && (board[2, 4] == identfier) && (board[2, 5] == identfier)) || ((board[2, 3] == identfier) && (board[2, 4] == identfier) && (board[2, 5] == identfier) && (board[2, 6] == identfier)) ||
                    // Check fourth row horizontal
                    ((board[3, 0] == identfier) && (board[3, 1] == identfier) && (board[3, 2] == identfier) && (board[3, 3] == identfier)) || ((board[3, 1] == identfier) && (board[3, 2] == identfier) && (board[3, 3] == identfier) && (board[3, 4] == identfier)) ||
                    ((board[3, 2] == identfier) && (board[3, 3] == identfier) && (board[3, 4] == identfier) && (board[3, 5] == identfier)) || ((board[3, 3] == identfier) && (board[3, 4] == identfier) && (board[3, 5] == identfier) && (board[3, 6] == identfier)) ||
                    // Check fifth row horizontal
                    ((board[4, 0] == identfier) && (board[4, 1] == identfier) && (board[4, 2] == identfier) && (board[4, 3] == identfier)) || ((board[4, 1] == identfier) && (board[4, 2] == identfier) && (board[4, 3] == identfier) && (board[4, 4] == identfier)) ||
                    ((board[4, 2] == identfier) && (board[4, 3] == identfier) && (board[4, 4] == identfier) && (board[4, 5] == identfier)) || ((board[4, 3] == identfier) && (board[4, 4] == identfier) && (board[4, 5] == identfier) && (board[4, 6] == identfier)) ||
                    // Check sixth row horizontal
                    ((board[5, 0] == identfier) && (board[5, 1] == identfier) && (board[5, 2] == identfier) && (board[5, 3] == identfier)) || ((board[5, 1] == identfier) && (board[5, 2] == identfier) && (board[5, 3] == identfier) && (board[5, 4] == identfier)) ||
                    ((board[5, 2] == identfier) && (board[5, 3] == identfier) && (board[5, 4] == identfier) && (board[5, 5] == identfier)) || ((board[5, 3] == identfier) && (board[5, 4] == identfier) && (board[5, 5] == identfier) && (board[5, 6] == identfier)) ||

                    // Check first column vertical
                    ((board[0, 0] == identfier) && (board[1, 0] == identfier) && (board[2, 0] == identfier) && (board[3, 0] == identfier)) || ((board[1, 0] == identfier) && (board[2, 0] == identfier) && (board[3, 0] == identfier) && (board[4, 0] == identfier)) ||
                    ((board[2, 0] == identfier) && (board[3, 0] == identfier) && (board[4, 0] == identfier) && (board[5, 0] == identfier)) ||
                    // Check second column vertical
                    ((board[0, 1] == identfier) && (board[1, 1] == identfier) && (board[2, 1] == identfier) && (board[3, 1] == identfier)) || ((board[1, 1] == identfier) && (board[2, 1] == identfier) && (board[3, 1] == identfier) && (board[4, 1] == identfier)) ||
                    ((board[2, 1] == identfier) && (board[3, 1] == identfier) && (board[4, 1] == identfier) && (board[5, 1] == identfier)) ||
                    // Check third column vertical
                    ((board[0, 2] == identfier) && (board[1, 2] == identfier) && (board[2, 2] == identfier) && (board[3, 2] == identfier)) || ((board[1, 2] == identfier) && (board[2, 2] == identfier) && (board[3, 2] == identfier) && (board[4, 2] == identfier)) ||
                    ((board[2, 2] == identfier) && (board[3, 2] == identfier) && (board[4, 2] == identfier) && (board[5, 2] == identfier)) ||
                    // Check fourth column vertical
                    ((board[0, 3] == identfier) && (board[1, 3] == identfier) && (board[2, 3] == identfier) && (board[3, 3] == identfier)) || ((board[1, 3] == identfier) && (board[2, 3] == identfier) && (board[3, 3] == identfier) && (board[4, 3] == identfier)) ||
                    ((board[2, 3] == identfier) && (board[3, 3] == identfier) && (board[4, 3] == identfier) && (board[5, 3] == identfier)) ||
                    // Check fifth column vertical
                    ((board[0, 4] == identfier) && (board[1, 4] == identfier) && (board[2, 4] == identfier) && (board[3, 4] == identfier)) || ((board[1, 4] == identfier) && (board[2, 4] == identfier) && (board[3, 4] == identfier) && (board[4, 4] == identfier)) ||
                    ((board[2, 4] == identfier) && (board[3, 4] == identfier) && (board[4, 4] == identfier) && (board[5, 4] == identfier)) ||
                    // Check sixtch column vertical
                    ((board[0, 5] == identfier) && (board[1, 5] == identfier) && (board[2, 5] == identfier) && (board[3, 5] == identfier)) || ((board[1, 5] == identfier) && (board[2, 5] == identfier) && (board[3, 5] == identfier) && (board[4, 5] == identfier)) ||
                    ((board[2, 5] == identfier) && (board[3, 5] == identfier) && (board[4, 5] == identfier) && (board[5, 5] == identfier)) ||
                    // Check seventh column vertical
                    ((board[0, 6] == identfier) && (board[1, 6] == identfier) && (board[2, 6] == identfier) && (board[3, 6] == identfier)) || ((board[1, 6] == identfier) && (board[2, 6] == identfier) && (board[3, 6] == identfier) && (board[4, 6] == identfier)) ||
                    ((board[2, 6] == identfier) && (board[3, 6] == identfier) && (board[4, 6] == identfier) && (board[5, 6] == identfier)) ||

                    // Check diagonal left up to right down
                    ((board[0, 0] == identfier) && (board[1, 1] == identfier) && (board[2, 2] == identfier) && (board[3, 3] == identfier)) || ((board[0, 1] == identfier) && (board[1, 2] == identfier) && (board[2, 3] == identfier) && (board[3, 4] == identfier)) ||
                    ((board[0, 2] == identfier) && (board[1, 3] == identfier) && (board[2, 4] == identfier) && (board[3, 5] == identfier)) || ((board[0, 3] == identfier) && (board[1, 4] == identfier) && (board[2, 5] == identfier) && (board[3, 6] == identfier)) ||
                    ((board[1, 1] == identfier) && (board[2, 2] == identfier) && (board[3, 3] == identfier) && (board[4, 4] == identfier)) || ((board[2, 2] == identfier) && (board[3, 3] == identfier) && (board[4, 4] == identfier) && (board[5, 5] == identfier)) ||
                    ((board[1, 2] == identfier) && (board[2, 3] == identfier) && (board[3, 4] == identfier) && (board[4, 5] == identfier)) || ((board[2, 3] == identfier) && (board[3, 4] == identfier) && (board[4, 5] == identfier) && (board[5, 6] == identfier)) ||
                    ((board[1, 3] == identfier) && (board[2, 4] == identfier) && (board[3, 5] == identfier) && (board[4, 6] == identfier)) ||
                    ((board[1, 0] == identfier) && (board[2, 1] == identfier) && (board[3, 2] == identfier) && (board[4, 3] == identfier)) || ((board[2, 1] == identfier) && (board[3, 2] == identfier) && (board[4, 3] == identfier) && (board[5, 4] == identfier)) ||
                    ((board[2, 0] == identfier) && (board[3, 1] == identfier) && (board[4, 2] == identfier) && (board[5, 5] == identfier)) ||
                    // Check diagonal left down to right up
                    ((board[3, 0] == identfier) && (board[2, 1] == identfier) && (board[1, 2] == identfier) && (board[0, 3] == identfier)) ||
                    ((board[4, 0] == identfier) && (board[3, 1] == identfier) && (board[2, 2] == identfier) && (board[1, 3] == identfier)) || ((board[3, 1] == identfier) && (board[2, 2] == identfier) && (board[1, 3] == identfier) && (board[0, 4] == identfier)) ||
                    ((board[5, 0] == identfier) && (board[4, 1] == identfier) && (board[3, 2] == identfier) && (board[2, 3] == identfier)) || ((board[4, 1] == identfier) && (board[3, 2] == identfier) && (board[2, 3] == identfier) && (board[1, 4] == identfier)) ||
                    ((board[3, 2] == identfier) && (board[2, 3] == identfier) && (board[1, 4] == identfier) && (board[0, 5] == identfier)) ||
                    ((board[5, 1] == identfier) && (board[4, 2] == identfier) && (board[3, 3] == identfier) && (board[2, 4] == identfier)) || ((board[4, 2] == identfier) && (board[3, 3] == identfier) && (board[2, 4] == identfier) && (board[1, 5] == identfier)) ||
                    ((board[3, 3] == identfier) && (board[2, 4] == identfier) && (board[1, 5] == identfier) && (board[0, 6] == identfier)) ||
                    ((board[5, 2] == identfier) && (board[4, 3] == identfier) && (board[3, 4] == identfier) && (board[2, 5] == identfier)) || ((board[4, 3] == identfier) && (board[3, 4] == identfier) && (board[2, 5] == identfier) && (board[1, 6] == identfier)) ||
                    ((board[5, 3] == identfier) && (board[4, 4] == identfier) && (board[3, 5] == identfier) && (board[2, 6] == identfier))
                    )
                {
                    if (identfier == 'X')
                    {
                        xWinnner = true;
                        oWinner = false;
                        xWon++;
                    }
                    else if (identfier == 'O')
                    {
                        xWinnner = false;
                        oWinner = true;
                        oWon++;
                    }
                    Console.Clear();
                    ShowBoard(board);
                reround:
                    if (xWinnner == true)
                    {
                        timesWon = xWon;
                    }
                    else if (oWinner == true)
                    {
                        timesWon = oWon;
                    }
                    Console.WriteLine("Player {0} won the {1}th time in this session", identfier, timesWon);
                    Console.WriteLine("Another Round? Y/N");
                    answer = Console.ReadKey().KeyChar;
                    if ((answer == 'y') || (answer == 'Y'))
                    {
                        xWinnner = false;
                        oWinner = false;
                        player = 2;
                        full1 = full2 = full3 = full4 = full5 = full6 = full7 = false;
                        row1 = row2 = row3 = row4 = row5 = row6 = row7 = 5;
                        ResetBoard(board);
                    }
                    else if ((answer == 'n') || (answer == 'N'))
                    {
                        Console.WriteLine("\bAlright, As you wish....");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        ShowBoard(board);
                        Console.WriteLine("Wrong input, please try again!");
                        goto reround;
                    }
                }
            } while (true);
        }
        static void ShowBoard(char[,] arr)
        {
            Console.WriteLine("");
            Console.WriteLine("Rows:");
            Console.WriteLine(" 1 | 2 | 3 | 4 | 5 | 6 | 7 ");
            Console.WriteLine("    ");
            Console.WriteLine(" {0} | {1} | {2} | {3} | {4} | {5} | {6} ", arr[0, 0], arr[0, 1], arr[0, 2], arr[0, 3], arr[0, 4], arr[0, 5], arr[0, 6]);
            Console.WriteLine("---+---+---+---+---+---+---");
            Console.WriteLine(" {0} | {1} | {2} | {3} | {4} | {5} | {6} ", arr[1, 0], arr[1, 1], arr[1, 2], arr[1, 3], arr[1, 4], arr[1, 5], arr[1, 6]);
            Console.WriteLine("---+---+---+---+---+---+---");
            Console.WriteLine(" {0} | {1} | {2} | {3} | {4} | {5} | {6} ", arr[2, 0], arr[2, 1], arr[2, 2], arr[2, 3], arr[2, 4], arr[2, 5], arr[2, 6]);
            Console.WriteLine("---+---+---+---+---+---+---");
            Console.WriteLine(" {0} | {1} | {2} | {3} | {4} | {5} | {6} ", arr[3, 0], arr[3, 1], arr[3, 2], arr[3, 3], arr[3, 4], arr[3, 5], arr[3, 6]);
            Console.WriteLine("---+---+---+---+---+---+---");
            Console.WriteLine(" {0} | {1} | {2} | {3} | {4} | {5} | {6} ", arr[4, 0], arr[4, 1], arr[4, 2], arr[4, 3], arr[4, 4], arr[4, 5], arr[4, 6]);
            Console.WriteLine("---+---+---+---+---+---+---");
            Console.WriteLine(" {0} | {1} | {2} | {3} | {4} | {5} | {6} ", arr[5, 0], arr[5, 1], arr[5, 2], arr[5, 3], arr[5, 4], arr[5, 5], arr[5, 6]);
            Console.WriteLine("");
        }

        static void ResetBoard(char[,] board)
        {
            // Initialize board array
            for (int y = 0; y < 6; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    board[y, x] = ' ';
                }
            }
        }
    }
}


