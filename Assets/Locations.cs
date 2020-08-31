using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets
{
    class Locations
    {
        // instance vairables
        private int roomNumber;
        private int[] bats = new int[7];
        private int[] rooms = new int[29];
        private int botPit;
        private int wumpusLoc;
        private Random rand;

        // constructors
        public Locations(Random myRandom)
        {
            rand = myRandom;
            for (int i = 0; i < 29; i++)
            {
                rooms[i] = i + 2;
            }

            for (int i = 0; i < bats.Length;)
            {
                int index = myRandom.Next(0, 29);
                if (rooms[index] > 0)
                {
                    bats[i] = rooms[index];
                    rooms[index] = 0;
                    i++;
                }
            }

            int num = 0;
            while (num == 0)
            {
                int index = myRandom.Next(0, 29);
                num = rooms[index];
                rooms[index] = 0;
            }
            botPit = num;

            num = 0;
            while (num == 0)
            {
                int index = myRandom.Next(0, 29);
                num = rooms[index];
                rooms[index] = 0;
            }
            wumpusLoc = num;
        }

        // mutators
        public void SetLocation(int roomNumber)
        {
            this.roomNumber = roomNumber;

        }

        // accessors
        //gets the player locations 
        public int GetPlayerLocation()
        {
            return this.roomNumber;
        }

        /* public void SetPlayerLocation(int playerLoc)
         {
             this.roomNumber = playerLoc;
         } */

        // gets info about bats rooms
        public int[] GetBats()
        {
            return bats;
        }

        public String toStringBats()
        {
            String str = "" + bats[0];
            for (int i = 1; i < bats.Length; i++)
            {
                str += ", " + bats[i];
            }
            return str;
        }

        public bool HasBats(int room)
        {
            for (int i = 0; i < bats.Length; i++)
            {
                if (bats[i] == room)
                {
                    return true;
                }
            }

            return false;
        }

        //info for the bottomless pits location
        public int GetBotPit()
        {
            return botPit;
        }

        public bool HasBotPit(int roomNumber)
        {
            if (roomNumber == botPit)
            {
                return true;
            }
            return false;
        }

        public int WumpusLocation()
        {
            return wumpusLoc;
        }

        public bool HasWumpus(int roomNumber)
        {
            if (roomNumber == wumpusLoc)
            {
                return true;
            }
            return false;
        }
    }
}
