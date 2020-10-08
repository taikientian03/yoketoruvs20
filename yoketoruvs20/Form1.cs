using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace yoketoruvs20
{
    public partial class Form1 : Form
    {
        const bool isDebug = true;

        const int PlayerMax = 1;
        const int EnemyMax = 10;
        const int ItemMax = 10;
        const int CherMax = PlayerMax + EnemyMax + ItemMax;
        Label[] chrs = new Label[CherMax];
        const int PlayerIndex = 0;
        const int EnemyIndex = PlayerIndex + PlayerMax;
        const int ItemIndex = EnemyIndex + EnemyMax;

        const string PlayerText = "●";
        const string EnemyText="◆";
        const string ItemText = "★";

        static Random rand = new Random();


        enum State
        {
            None = -1,  // 無効
            Title,      // タイトル
            Game,       // ゲーム
            Gameover,   // ゲームオーバー
            Clear       // クリア
        }
        State currentState = State.None;
        State nextState = State.Title;

        const int SpeedMax = 20;
        int[] vx = new int[CherMax];
        int[] vy = new int[CherMax];

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        public Form1()
        {
            InitializeComponent();

            vx[CherMax] = rand.Next(-SpeedMax, SpeedMax);
            vy[CherMax] = rand.Next(--SpeedMax, SpeedMax);
            for (int i = 0; i < CherMax; i++)
            {
                chrs[i] = new Label();
                chrs[i].AutoSize = true;
                if (i == PlayerIndex)
                {
                    chrs[i].Text = PlayerText;
                }
                else if (i < ItemIndex)
                {
                    chrs[i].Text = EnemyText;
                }
                else
                {
                    chrs[i].Text = ItemText;
                }
                chrs[i].Font = TempLabel.Font;
                Controls.Add(chrs[i]);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (nextState != State.None)
            {
                initProc();
            }

            if (isDebug)
            {
                if (GetAsyncKeyState((int)Keys.O) < 0)
                {
                    nextState = State.Gameover;
                }
                else if (GetAsyncKeyState((int)Keys.C) < 0)
                {
                    nextState = State.Clear;
                }
            }

            if(currentState==State.Game)
            {
                UpdateGame();
            }
        }

        void UpdateGame()
        {
            Point mp = PointToClient(MousePosition);

            //TODO; mpがプレイヤーの中心になるように設定
            chrs[PlayerIndex].Left = mp.X; - chrs[PlayerIndex].Width / 2;
            chrs[PlayerIndex].Top = mp.Y; - chrs[PlayerIndex].Height / 2;

            for(int i=EnemyIndex;i<CherMax;i++)
            {
                chrs[i].Left += vx[i];
                chrs[i].Top += vy[i];

                if(chrs[i].Left<0)
                {
                    vx[i] = Math.Abs(vx[i]);
                }
                if(chrs[i].Top<0)
                {
                    vy[i] = Math.Abs(vx[i]);
                }
                if(chrs[i].Right<ClientSize.Width)
                {
                    vx[i] = Math.Abs(vx[i]);
                }
                if(chrs[i].Bottom>ClientSize.Height)
                {
                    vy[i] = Math.Abs(vx[i]);
                }
                //当たり判定
                if(  (mp.X>=chrs[i].Left)
                    && (mp.X<chrs[i].Right)
                    &&(mp.Y>=chrs[i].Top)
                    &&(mp.Y<chrs[i].Bottom)
                    )
                {
                    //MessageBox.Show("あたった!");
                    //敵か?

                    if(i<ItemIndex)
                    //if(chrs[i].Text== EnemyText)
                    {
                        nextState = State.Gameover;
                    }
                    else
                    {
                        //　アイテム
                        chrs[i].Visible = false;
                    }
                }
            }
        }
        
        void initProc()
        {
            currentState = nextState;
            nextState = State.None;

            switch (currentState)
            {
                case State.Title:
                    titleLabel.Visible = true;
                    startButton.Visible = true;
                    copyrightLabel.Visible = true;
                    hiLabel.Visible = true;
                    gameOverLabel.Visible = false;
                    titleButton.Visible = false;
                    clearLabel.Visible = false;
                    break;

                case State.Game:
                    titleLabel.Visible = false;
                    startButton.Visible = false;
                    copyrightLabel.Visible = false;
                    hiLabel.Visible = false;

                    for(int i=EnemyIndex; i<CherMax; i++)
                    {
                        chrs[i].Left = rand.Next(ClientSize.Width - chrs[i].Width);
                        chrs[i].Top = rand.Next(ClientSize.Height - chrs[i].Height);
                        vx[i] = rand.Next(-SpeedMax, SpeedMax + 1);
                        vy[i] = rand.Next(-SpeedMax, SpeedMax + 1);
                    }

                    break;


                case State.Gameover:
                    gameOverLabel.Visible = true;
                    titleButton.Visible = true;
                    break;

                case State.Clear:
                    clearLabel.Visible = true;
                    titleButton.Visible = true;
                    hiLabel.Visible = true;
                    break;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }

        private void titleButton_Click(object sender, EventArgs e)
        {
            nextState = State.Title;
        }
    }
}
