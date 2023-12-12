using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using TicTacToeRendererLib.Enums;
using TicTacToeRendererLib.Renderer;

namespace TicTacToeSubmissionConole
{
    public class TicTacToe
    {
        private TicTacToeConsoleRenderer _boardRenderer;

        public TicTacToe()
        {
            _boardRenderer = new TicTacToeConsoleRenderer(10, 6);
            _boardRenderer.Render();
        }

        public static string[,] pos = { { "", "", "" }, { "", "", "" }, { "", "", "" } };
        public static string[] position = { "", "", "", "", "", "", "", "", "" };

        public void Run()
        {

            pos[0, 0] = position[0];
            pos[0, 1] = position[1];
            pos[0, 2] = position[2];
            pos[1, 0] = position[3];
            pos[1, 1] = position[4];
            pos[1, 2] = position[5];
            pos[2, 0] = position[6];
            pos[2, 1] = position[7];
            pos[2, 2] = position[8];


            // FOR ILLUSTRATION CHANGE TO YOUR OWN LOGIC TO DO TIC TAC TOE


            while (true)
            {
                int xturn = 0;
                int oturn = 0;

                while (true)
                {
                    Console.SetCursorPosition(2, 19);

                    Console.Write("Player X");

                    Console.SetCursorPosition(2, 20);

                    Console.Write("Please Enter Row: ");
                    var row = Console.ReadLine();

                    Console.SetCursorPosition(2, 22);


                    Console.Write("Please Enter Column: ");
                    var column = Console.ReadLine();




                    if (pos[int.Parse(row), int.Parse(column)] == "")
                    {
                        _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.X, true);
                        pos[int.Parse(row), int.Parse(column)] = "X";
                        xturn += 1;
                        break;
                    }

                    else
                    {
                        Console.Clear();
                        Console.SetCursorPosition(2, 24);
                        Console.WriteLine("Try Again");

                    }


                }




                if (xturn == 5)
                {
                    break;
                }


                while (true)
                {

                    Console.SetCursorPosition(3, 25);

                    Console.Write("Player O");

                    Console.SetCursorPosition(3, 26);

                    Console.Write("Please Enter Row: ");
                    var row1 = Console.ReadLine();

                    Console.SetCursorPosition(3, 28);


                    Console.Write("Please Enter Column: ");
                    var column1 = Console.ReadLine();

                    if (pos[int.Parse(row1), int.Parse(column1)] == "")
                    {
                        _boardRenderer.AddMove(int.Parse(row1), int.Parse(column1), PlayerEnum.O, true);
                        pos[int.Parse(row1), int.Parse(column1)] = "O";
                        oturn += 1;
                    }

                    else
                    {
                        Console.Clear();
                        Console.SetCursorPosition(2, 24);
                        Console.WriteLine("Try Again");
                        continue;


                    }







                    if (position[0] == "O" && position[1] == "O" && position[2] == "O") // Horizontal ----------------------------------------
                    {
                        Console.Clear();
                        Console.WriteLine("Player O Wins!!!");

                    }
                    else if (position[3] == "O" && position[4] == "O" && position[5] == "O")
                    {
                        Console.Clear();
                        Console.WriteLine("Player O Wins!!!");
                    }
                    else if (position[6] == "O" && position[7] == "O" && position[8] == "O")
                    {
                        Console.Clear();
                        Console.WriteLine("Player O Wins!!!");
                    }

                    else if (position[0] == "O" && position[4] == "O" && position[8] == "O") // Diagonal -----------------------------------------
                    {
                        Console.Clear();
                        Console.WriteLine("Player O Wins!!!");
                    }
                    else if (position[6] == "O" && position[4] == "O" && position[2] == "O")
                    {
                        Console.Clear();
                        Console.WriteLine("Player O Wins!!!");
                    }

                    else if (position[0] == "O" && position[3] == "O" && position[6] == "O")// Coloumns ------------------------------------------
                    {
                        Console.Clear();
                        Console.WriteLine("Player 0 Wins!!!");
                    }
                    else if (position[1] == "O" && position[4] == "O" && position[7] == "O")
                    {
                        Console.Clear();
                        Console.WriteLine("Player 0 Wins!!!");
                    }
                    else if (position[2] == "O" && position[5] == "O" && position[8] == "O")
                    {
                        Console.Clear();
                        Console.WriteLine("Player 0 Wins!!!");
                    }

                    if (position[0] == "X" && position[1] == "X" && position[2] == "X") // Horizontal ----------------------------------------
                    {
                        Console.Clear();
                        Console.WriteLine("Player X Wins!!!");
                    }
                    else if (position[3] == "X" && position[4] == "X" && position[5] == "X")
                    {
                        Console.Clear();
                        Console.WriteLine("Player X Wins!!!");
                    }
                    else if (position[6] == "X" && position[7] == "X" && position[8] == "X")
                    {
                        Console.Clear();
                        Console.WriteLine("Player X Wins!!!");
                    }

                    else if (position[0] == "X" && position[4] == "X" && position[8] == "X") // Diagonal -----------------------------------------
                    {
                        Console.Clear();
                        Console.WriteLine("Player X Wins!!!");
                    }
                    else if (position[6] == "X" && position[4] == "X" && position[2] == "X")
                    {
                        Console.Clear();
                        Console.WriteLine("Player X Wins!!!");
                    }

                    else if (position[0] == "X" && position[3] == "X" && position[6] == "X") // Coloumns ------------------------------------------
                    {
                        Console.Clear();
                        Console.WriteLine("Player X Wins!!!");
                    }
                    else if (position[1] == "X" && position[4] == "X" && position[7] == "X")
                    {
                        Console.Clear();
                        Console.WriteLine("Player X Wins!!!");
                    }
                    else if (position[2] == "X" && position[5] == "X" && position[8] == "X")
                    {
                        Console.Clear();
                        Console.WriteLine("Player X Wins!!!");
                    }
                    else // No winner ----------------------------------------------
                    {

                        Console.Clear();
                        Console.WriteLine("DRAW!!!!!!!!!!");

                    }





                }
            }

        }
    }
}
