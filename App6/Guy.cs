using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App6;

namespace Dayattheraces
{
   
public class Guy{
    public string Name;
    public Bet MyBet;
    public int Cash;
    public RadioButton MyRadioButton;
    public Label MyLabel;

    public void UpdateLabels(){
        if(MyBet == null)
            MyLabel.Text=Name +"placed no bets.";
        else
            MyLabel.Text=MyBet.GetDescription();
            MyRadioButton.Text=Name+"has"+Cash+"bucks";
    }
    public void ClearBet() {
        MyBet=null;
    }
    public bool PlaceBet(int Amount, int DogToWin) {
        this.MyBet=new Bet();
        if (Cash >= Amount)
        {
            Cash = Cash - Amount;
            MyBet.Amount = Amount;
            MyBet.Dog = Dog;
            MyBet.Bettor = this;
            UpdateLabels();
            return true;
        }
        else { 
            return false;
    }
    }
    public void Collect(int Winner){
        if(MyBet != null)
            Cash += MyBet.PayOut(Winner);
    }

    public int Dog { get; set; }
}
    
    
}
