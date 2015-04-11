using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App6;


namespace Dayattheraces
{
    public partial class Form1 : Form
    {

        
        Greyhound[] GreyhoundArray = new Greyhound[4];
        Guy[] GuyArray = new Guy[3];
        Guy GuyBet = new Guy();

        
        Random random = new Random();

        
        bool lockRace = false;
        bool BetPlaced = false;

        int minBet = 5;
        private App6.PictureBox Greyhound1;
        private App6.PictureBox Greyhound2;
        private App6.PictureBox GreyHound3;
        private App6.PictureBox GreyHound4;
        private App6.RadioButton joeRadioButton;
        private App6.RadioButton bobRadioButton;
        private App6.RadioButton alRadioButton;
        private App6.Label alBetLabel;


        public Form1()
        {
            InitializeComponent();
            
            Center_Text();

           
            minBetLabel.Text = "Minimum Bet = 5" + minBet;

           
            GreyhoundArray[0] = new Greyhound()
            {
                MyPictureBox = Greyhound1,
                StartingPosition = Greyhound1.Left,
                RaceTrackLength = raceTrackPictureBox.Width - Greyhound1.Width,
                Randomizer = random
            };

            GreyhoundArray[1] = new Greyhound()
            {
                MyPictureBox = Greyhound2,
                StartingPosition = Greyhound2.Left,
                RaceTrackLength = raceTrackPictureBox.Width - Greyhound2.Width,
                Randomizer = random
            };

            GreyhoundArray[2] = new Greyhound()
            {
                MyPictureBox = GreyHound3,
                StartingPosition = GreyHound3.Left,
                RaceTrackLength = raceTrackPictureBox.Width - GreyHound3.Width,
                Randomizer = random
            };

            GreyhoundArray[3] = new Greyhound()
            {
                MyPictureBox = GreyHound4,
                StartingPosition = GreyHound4.Left,
                RaceTrackLength = raceTrackPictureBox.Width - GreyHound4.Width,
                Randomizer = random
            };

           
            GuyArray[0] = new Guy()
            {
                Name = "Joe",
                MyBet = new Bet(),
                Cash = 50,
                MyRadioButton = joeRadioButton,
                MyLabel = joeBetLabel
            };

            GuyArray[1] = new Guy()
            {
                Name = "Bob",
                MyBet = new Bet(),
                Cash = 75,
                MyRadioButton = bobRadioButton,
                MyLabel = bobBetLabel
            };

            GuyArray[2] = new Guy()
            {
                Name = "Al",
                MyBet = new Bet(),
                Cash = 45,
                MyRadioButton = alRadioButton,
                MyLabel = alBetLabel
            };

           
            for (int i = 0; i <= 2; i++)
            {
                GuyArray[i].ClearBet();
                GuyArray[i].UpdateLabels();
            }

        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

       
        private void Center_Text()
        {
            Graphics g = this.CreateGraphics();
            Double startingPoint = (this.Width / 2) - (g.MeasureString(this.Text.Trim(), this.Font).Width / 2);
            Double widthOfASpace = g.MeasureString(" ", this.Font).Width;
            Double textOffset = (g.MeasureString(this.Text, this.Font).Width / 2);
            String tmp = " ";
            Double tmpWidth = 0;
            while (((tmpWidth + widthOfASpace) - textOffset) < startingPoint)
            {
                tmp += " ";
                tmpWidth += widthOfASpace;
            }

            this.Text = tmp + this.Text.Trim();

        }

        
        private void raceButton_Click(object sender, EventArgs e)
        {
            if (BetPlaced)
            {
               
                for (int i = 0; i <= 3; i++)
                {
                    GreyhoundArray[i].TakeStartingPosition();

                }

               
                raceTimer.Start();
                lockRace = false;
                bettingParlour.Enabled = false;
            }
            else
            {
                MessageBoxEx.Show(this, "No Bets have been placed!", "Payup if you wanna race!");
            }
        }

        
        private void raceTimer_Tick(object sender, EventArgs e)
        {
            
            for (int i = 0; i <= 3; i++)
            {
                GreyhoundArray[i].Run();
                   
                if (lockRace == false)
                {

                    if (GreyhoundArray[i].Run())
                    {
                        raceTimer.Stop();

                        MessageBoxEx.Show(this, "Congratulations Greyhound Number : " + (i + 1), "We have a winner!");
                        
                        int winner = (i + 1);
                        
                        GuyArray[0].Collect(winner);
                        GuyArray[1].Collect(winner);
                        GuyArray[2].Collect(winner);
                        
                        lockRace = true;
                        BetPlaced = false;
                        bettingParlour.Enabled = true;
                    }

                }
            }
        }
      
        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Joe";
            GuyBet = GuyArray[0];
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Bob";
            GuyBet = GuyArray[1];
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Al";
            GuyBet = GuyArray[2];
        } 
        private void betButton_Click(object sender, EventArgs e)
        {
            
            int bet = (int)betValue.Value;
            int dogNo = (int)dogNumber.Value;
            bool PlaceBet;

            GuyBet.Name = nameLabel.Text;
            if (bet >= minBet)
            {
                PlaceBet = GuyBet.PlaceBet(bet, dogNo);
                if (PlaceBet)
                {
                    GuyBet.UpdateLabels();
                    BetPlaced = true;
                }
            }
            else
            {
                MessageBoxEx.Show(this, "The Minimum Bet allowed is: 5" + minBet, "Pay up Cheapo!");
            }

        }

        internal App6.Label bobBetLabel { get; set; }

        public int Width { get; set; }
    }
 
} 

