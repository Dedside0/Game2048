using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game2048
{
    public partial class FormGame : Form
    {
        int len = DataBase.len;
        static int[,] gameField;
        static int[,] savedField;
        static int[] values = new int[100];
        static int maxValue = 4;

        public FormGame()
        {
            InitializeComponent();
            gameField = new int[len, len];
            savedField = new int[len, len];
        }

            
        private void FormGame_Load(object sender, EventArgs e)
        {
            this.Location = new Point(500, 200);

            int iii = 2;
            for (int i = 0; i < 100; i++)
            {
                values[i] = iii;
                iii *= 2;
            }

            for (int i = 0; i <len; i++)
            {
                dataGridViewGameField.RowCount = len;
                dataGridViewGameField.ColumnCount = len;
                dataGridViewGameField.Rows[i].Height = dataGridViewGameField.Columns[i].Width;

            }

            NewGame();

            labelRecord.Text = "0";
        }

        
        private void dataGridViewGameField_KeyDown_1(object sender, KeyEventArgs e)
        {
            string key = e.KeyCode.ToString().ToLower();
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    savedField[i, j] = gameField[i, j];
                }
            }

            switch (key)
            {
                case ("w"):
                case ("up"): UpStep(); GenerateNum(); ; break;
                case ("s"):
                case ("down"): DownStep(); GenerateNum(); ; break;
                case ("d"):
                case ("right"): RightStep(); GenerateNum(); ; break;
                case ("a"):
                case ("left"): LeftStep(); GenerateNum(); ; break;
            }
            if (!haveEmptySlot() && isEnd())
            {
                ShowField();
                MessageBox.Show("Ты проиграл! \nТы набрал : " + maxValue + " очков");
                NewGame();
            }
            ShowField();
            labelScore.Text = maxValue.ToString();
        }


        


        bool isEnd()
        {
            int[,] temp = new int[len, len];
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    temp[i, j] = gameField[i, j];
                }
            }
            RightStep();
            LeftStep();
            UpStep();
            DownStep();
            if(haveEmptySlot())
            {
                for (int i = 0; i < len; i++)
                {
                    for (int j = 0; j < len; j++)
                    {
                        gameField[i, j] = temp[i, j];
                    }
                }
                return false;
            }
            return true;
            
        }


        void RightStep()
        {
            for (int i = 0; i < len; i++)
                for (int j = len - 2; j >= 0; j--)
                    if (gameField[i, j] != 0) 
                    {
                        int tempj = j;
                        while (tempj < len - 1 && gameField[i, tempj + 1] == 0)
                        {
                            gameField[i, tempj + 1] = gameField[i, tempj];
                            gameField[i, tempj] = 0;
                            tempj++;
                        }

                        if (tempj < len - 1 && gameField[i, tempj + 1] == gameField[i, tempj])
                        {
                            gameField[i, tempj + 1] += gameField[i, tempj];
                            gameField[i, tempj] = 0;

                            maxValue = Math.Max(maxValue, gameField[i, tempj + 1]);
                        }
                    }

        }


        void LeftStep()
        {
            for (int i = 0; i < len; i++) 
                for (int j = 1; j < len; j++)
                    if (gameField[i, j] != 0)
                    {
                        int tempj = j;

                        while (tempj > 0 && gameField[i, tempj - 1] == 0)
                        {
                            gameField[i, tempj - 1] = gameField[i, tempj];
                            gameField[i, tempj] = 0;
                            tempj--;
                        }

                        if (tempj > 0 && gameField[i, tempj - 1] == gameField[i, tempj])
                        {
                            gameField[i, tempj - 1] += gameField[i, tempj];
                            gameField[i, tempj] = 0;

                            maxValue = Math.Max(maxValue, gameField[i, tempj - 1]);
                        }
                    }
        }

        void DownStep()
        {
            for (int j = 0; j < len; j++) 
                for (int i = len - 2; i >= 0; i--) 
                    if (gameField[i, j] != 0) 
                    {
                        int tempi = i;

                        while (tempi < len - 1 && gameField[tempi + 1, j] == 0)
                        {
                            gameField[tempi + 1, j] = gameField[tempi, j];
                            gameField[tempi, j] = 0;
                            tempi++;
                        }

                        if (tempi < len - 1 && gameField[tempi + 1, j] == gameField[tempi, j])
                        {
                            gameField[tempi + 1, j] += gameField[tempi, j];
                            gameField[tempi, j] = 0;

                            maxValue = Math.Max(maxValue, gameField[tempi + 1, j]);
                        }
                    }
        }


        void UpStep()
        {
            for (int j = 0; j < len; j++) 
                for (int i = 1; i < len; i++) 
                    if (gameField[i, j] != 0) 
                    {
                        int tempi = i;

                        
                        while (tempi > 0 && gameField[tempi - 1, j] == 0)
                        {
                           
                            gameField[tempi - 1, j] = gameField[tempi, j];
                            gameField[tempi, j] = 0;
                            tempi--;
                        }

                        
                        if (tempi > 0 && gameField[tempi - 1, j] == gameField[tempi, j])
                        {
                            gameField[tempi - 1, j] += gameField[tempi, j];
                            gameField[tempi, j] = 0;

                            maxValue = Math.Max(maxValue, gameField[tempi - 1, j]);
                        }
                    }
        }


        void GenerateNum()
        {
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    if (dataGridViewGameField[j, i].Style.BackColor == Color.AntiqueWhite)
                        dataGridViewGameField[j, i].Style.BackColor = Color.FromKnownColor(KnownColor.Window);
                }
            }
            if (haveEmptySlot())
            {
                Random rnd = new Random();
                int i = rnd.Next(len);
                int j = rnd.Next(len);
                while (gameField[i, j] != 0)
                {
                    i = rnd.Next(len);
                    j = rnd.Next(len);
                }
                if (FindStepen(maxValue) > 4)
                    gameField[i, j] = values[rnd.Next(FindStepen(maxValue / 128), FindStepen(maxValue) - 2)];
                else
                    gameField[i, j] = values[rnd.Next(FindStepen(maxValue / 128), FindStepen(maxValue) - 0)];
                dataGridViewGameField[j, i].Style.BackColor =  Color.AntiqueWhite;

            }
        }


        bool haveEmptySlot()
        {
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    if (gameField[i, j] == 0)
                        return true;
                }
            }
            return false;
        }


        void NewGame()
        {
            gameField = new int[len,len];
            DataBase.record = Math.Max(maxValue, DataBase.record);
            maxValue = 4;
            GenerateNum();
            labelRecord.Text = DataBase.record.ToString();
            ShowField();
        }


        void ShowField()
        {
            for (int i = 0; i < len; i++)
                for (int j = 0; j < len; j++)
                    if (gameField[i, j] == 0)
                        dataGridViewGameField[j, i].Value = null;
                    else
                        dataGridViewGameField[j, i].Value = gameField[i, j];
        }


        int FindStepen(int a)
        {
            int res = 1;
            int temp = 2;
            while (temp < a)
            {
                temp *= 2;
                res++;
            }
            return res;
        }


       
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Forms.MENU.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    gameField[i, j] = savedField[i, j];
                }
            }
            ShowField();
        }
    }
}
