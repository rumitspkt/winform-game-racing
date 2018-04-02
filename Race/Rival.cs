using System;
using System.Drawing;

namespace Race
{
    class Rival : IDriveable
    {
        private int x = 0, y = 0;
        public int width, height;                                               
        private int[] x_spawns = { 0, 60, 120, 180 };                           
        private static Image rival_texture = Properties.Resources.Rival_texture;
        public int X
        {
            get
            {
                return x;
            }
            set
            { 
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {   
                if (value < 0)
                    value = 0;
                else
                    y = value;
            }
        }
        public Rival(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            this.width = width;
            this.height = height;
        }
        public void Acceleration(params object[] rivals)
        {
            foreach (Rival rival in rivals)
                rival.Y += 15;
        }
        public void Turn(params object[] rivals)
        {
            Rival[] r = new Rival[rivals.Length];
            for (int i = 0; i < rivals.Length; i++)
            {
                r[i] = (Rival)rivals[i];
            }
            if (r[0].Y > 400 && r[1].Y > 400)
            {
                Spawn(r);
                for (int i = 0; i < r.Length; i++)
                    r[i].Y = 0;
            }
            else
                return;                
        }
        public void Spawn(Rival[] rivals)
        {
            Random random = new Random();
            for (int i = 0; i < rivals.Length; i++)
            {
                rivals[i].X = x_spawns[random.Next(0, (x_spawns.Length - 1))];
            }
            if (rivals[0].X == rivals[1].X)
                Spawn(rivals);
            else
                return;
        }
        public static void DrawRival(Graphics g, params Rival[] rivals)
        {
            foreach (Rival rival in rivals)
                g.DrawImage(rival_texture, rival.X, rival.Y, rival.width, rival.height);
        }
    }
}