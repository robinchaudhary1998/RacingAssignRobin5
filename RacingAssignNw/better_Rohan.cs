using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingAssignNw
{
    public class better_Rohan
    {
        //declare the global variable that are used in the working to declare the result 
        int rabit_No = 0;
        int bet_Amount = 0;
        int Budget = 0;

        //parameterized constructor that is used to pass the value when rohan interested to play
        public better_Rohan(int rabit, int betAmount, int budget)
        {
            //pass the value from the local to global 
            this.rabit_No = rabit;
            this.bet_Amount = betAmount;
            this.Budget = budget;
        }

        //this method is used to get the value and pass the budget at the end of the game 
        public int rohan_Budget(int winner) {
            if (rabit_No == winner)
            {
                Budget = Budget + bet_Amount;
            }
            else {
                Budget = Budget - bet_Amount;
            }
            return Budget;
        }


    }
}
