using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets
{
    class Player
    {
        private int locationX;
        private int locationY;
        private readonly String playerName;
        private readonly int width = 50;
        private readonly int height = 70;

        private int arrows;
        private int coins;
        private int turnsTaken;
        private int score;

        public Player(String name, int x, int y)
        {
            playerName = name;
            locationX = x;
            locationY = y;
        }

        public int GetX()
        {
            return locationX;
        }

        public int GetY()
        {
            return locationY;
        }

        public Boolean Overlap(int x, int y, int w, int h)
        {
            int ourUpperLeftX = locationX;
            int ourUpperLeftY = locationY;
            int ourLowerRightX = ourUpperLeftX + width;
            int ourLowerRightY = ourUpperLeftY + height;

            int otherUpperLeftX = x;
            int otherUpperLeftY = y;
            int otherLowerRightX = otherUpperLeftX + w;
            int otherLowerRightY = otherUpperLeftY + h;

            int overlapUpperLeftX = Math.Max(ourUpperLeftX, otherUpperLeftX);
            int overlapUpperLeftY = Math.Max(ourUpperLeftY, otherUpperLeftY);
            int overlapLowerRightX = Math.Min(ourLowerRightX, otherLowerRightX);
            int overlapLowerRightY = Math.Min(ourLowerRightY, otherLowerRightY);

            int overlapWidth = overlapLowerRightX - overlapUpperLeftX;
            int overlapHeight = overlapLowerRightY - overlapUpperLeftY;


            if (overlapWidth < 0 || overlapHeight < 0)
            {
                return false;
            }

            return true;
        }

        public String GetName()
        {
            return playerName;
        }

        public int GetArrows()
        {
            return arrows;
        }

        public void SetArrows(int value)
        {
            arrows = value;
        }

        public int GetCoins()
        {
            return coins;
        }

        public void SetCoins(int value)
        {
            coins = value;
        }

        public int GetTurns()
        {
            return turnsTaken;
        }

        public void SetTurns(int value)
        {
            turnsTaken = value;
        }

        public int Score
        {
            // add 50 if Wumpus is killed or not??
            get
            {
                score = 100 - turnsTaken + coins + (5 * arrows);
                return score;
            }
        }
    }
}
