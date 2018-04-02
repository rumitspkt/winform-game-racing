using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Race
{ 
    public partial class Form1 : Form
    {
        public Form1(Form0 f0)
        {
            this.f0 = f0;
            InitializeComponent();  
        }
        Form0 f0;
        bool pause = true;                    
        int game_speed = 400;                  
        Levels level = new Levels();           
        Thread rival_thread;                   
        Player p = new Player(60, 160, 60, 80);
        Rival r1 = new Rival(0, 1, 60, 80);    
        Rival r2 = new Rival(120, 1, 60, 80);  
        Pen pen = new Pen(Color.Gray, 2.55f);  
        int score;

        public Levels Level
        {
            get
            {
                return level;
            }
            set
            {
                level = value;
            }
        }
        public void GetScore(Levels Level, ref int score)
        {
            switch (Level)
            {
                case Levels.Easy:
                    score += 15;
                    break;
                case Levels.Medium:
                    score += 25;
                    break;
                case Levels.Hard:
                    score += 35;
                    break;
            }
        }
        public void Check()
        {
            switch(Level)
            {
                case Levels.Easy:
                    if (game_speed <= 300)
                        Level = Levels.Medium;
                    break;
                case Levels.Medium:
                    if (game_speed <= 125)
                        Level = Levels.Hard;
                    break;
            }
            if (((p.X == r1.X) && (((p.Y >= r1.Y) && (p.Y <= (r1.Y + r1.height))) || (((p.Y + p.height) >= r1.Y) && ((p.Y + p.height) <= (r1.Y + r1.height))))) || ((p.X == r2.X) && (((p.Y >= r1.Y) && (p.Y <= (r2.Y + r2.height))) || (((p.Y + p.height) >= r2.Y) && ((p.Y + p.height) <= (r2.Y + r2.height))))))
            {
                GameOver();
                pause = true;
                MessageBox.Show("Thua rồi!!");
            }
            else if (((p.Y >= r1.Y) && (p.Y <= (r1.Y + r1.height))) || ((p.Y >= r2.Y) && (p.Y <= (r2.Y + r2.height))))
                GetScore(Level, ref score);
        }
        void GameOver()
        {
            r1.Y = 0;
            r2.Y = 0;
            p.X = 60;
            p.Y = 160;
            Level = Levels.Easy;
            game_speed = 400;
         score = 0;  
        }
        private void Pause()
        {
            if (pause == true)
            {
                pause = false;
                rival_thread = new Thread(Game);
                rival_thread.Start();      
            }
            else if (pause == false)
            {
                pause = true;
                rival_thread.Abort();               
            }
        }
        private void Game()
        {
            RivalControl riv_con = new RivalControl(r1.Acceleration);
            riv_con += r1.Turn;
            while(!pause)
            {
                Check();
                Thread.Sleep(game_speed);
                riv_con(r1, r2);
                game_speed -= (1 * (int)Level);
                if (game_speed <= 25)
                    game_speed = 25;
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            if (rival_thread != null)
                rival_thread.Abort();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Rival.DrawRival(e.Graphics, r1, r2);
            p.DrawPlayer(p, e.Graphics);
            e.Graphics.DrawLine(pen, 0, 0, 180, 0);
            e.Graphics.DrawLine(pen, 0, 0, 0, 320);
            e.Graphics.DrawLine(pen, 180, 0, 180, 320);
            e.Graphics.DrawLine(pen, 60, 0, 60, 320);
            e.Graphics.DrawLine(pen, 120, 0, 120, 320);
            e.Graphics.DrawLine(pen, 0, 320, 180, 320);
            Lvl_Lbl.Text = "Độ khó: " + Level;
            Lvl_Lbl.Update();
            score_label.Text = "Điểm: " + score.ToString();
            score_label.Update();
            if (pause == false)
                Invalidate();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (pause == false)
            {
                switch (e.KeyData)
                {
                    case Keys.S:
                        p.Acceleration(Direction.Down);
                        break;
                    case Keys.W:
                        p.Acceleration(Direction.Up);
                        break;
                    case Keys.A:
                        p.Turn(Direction.Left);
                        break;
                    case Keys.D:
                        p.Turn(Direction.Right);
                        break;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Pause();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (pause == false)
                Pause();
            Hide();
            f0.Show();
        }
    }
}