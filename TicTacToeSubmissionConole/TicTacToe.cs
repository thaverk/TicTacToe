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
       

        public void Run()
        {

            int xturn = 0;
            int oturn = 0;



            // FOR ILLUSTRATION CHANGE TO YOUR OWN LOGIC TO DO TIC TAC TOE


            while (true)
            {
                
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
              
                
                
                    if (pos[0, 0] == "X" && pos[0, 1] == "X" && pos[0, 2] == "X") // Horizontal ----------------------------------------
                    {
                        Console.Clear();
                        Console.SetCursorPosition(10, 2);
                        Console.WriteLine("Player X Wins!!!");
                        break;
                    }
                    else if (pos[1, 0] == "X" && pos[1, 1] == "X" && pos[1, 2] == "X")
                    {
                        Console.Clear();
                        Console.SetCursorPosition(10, 2);
                        Console.WriteLine("Player X Wins!!!");
                        break;
                    }
                    else if (pos[2, 0] == "X" && pos[2, 1] == "X" && pos[2,2] == "X")
                    {
                        Console.Clear();
                         Console.SetCursorPosition(10, 2);
                        Console.WriteLine("Player X Wins!!!");
                        break;
                    }

                    else if( pos[0, 0] == "X" && pos[1, 1] == "X" && pos[2, 2] == "X") // Diagonal -----------------------------------------
                    {
                        Console.Clear();
                        Console.SetCursorPosition(10, 2);
                         Console.WriteLine("Player X Wins!!!");
                        break;
                    }
                    else if (pos[2, 0] == "X" && pos[1, 1] == "X" && pos[2, 2] == "X")
                    {
                        Console.Clear();
                    Console.SetCursorPosition(10, 2);
                    Console.WriteLine("Player X Wins!!!");
                        break;
                    }

                    else if (pos[0, 0] == "X" && pos[1, 0] == "X" && pos[2,0] == "X") // Coloumns ------------------------------------------
                    {
                        Console.Clear();
                    Console.SetCursorPosition(10, 2);
                    Console.WriteLine("Player X Wins!!!");
                        break;
                    }
                    else if (pos[0, 1] == "X" && pos[1, 1] == "X" && pos[2, 1] == "X")
                    {
                        Console.Clear();
                    Console.SetCursorPosition(10, 2);
                    Console.WriteLine("Player X Wins!!!");
                        break;
                    }
                    else if (pos[0, 2] == "X" && pos[1, 2] == "X" && pos[2, 2] == "X")
                    {
                        Console.Clear();
                    Console.SetCursorPosition(10, 2);
                    Console.WriteLine("Player X Wins!!!");
                        break;
                    }
               
                    
                
                


                if (xturn == 5&oturn==4)
                {
                    Console.Clear();
                    Console.SetCursorPosition(10, 2);
                    Console.WriteLine("Draw!!!");
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
                        break;
                    }

                    else
                    {
                        Console.Clear();
                        Console.SetCursorPosition(2, 24);
                        Console.WriteLine("Try Again");
                 
                    }
                   
                }

                if (pos[0, 0] == "O" && pos[0, 1] == "O" && pos[0, 2] == "O") // Horizontal ----------------------------------------
                {
                    Console.Clear();
                    Console.SetCursorPosition(10, 2);
                    Console.WriteLine("Player O Wins!!!");
                    break;
                }
                else if (pos[1, 0] == "O" && pos[1, 1] == "O" && pos[1, 2] == "O")
                {
                    Console.Clear();
                    Console.SetCursorPosition(10, 2);
                    Console.WriteLine("Player O Wins!!!");
                    break;
                }
                else if (pos[2, 0] == "O" && pos[2, 1] == "O" && pos[2, 2] == "O")
                {
                    Console.Clear();
                    Console.SetCursorPosition(10, 2);
                    Console.WriteLine("Player O Wins!!!");
                    break;
                }

                else if (pos[0, 0] == "O" && pos[1, 1] == "O" && pos[2, 2] == "O") // Diagonal -----------------------------------------
                {
                    Console.Clear();
                    Console.SetCursorPosition(10, 2);
                    Console.WriteLine("Player X Wins!!!");
                    break;
                }
                else if (pos[2, 0] == "O" && pos[1, 1] == "O" && pos[2, 2] == "O")
                {
                    Console.Clear();
                    Console.SetCursorPosition(10, 2);
                    Console.WriteLine("Player X Wins!!!");
                    break;
                }

                else if (pos[0, 0] == "O" && pos[1, 0] == "O" && pos[2, 0] == "O") // Coloumns ------------------------------------------
                {
                    Console.Clear();
                    Console.SetCursorPosition(10, 2);
                    Console.WriteLine("Player X Wins!!!");
                    break;
                }
                else if (pos[0, 1] == "O" && pos[1, 1] == "O" && pos[2, 1] == "O")
                {
                    Console.Clear();
                    Console.SetCursorPosition(10, 2);
                    Console.WriteLine("Player O Wins!!!");
                    break;
                }
                else if (pos[0, 2] == "O" && pos[1, 2] == "O" && pos[2, 2] == "O")
                {
                    Console.Clear();
                    Console.SetCursorPosition(10, 2);
                    Console.WriteLine("Player O Wins!!!");
                    break;
                }
                















            }

        }
    }
}
