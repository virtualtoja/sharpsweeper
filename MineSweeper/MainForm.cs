using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public List<MineBtn> buttons = new List<MineBtn>();
        public string[,] board = new string[0,0];

        public int mineCount = 8;

        public void StartNewGame()
        {
            panelGame.Controls.Clear();
            board = new string[8, 8];
            GenerateBoard();
            GenerateButtons();
        }

        public void GenerateButtons()
        {
            for(int y = 0; y < 7; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    MineBtn btn = new MineBtn();

                    btn.Size = new Size(panelGame.Width / 8, panelGame.Height / 8);
                    btn.Text = " ";

                    btn.Location = new Point(panelGame.Width / 8 * x, panelGame.Height / 8 * y);
                    btn.Click += Btn_Click;
                    btn.MouseMove += Btn_MouseHover;

                    btn.x = x;
                    btn.y = y;

                    buttons.Add(btn);
                    panelGame.Controls.Add(btn);
                }
            }
        }

        private void Btn_MouseHover(object sender, EventArgs e)
        {
            if(hint)
            {
                MineBtn btn = sender as MineBtn;

                int x = btn.x;
                int y = btn.y;

                labelC.Text = (board[x, y] == "*").ToString();
            }
        }

        int counter = 0;
        bool playing = true;

        private void Btn_Click(object sender, EventArgs e)
        {
            if (playing == false) return;

            MineBtn btn = sender as MineBtn;
            btn.Text = board[btn.x, btn.y];
            if (!btn.clicked)
            {
                counter++;
                btn.clicked = true;
            }

            if (btn.Text == "*")
            {
                foreach (MineBtn bt in buttons) 
                {
                    bt.Text = board[bt.x, bt.y];
                    bt.Enabled = false;
                }
                counter = 0;
            }
            else if (btn.Text == " ")
            {
                btn.Enabled = false;
            }

            if (debug) labelD.Text = counter.ToString();
            if (counter == 41)
            {
                foreach (MineBtn bt in buttons)
                {
                    bt.Text = board[bt.x, bt.y];
                    bt.Enabled = true;
                }
                MessageBox.Show("You won!");
                playing = false;
            }
        }

        public void GenerateBoard()
        {
            for (int i = 0; i < mineCount; i++)
            {
                Randomize:
                int x = new Random(new Random().Next()).Next(0, 7);
                int y = new Random(new Random().Next()).Next(0, 7);

                if (board[x, y] == "*" || (x == 0 && y == 0)) goto Randomize;

                board[x, y] = "*";
            }

            List<Point> minePositions = new List<Point>();

            int GenerateNumber(int x, int y)
            {
                int mines = 0;

                if (x != 0 && board[x - 1, y] == "*") mines++;
                if (x != 7 && board[x + 1, y] == "*") mines++;
                if (y != 7 && board[x, y + 1] == "*") mines++;
                if (y != 0 && board[x, y - 1] == "*") mines++;
                if (x != 0 && y != 0 && board[x - 1, y - 1] == "*") mines++;
                if (x != 0 && y != 7 && board[x - 1, y + 1] == "*") mines++;
                if (x != 7 && y != 7 && board[x + 1, y + 1] == "*") mines++;
                if (x != 7 && y != 0 && board[x + 1, y - 1] == "*") mines++;

                return mines;
            }

            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 7; y++)
                {
                    if (board[x, y] == "*")
                        minePositions.Add(new Point(x, y));
                    else
                    {
                        int m = GenerateNumber(x, y);
                        string mm = m.ToString();

                        if (mm == "0") mm = " ";

                        board[x, y] = mm;
                    }
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void aboutMinesweeperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private void showBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string response = "";

            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 7; y++)
                {
                    string str = board[x, y];
                    if (str == " ") str = "0 ";
                    else str += " ";
                    response += str;
                }
                response += "\n";
            }

            MessageBox.Show(response);
        }

        bool hint = false;
        bool debug = false;

        private void showHintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hint = true;
            labelC.Visible = true;
        }

        private void showMinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(MineBtn btn in buttons)
            {
                if (board[btn.x, btn.y] == "*")
                    btn.Text = "*";
            }
        }

        private void showDebugInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            debug = true;
            labelD.Visible = true;
        }

        private void disableMineButtonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (MineBtn btn in buttons)
            {
                if (board[btn.x, btn.y] == "*")
                    btn.Enabled = false;
            }
        }
    }
}
