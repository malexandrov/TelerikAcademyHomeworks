using System;

namespace Minesweeper
{
    public class Player
    {
        private string nickName;
        private int points;

        public string NickName
        {
            get { return this.nickName; }
            set { this.nickName = value; }
        }

        public int Points
        {
            get { return this.points; }
            set { this.points = value; }
        }

        public Player()
            : this(null, 0)
        {
        }

        public Player(string nickName, int points)
        {
            this.nickName = nickName;
            this.points = points;
        }
    }
}
