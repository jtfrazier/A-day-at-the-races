using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Foundation;
using App6;

namespace Dayattheraces
{

    public class Greyhound
    {
        public int StartingPosition;
        public int RaceTrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random Randomizer;

        private int NewLoc;

        public bool Run()
        {
            Location = Randomizer.Next(1, 4);
            NewLoc += Location;
            MyPictureBox.Left = StartingPosition +  NewLoc;
            if (MyPictureBox.Left >= RaceTrackLength)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void TakeStartingPosition()
        {
            Location = 0;
            NewLoc = 0;
            MyPictureBox.Left = StartingPosition;
        }
    }
}