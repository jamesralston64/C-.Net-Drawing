using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeDrawing
{
    public partial class Form1 : Form
    {
        private int width;
        private int height;
        private Image xImage = new Bitmap("../../playX.png");
        private Image O = new Bitmap("../../playO.png");
        private int[,] board = new int[3, 3];
        private int turn = 1;
        private int gameType;
        Random coin = new Random();
        private int player1Count = 0;
        private int player2Count = 0;

        public Form1()
        {
            InitializeComponent();
            startGame();
        }


        private int coinToss()
        {
            int num;
            num = coin.Next(1,2);

            if(num == 1)
            {
                headsOrTails.Text = "The Coin Toss Was\n Heads";
            }

            if(num == 2)
            {
                headsOrTails.Text = "The Coin Toss Was\n Tails";
            }
            return num;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen black = new Pen(Color.Black, 3);
            width = this.Width = 600;
            height = this.Height;

            drawBoard(g, 0, 0, width);

            base.OnPaint(e);
        }

        private void drawBoard(Graphics g, int x, int y, int width)
        {
            Pen black = new Pen(Color.Black, 6);

            //vertical lines
            g.DrawLine(black, width / 3 + x, y, width / 3 + x, y + width);
            g.DrawLine(black, width / 3 * 2 + x, y, width / 3 * 2 + x, y + width);
            g.DrawLine(black, width / 3 * 3 + x, y, width / 3 * 3 + x, y + width);

            //horizontal lines
            g.DrawLine(black, x, width / 3 + y, x + width, width / 3 + y);
            g.DrawLine(black, x, width / 3 * 2 + y, x + width, width / 3 * 2 + y);
            g.DrawLine(black, x, width / 3 * 3 + y, x + width, width / 3 * 3 + y);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            int xLocation = e.X;
            int yLocation = e.Y;

            if(gameType == 1)
            {
                if (turn == 1)
                {
                    playerTurn.Text = "Player 1 Turn!";
                }
                else
                {
                    playerTurn.Text = "Computer Player Turn!";
                }
                play1Player(xLocation, yLocation);
            }

            if (gameType == 2)
            {
                if(turn == 2)
                {
                    playerTurn.Text = "Player 1 Turn!";
                }
                else
                {
                    playerTurn.Text = "Player 2 Turn!";
                }

                playGame2Player(xLocation, yLocation);
            }

        }

        private void DrawX(int x, int y)
        {
            //Pen red = new Pen(Color.Red, 10);
            Graphics g = this.CreateGraphics();

            //g.DrawLine(red, x, y, 10-10/2, 10-10/2);
            //g.DrawLine(red, x, 10-10/2, 10-10/2, y);

            g.DrawImage(xImage, x - xImage.Width / 2, y - xImage.Height / 2);

            //red.Dispose();

        }

        private void DrawO(int x, int y)
        {
            Graphics g = this.CreateGraphics();

            g.DrawImage(O, x - O.Width / 2, y - O.Height / 2);
        }

        private void startGame()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = 0;
                }
            }

            player1.Enabled = true;
            player2.Enabled = true;

            if (turn == 1)
            {
                playerTurn.Text = "Player 1 Turn!";
            }
            else
            {
                playerTurn.Text = "Computer Player Turn!";
            }


            turn = coinToss();

            p1Score.Text = player1Count.ToString();
            p2Score.Text = player2Count.ToString();

            Invalidate();

            /*if(turn == 2 && gameType == 1)
            {
                computer();
            }*/
        }

        private void play1Player(int xLocation, int yLocation)
        {
                if (xLocation > 0 && xLocation < 200 && yLocation > 0 && yLocation < 200 && board[0, 0] == 0)
                {
                    if (turn == 1)
                    {
                        DrawX(100, 100);
                        board[0, 0] = 1;
                        checkWinner();
                        computer();
                        turn = 2;
                    }//end if

                if (turn == 2)
                {
                    computer();
                    DrawX(100, 100);
                    board[0, 0] = 1;
                    checkWinner();
                    turn = 2;
                }//end if

                }

                if (xLocation > 200 && xLocation < 400 && yLocation > 0 && yLocation < 200 && board[1, 0] == 0)
                {
                    if (turn == 1)
                    {
                        DrawX(300, 100);
                        board[1, 0] = 1;
                        checkWinner();
                        computer();
                        turn = 2;
                    }//end if

                if (turn == 2)
                {
                    computer();
                    DrawX(300, 100);
                    board[1, 0] = 1;
                    checkWinner();
                    turn = 2;
                }//end if



                }

                if (xLocation > 400 && xLocation < 600 && yLocation > 0 && yLocation < 200 && board[2, 0] == 0)
                {
                    if (turn == 1)
                    {
                        DrawX(500, 100);
                        board[2, 0] = 1;
                        checkWinner();
                        computer();
                        //turn = 2;
                    }//end if

                if (turn == 2)
                {
                    computer();
                    DrawX(500, 100);
                    board[2, 0] = 1;
                    checkWinner();

                    //turn = 2;
                }//end if



                }

                if (xLocation > 0 && xLocation < 200 && yLocation > 200 && yLocation < 400 && board[0, 1] == 0)
                {
                    if (turn == 1)
                    {
                        DrawX(100, 300);
                        board[0, 1] = 1;
                        checkWinner();
                        computer();
                        //turn = 2;
                    }//end if

                    if (turn == 2)
                    {
                        computer();
                        DrawX(100, 300);
                        board[0, 1] = 1;
                        checkWinner();

                        //turn = 2;
                    }//end if


                }

                if (xLocation > 200 && xLocation < 400 && yLocation > 200 && yLocation < 400 && board[1, 1] == 0)
                {
                    if (turn == 1)
                    {
                        DrawX(300, 300);
                        board[1, 1] = 1;
                        checkWinner();
                        computer();
                       // turn = 2;
                    }//end if

                if (turn == 2)
                {
                    computer();
                    DrawX(300, 300);
                    board[1, 1] = 1;
                    checkWinner();
                    //turn = 2;
                }//end if



                }

                if (xLocation > 400 && xLocation < 600 && yLocation > 200 && yLocation < 400 && board[2, 1] == 0)
                {
                    if (turn == 1)
                    {
                        DrawX(500, 300);
                        board[2, 1] = 1;
                        checkWinner();
                        computer();
                        //turn = 2;
                    }//end if

                if (turn == 2)
                {
                    computer();
                    DrawX(500, 300);
                    board[2, 1] = 1;
                    checkWinner();

                   // turn = 2;
                }//end if


                }

                if (xLocation > 0 && xLocation < 200 && yLocation > 400 && yLocation < 600 && board[0, 2] == 0)
                {
                    if (turn == 1)
                    {
                        DrawX(100, 500);
                        board[0, 2] = 1;
                        checkWinner();
                        computer();
                        //turn = 2;
                    }//end if

                if (turn == 2)
                {
                    computer();
                    DrawX(100, 500);
                    board[0, 2] = 1;
                    checkWinner();
                    //turn = 2;
                }//end if



             
                }

                if (xLocation > 200 && xLocation < 400 && yLocation > 400 && yLocation < 600 && board[1, 2] == 0)
                {
                    if (turn == 1)
                    {
                        DrawX(300, 500);
                        board[1, 2] = 1;
                        checkWinner();
                        computer();
                        //turn = 2;
                    }//end if

                if (turn == 2)
                {
                    computer();
                    DrawX(300, 500);
                    board[1, 2] = 1;
                    
                    //turn = 2;
                    checkWinner();
                }//end if



                }

                if (xLocation > 400 && xLocation < 600 && yLocation > 400 && yLocation < 600 && board[2, 2] == 0)
                {
                    if (turn == 1)
                    {
                        DrawX(500, 500);
                        board[2, 2] = 1;
                        checkWinner();
                        computer();
                        //turn = 2;
                    }//end if

                if (turn == 2)
                {
                    computer();
                    DrawX(500, 500);
                    board[2, 2] = 1;                    
                    //turn = 2;
                    checkWinner();
                }//end if

                
                }

                String click = xLocation.ToString() + ", " + yLocation.ToString();


                //MessageBox.Show(click);
            
        }

        private void check1Diagonals()
        {
            int p1 = 0;
            int p2 = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j && board[j, i] == 1)
                    {
                        p1 += 1;
                    }//end if

                    if (i == j && board[j, i] == 2)
                    {
                        p2 += 1;
                    }//end if

                    if (p1 == 3)
                    {
                        MessageBox.Show("Player Wins!\n\nClick ok to reset the board");
                        player1Count += 1;
                        startGame();
                        break;
                    }//end if

                    if (p2 == 3)
                    {
                        MessageBox.Show("Player 2 Wins!\n\nClick ok to reset the board");
                        player2Count += 1;
                        startGame();
                        break;
                    }//end if
                }//end for j

            }//end for i

        }//end check diagonals

        private void check2Diagonals()
        {
            int p1 = 0;
            int p2 = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i + j == 2 && board[j, i] == 1)
                    {
                        p1 += 1;
                    }//end if

                    if (i + j == 2 && board[j, i] == 2)
                    {
                        p2 += 1;
                    }//end if

                    if (p1 == 3)
                    {
                        MessageBox.Show("Player Wins!\n\nClick ok to reset the board");
                        player1Count += 1;
                        startGame();
                        break;
                    }//end if

                    if (p2 == 3)
                    {
                        MessageBox.Show("Player 2 Wins!\n\nClick ok to reset the board");
                        player2Count += 1;
                        startGame();
                        break;
                    }//end if
                }//end for j

            }//end for i
        }

        private void checkRows()
        {
            int p1 = 0;
            int p2 = 0;

            for (int i = 0; i < 3; i++)
            {
                p1 = 0;
                p2 = 0;

                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == 1)
                    {
                        p1 += 1;
                    }//end if

                    if (board[i, j] == 2)
                    {
                        p2 += 1;
                    }//end if

                    if (p1 == 3)
                    {
                        MessageBox.Show("Player Wins!\n\nClick ok to reset the board");
                        player1Count += 1;
                        startGame();
                        break;
                    }//end if

                    if (p2 == 3)
                    {
                        MessageBox.Show("Player 2 Wins!\n\nClick ok to reset the board");
                        player2Count += 1;
                        startGame();
                        break;
                    }//end if
                }//end for j
            }//end for i
        }//end checkRows

        private void checkWinner()
        {
            checkColumns();
            check1Diagonals();
            check2Diagonals();
            checkRows();
        }

        private void checkColumns()
        {
            int p1 = 0;
            int p2 = 0;

            for (int i = 0; i < 3; i++)
            {
                p1 = 0;
                p2 = 0;

                for (int j = 0; j < 3; j++)
                {
                    if (board[j, i] == 1)
                    {
                        p1 += 1;
                    }//end if

                    if (board[j, i] == 2)
                    {
                        p2 += 1;
                    }//end if

                    if (p1 == 3)
                    {
                        MessageBox.Show("Player Wins!\n\nClick ok to reset the board");
                        player1Count += 1;
                        startGame();
                        break;
                    }//end if

                    if (p2 == 3)
                    {
                        MessageBox.Show("Player 2 Wins!\n\nClick ok to reset the board");
                        player2Count += 1;
                        startGame();
                        break;
                    }//end if
                }//end for j
            }//end for i
        }//end check columns

        private void computer()
        {
            Boolean played = false;
            Random r = new Random();
            int num = r.Next(0, 8);

            while (played == false)
            {
                if (num == 0 && board[0, 0] == 0)
                {
                   DrawO(100, 100);
                   board[0, 0] = 2;
                   turn = 1;
                   played = true;
                }//end if

                else if(num == 1 && board[1, 0] == 0)
                {
                    DrawO(300, 100);
                    board[1,0] = 2;
                    turn = 1;
                    played = true;
                }

                else if (num == 2 && board[2, 0] == 0)
                {
                    DrawO(500, 100);
                    board[2, 0] = 2;
                    turn = 1;
                    played = true;
                }

                else if (num == 3 && board[0, 1] == 0)
                {
                    DrawO(100, 300);
                    board[0, 1] = 2;
                    turn = 1;
                    played = true;
                }

                else if (num == 4 && board[1, 1] == 0)
                {
                    DrawO(300, 300);
                    board[1, 1] = 2;
                    turn = 1;
                    played = true;
                }

                else if (num == 5 && board[2, 1] == 0)
                {
                    DrawO(500, 300);
                    board[2, 1] = 2;
                    turn = 1;
                    played = true;
                }

                else if (num == 6 && board[0, 2] == 0)
                {
                    DrawO(100, 500);
                    board[0, 2] = 2;
                    turn = 1;
                    played = true;
                }

                else if (num == 7 && board[1, 2] == 0)
                {
                    DrawO(300, 500);
                    board[1, 2] = 2;
                    turn = 1;
                    played = true;
                    
                }

                else if (num == 8 && board[2, 2] == 0)
                {
                    DrawO(500, 500);
                    board[2, 2] = 2;
                    turn = 1;
                    played = true;
                    
                }

                else
                {
                    num = r.Next(0, 8);
                }
                checkWinner();

            }//end while
        }

        private void playGame2Player(int xLocation, int yLocation)
        {
            if (xLocation > 0 && xLocation < 200 && yLocation > 0 && yLocation < 200 && board[0, 0] == 0)
            {
                if (turn == 1)
                {
                    DrawX(100, 100);
                    board[0, 0] = 1;
                    turn = 2;
                }//end if

                else
                {
                    DrawO(100, 100);
                    board[0, 0] = 2;
                    turn = 1;
                }//end else

                checkWinner();
            }

            if (xLocation > 200 && xLocation < 400 && yLocation > 0 && yLocation < 200 && board[1, 0] == 0)
            {
                if (turn == 1)
                {
                    DrawX(300, 100);
                    board[1, 0] = 1;
                    turn = 2;
                }//end if

                else
                {
                    DrawO(300, 100);
                    board[1, 0] = 2;
                    turn = 1;
                }////////////end else

                checkWinner();
            }

            if (xLocation > 400 && xLocation < 600 && yLocation > 0 && yLocation < 200 && board[2, 0] == 0)
            {
                if (turn == 1)
                {
                    DrawX(500, 100);
                    board[2, 0] = 1;
                    turn = 2;
                }//end if

                else
                {
                    DrawO(500, 100);
                    board[2, 0] = 2;
                    turn = 1;
                }//end else

                checkWinner();
            }

            if (xLocation > 0 && xLocation < 200 && yLocation > 200 && yLocation < 400 && board[0, 1] == 0)
            {
                if (turn == 1)
                {
                    DrawX(100, 300);
                    board[0, 1] = 1;
                    turn = 2;
                }//end if

                else
                {
                    DrawO(100, 300);
                    board[0, 1] = 2;
                    turn = 1;
                }//end else

                checkWinner();
            }

            if (xLocation > 200 && xLocation < 400 && yLocation > 200 && yLocation < 400 && board[1, 1] == 0)
            {
                if (turn == 1)
                {
                    DrawX(300, 300);
                    board[1, 1] = 1;
                    turn = 2;
                }//end if

                else
                {
                    DrawO(300, 300);
                    board[1, 1] = 2;
                    turn = 1;
                }//end else

                checkWinner();
            }

            if (xLocation > 400 && xLocation < 600 && yLocation > 200 && yLocation < 400 && board[2, 1] == 0)
            {
                if (turn == 1)
                {
                    DrawX(500, 300);
                    board[2, 1] = 1;
                    turn = 2;
                }//end if

                else
                {
                    DrawO(500, 300);
                    board[2, 1] = 2;
                    turn = 1;
                }//end else

                checkWinner();
            }

            if (xLocation > 0 && xLocation < 200 && yLocation > 400 && yLocation < 600 && board[0, 2] == 0)
            {
                if (turn == 1)
                {
                    DrawX(100, 500);
                    board[0, 2] = 1;
                    turn = 2;
                }//end if

                else
                {
                    DrawO(100, 500);
                    board[0, 2] = 2;
                    turn = 1;
                }//end else

                checkWinner();
            }

            if (xLocation > 200 && xLocation < 400 && yLocation > 400 && yLocation < 600 && board[1, 2] == 0)
            {
                if (turn == 1)
                {
                    DrawX(300, 500);
                    board[1, 2] = 1;
                    turn = 2;
                }//end if

                else
                {
                    DrawO(300, 500);
                    board[1, 2] = 2;
                    turn = 1;
                }//end else

                checkWinner();
            }

            if (xLocation > 400 && xLocation < 600 && yLocation > 400 && yLocation < 600 && board[2, 2] == 0)
            {
                if (turn == 1)
                {
                    DrawX(500, 500);
                    board[2, 2] = 1;
                    turn = 2;
                }//end if

                else
                {
                    DrawO(500, 500);
                    board[2, 2] = 2;
                    turn = 1;
                }//end else

                checkWinner();
            }

            String click = xLocation.ToString() + ", " + yLocation.ToString();


            //MessageBox.Show(click);
        }

        private void player1_Click(object sender, EventArgs e)
        {
            gameType = 1;
            player1.Enabled = false;
            player2.Enabled = false;
        }

        private void player2_Click(object sender, EventArgs e)
        {
            gameType = 2;

            player1.Enabled = false;
            player2.Enabled = false;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            startGame();
        }
    }
}
