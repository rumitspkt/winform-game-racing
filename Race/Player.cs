using System.Drawing;

namespace Race
{
    class Player : IDriveable
    {
        private int x, y;
        public int width, height;                                                
        private static Image player_texture = Properties.Resources.Player_texture;
        public int X
        {
            get
            {
                return x;
            }
            set
            {           
                if (value < 0)
                    value = 0;
                else if (value > (180 - width))
                    value = 180 - width;
                else
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
                else if (value > (320 - height))
                    value = 320 - height;
                else
                    y = value;
            }
        }
        public Player(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            this.width = width;
            this.height = height;
        }
        public void Acceleration(params object[] dir)
        {
            Direction direction = (Direction)dir[0];
            if(direction == Direction.Up)
            {
                Y -= 10;
            }
            if (direction == Direction.Down)
            {
                Y += 10;
            }
        }
        public void Turn(params object[] dir)
        {
            Direction direction = (Direction)dir[0];
            if(direction == Direction.Left)
            {
                X -= width;
            }
            if (direction == Direction.Right)
            {
                X += width;
            }
        }
        public void DrawPlayer(Player player, Graphics g)
        {
            g.DrawImage(player_texture, player.X, player.Y, player.width, player.height);
        }
    }

}