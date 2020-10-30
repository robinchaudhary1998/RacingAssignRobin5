using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingAssignNw
{
    public partial class main : Form
    {
        //declare the instance of the relevant classes
        runner instance_Runner = new runner();
        better_Rohan instance_Rohan = null;
        better_Harry instance_Harry = null;
        better_Chris instance_Chris = null;

        int rohan_Budget = 100, harry_Budget = 100, chris_Budget = 100;


        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnFixed_Click(object sender, EventArgs e)
        {
            /// first of all check Rohan has intereset to play or not 
            int player = Convert.ToInt32(cbPlayer.SelectedIndex);
            int rabit = Convert.ToInt32(cbRabbit.SelectedIndex);
            if (player == -1)
            {
                MessageBox.Show("atleast one player has to set the bet to start the Game ");

            }
            else {
                if (rabit == -1)
                {

                    MessageBox.Show("must choose any one rabit for the bet ");
                }
                else {
                  //  MessageBox.Show("" + player + "----" + rabit);
                    switch (player)
                    {
                        case 0:
                            Rohan.Text = "Rohan select the " + (rabit+1) + " Rabit for the bet with the Amount " + nmAmount.Value;
                            instance_Rohan = new better_Rohan((rabit + 1), Convert.ToInt32(nmAmount.Value),rohan_Budget);
                            btnRun.Visible = true;
                            break;
                        case 1:
                            Harry.Text = "Harry select the " + (rabit + 1) + " Rabit for the bet with the Amount " + nmAmount.Value; ;
                            instance_Harry = new better_Harry((rabit + 1), Convert.ToInt32(nmAmount.Value),harry_Budget);
                            btnRun.Visible = true;
                            break;
                        case 2:
                            Chris.Text = "Chris select the " + (rabit + 1) + " Rabit for the bet with the Amount " + nmAmount.Value; ;
                            instance_Chris = new better_Chris((rabit + 1), Convert.ToInt32(nmAmount.Value),chris_Budget);
                            btnRun.Visible = true;
                            break;
                        default:
                            MessageBox.Show("must follow the proper instruction to play");
                            break;

                    }
                }
            }
           
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
        }
        //these messages will tell that who will win the race
        private void timer1_Tick(object sender, EventArgs e)
        {
            Rabit1.Left += instance_Runner.generate_Number();
            Rabit2.Left += instance_Runner.generate_Number();
            Rabit3.Left += instance_Runner.generate_Number();
            Rabit4.Left += instance_Runner.generate_Number();
            if (Rabit1.Left>950) {
                timer1.Stop();
                MessageBox.Show(" Rabit 1 win the race ");
                announce_Result(1);

            }
            if (Rabit2.Left > 950)
            {
                timer1.Stop();
                MessageBox.Show(" Rabit 2 win the race ");
                announce_Result(2);

            }
            if (Rabit3.Left > 950)
            {
                timer1.Stop();
                MessageBox.Show("Rabit 3 win the race ");
                announce_Result(3);
            }
            if (Rabit4.Left > 950)
            {
                timer1.Stop();
                MessageBox.Show("Rabit 4 win the race ");
                announce_Result(4);
            }
           
        }

        //this method is used to annouce the result
        public void announce_Result(int winner) {
            if (Rohan.Text.Contains("Rabit")) {
                rohan_Budget = instance_Rohan.rohan_Budget(winner);
                Rohan.Text = "Rohan has "+ rohan_Budget + " Dollar Left";
            }
            if (Harry.Text.Contains("Rabit"))
            {
                harry_Budget = instance_Harry.harry_Budget(winner);
                Harry.Text = "Harry has " + harry_Budget + " Dollar Left";
            }
            if (Chris.Text.Contains("Rabit"))
            {
                chris_Budget = instance_Chris.chris_Budget(winner);
                Chris.Text = "Chris has " + chris_Budget + " Dollar Left";
            }

            Rabit1.Left = 0; Rabit2.Left = 0; Rabit3.Left = 0; Rabit4.Left = 0;
            cbPlayer.Text = "";cbRabbit.Text = "";nmAmount.Value = 10;
            btnRun.Visible = false;


        }
    }
}
