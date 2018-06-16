using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_034_MegaChallengeCasino
{
    public partial class Default : System.Web.UI.Page
    {
        Random random = new Random();

        public string PlayersMoney { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] reels = new string[] { SpinReel(), SpinReel(), SpinReel() };
                DisplayImages(reels);
                ViewState.Add("PlayersMoney", 100);
                DisplayBalance();
            }
        }

        private void DisplayBalance()
        {
            moneyLabel.Text = String.Format("Player's Money: {0:C}", ViewState["PlayersMoney"]);
        } 
        
        protected void PullButton_Click(object sender, EventArgs e)
        {
            int bet = 0;
            if (!int.TryParse(betTextBox.Text, out bet)) return;
            int winnings = PullLever(bet);
            DisplayResult(bet, winnings);
            AdjustPlayersMoney(bet, winnings);
            DisplayBalance();
        }

        private void AdjustPlayersMoney(int bet, int winnings)
        {
            int PlayersMoney = int.Parse(ViewState["PlayersMoney"].ToString());
            PlayersMoney -= bet;
            PlayersMoney += winnings;
            ViewState["PlayersMoney"] = PlayersMoney;
        }
            
        private int PullLever(int bet)
        {
            string[] reels = new string[] { SpinReel(), SpinReel(), SpinReel() };
            DisplayImages(reels);
            int multiplier = EvaluateSpin(reels);

            return bet * multiplier;
        }

        private int EvaluateSpin(string[] reels)
        {
            if (IsBar(reels)) return 0;
            if (IsJackpot(reels)) return 100;
            int multiplier = 0;
            if (IsWinner(reels, out multiplier)) return multiplier;

            return 0;
        }

        private void DisplayResult(int bet, int winnings)
        {
            if (winnings > 0)
                ResultLabel.Text = String.Format("You bet {0:C} and won {1:C}!", bet, winnings);
            else
                ResultLabel.Text = String.Format("Sorry you lost {0:C}. Better luck next time", bet);
        }
        
        private bool IsWinner(string[] reels, out int multiplier)
        {
            multiplier = DetermineMultiplier(reels);
            if (multiplier > 0)
                return true;

            return false;
        }

        private int DetermineMultiplier(string[] reels)
        {
            int cherryCount = DetermineCherryCount(reels);
            if (cherryCount == 1) return 2;
            if (cherryCount == 2) return 3;
            if (cherryCount == 3) return 4;

            return 0;
        }

        private int DetermineCherryCount(string[] reels)
        {
            int cherryCount = 0;
            if (reels[0] == "Cherry") cherryCount++;
            if (reels[1] == "Cherry") cherryCount++;
            if (reels[2] == "Cherry") cherryCount++;

            return cherryCount;
        }

        private bool IsJackpot(string[] reels)
        {
            if (reels[0] == "Seven" &&
                reels[1] == "Seven" &&
                reels[2] == "Seven")

                return true;
            else return false;
        }

        private bool IsBar(string[] reels)
        {
            if (reels[0] == "Bar" ||
                reels[1] == "Bar" ||
                reels[2] == "Bar")

                return true;
            else return false;
        }

        private string SpinReel()
        {
            string[] images = new string[] {
                "Bar", "Bell", "Cherry", "Clover",
                "Diamond", "HorseShoe", "Lemon", "Orange",
                "Plum", "Seven", "Strawberry", "Watermelon" };

            return images[random.Next(11)];
        }

        private void DisplayImages(string[] reels)
        {
            Image1.ImageUrl = "/Images/" + reels[0] + ".png";
            Image2.ImageUrl = "/Images/" + reels[1] + ".png";
            Image3.ImageUrl = "/Images/" + reels[2] + ".png";
        }       
    }
}